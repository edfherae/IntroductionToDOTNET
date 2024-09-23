using System;
using System.Linq;

namespace Academy
{
	internal class Human
	{
		static readonly int TYPE_WIDTH = 10;
		static readonly int LAST_NAME_WIDTH = 10;
		static readonly int FIRST_NAME_WIDTH = 10;
		static readonly int AGE_WIDTH = 3;
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public uint Age { get; set; }
		public Human(string lastName, string firstName, uint age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstructor:\t{GetHashCode()}");
		}
		public Human(Human other)
		{
			LastName = other.LastName;
			FirstName = other.FirstName;
			Age = other.Age;
			Console.WriteLine($"HConstructor:\t{GetHashCode()}");
		}
		~Human()
		{
			Console.WriteLine($"HDestructor:\t{GetHashCode()}");
		}
		public override string ToString()
		{
			return (base.ToString().Split('.').Last() + ": ").PadRight(TYPE_WIDTH) + $"{LastName.PadRight(LAST_NAME_WIDTH)} {FirstName.PadRight(FIRST_NAME_WIDTH)} {Age.ToString().PadLeft(AGE_WIDTH)} y/o";
		}
		public virtual string ToFileString()
		{
			return base.ToString().Split('.').Last() + $",{LastName},{FirstName},{Age}";
		}
		public virtual Human Init(string[] values)
		{
			LastName = values[1];
			FirstName = values[2];
			Age = Convert.ToUInt32(values[3]);
			return this;
		}
	}
}
