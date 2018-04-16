Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports ml.Attributes
Imports System.ComponentModel

Namespace MachineLearningDemo.Data
	Public Enum Grade
		A
		B
		C
		D
		F
	End Enum

	Public Class Student
		<Feature> _
				Public Function GradeToPercent() As Double
            Dim gradeVal As Double = 0
			Select Case Grade
				Case Grade.A
                    gradeVal = 90
				Case Grade.B
                    gradeVal = 80
				Case Grade.C
                    gradeVal = 70
				Case Grade.D
                    gradeVal = 60
				Case Grade.F
                    gradeVal = 50
			End Select
            Return gradeVal
		End Function

		<Feature> _
		Public Function QuadrupleFriends() As Double
			Return Friends * 4
		End Function

		Public Function GetName() As String
			Return Name
		End Function

		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property

		Private privateGrade As Grade
		Public Property Grade() As Grade
			Get
				Return privateGrade
			End Get
			Set(ByVal value As Grade)
				privateGrade = value
			End Set
		End Property

		Private privateGPA As Double
		<Feature> _
		Public Property GPA() As Double
			Get
				Return privateGPA
			End Get
			Set(ByVal value As Double)
				privateGPA = value
			End Set
		End Property

		Private privateAge As Integer
		<Feature> _
		Public Property Age() As Integer
			Get
				Return privateAge
			End Get
			Set(ByVal value As Integer)
				privateAge = value
			End Set
		End Property

		Private privateTall As Boolean
		<Feature> _
		Public Property Tall() As Boolean
			Get
				Return privateTall
			End Get
			Set(ByVal value As Boolean)
				privateTall = value
			End Set
		End Property

		Private privateFriends As Integer
		Public Property Friends() As Integer
			Get
				Return privateFriends
			End Get
			Set(ByVal value As Integer)
				privateFriends = value
			End Set
		End Property

		Private privateGood As Boolean
		<Label> _
		Public Property Good() As Boolean
			Get
				Return privateGood
			End Get
			Set(ByVal value As Boolean)
				privateGood = value
			End Set
		End Property

		Private privateCluster As Integer
		Public Property Cluster() As Integer
			Get
				Return privateCluster
			End Get
			Set(ByVal value As Integer)
				privateCluster = value
			End Set
		End Property
	End Class
End Namespace
