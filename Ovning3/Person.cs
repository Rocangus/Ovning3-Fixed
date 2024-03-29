﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Encapsulation
{
    public class Person
    {
        // It is not possible to directly access these private variables from program.cs.
        private int age;
        private string fName, lName;
        private double height, weight;

        public int Age { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
        }
    }
}
