using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ml.Attributes;
using System.ComponentModel;

namespace MachineLearningDemo.Data
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    public class Student
    {
        [Feature]
        public double GradeToPercent()
        {
            double grade = 0;
            switch (Grade)
            {
                case Grade.A:
                    grade = 90;
                    break;
                case Grade.B:
                    grade = 80;
                    break;
                case Grade.C:
                    grade = 70;
                    break;
                case Grade.D:
                    grade = 60;
                    break;
                case Grade.F:
                    grade = 50;
                    break;
            }
            return grade;
        }

        [Feature]
        public double QuadrupleFriends()
        {
            return Friends * 4;
        }

        public string GetName()
        {
            return Name;
        }

        public string Name { get; set; }

        public Grade Grade { get; set; }

        [Feature]
        public double GPA { get; set; }

        [Feature]
        public int Age { get; set; }

        [Feature]
        public bool Tall { get; set; }

        public int Friends { get; set; }

        [Label]
        public bool Good { get; set; }

        public int Cluster { get; set; }        
    }
}
