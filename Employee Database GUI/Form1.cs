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


        private void employeeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
