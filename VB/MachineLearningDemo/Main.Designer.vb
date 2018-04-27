Namespace MachineLearningDemo
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView1 As New DevExpress.XtraCharts.PointSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView2 As New DevExpress.XtraCharts.PointSeriesView()
            Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView3 As New DevExpress.XtraCharts.PointSeriesView()
            Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
            Dim series3 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel4 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView4 As New DevExpress.XtraCharts.PointSeriesView()
            Dim series4 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel5 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView5 As New DevExpress.XtraCharts.PointSeriesView()
            Dim series5 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel6 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView6 As New DevExpress.XtraCharts.PointSeriesView()
            Dim series6 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel7 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView7 As New DevExpress.XtraCharts.PointSeriesView()
            Dim pointSeriesLabel8 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView8 As New DevExpress.XtraCharts.PointSeriesView()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.tabLinear = New DevExpress.XtraTab.XtraTabPage()
            Me.buttonLoadPlot = New DevExpress.XtraEditors.SimpleButton()
            Me.chartLinear = New DevExpress.XtraCharts.ChartControl()
            Me.tabStudent = New DevExpress.XtraTab.XtraTabPage()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.splitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.propertyStudent = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.propertyDescriptionControl1 = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
            Me.gridStudent = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceStudent = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridViewStudent = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGrade = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGPA = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTall = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFriends = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGood = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCluster = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.spinClusterCount = New DevExpress.XtraEditors.SpinEdit()
            Me.buttonClusteStudents = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonPredict = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonSaveModel = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonGenerate = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonLoad = New DevExpress.XtraEditors.SimpleButton()
            Me.tabCluster = New DevExpress.XtraTab.XtraTabPage()
            Me.buttonAnimate = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonUpdate = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonAssign = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonInitCluster = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonGenerateCluster = New DevExpress.XtraEditors.SimpleButton()
            Me.chartCluster = New DevExpress.XtraCharts.ChartControl()
            Me.tabFeed = New DevExpress.XtraTab.XtraTabPage()
            Me.gridFeeds = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceFeed = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridViewFeeds = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colSource = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCluster1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.buttonSaveDescription = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonLoadFeeds = New DevExpress.XtraEditors.SimpleButton()
            Me.spinFeedClusterCount = New DevExpress.XtraEditors.SpinEdit()
            Me.buttonClusterFeeds = New DevExpress.XtraEditors.SimpleButton()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.dialogSaveModel = New System.Windows.Forms.SaveFileDialog()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.tabLinear.SuspendLayout()
            CType(Me.chartLinear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabStudent.SuspendLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl2.SuspendLayout()
            CType(Me.propertyStudent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridStudent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceStudent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridViewStudent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.spinClusterCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabCluster.SuspendLayout()
            CType(Me.chartCluster, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pointSeriesView8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabFeed.SuspendLayout()
            CType(Me.gridFeeds, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceFeed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridViewFeeds, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.spinFeedClusterCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.LookAndFeel.SkinName = "Black"
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.tabLinear
            Me.xtraTabControl1.Size = New System.Drawing.Size(643, 637)
            Me.xtraTabControl1.TabIndex = 4
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tabLinear, Me.tabStudent, Me.tabCluster, Me.tabFeed})
            ' 
            ' tabLinear
            ' 
            Me.tabLinear.Controls.Add(Me.buttonLoadPlot)
            Me.tabLinear.Controls.Add(Me.chartLinear)
            Me.tabLinear.Name = "tabLinear"
            Me.tabLinear.Size = New System.Drawing.Size(636, 609)
            Me.tabLinear.Text = "Linear Data"
            ' 
            ' buttonLoadPlot
            ' 
            Me.buttonLoadPlot.Location = New System.Drawing.Point(10, 3)
            Me.buttonLoadPlot.Name = "buttonLoadPlot"
            Me.buttonLoadPlot.Size = New System.Drawing.Size(89, 23)
            Me.buttonLoadPlot.TabIndex = 1
            Me.buttonLoadPlot.Text = "Generate Data"
            ' 
            ' chartLinear
            ' 
            Me.chartLinear.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisX.Range.SideMarginsEnabled = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisY.Range.SideMarginsEnabled = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.EnableAxisYScrolling = True
            xyDiagram1.EnableAxisYZooming = True
            Me.chartLinear.Diagram = xyDiagram1
            Me.chartLinear.Location = New System.Drawing.Point(3, 32)
            Me.chartLinear.Name = "chartLinear"
            Me.chartLinear.PaletteName = "Concourse"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel1.LineVisible = True
            pointSeriesLabel1.Visible = False
            series1.Label = pointSeriesLabel1
            series1.Name = "Blue"
            series1.ShowInLegend = False
            series1.View = pointSeriesView1
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel2.LineVisible = True
            pointSeriesLabel2.Visible = False
            series2.Label = pointSeriesLabel2
            series2.Name = "Red"
            series2.ShowInLegend = False
            series2.View = pointSeriesView2
            Me.chartLinear.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            pointSeriesLabel3.LineVisible = True
            Me.chartLinear.SeriesTemplate.Label = pointSeriesLabel3
            Me.chartLinear.SeriesTemplate.View = pointSeriesView3
            Me.chartLinear.Size = New System.Drawing.Size(626, 570)
            Me.chartLinear.TabIndex = 0
            ' 
            ' tabStudent
            ' 
            Me.tabStudent.Controls.Add(Me.splitContainerControl1)
            Me.tabStudent.Name = "tabStudent"
            Me.tabStudent.Size = New System.Drawing.Size(636, 609)
            Me.tabStudent.Text = "Student Data"
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.splitContainerControl2)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gridStudent)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.panelControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(636, 609)
            Me.splitContainerControl1.SplitterPosition = 139
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' splitContainerControl2
            ' 
            Me.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl2.Horizontal = False
            Me.splitContainerControl2.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl2.Name = "splitContainerControl2"
            Me.splitContainerControl2.Panel1.Controls.Add(Me.propertyStudent)
            Me.splitContainerControl2.Panel1.Text = "Panel1"
            Me.splitContainerControl2.Panel2.Controls.Add(Me.propertyDescriptionControl1)
            Me.splitContainerControl2.Panel2.Text = "Panel2"
            Me.splitContainerControl2.Size = New System.Drawing.Size(139, 609)
            Me.splitContainerControl2.TabIndex = 0
            Me.splitContainerControl2.Text = "splitContainerControl2"
            ' 
            ' propertyStudent
            ' 
            Me.propertyStudent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyStudent.Location = New System.Drawing.Point(0, 0)
            Me.propertyStudent.LookAndFeel.SkinName = "Black"
            Me.propertyStudent.LookAndFeel.UseDefaultLookAndFeel = False
            Me.propertyStudent.Name = "propertyStudent"
            Me.propertyStudent.Size = New System.Drawing.Size(139, 503)
            Me.propertyStudent.TabIndex = 0
            ' 
            ' propertyDescriptionControl1
            ' 
            Me.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyDescriptionControl1.Location = New System.Drawing.Point(0, 0)
            Me.propertyDescriptionControl1.LookAndFeel.SkinName = "Black"
            Me.propertyDescriptionControl1.Name = "propertyDescriptionControl1"
            Me.propertyDescriptionControl1.PropertyGrid = Me.propertyStudent
            Me.propertyDescriptionControl1.Size = New System.Drawing.Size(139, 100)
            Me.propertyDescriptionControl1.TabIndex = 0
            Me.propertyDescriptionControl1.TabStop = False
            ' 
            ' gridStudent
            ' 
            Me.gridStudent.DataSource = Me.bindingSourceStudent
            Me.gridStudent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridStudent.Location = New System.Drawing.Point(0, 38)
            Me.gridStudent.MainView = Me.gridViewStudent
            Me.gridStudent.Name = "gridStudent"
            Me.gridStudent.Size = New System.Drawing.Size(491, 571)
            Me.gridStudent.TabIndex = 1
            Me.gridStudent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewStudent})
            ' 
            ' bindingSourceStudent
            ' 
            Me.bindingSourceStudent.DataSource = GetType(MachineLearningDemo.Data.Student)
            ' 
            ' gridViewStudent
            ' 
            Me.gridViewStudent.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colGrade, Me.colGPA, Me.colAge, Me.colTall, Me.colFriends, Me.colGood, Me.colCluster})
            Me.gridViewStudent.GridControl = Me.gridStudent
            Me.gridViewStudent.Name = "gridViewStudent"
            Me.gridViewStudent.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            Me.gridViewStudent.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            Me.gridViewStudent.OptionsBehavior.Editable = False
            Me.gridViewStudent.OptionsView.EnableAppearanceEvenRow = True
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            ' 
            ' colGrade
            ' 
            Me.colGrade.FieldName = "Grade"
            Me.colGrade.Name = "colGrade"
            Me.colGrade.Visible = True
            Me.colGrade.VisibleIndex = 1
            ' 
            ' colGPA
            ' 
            Me.colGPA.FieldName = "GPA"
            Me.colGPA.Name = "colGPA"
            Me.colGPA.Visible = True
            Me.colGPA.VisibleIndex = 2
            ' 
            ' colAge
            ' 
            Me.colAge.FieldName = "Age"
            Me.colAge.Name = "colAge"
            Me.colAge.Visible = True
            Me.colAge.VisibleIndex = 3
            ' 
            ' colTall
            ' 
            Me.colTall.FieldName = "Tall"
            Me.colTall.Name = "colTall"
            Me.colTall.Visible = True
            Me.colTall.VisibleIndex = 4
            ' 
            ' colFriends
            ' 
            Me.colFriends.FieldName = "Friends"
            Me.colFriends.Name = "colFriends"
            Me.colFriends.Visible = True
            Me.colFriends.VisibleIndex = 5
            ' 
            ' colGood
            ' 
            Me.colGood.FieldName = "Good"
            Me.colGood.Name = "colGood"
            Me.colGood.Visible = True
            Me.colGood.VisibleIndex = 6
            ' 
            ' colCluster
            ' 
            Me.colCluster.FieldName = "Cluster"
            Me.colCluster.Name = "colCluster"
            Me.colCluster.Visible = True
            Me.colCluster.VisibleIndex = 7
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.spinClusterCount)
            Me.panelControl1.Controls.Add(Me.buttonClusteStudents)
            Me.panelControl1.Controls.Add(Me.buttonPredict)
            Me.panelControl1.Controls.Add(Me.buttonSaveModel)
            Me.panelControl1.Controls.Add(Me.buttonGenerate)
            Me.panelControl1.Controls.Add(Me.buttonLoad)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.LookAndFeel.SkinName = "Black"
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(491, 38)
            Me.panelControl1.TabIndex = 0
            ' 
            ' spinClusterCount
            ' 
            Me.spinClusterCount.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
            Me.spinClusterCount.Location = New System.Drawing.Point(420, 8)
            Me.spinClusterCount.Name = "spinClusterCount"
            Me.spinClusterCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinClusterCount.Properties.MaxValue = New Decimal(New Integer() { 1000, 0, 0, 0})
            Me.spinClusterCount.Properties.MinValue = New Decimal(New Integer() { 2, 0, 0, 0})
            Me.spinClusterCount.Size = New System.Drawing.Size(58, 20)
            Me.spinClusterCount.TabIndex = 5
            ' 
            ' buttonClusteStudents
            ' 
            Me.buttonClusteStudents.Location = New System.Drawing.Point(339, 5)
            Me.buttonClusteStudents.Name = "buttonClusteStudents"
            Me.buttonClusteStudents.Size = New System.Drawing.Size(75, 23)
            Me.buttonClusteStudents.TabIndex = 4
            Me.buttonClusteStudents.Text = "Cluster"
            ' 
            ' buttonPredict
            ' 
            Me.buttonPredict.Location = New System.Drawing.Point(258, 5)
            Me.buttonPredict.Name = "buttonPredict"
            Me.buttonPredict.Size = New System.Drawing.Size(75, 23)
            Me.buttonPredict.TabIndex = 3
            Me.buttonPredict.Text = "Predict"
            ' 
            ' buttonSaveModel
            ' 
            Me.buttonSaveModel.Location = New System.Drawing.Point(177, 5)
            Me.buttonSaveModel.Name = "buttonSaveModel"
            Me.buttonSaveModel.Size = New System.Drawing.Size(75, 23)
            Me.buttonSaveModel.TabIndex = 2
            Me.buttonSaveModel.Text = "Save Model"
            ' 
            ' buttonGenerate
            ' 
            Me.buttonGenerate.Location = New System.Drawing.Point(86, 5)
            Me.buttonGenerate.Name = "buttonGenerate"
            Me.buttonGenerate.Size = New System.Drawing.Size(85, 23)
            Me.buttonGenerate.TabIndex = 1
            Me.buttonGenerate.Text = "Generate Model"
            ' 
            ' buttonLoad
            ' 
            Me.buttonLoad.Location = New System.Drawing.Point(5, 5)
            Me.buttonLoad.Name = "buttonLoad"
            Me.buttonLoad.Size = New System.Drawing.Size(75, 23)
            Me.buttonLoad.TabIndex = 0
            Me.buttonLoad.Text = "Load Data"
            ' 
            ' tabCluster
            ' 
            Me.tabCluster.Controls.Add(Me.buttonAnimate)
            Me.tabCluster.Controls.Add(Me.buttonUpdate)
            Me.tabCluster.Controls.Add(Me.buttonAssign)
            Me.tabCluster.Controls.Add(Me.buttonInitCluster)
            Me.tabCluster.Controls.Add(Me.buttonGenerateCluster)
            Me.tabCluster.Controls.Add(Me.chartCluster)
            Me.tabCluster.Name = "tabCluster"
            Me.tabCluster.Size = New System.Drawing.Size(636, 609)
            Me.tabCluster.Text = "Cluster Data"
            ' 
            ' buttonAnimate
            ' 
            Me.buttonAnimate.Location = New System.Drawing.Point(351, 3)
            Me.buttonAnimate.Name = "buttonAnimate"
            Me.buttonAnimate.Size = New System.Drawing.Size(75, 23)
            Me.buttonAnimate.TabIndex = 5
            Me.buttonAnimate.Text = "Animate"
            ' 
            ' buttonUpdate
            ' 
            Me.buttonUpdate.Enabled = False
            Me.buttonUpdate.Location = New System.Drawing.Point(270, 3)
            Me.buttonUpdate.Name = "buttonUpdate"
            Me.buttonUpdate.Size = New System.Drawing.Size(75, 23)
            Me.buttonUpdate.TabIndex = 4
            Me.buttonUpdate.Text = "Update"
            ' 
            ' buttonAssign
            ' 
            Me.buttonAssign.Enabled = False
            Me.buttonAssign.Location = New System.Drawing.Point(189, 3)
            Me.buttonAssign.Name = "buttonAssign"
            Me.buttonAssign.Size = New System.Drawing.Size(75, 23)
            Me.buttonAssign.TabIndex = 3
            Me.buttonAssign.Text = "Assignment"
            ' 
            ' buttonInitCluster
            ' 
            Me.buttonInitCluster.Enabled = False
            Me.buttonInitCluster.Location = New System.Drawing.Point(108, 3)
            Me.buttonInitCluster.Name = "buttonInitCluster"
            Me.buttonInitCluster.Size = New System.Drawing.Size(75, 23)
            Me.buttonInitCluster.TabIndex = 2
            Me.buttonInitCluster.Text = "Initialize"
            ' 
            ' buttonGenerateCluster
            ' 
            Me.buttonGenerateCluster.Location = New System.Drawing.Point(10, 3)
            Me.buttonGenerateCluster.Name = "buttonGenerateCluster"
            Me.buttonGenerateCluster.Size = New System.Drawing.Size(92, 23)
            Me.buttonGenerateCluster.TabIndex = 1
            Me.buttonGenerateCluster.Text = "Generate Data"
            ' 
            ' chartCluster
            ' 
            Me.chartCluster.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram2.AxisX.Range.SideMarginsEnabled = True
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram2.AxisY.Range.SideMarginsEnabled = True
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartCluster.Diagram = xyDiagram2
            Me.chartCluster.Location = New System.Drawing.Point(10, 32)
            Me.chartCluster.Name = "chartCluster"
            Me.chartCluster.PaletteName = "Office"
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel4.LineVisible = True
            pointSeriesLabel4.Visible = False
            series3.Label = pointSeriesLabel4
            series3.Name = "Blue"
            series3.View = pointSeriesView4
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel5.LineVisible = True
            pointSeriesLabel5.Visible = False
            series4.Label = pointSeriesLabel5
            series4.Name = "Red"
            series4.View = pointSeriesView5
            series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel6.LineVisible = True
            pointSeriesLabel6.Visible = False
            series5.Label = pointSeriesLabel6
            series5.LegendText = "Cluster 1"
            series5.Name = "Cluster 1"
            pointSeriesView6.PointMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
            pointSeriesView6.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Cross
            pointSeriesView6.PointMarkerOptions.Size = 16
            pointSeriesView6.Shadow.Visible = True
            series5.View = pointSeriesView6
            series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel7.LineVisible = True
            pointSeriesLabel7.Visible = False
            series6.Label = pointSeriesLabel7
            series6.LegendText = "Cluster 2"
            series6.Name = "Cluster 2"
            pointSeriesView7.PointMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
            pointSeriesView7.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Plus
            pointSeriesView7.PointMarkerOptions.Size = 14
            series6.View = pointSeriesView7
            Me.chartCluster.SeriesSerializable = New DevExpress.XtraCharts.Series() { series3, series4, series5, series6}
            pointSeriesLabel8.LineVisible = True
            Me.chartCluster.SeriesTemplate.Label = pointSeriesLabel8
            Me.chartCluster.SeriesTemplate.View = pointSeriesView8
            Me.chartCluster.Size = New System.Drawing.Size(619, 570)
            Me.chartCluster.TabIndex = 0
            ' 
            ' tabFeed
            ' 
            Me.tabFeed.Controls.Add(Me.gridFeeds)
            Me.tabFeed.Controls.Add(Me.panelControl2)
            Me.tabFeed.Name = "tabFeed"
            Me.tabFeed.Size = New System.Drawing.Size(636, 609)
            Me.tabFeed.Text = "Feed Data"
            ' 
            ' gridFeeds
            ' 
            Me.gridFeeds.DataSource = Me.bindingSourceFeed
            Me.gridFeeds.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridFeeds.Location = New System.Drawing.Point(0, 33)
            Me.gridFeeds.MainView = Me.gridViewFeeds
            Me.gridFeeds.Name = "gridFeeds"
            Me.gridFeeds.Size = New System.Drawing.Size(636, 576)
            Me.gridFeeds.TabIndex = 0
            Me.gridFeeds.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewFeeds})
            ' 
            ' bindingSourceFeed
            ' 
            Me.bindingSourceFeed.DataSource = GetType(MachineLearningDemo.Data.Feed)
            ' 
            ' gridViewFeeds
            ' 
            Me.gridViewFeeds.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSource, Me.colContent, Me.colCluster1})
            Me.gridViewFeeds.GridControl = Me.gridFeeds
            Me.gridViewFeeds.Name = "gridViewFeeds"
            Me.gridViewFeeds.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            Me.gridViewFeeds.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            Me.gridViewFeeds.OptionsBehavior.Editable = False
            Me.gridViewFeeds.OptionsBehavior.ReadOnly = True
            Me.gridViewFeeds.OptionsPrint.EnableAppearanceEvenRow = True
            ' 
            ' colSource
            ' 
            Me.colSource.FieldName = "Source"
            Me.colSource.Name = "colSource"
            Me.colSource.Visible = True
            Me.colSource.VisibleIndex = 0
            ' 
            ' colContent
            ' 
            Me.colContent.FieldName = "Content"
            Me.colContent.Name = "colContent"
            Me.colContent.Visible = True
            Me.colContent.VisibleIndex = 1
            ' 
            ' colCluster1
            ' 
            Me.colCluster1.FieldName = "Cluster"
            Me.colCluster1.Name = "colCluster1"
            Me.colCluster1.Visible = True
            Me.colCluster1.VisibleIndex = 2
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.buttonSaveDescription)
            Me.panelControl2.Controls.Add(Me.buttonLoadFeeds)
            Me.panelControl2.Controls.Add(Me.spinFeedClusterCount)
            Me.panelControl2.Controls.Add(Me.buttonClusterFeeds)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(636, 33)
            Me.panelControl2.TabIndex = 1
            ' 
            ' buttonSaveDescription
            ' 
            Me.buttonSaveDescription.Location = New System.Drawing.Point(236, 4)
            Me.buttonSaveDescription.Name = "buttonSaveDescription"
            Me.buttonSaveDescription.Size = New System.Drawing.Size(90, 23)
            Me.buttonSaveDescription.TabIndex = 8
            Me.buttonSaveDescription.Text = "Save Description"
            ' 
            ' buttonLoadFeeds
            ' 
            Me.buttonLoadFeeds.Location = New System.Drawing.Point(10, 4)
            Me.buttonLoadFeeds.Name = "buttonLoadFeeds"
            Me.buttonLoadFeeds.Size = New System.Drawing.Size(75, 23)
            Me.buttonLoadFeeds.TabIndex = 7
            Me.buttonLoadFeeds.Text = "Load Feeds"
            ' 
            ' spinFeedClusterCount
            ' 
            Me.spinFeedClusterCount.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
            Me.spinFeedClusterCount.Location = New System.Drawing.Point(172, 8)
            Me.spinFeedClusterCount.Name = "spinFeedClusterCount"
            Me.spinFeedClusterCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinFeedClusterCount.Properties.MaxValue = New Decimal(New Integer() { 1000, 0, 0, 0})
            Me.spinFeedClusterCount.Properties.MinValue = New Decimal(New Integer() { 2, 0, 0, 0})
            Me.spinFeedClusterCount.Size = New System.Drawing.Size(58, 20)
            Me.spinFeedClusterCount.TabIndex = 6
            ' 
            ' buttonClusterFeeds
            ' 
            Me.buttonClusterFeeds.Location = New System.Drawing.Point(91, 5)
            Me.buttonClusterFeeds.Name = "buttonClusterFeeds"
            Me.buttonClusterFeeds.Size = New System.Drawing.Size(75, 23)
            Me.buttonClusterFeeds.TabIndex = 0
            Me.buttonClusterFeeds.Text = "Cluster"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
            ' 
            ' dialogSaveModel
            ' 
            Me.dialogSaveModel.DefaultExt = "xml"
            Me.dialogSaveModel.Filter = "XML Files|*.xml"
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(643, 637)
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "Main"
            Me.Text = "Main"
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.tabLinear.ResumeLayout(False)
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartLinear, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabStudent.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl2.ResumeLayout(False)
            CType(Me.propertyStudent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridStudent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceStudent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridViewStudent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.spinClusterCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabCluster.ResumeLayout(False)
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pointSeriesView8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartCluster, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabFeed.ResumeLayout(False)
            CType(Me.gridFeeds, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceFeed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridViewFeeds, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.spinFeedClusterCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private tabStudent As DevExpress.XtraTab.XtraTabPage
        Private tabFeed As DevExpress.XtraTab.XtraTabPage
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private splitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
        Private propertyStudent As DevExpress.XtraVerticalGrid.PropertyGridControl
        Private propertyDescriptionControl1 As DevExpress.XtraVerticalGrid.PropertyDescriptionControl
        Private gridStudent As DevExpress.XtraGrid.GridControl
        Private gridViewStudent As DevExpress.XtraGrid.Views.Grid.GridView
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents buttonGenerate As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonLoad As DevExpress.XtraEditors.SimpleButton
        Private bindingSourceStudent As System.Windows.Forms.BindingSource
        Private dialogSaveModel As System.Windows.Forms.SaveFileDialog
        Private WithEvents buttonSaveModel As DevExpress.XtraEditors.SimpleButton
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private colGrade As DevExpress.XtraGrid.Columns.GridColumn
        Private colGPA As DevExpress.XtraGrid.Columns.GridColumn
        Private colAge As DevExpress.XtraGrid.Columns.GridColumn
        Private colTall As DevExpress.XtraGrid.Columns.GridColumn
        Private colFriends As DevExpress.XtraGrid.Columns.GridColumn
        Private colGood As DevExpress.XtraGrid.Columns.GridColumn
        Private colCluster As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents buttonPredict As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonClusteStudents As DevExpress.XtraEditors.SimpleButton
        Private spinClusterCount As DevExpress.XtraEditors.SpinEdit
        Private gridFeeds As DevExpress.XtraGrid.GridControl
        Private gridViewFeeds As DevExpress.XtraGrid.Views.Grid.GridView
        Private bindingSourceFeed As System.Windows.Forms.BindingSource
        Private colSource As DevExpress.XtraGrid.Columns.GridColumn
        Private colContent As DevExpress.XtraGrid.Columns.GridColumn
        Private colCluster1 As DevExpress.XtraGrid.Columns.GridColumn
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private spinFeedClusterCount As DevExpress.XtraEditors.SpinEdit
        Private WithEvents buttonClusterFeeds As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonLoadFeeds As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonSaveDescription As DevExpress.XtraEditors.SimpleButton
        Private tabLinear As DevExpress.XtraTab.XtraTabPage
        Private chartLinear As DevExpress.XtraCharts.ChartControl
        Private WithEvents buttonLoadPlot As DevExpress.XtraEditors.SimpleButton
        Private tabCluster As DevExpress.XtraTab.XtraTabPage
        Private chartCluster As DevExpress.XtraCharts.ChartControl
        Private WithEvents buttonGenerateCluster As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonInitCluster As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonUpdate As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonAssign As DevExpress.XtraEditors.SimpleButton
        Private WithEvents buttonAnimate As DevExpress.XtraEditors.SimpleButton


    End Class
End Namespace