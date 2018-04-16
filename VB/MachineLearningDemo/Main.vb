Imports Microsoft.VisualBasic
Imports System
Imports ml.Math
Imports System.IO
Imports ml.Attributes
Imports ml.Supervised
Imports ml.Unsupervised
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports MachineLearningDemo.Data
Imports System.Xml.Serialization
Imports System.Linq
Imports System.Threading

Namespace MachineLearningDemo
	Partial Public Class Main
		Inherits DevExpress.XtraEditors.XtraForm
		Private _classifier As IPredict(Of Student)
		Private _data() As Student
		Private _subject As Student

		Private _feedData() As Feed
		Private _feedDescription As TypeDescription

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonLoad.Click
			_data = StudentData.GetData()
			gridStudent.DataSource = _data
			gridStudent.RefreshDataSource()
			_subject = New Student With {.Name = "Seth", .GPA = 3.5, .Age = 31, .Grade = Grade.A, .Tall = False, .Friends = 15}
			propertyStudent.SelectedObject = _subject
		End Sub

		Private Sub buttonGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonGenerate.Click
			If _data Is Nothing Then
				XtraMessageBox.Show("There is no data create model!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If

			Dim model = New PerceptronModel(Of Student)()
			_classifier = model.Generate(_data)
			XtraMessageBox.Show("Done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub buttonSaveModel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSaveModel.Click
			If _classifier Is Nothing Then
				XtraMessageBox.Show("There is no model to save!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If

			If dialogSaveModel.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				_classifier.Save(dialogSaveModel.FileName)
				XtraMessageBox.Show("Done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub buttonPredict_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonPredict.Click
			If _classifier Is Nothing Then
				XtraMessageBox.Show("There is no model to predict!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If

			_classifier.Predict(_subject)
			propertyStudent.Refresh()
			MessageBox.Show(String.Format("Looks like {0} is {1}!", _subject.Name,If(_subject.Good, "good", "not good")), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub buttonClusteStudents_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClusteStudents.Click
			If _data Is Nothing Then
				XtraMessageBox.Show("There is no data create cluster!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If

			Dim g As Integer = CInt(Fix(spinClusterCount.Value))
			Dim kmeans = New KMeans(Of Student)()

			Dim grouping = kmeans.Generate(_data, g)

			For i As Integer = 0 To grouping.Length - 1
				_data(i).Cluster = grouping(i) + 1
			Next i

			gridStudent.DataSource = _data
			gridStudent.RefreshDataSource()

			MessageBox.Show("Done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub buttonClusterFeeds_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClusterFeeds.Click
			If _feedData Is Nothing Then
				XtraMessageBox.Show("There is no data create cluster!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If

			Cursor = Cursors.WaitCursor

			Dim g As Integer = CInt(Fix(spinFeedClusterCount.Value))
			Dim kmeans = New KMeans(Of Feed)()
			Dim grouping = kmeans.Generate(_feedData, g)
			_feedDescription = kmeans.Description

			For i As Integer = 0 To grouping.Length - 1
				_feedData(i).Cluster = grouping(i) + 1
			Next i

			gridFeeds.DataSource = _feedData
			gridFeeds.RefreshDataSource()

			Cursor = Cursors.Default

			MessageBox.Show("Done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub buttonLoadFeeds_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonLoadFeeds.Click
			_feedData = FeedData.GetData()
			gridFeeds.DataSource = _feedData
			gridFeeds.RefreshDataSource()
		End Sub

		Private Sub buttonSaveDescription_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSaveDescription.Click
			If _feedDescription Is Nothing Then
				XtraMessageBox.Show("There is no description to save!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If

			If dialogSaveModel.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim serializer As New XmlSerializer(_feedDescription.GetType())
				Using stream = File.OpenWrite(dialogSaveModel.FileName)
					serializer.Serialize(stream, _feedDescription)
				End Using
				XtraMessageBox.Show("Done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub buttonLoadPlot_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonLoadPlot.Click
			Dim n As Integer = 50
			Cursor = Cursors.WaitCursor
			chartLinear.Series(0).Points.Clear()
			chartLinear.Series(1).Points.Clear()

			Dim reds As Matrix = Matrix.Rand(n, 2) -.1
			Dim blue As Matrix = Matrix.Rand(n, 2) -.9

			For i As Integer = 0 To n - 1
				chartLinear.Series(1).Points.Add(New SeriesPoint(reds(i, 0), reds(i, 1)))
				chartLinear.Series(0).Points.Add(New SeriesPoint(blue(i, 0), blue(i, 1)))
			Next i

			Cursor = Cursors.Default
		End Sub

		' Cluster data
		Private _x As Matrix
		' Cluster centers
		Private _means As Matrix
		' cluster assignments
		Private _assignments() As Integer

		Private Sub buttonGenerateCluster_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonGenerateCluster.Click
			Cursor = Cursors.WaitCursor

			Dim n As Integer = 100
			_x = Matrix.Rand(n, 2) -.1
			_x = _x.Stack(Matrix.Rand(n, 2) -.9)

			' Chart stuff
			chartCluster.Series(0).Points.Clear()
			chartCluster.Series(1).Points.Clear()
			chartCluster.Series(2).Points.Clear()
			chartCluster.Series(3).Points.Clear()
			For i As Integer = 0 To 2 * n - 1
				chartCluster.Series(1).Points.Add(New SeriesPoint(_x(i, 0), _x(i, 1)))
			Next i

			buttonInitCluster.Enabled = True
			Cursor = Cursors.Default
		End Sub


		Private Sub buttonInitCluster_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonInitCluster.Click
			Dim one As Vector = Vector.Rand(2) *.8
			one(0) *= -1
			Dim two As Vector = -one

			_means = one.Stack(two)

			' chart stuff
			chartCluster.Series(2).Points.Clear()
			chartCluster.Series(3).Points.Clear()
			chartCluster.Series(2).Points.Add(New SeriesPoint(_means(0, 0), _means(0, 1)))
			chartCluster.Series(3).Points.Add(New SeriesPoint(_means(1, 0), _means(1, 1)))
			buttonAssign.Enabled = True
		End Sub


		Private Sub buttonAssign_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAssign.Click
			Cursor = Cursors.WaitCursor
			buttonUpdate.Enabled = True

			AssignmentStep()

			Cursor = Cursors.Default
		End Sub

		Private Sub buttonUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonUpdate.Click
			Cursor = Cursors.WaitCursor
			UpdateStep()
			Cursor = Cursors.Default
		End Sub


		Private Sub AssignmentStep()

			_assignments = ( _
					From x In _x.GetRows() _
					Let z = ( _
						From d In _means.GetRows() _
						Select Vector.NormDiff(x, d)) _
					Select z.MinIndex()).ToArray()

			' Chart Stuff
			chartCluster.Series(0).Points.Clear()
			chartCluster.Series(1).Points.Clear()
			For i As Integer = 0 To _x.Rows - 1
				chartCluster.Series(_assignments(i)).Points.Add(New SeriesPoint(_x(i, 0), _x(i, 1)))
			Next i
		End Sub


		Private Function UpdateStep() As Double
			Dim n = ( _
					From x In _x.GetRows().Zip(_assignments, Function(r, a) New With {Key .Vec = r, Key .Asgn = a}) _
					Group x By x.Asgn Into grps = Group _
					Select grps.Select(Function(t) t.Vec).Average()).ToMatrix()



			' Means matrix norm diff (for stopping)
			Dim diff = _means.GetRows().Zip(n.GetRows(), Function(v1, v2) New With {Key .V1 = v1, Key .V2 = v2}).Sum(Function(a) Vector.NormDiff(a.V1, a.V2))

			_means = n

			' chart stuff
			chartCluster.Series(2).Points.Clear()
			chartCluster.Series(3).Points.Clear()

			chartCluster.Series(2).Points.Add(New SeriesPoint(n(0, 0), n(0, 1)))
			chartCluster.Series(3).Points.Add(New SeriesPoint(n(1, 0), n(1, 1)))

			Return diff
		End Function

		Private Sub buttonAnimate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAnimate.Click
			Dim diff = Double.MaxValue
			Do While diff >=.00001
				AssignmentStep()
				Refresh()
				Thread.Sleep(500)
				diff = UpdateStep()
				Refresh()
				Thread.Sleep(500)
			Loop
		End Sub
	End Class
End Namespace