﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Teacher:Human
	{
		public string Speciality { get; set; }
		public int Experience { get; set; }
		public Teacher
			(
				string lastName, string firstName, int age,
				string speciality, int experience
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TConstructor:\t {this.GetHashCode()}");
		}
		public Teacher(Teacher other) : base(other)
		{
			this.Speciality = other.Speciality;
			this.Experience = other.Experience;
			Console.WriteLine($"TCopyConstructor:{this.GetHashCode()}");
		}
		~Teacher()
		{
			Console.WriteLine($"TDestructor:\t {this.GetHashCode()}");
		}

		public override string ToString()
		{
			return base.ToString() + " " + $"{Speciality} {Experience}";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Speciality:\t" + Speciality);
			Console.WriteLine("Experience:\t" + Experience);
		}
	}
}
