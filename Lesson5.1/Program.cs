using System;
using System.IO;
namespace Lesson5
{
	struct Car
	{
		public int EngineNum;
		public int[] Wheels;
	}
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*  File.WriteAllText("/Users/ann/", "Hello");
              string hello = File.ReadAllText("/Users/ann/");
              string[] lines = File.ReadAllLines("d:\\");
              File.AppendAllText("d:\\", "Word");
              File.Exists("d:\\");

              string[] files = Directory.GetFiles("d:\\");
              for (int i = 0; i < files.Length; i++)
              {
                  Console.WriteLine(files[i]);
              } */



            Car bmw = new Car() { EngineNum = 12345, Wheels = new int[] { 1, 1, 1 } };
            string toSave = bmw.EngineNum.ToString() + Environment.NewLine;
            toSave += bmw.Wheels.Length + Environment.NewLine;
            for (int i = 0; i < bmw.Wheels.Length; i++)
            {

                {
                    toSave += bmw.Wheels[i];
                } 
                File.WriteAllText("d:\\", toSave);
                string[] fromString = File.ReadAllLines("d:\\");
                Car newBmw = new Car();
                newBmw.EngineNum = int.Parse(fromString[0]);
                newBmw.Wheels = new int[int.Parse(fromString[1])];
                var wheelsString = fromString[2];
                string temp = string.Empty;
                for (int i = 0, j = 0; i < wheelsString.Length && j<newBmw.Wheels.Length; i++)
                {
                    char currentchar = wheelsString[i];
                    if (currentchar != ';')
                        temp += currentchar;
                    else 
                    {
                        newBmw.Wheels[j] = int.Parse(temp);
                        j++;
                    }
                }

            }
        } 
        }
    }

