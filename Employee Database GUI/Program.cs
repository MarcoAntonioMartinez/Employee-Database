using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Database_GUI
{
    static class Program
    {   
        //list of employees
	public static List<Employee> EmployeeList = new List<Employee>();
     
        //array to hold the options users have for interacting with info
        public static string[] OptionsArr;

        //array to hold the departments
        public static string[] DeptsArr;

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //hold a read line one at a time
            string holdLine = "";

            //holds the split line
            string[] split;     


			//try to read the input file 
			try
			{
                using (StreamReader inFile = new StreamReader("..\\..\\employees.txt"))
                {
                    while (!inFile.EndOfStream)
                    {
                        holdLine = inFile.ReadLine();
                                          
                        split = holdLine.Split(',');

                        //create a new employee object and store in EmployeeList
                        EmployeeList.Add(new Employee(uint.Parse(split[0]), split[1], split[2], split[3], split[4], uint.Parse(split[5])));
                                              
                    }

                }

                //set the options array to the contents of the options file
                OptionsArr = File.ReadAllLines("..\\..\\options.txt");
                                
                //set the departments array to the contents of the depts file
                DeptsArr = File.ReadAllLines("..\\..\\departments.txt");

                //Generate a new MainForm window, this happens after the files are read
                //to ensure the listboxes will have valid information to display on startup
                Application.Run(new Form1());
            }
			catch(System.IO.FileNotFoundException)			//catch the file not found exception
			{
				Console.WriteLine("The file was not found");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(1);
			}
        }
    }
}
