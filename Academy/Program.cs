//#define INHERITANCE_1
//#define INHERITANCE_2
//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;

namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_1
			Human human = new Human("test", "test", 0);
			Console.WriteLine(human);

			Student student = new Student("Hugo", "Stiglitz", 35, "Rebel", "Bastards", 95, 100);
			Console.WriteLine(student);

			Teacher teacher = new Teacher("Marya", "Ivanovna", 99, "Screaming", 79);
			Console.WriteLine(teacher);
			
			Graduate graduate = new Graduate("Marya", "Ivanovna", 99, "Screaming", "A", 99, 99, "Math");
			Console.WriteLine(graduate);

#endif

#if INHERITANCE_2
			Human tommy = new Human("Vercetty", "Tommy", 30);
			Console.WriteLine(tommy);
			Student student_tommy = new Student(tommy, "theft", "Vice", 95, 98);
			Console.WriteLine(student_tommy);

			Human henry = new Human("Henry", "Tomassino", 50);
			Console.WriteLine();
			Teacher teacher_henry = new Teacher(henry, "Weapons distrubution", 20);
			Console.WriteLine(teacher_henry.ToString());

			Human harry = new Human("Harry", "Potter", 18);
			Console.WriteLine(harry);
			Student student_harry = new Student(harry, "Magic", "Griffindor", 100, 100);
			Console.WriteLine(student_harry);
			Graduate graduate_harry = new Graduate(student_harry, "Saving of the World");
			Console.WriteLine(graduate_harry); 
#endif

#if WRITE_TO_FILE
			Human[] group = new Human[]
				{
				new Student("Hugo", "Stiglitz", 35, "Rebel", "Bastards", 95, 100),
				new Teacher("Marya", "Ivanovna", 99, "Screaming", 79),
				new Graduate("Marya", "Ivanovna", 99, "Screaming", "A", 99, 99, "Math"),
				new Human("test", "test", 0)
				};
			Print(group);
			Save(group, "Group.csv"); //Common separated values - значения, разделённе запятыми  
#endif

#if READ_FROM_FILE
			Human[] group = Load("Group.csv");
			Print(group);
#endif

		}
		static void Print(Human[] group)
		{
			//for (int i = 0; i < group.Length; i++)
			//{
			//	Console.WriteLine($"{group[i]} ");
			//}

			foreach (Human i in group)
			{
				Console.WriteLine(i); //DownCast - преобразование от базового типа к дочернему
			}
		}
		static void Save(Human[] group, string path)
		{
			StreamWriter sw = new StreamWriter(path);
			foreach (Human i in group)
			{
				sw.WriteLine(i.ToFileString());
			}
			sw.Close();
			Process.Start("notepad", path);
		}
		static Human[] Load(string path)
		{
			List<Human> list = new List<Human>();
			StreamReader sr = new StreamReader(path);
			while(!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				//Console.WriteLine(buffer);
				string[] values = buffer.Split(',');
				//Human human = HumanFactory(values[0]);
				//human.Init(values);
				//list.Add(human);

				list.Add(HumanFactory(values[0]).Init(values));
			}
			list.ForEach(x => Console.WriteLine(x));
			sr.Close();
			return list.ToArray();
		}
		static Human HumanFactory(string type) //UpCast - преобразование дочернего типа к базовому
		{
			Human human = null;
			switch(type)
			{
				case "Human": human = new Human("", "", 0);  break;
				case "Teacher": human = new Teacher("", "", 0,"",0);  break;
				case "Student": human = new Student("", "", 0,"","",0,0);  break;
				case "Graduate": human = new Graduate("", "", 0,"","",0,0,"");  break;
			}
			return human;
		}
	}
}
