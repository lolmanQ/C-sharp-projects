using System;
using System.Collections.Generic;

namespace d1_1
{
	class Program
	{
		static void Main(string[] args)
		{
			MainProgram mp = new MainProgram();
			mp.Run();
		}
	}
	
	class MainProgram
	{
		List<int> listofint = new List<int>();
		public void Run()
		{
			bool isInput = true;
			double totalFuel = 0;
			while (isInput)
			{
				string tempObjMassString = Console.ReadLine();
				if(tempObjMassString == "done")
				{
					isInput = false;
				}
				else
				{
					int tempMass = int.Parse(tempObjMassString);
					int modulFuel = 0;
					int neededFuel = 0;
					neededFuel = CalcFuel(tempMass);
					modulFuel = neededFuel;
					do
					{
						neededFuel = CalcFuel(neededFuel);
						if(neededFuel > 0)
						{
							modulFuel += neededFuel;
						}
					} while (neededFuel >= 0);
					listofint.Add(modulFuel);
				}
			}

			foreach (int item in listofint)
			{
				totalFuel += item;
			}
			Console.WriteLine(totalFuel);
		}

		int CalcFuel(int inputMass)
		{
			double tempDB = inputMass;
			tempDB /= 3;
			tempDB = Math.Floor(tempDB);
			tempDB -= 2;
			int tempInt = Convert.ToInt32(tempDB);
			return tempInt;
		}
	}
}
