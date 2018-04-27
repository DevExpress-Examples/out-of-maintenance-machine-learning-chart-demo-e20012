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

            Dim grade_Renamed As Double = 0
            Select Case Grade
                Case Grade.A
                    grade_Renamed = 90
                Case Grade.B
                    grade_Renamed = 80
                Case Grade.C
                    grade_Renamed = 70
                Case Grade.D
                    grade_Renamed = 60
                Case Grade.F
                    grade_Renamed = 50
            End Select
            Return grade_Renamed
        End Function

        <Feature> _
        Public Function QuadrupleFriends() As Double
            Return Friends * 4
        End Function

        Public Function GetName() As String
            Return Name
        End Function

        Public Property Name() As String

        Public Property Grade() As Grade

        <Feature> _
        Public Property GPA() As Double

        <Feature> _
        Public Property Age() As Integer

        <Feature> _
        Public Property Tall() As Boolean

        Public Property Friends() As Integer

        <Label> _
        Public Property Good() As Boolean

        Public Property Cluster() As Integer
    End Class
End Namespace
