Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace MachineLearningDemo.Data
    Public Class StudentData
        Public Shared Function GetData() As Student()
            Return New Student() { _
                New Student With { _
                    .Name = "Aidan", _
                    .Age = 27, _
                    .Friends = 3, _
                    .GPA = 0.54, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Amelia", _
                    .Age = 40, _
                    .Friends = 7, _
                    .GPA = 2.60, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Noah", _
                    .Age = 26, _
                    .Friends = 0, _
                    .GPA = 2.39, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Isabella", _
                    .Age = 21, _
                    .Friends = 9, _
                    .GPA = 3.83, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Liam", _
                    .Age = 19, _
                    .Friends = 3, _
                    .GPA = 1.06, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Ava", _
                    .Age = 16, _
                    .Friends = 7, _
                    .GPA = 3.31, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Cayden", _
                    .Age = 34, _
                    .Friends = 2, _
                    .GPA = 1.01, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Sophia", _
                    .Age = 28, _
                    .Friends = 13, _
                    .GPA = 3.33, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Ethan", _
                    .Age = 21, _
                    .Friends = 3, _
                    .GPA = 0.33, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Olivia", _
                    .Age = 32, _
                    .Friends = 5, _
                    .GPA = 3.12, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jackson", _
                    .Age = 26, _
                    .Friends = 0, _
                    .GPA = 0.47, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Madeline", _
                    .Age = 40, _
                    .Friends = 6, _
                    .GPA = 3.63, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Landon", _
                    .Age = 24, _
                    .Friends = 1, _
                    .GPA = 0.40, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Lily", _
                    .Age = 26, _
                    .Friends = 14, _
                    .GPA = 3.40, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jacob", _
                    .Age = 20, _
                    .Friends = 3, _
                    .GPA = 1.02, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Abigail", _
                    .Age = 32, _
                    .Friends = 6, _
                    .GPA = 3.10, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Caleb", _
                    .Age = 37, _
                    .Friends = 3, _
                    .GPA = 1.52, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Chloe", _
                    .Age = 32, _
                    .Friends = 10, _
                    .GPA = 3.59, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Lucas", _
                    .Age = 28, _
                    .Friends = 2, _
                    .GPA = 1.66, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Emma", _
                    .Age = 25, _
                    .Friends = 13, _
                    .GPA = 3.30, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Braden", _
                    .Age = 27, _
                    .Friends = 2, _
                    .GPA = 2.09, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Charlotte", _
                    .Age = 31, _
                    .Friends = 10, _
                    .GPA = 3.22, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Benjamin", _
                    .Age = 26, _
                    .Friends = 3, _
                    .GPA = 0.69, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Ella", _
                    .Age = 38, _
                    .Friends = 12, _
                    .GPA = 3.78, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Gavin", _
                    .Age = 18, _
                    .Friends = 3, _
                    .GPA = 1.63, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Addison", _
                    .Age = 27, _
                    .Friends = 8, _
                    .GPA = 3.65, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Connor", _
                    .Age = 16, _
                    .Friends = 0, _
                    .GPA = 1.67, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Elizabeth", _
                    .Age = 30, _
                    .Friends = 10, _
                    .GPA = 2.67, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Elijah", _
                    .Age = 27, _
                    .Friends = 1, _
                    .GPA = 0.68, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Grace", _
                    .Age = 27, _
                    .Friends = 7, _
                    .GPA = 2.54, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Oliver", _
                    .Age = 24, _
                    .Friends = 3, _
                    .GPA = 1.66, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Audrey", _
                    .Age = 26, _
                    .Friends = 11, _
                    .GPA = 3.86, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Alexander", _
                    .Age = 38, _
                    .Friends = 2, _
                    .GPA = 0.17, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Emily", _
                    .Age = 23, _
                    .Friends = 13, _
                    .GPA = 3.83, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Owen", _
                    .Age = 39, _
                    .Friends = 2, _
                    .GPA = 0.73, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Bella", _
                    .Age = 38, _
                    .Friends = 12, _
                    .GPA = 2.90, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Gabriel", _
                    .Age = 36, _
                    .Friends = 2, _
                    .GPA = 2.17, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Hannah", _
                    .Age = 35, _
                    .Friends = 12, _
                    .GPA = 3.11, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Logan", _
                    .Age = 33, _
                    .Friends = 2, _
                    .GPA = 1.44, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Isabelle", _
                    .Age = 23, _
                    .Friends = 9, _
                    .GPA = 3.13, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "William", _
                    .Age = 40, _
                    .Friends = 1, _
                    .GPA = 0.93, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Scarlett", _
                    .Age = 26, _
                    .Friends = 14, _
                    .GPA = 2.84, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Tristan", _
                    .Age = 37, _
                    .Friends = 3, _
                    .GPA = 2.44, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Lila", _
                    .Age = 32, _
                    .Friends = 14, _
                    .GPA = 3.05, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jayden", _
                    .Age = 19, _
                    .Friends = 3, _
                    .GPA = 1.38, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Arianna", _
                    .Age = 31, _
                    .Friends = 12, _
                    .GPA = 3.31, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Cole", _
                    .Age = 26, _
                    .Friends = 0, _
                    .GPA = 2.21, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Caitlyn", _
                    .Age = 36, _
                    .Friends = 7, _
                    .GPA = 3.08, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Asher", _
                    .Age = 16, _
                    .Friends = 2, _
                    .GPA = 2.16, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Kaylee", _
                    .Age = 39, _
                    .Friends = 7, _
                    .GPA = 3.96, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jack", _
                    .Age = 19, _
                    .Friends = 0, _
                    .GPA = 1.04, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Keira", _
                    .Age = 17, _
                    .Friends = 10, _
                    .GPA = 2.67, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "James", _
                    .Age = 33, _
                    .Friends = 1, _
                    .GPA = 0.74, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Claire", _
                    .Age = 22, _
                    .Friends = 12, _
                    .GPA = 2.97, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Chase", _
                    .Age = 28, _
                    .Friends = 2, _
                    .GPA = 1.59, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Leah", _
                    .Age = 39, _
                    .Friends = 6, _
                    .GPA = 2.99, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Nathan", _
                    .Age = 20, _
                    .Friends = 3, _
                    .GPA = 1.50, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Layla", _
                    .Age = 33, _
                    .Friends = 12, _
                    .GPA = 3.53, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Andrew", _
                    .Age = 23, _
                    .Friends = 0, _
                    .GPA = 0.38, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Avery", _
                    .Age = 27, _
                    .Friends = 5, _
                    .GPA = 3.51, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Elliot", _
                    .Age = 36, _
                    .Friends = 2, _
                    .GPA = 0.44, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Madison", _
                    .Age = 39, _
                    .Friends = 10, _
                    .GPA = 2.65, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Aaron", _
                    .Age = 22, _
                    .Friends = 3, _
                    .GPA = 1.31, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Natalie", _
                    .Age = 16, _
                    .Friends = 13, _
                    .GPA = 3.50, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Colin", _
                    .Age = 26, _
                    .Friends = 3, _
                    .GPA = 0.14, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Sophie", _
                    .Age = 34, _
                    .Friends = 6, _
                    .GPA = 3.91, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Grayson", _
                    .Age = 20, _
                    .Friends = 0, _
                    .GPA = 1.70, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Payton", _
                    .Age = 29, _
                    .Friends = 7, _
                    .GPA = 3.45, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Mason", _
                    .Age = 40, _
                    .Friends = 1, _
                    .GPA = 0.08, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Hayley", _
                    .Age = 26, _
                    .Friends = 13, _
                    .GPA = 3.83, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Nicholas", _
                    .Age = 25, _
                    .Friends = 2, _
                    .GPA = 2.35, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Violet", _
                    .Age = 28, _
                    .Friends = 9, _
                    .GPA = 3.03, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Joshua", _
                    .Age = 25, _
                    .Friends = 0, _
                    .GPA = 0.85, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Sadie", _
                    .Age = 24, _
                    .Friends = 14, _
                    .GPA = 2.87, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Dylan", _
                    .Age = 20, _
                    .Friends = 0, _
                    .GPA = 1.25, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Lucy", _
                    .Age = 37, _
                    .Friends = 7, _
                    .GPA = 3.33, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Isaac", _
                    .Age = 37, _
                    .Friends = 1, _
                    .GPA = 0.18, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Nora", _
                    .Age = 19, _
                    .Friends = 9, _
                    .GPA = 2.81, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Matthew", _
                    .Age = 32, _
                    .Friends = 3, _
                    .GPA = 2.48, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Alice", _
                    .Age = 21, _
                    .Friends = 14, _
                    .GPA = 3.71, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Levi", _
                    .Age = 37, _
                    .Friends = 0, _
                    .GPA = 0.23, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Cailyn", _
                    .Age = 35, _
                    .Friends = 9, _
                    .GPA = 2.53, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jasper", _
                    .Age = 23, _
                    .Friends = 0, _
                    .GPA = 1.39, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Savannah", _
                    .Age = 39, _
                    .Friends = 10, _
                    .GPA = 3.06, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Zachary", _
                    .Age = 24, _
                    .Friends = 3, _
                    .GPA = 1.14, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Adrianna", _
                    .Age = 26, _
                    .Friends = 13, _
                    .GPA = 3.11, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Carter", _
                    .Age = 34, _
                    .Friends = 3, _
                    .GPA = 2.22, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Anna", _
                    .Age = 34, _
                    .Friends = 14, _
                    .GPA = 3.94, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Nathaniel", _
                    .Age = 39, _
                    .Friends = 0, _
                    .GPA = 0.19, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Riley", _
                    .Age = 29, _
                    .Friends = 5, _
                    .GPA = 3.32, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Evan", _
                    .Age = 30, _
                    .Friends = 1, _
                    .GPA = 0.81, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Annabelle", _
                    .Age = 22, _
                    .Friends = 14, _
                    .GPA = 3.42, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Sebastian", _
                    .Age = 25, _
                    .Friends = 2, _
                    .GPA = 2.31, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Callie", _
                    .Age = 30, _
                    .Friends = 14, _
                    .GPA = 3.69, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Dominic", _
                    .Age = 18, _
                    .Friends = 0, _
                    .GPA = 0.53, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Paige", _
                    .Age = 35, _
                    .Friends = 10, _
                    .GPA = 3.34, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Wyatt", _
                    .Age = 20, _
                    .Friends = 2, _
                    .GPA = 1.73, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Alexis", _
                    .Age = 24, _
                    .Friends = 11, _
                    .GPA = 2.82, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Henry", _
                    .Age = 38, _
                    .Friends = 1, _
                    .GPA = 0.84, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Mia", _
                    .Age = 32, _
                    .Friends = 7, _
                    .GPA = 3.70, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Ryan", _
                    .Age = 19, _
                    .Friends = 3, _
                    .GPA = 0.03, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Evelyn", _
                    .Age = 20, _
                    .Friends = 5, _
                    .GPA = 2.54, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Michael", _
                    .Age = 34, _
                    .Friends = 2, _
                    .GPA = 1.88, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Kylie", _
                    .Age = 28, _
                    .Friends = 6, _
                    .GPA = 3.09, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Luke", _
                    .Age = 18, _
                    .Friends = 0, _
                    .GPA = 0.72, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Maya", _
                    .Age = 36, _
                    .Friends = 10, _
                    .GPA = 2.55, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Emmett", _
                    .Age = 26, _
                    .Friends = 1, _
                    .GPA = 1.65, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Aurora", _
                    .Age = 18, _
                    .Friends = 12, _
                    .GPA = 3.79, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Ian", _
                    .Age = 16, _
                    .Friends = 1, _
                    .GPA = 2.24, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Zoe", _
                    .Age = 21, _
                    .Friends = 13, _
                    .GPA = 3.92, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Micah", _
                    .Age = 28, _
                    .Friends = 3, _
                    .GPA = 2.48, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Alyssa", _
                    .Age = 27, _
                    .Friends = 5, _
                    .GPA = 3.96, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Finn", _
                    .Age = 19, _
                    .Friends = 1, _
                    .GPA = 0.19, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Juliet", _
                    .Age = 21, _
                    .Friends = 7, _
                    .GPA = 3.30, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Samuel", _
                    .Age = 23, _
                    .Friends = 3, _
                    .GPA = 1.00, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Eva", _
                    .Age = 36, _
                    .Friends = 13, _
                    .GPA = 3.17, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Adam", _
                    .Age = 40, _
                    .Friends = 2, _
                    .GPA = 2.31, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Michaela", _
                    .Age = 28, _
                    .Friends = 6, _
                    .GPA = 3.85, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Xander", _
                    .Age = 24, _
                    .Friends = 1, _
                    .GPA = 2.40, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Vivienne", _
                    .Age = 40, _
                    .Friends = 8, _
                    .GPA = 3.14, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Daniel", _
                    .Age = 37, _
                    .Friends = 2, _
                    .GPA = 2.37, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Ashlyn", _
                    .Age = 33, _
                    .Friends = 6, _
                    .GPA = 4.01, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Seth", _
                    .Age = 27, _
                    .Friends = 0, _
                    .GPA = 1.44, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Gabriella", _
                    .Age = 21, _
                    .Friends = 12, _
                    .GPA = 3.12, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Parker", _
                    .Age = 20, _
                    .Friends = 3, _
                    .GPA = 1.44, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Allison", _
                    .Age = 21, _
                    .Friends = 11, _
                    .GPA = 2.69, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Ryder", _
                    .Age = 38, _
                    .Friends = 1, _
                    .GPA = 0.57, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Cadence", _
                    .Age = 38, _
                    .Friends = 5, _
                    .GPA = 2.71, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Edward", _
                    .Age = 25, _
                    .Friends = 0, _
                    .GPA = 2.29, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Lillian", _
                    .Age = 39, _
                    .Friends = 5, _
                    .GPA = 3.65, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Xavier", _
                    .Age = 28, _
                    .Friends = 2, _
                    .GPA = 0.89, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Stella", _
                    .Age = 16, _
                    .Friends = 9, _
                    .GPA = 3.57, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Max", _
                    .Age = 35, _
                    .Friends = 3, _
                    .GPA = 0.61, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Sarah", _
                    .Age = 29, _
                    .Friends = 7, _
                    .GPA = 3.41, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Damien", _
                    .Age = 28, _
                    .Friends = 1, _
                    .GPA = 0.69, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Caroline", _
                    .Age = 28, _
                    .Friends = 6, _
                    .GPA = 2.77, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jonah", _
                    .Age = 18, _
                    .Friends = 3, _
                    .GPA = 0.93, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Sienna", _
                    .Age = 19, _
                    .Friends = 11, _
                    .GPA = 2.52, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Miles", _
                    .Age = 21, _
                    .Friends = 2, _
                    .GPA = 0.38, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Lauren", _
                    .Age = 26, _
                    .Friends = 11, _
                    .GPA = 3.29, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Adrian", _
                    .Age = 17, _
                    .Friends = 0, _
                    .GPA = 1.70, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Aubrey", _
                    .Age = 31, _
                    .Friends = 11, _
                    .GPA = 3.47, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Tyler", _
                    .Age = 26, _
                    .Friends = 0, _
                    .GPA = 2.09, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Autumn", _
                    .Age = 24, _
                    .Friends = 6, _
                    .GPA = 3.31, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Christopher", _
                    .Age = 25, _
                    .Friends = 2, _
                    .GPA = 1.68, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Aaliyah", _
                    .Age = 33, _
                    .Friends = 6, _
                    .GPA = 3.81, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Isaiah", _
                    .Age = 37, _
                    .Friends = 3, _
                    .GPA = 2.37, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Victoria", _
                    .Age = 28, _
                    .Friends = 9, _
                    .GPA = 3.98, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Carson", _
                    .Age = 32, _
                    .Friends = 0, _
                    .GPA = 1.62, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Ruby", _
                    .Age = 34, _
                    .Friends = 8, _
                    .GPA = 3.13, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Eli", _
                    .Age = 40, _
                    .Friends = 2, _
                    .GPA = 0.32, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Catherine", _
                    .Age = 36, _
                    .Friends = 10, _
                    .GPA = 2.51, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Thomas", _
                    .Age = 21, _
                    .Friends = 1, _
                    .GPA = 0.82, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Alexandra", _
                    .Age = 23, _
                    .Friends = 11, _
                    .GPA = 2.87, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Holden", _
                    .Age = 17, _
                    .Friends = 3, _
                    .GPA = 1.66, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Samantha", _
                    .Age = 26, _
                    .Friends = 9, _
                    .GPA = 3.89, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Hayden", _
                    .Age = 23, _
                    .Friends = 1, _
                    .GPA = 1.97, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Bailey", _
                    .Age = 19, _
                    .Friends = 12, _
                    .GPA = 2.87, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "David", _
                    .Age = 17, _
                    .Friends = 0, _
                    .GPA = 2.06, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Harper", _
                    .Age = 25, _
                    .Friends = 8, _
                    .GPA = 3.39, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Cameron", _
                    .Age = 40, _
                    .Friends = 2, _
                    .GPA = 2.39, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Jillian", _
                    .Age = 38, _
                    .Friends = 10, _
                    .GPA = 3.28, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Joseph", _
                    .Age = 20, _
                    .Friends = 1, _
                    .GPA = 1.92, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Mackenzie", _
                    .Age = 26, _
                    .Friends = 8, _
                    .GPA = 2.83, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Austin", _
                    .Age = 38, _
                    .Friends = 2, _
                    .GPA = 1.63, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Alexa", _
                    .Age = 19, _
                    .Friends = 12, _
                    .GPA = 3.37, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Hunter", _
                    .Age = 26, _
                    .Friends = 1, _
                    .GPA = 0.42, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Esme", _
                    .Age = 38, _
                    .Friends = 10, _
                    .GPA = 3.24, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Colton", _
                    .Age = 28, _
                    .Friends = 1, _
                    .GPA = 1.34, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Gabrielle", _
                    .Age = 33, _
                    .Friends = 8, _
                    .GPA = 2.51, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Brody", _
                    .Age = 40, _
                    .Friends = 0, _
                    .GPA = 1.00, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Lydia", _
                    .Age = 20, _
                    .Friends = 7, _
                    .GPA = 2.65, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Blake", _
                    .Age = 22, _
                    .Friends = 2, _
                    .GPA = 1.25, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Kayla", _
                    .Age = 37, _
                    .Friends = 14, _
                    .GPA = 4.06, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Rhys", _
                    .Age = 35, _
                    .Friends = 3, _
                    .GPA = 1.69, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Rosalie", _
                    .Age = 39, _
                    .Friends = 8, _
                    .GPA = 3.40, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Gage", _
                    .Age = 35, _
                    .Friends = 3, _
                    .GPA = 1.07, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Zoey", _
                    .Age = 25, _
                    .Friends = 9, _
                    .GPA = 4.10, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jonathan", _
                    .Age = 32, _
                    .Friends = 0, _
                    .GPA = 1.72, _
                    .Grade = Grade.D, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Brianna", _
                    .Age = 35, _
                    .Friends = 9, _
                    .GPA = 2.66, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Riley", _
                    .Age = 23, _
                    .Friends = 1, _
                    .GPA = 0.61, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Isla", _
                    .Age = 22, _
                    .Friends = 5, _
                    .GPA = 3.55, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Joel", _
                    .Age = 40, _
                    .Friends = 1, _
                    .GPA = 1.15, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Taylor", _
                    .Age = 18, _
                    .Friends = 11, _
                    .GPA = 3.64, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Brandon", _
                    .Age = 31, _
                    .Friends = 0, _
                    .GPA = 1.16, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Brooke", _
                    .Age = 25, _
                    .Friends = 9, _
                    .GPA = 2.72, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jude", _
                    .Age = 17, _
                    .Friends = 0, _
                    .GPA = 1.44, _
                    .Grade = Grade.F, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Adalyn", _
                    .Age = 18, _
                    .Friends = 9, _
                    .GPA = 2.66, _
                    .Grade = Grade.B, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Jason", _
                    .Age = 32, _
                    .Friends = 1, _
                    .GPA = 1.03, _
                    .Grade = Grade.C, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Lorelei", _
                    .Age = 26, _
                    .Friends = 8, _
                    .GPA = 4.04, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Anthony", _
                    .Age = 28, _
                    .Friends = 3, _
                    .GPA = 0.89, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Julia", _
                    .Age = 21, _
                    .Friends = 8, _
                    .GPA = 3.86, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Nolan", _
                    .Age = 34, _
                    .Friends = 1, _
                    .GPA = 1.86, _
                    .Grade = Grade.F, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Reagan", _
                    .Age = 34, _
                    .Friends = 7, _
                    .GPA = 3.71, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Cooper", _
                    .Age = 37, _
                    .Friends = 2, _
                    .GPA = 1.13, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Faith", _
                    .Age = 23, _
                    .Friends = 9, _
                    .GPA = 2.63, _
                    .Grade = Grade.A, _
                    .Tall = True, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "Maddox", _
                    .Age = 21, _
                    .Friends = 3, _
                    .GPA = 2.30, _
                    .Grade = Grade.D, _
                    .Tall = True, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Sydney", _
                    .Age = 39, _
                    .Friends = 7, _
                    .GPA = 2.64, _
                    .Grade = Grade.A, _
                    .Tall = False, _
                    .Good = True _
                }, _
                New Student With { _
                    .Name = "John", _
                    .Age = 22, _
                    .Friends = 1, _
                    .GPA = 1.17, _
                    .Grade = Grade.C, _
                    .Tall = False, _
                    .Good = False _
                }, _
                New Student With { _
                    .Name = "Jasmine", _
                    .Age = 20, _
                    .Friends = 8, _
                    .GPA = 2.53, _
                    .Grade = Grade.B, _
                    .Tall = False, _
                    .Good = True _
                } _
            }
        End Function
    End Class
End Namespace
