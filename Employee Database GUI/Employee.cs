using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Database_GUI
{
    class Employee
    {
        // employee no., lname, fname, dept, part time/full time, salary
        readonly uint eid;
        private string lname, fname, dept;
        private string empStatus; //maybe change
        private uint salary;

        /***************************************************/
        //getters and setters for data members

        public uint Eid { get { return eid; } }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public string EmpStatus
        {
            get { return empStatus; }
            set { empStatus = value; }
        }

        public uint Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        //default constructor
        public Employee()
        {//maybe change
            eid = 0;
            lname = "/0";//need to find out what this is for
            fname = "";
            dept = "";
            empStatus = "";
            salary = 0;
        }

        //constructor for Employee objects
        public Employee(uint ConEid, string ConLname, string ConFname, string ConDept, string ConStatus, uint ConSal)
        {

            lname = ConLname;
            fname = ConFname;
            dept = ConDept;
            empStatus = ConStatus;
            salary = ConSal;

            //make sure the id is valid
            if (ConEid < 1000000)
            {
                eid = 0;
            }

            else
            {
                eid = ConEid;
            }
        }


    }
}
