Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports ml.Attributes

Namespace MachineLearningDemo.Data
    Public Class Feed
        Public Property Source() As String

        <StringFeature(SplitType:=StringType.Word)> _
        Public Property Content() As String

        Public Property Cluster() As Integer
    End Class
End Namespace
