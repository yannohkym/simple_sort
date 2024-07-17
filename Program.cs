using Microsoft.VisualBasic;

namespace ConsoleMe
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			List<int>  ints = new List<int>();
			ints.Add(1);
			ints.Add(4);
			ints.Add(3);
			ints.Add(2);
			ints.Add(5);

			 foreach(var item in ints)
				{
					Console.WriteLine(item);
				}

			int temp;
			for(int i = 0; i < ints.Count; i++)
			{
				for (int j = 0; j < ints.Count; j++)
				{
					if (ints[i] < ints[j])
					{
						 temp = ints[i]; 
						ints[i] = ints[j];
						ints[j] = temp;
						
						
					}
				}
			}
			Console.WriteLine("----------------");
			Console.WriteLine("After  sorting");


			foreach (var item in ints)
			{
				Console.WriteLine(item);
			}



			Console.WriteLine("Sort  and compare  strings-------------");

		    List<string> strings = new List<string>();
			strings.Add("aa");
			strings.Add("bbcaa");
			strings.Add("bca");
			strings.Add("czs");
			strings.Add("a");

			foreach (var item in strings)
			{
				Console.WriteLine(item);
			}

			string temps;
			for (int i = 0; i < strings.Count; i++)
			{
				for (int j = 0; j < strings.Count; j++)
				{
					if(string.Compare(strings[i], strings[j]) <0) {

						temps = strings[i];
						strings[i] = strings[j];
						strings[j] = temps;
					}
			
              

					
				}
			}
			Console.WriteLine("----------------");
			Console.WriteLine("After  sorting");


			foreach (var item in strings)
			{
				Console.WriteLine(item);
			}



		}
	}
}