using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Database_GUI
{
    public partial class Form1 : Form
    {
        //apply search criteria button variables
        private uint? eidSearch;
        private string deptSearch;

        /*********************************************
        * Constructor: name()
        * 
        * Use: Constructs a new Derived Form object
        * 
        * Parameters: none
        *********************************************/

        public Form1()
        {
            InitializeComponent();

            //initialize private variables
            eidSearch = null;
            deptSearch = null;

            //initialize list boxes
            UpdateEmployeeListBox();
            UpdateOptionsListBox();
            UpdateDeptListBox();

            DeptListBox.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
		
		/**********************************************************************
        * Method: UpdateOptionsListBox()
        * 
        * Use: Updates the options list box with options for working with employee data
        * 
        * Parameters: none
        ************************************************************************/
		
        private void UpdateOptionsListBox()
        {
            
            //set up for new info
            OptionsListBox.Items.Clear();

            //prevent interfence with update
            OptionsListBox.BeginUpdate();

            //set options listbox to options array
            OptionsListBox.DataSource = Program.OptionsArr;
             
            OptionsListBox.EndUpdate();
        }
		
		/**********************************************************************
        * Method: UpdateEmployeeListBox()
        * 
        * Use: Updates the employee list box with employee data
        * 
        * Parameters: none
        ************************************************************************/
		
        private void UpdateEmployeeListBox()
        {
                     
            //set up for new info
            EmployeeListBox.Items.Clear();

            //prevent interfence with update
            EmployeeListBox.BeginUpdate();

            //add each employee into the list box
            if (eidSearch == null)
            {
         
            foreach (Employee e in Program.EmployeeList)
                {
                    EmployeeListBox.Items.Add(string.Format("{0} -- {1}, {2}", e.Eid, e.Lname, e.Fname));
                }
            }
            else
            {
                //lambda expression to check to see if any eid matches or starts with a requested eid
                foreach (Employee e in Program.EmployeeList.Where(e => e.Eid.ToString().StartsWith(eidSearch.ToString()) || e.Eid == eidSearch))
                {
                    EmployeeListBox.Items.Add(string.Format("{0} -- {1}, {2}", e.Eid, e.Lname, e.Fname));
                }
            }
            EmployeeListBox.EndUpdate();
            }

        /**********************************************************************
        * Method: UpdateDeptListBox()
        * 
        * Use: Updates the department list box with department data
        * 
        * Parameters: none
        ************************************************************************/

        private void UpdateDeptListBox()
        {

            //set up for new info
            DeptListBox.Items.Clear();

            //prevent interfence with update
            DeptListBox.BeginUpdate();

            //set department listbox to depts array
            DeptListBox.DataSource = Program.DeptsArr;

            /*this is for if i need dept to be looked around like with employees */
            #region
            /*//add each employee into the list box
            if (eidSearch == null)
            {

                foreach (Employee e in Program.EmployeeList)
                {
                    EmployeeListBox.Items.Add(string.Format("{0} -- {1}, {2}", e.Eid, e.Lname, e.Fname));
                }
            }
            else
            {
                //lambda expression to check to see if any eid matches or starts with a requested eid
                foreach (Employee e in Program.EmployeeList.Where(e => e.Eid.ToString().StartsWith(eidSearch.ToString()) || e.Eid == eidSearch))
                {
                    EmployeeListBox.Items.Add(string.Format("{0} -- {1}, {2}", e.Eid, e.Lname, e.Fname));
                }
               
            }*/
            #endregion

            DeptListBox.EndUpdate();
        }

        /**********************************************************************
        * Method: UpdateOptionsListBox()
        * 
        * Use: Updates the options list box with options for working with employee data
        * 
        * Parameters: none
        ************************************************************************/

        private void DisableListBox()
        {
            //   bool isEnabled = true;

            //by default employee list should be disabled unless edit button is pressed
            EmployeeListBox.Enabled = false;

           
            

            //should just be variable
            DeptListBox.Enabled = false;
            //  if (//Selected index for listbox is an option that does not include department then department list is not visible)
            //options list should have Create Read Update Delete I dont know maybe i should make the Crud its own set of options. Or maybe break the read down to the info
            //like Read Salary, Read Employment Status. something like that
            //index of department option
            

          //  return isEnabled;
            }   //dept listbox should be invisible by default
	

        private void employeeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OptionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] empIndexArr = new int[] { 2, 3, 4 };

            if (empIndexArr.Contains(OptionsListBox.SelectedIndex) && OptionsListBox.SelectedIndex == 2)
                {
               
                    DeptListBox.Enabled = true;
                    
                }

                else if(empIndexArr.Contains(OptionsListBox.SelectedIndex))
                {
                    DeptListBox.Enabled = false;
                }

                else
                {
                EmployeeListBox.Enabled = false;
                    DeptListBox.Enabled = false;
                }
            
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            List<Employee> ResultList = new List<Employee>();
            //name option selected
            if (OptionsListBox.SelectedIndex == 1)
            {
                //department is marketing               
                if (DeptListBox.SelectedIndex == 0)
                {
                    
                    ResultList = Program.EmployeeList.Where(empl => Equals(empl.Dept, Program.DeptsArr[0])).ToList();

                    //trying to make a header
                    ResultListBox.Items.Add("Names of Employees in specified Department");

                    for (int i = 0; i<ResultList.Count; i++)
                    { 
                        ResultListBox.Items.Add(ResultList[i].Lname + ", " + ResultList[i].Fname + " " + ResultList[i].Dept);
                    }
                }

                //case statement see if it would be better

                switch (DeptListBox.SelectedIndex)
                {
                    case 1:
                        ResultList = Program.EmployeeList.Where(empl => Equals(empl.Dept, Program.DeptsArr[1])).ToList();
                        break;
                    case 2:
                        ResultList = Program.EmployeeList.Where(empl => Equals(empl.Dept, Program.DeptsArr[2])).ToList();
                        break;
                    case 3:
                        ResultList = Program.EmployeeList.Where(empl => Equals(empl.Dept, Program.DeptsArr[3])).ToList();
                        break;
                    case 4:
                        ResultList = Program.EmployeeList.Where(empl => Equals(empl.Dept, Program.DeptsArr[4])).ToList();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
