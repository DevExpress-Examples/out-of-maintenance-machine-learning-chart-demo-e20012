Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports ml.Attributes

Namespace MachineLearningDemo.Data
	Public Class Feed
		Private privateSource As String
		Public Property Source() As String
			Get
				Return privateSource
			End Get
			Set(ByVal value As String)
				privateSource = value
			End Set
		End Property

		Private privateContent As String
		<StringFeature(SplitType:=StringType.Word)> _
		Public Property Content() As String
			Get
				Return privateContent
			End Get
			Set(ByVal value As String)
				privateContent = value
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
