﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompleteApp
{
    class Student : Person
    {
        double marks;

        public Student()
        {
        }
        public Student(string name, double marks) : base(name)
        {
            this.marks = marks;
        }

        public double Marks { get => marks; set => marks = value; }

        public override bool IsOutstanding()
        {
            return marks > 85 ? true : false;
        }
        public override string PrintInfo()
        {
            return $"{ base.PrintInfo() }, {marks}";
        }
    }
}
