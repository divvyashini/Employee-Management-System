using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;


namespace employee
{
    public partial class LeaveRequest : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=OrdersLK;Integrated Security=True");
        public LeaveRequest()
        {
            InitializeComponent();
        }

        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
             
              try
                {
                    if (empid.Text != "" & leavecategory.Text != "" & leavestartdate.Text != "" & leaveenddate.Text != "" & monthcombobox.Text != "" & leavedescription.Text != "" & leaveyear.Text != "")
                    {
                        string leaverequestid = Functions.getNextID("ELId", "EmployeeLeaves", "ELV");
                        string employeeid = empid.Text;
                        string leavecat = leavecategory.SelectedItem.ToString();
                        string startdate = leavestartdate.Value.ToString();
                        string enddate = leaveenddate.Value.ToString();
                        string monthofleave = monthcombobox.SelectedItem.ToString();
                        string leaverequestdesc = leavedescription.Text;
                        string year = leaveyear.Text;


                        string leaverequestquery = "insert into EmployeeLeaves(ELId,FromDate,ToDate,Comment,LeaveCatergory,EmpId,month,yearofleave)"
                        + "values('" + leaverequestid + "','" + startdate + "','" + enddate + "','" + leaverequestdesc + "','" + leavecat + "','" + employeeid + "','" + monthofleave + "','" + year + "')";

                        Functions.ExecuteQuery(leaverequestquery);
                        reset();
                        MessageBox.Show("The leave request was successfully sent");

                    }


                    else
                    {
                        MessageBox.Show("One or More Fields Empty");
                    }
              
               }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid employee id");
            }
            /*try
            {
                if (empid.Text != "" &   leavecategory.Text != "" & leavestartdate.Text != "" & leaveenddate.Text != "" & monthcombobox.Text!="" & leavedescription.Text != "" )
                {
                    
                    conn.Open();

                   
                    SqlCommand cmd = new SqlCommand("INSERT INTO  EmployeeLeaves (FromDate,ToDate,Comment,LeaveCategory,EmpId,month) VALUES (@2,@3,@4,@5,@6,@7);", conn);


                    cmd.Parameters.AddWithValue("@2",leavestartdate.Text);
                    cmd.Parameters.AddWithValue("@3",leaveenddate.Text);
                    cmd.Parameters.AddWithValue("@4", leavedescription.Text);
                    cmd.Parameters.AddWithValue("@5", leavecategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@6", empid.Text);
                    cmd.Parameters.AddWithValue("@7", monthcombobox.Text);
                 


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The leave request was submitted successfully.");

                    conn.Close();
                    reset();


                }
                else
                {

                    MessageBox.Show("One or more fields are empty");
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
                reset();
            }*/

        }

        private void LeaveRequest_Load(object sender, EventArgs e)
        {
            leavecategory.Items.Add("Annual");
            leavecategory.Items.Add("Health");
            leavecategory.Items.Add("Emergency");
            leavecategory.Items.Add("Maternity");
            leavecategory.Items.Add("Injury");
            leavecategory.Items.Add("Pilgrimage");
            monthcombobox.Items.Add("January");
            monthcombobox.Items.Add("February");
            monthcombobox.Items.Add("March");
            monthcombobox.Items.Add("April");
            monthcombobox.Items.Add("May");
            monthcombobox.Items.Add("June");
            monthcombobox.Items.Add("July");
            monthcombobox.Items.Add("August");
            monthcombobox.Items.Add("September");
            monthcombobox.Items.Add("October");
            monthcombobox.Items.Add("November");
            monthcombobox.Items.Add("December");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

                

       
        void reset()
        {

            empid.Text = "";
          
            leavecategory.SelectedIndex = -1;
            leavestartdate.Text = "";
            leaveenddate.Text = "";
            leavedescription.Text = "";
            leaveyear.Text = "";
            monthcombobox.SelectedIndex = -1;
           



        }

        private void empname_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void empid_TextChanged(object sender, EventArgs e)
        {

        }

        private void leaveyear_TextChanged(object sender, EventArgs e)
        {
            string sal = leaveyear.Text;

            if (Functions.isLetter(sal))
            {
                errorProvider1.SetError(leaveyear, "can contain only numbers");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                button1.Enabled = true;

            }
        }
    }
}
