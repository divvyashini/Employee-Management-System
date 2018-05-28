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
    public partial class Salary : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=OrdersLK;Integrated Security=True");

        public Salary()
        {
            InitializeComponent();
        }

        SqlDataReader dr;

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            monthcombo.Items.Add("January");
            monthcombo.Items.Add("February");
            monthcombo.Items.Add("March");
            monthcombo.Items.Add("April");
            monthcombo.Items.Add("May");
            monthcombo.Items.Add("June");
            monthcombo.Items.Add("July");
            monthcombo.Items.Add("August");
            monthcombo.Items.Add("September");
            monthcombo.Items.Add("October");
            monthcombo.Items.Add("November");
            monthcombo.Items.Add("December");
            salstatus.Items.Add("Paid");
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (empid.Text != "")
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM  Employee where EmpId = @1", conn);


                    cmd.Parameters.AddWithValue("@1", empid.Text);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {

                            empname.Text = dr["FirstName"].ToString();
                            depid.Text = dr["DeptId"].ToString();
                            basicsalary.Text = dr["BasicSalary"].ToString();

                        }

                    }

                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter The Employee ID To Process The Details");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (empid.Text != "" & monthcombo.Text != "" & yearbox.Text != "")
                {
                    conn.Open();
                    SqlCommand cmdtwo = new SqlCommand();
                    cmdtwo.CommandText = "SELECT COUNT (ELId) FROM EmployeeLeaves WHERE EmpId = @1 AND month=@15 AND yearofleave=@16 AND Status='Approved'";
                    cmdtwo.Connection = conn;
                    cmdtwo.Parameters.AddWithValue("@1", empid.Text);
                    cmdtwo.Parameters.AddWithValue("@15", monthcombo.SelectedItem.ToString());
                    cmdtwo.Parameters.AddWithValue("@16", yearbox.Text);

                    noofleavestaken.Text = cmdtwo.ExecuteScalar().ToString();
                }

                else
                {
                    MessageBox.Show("Please fill the relevant fields to process the attendance details");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please Enter The Details Correctly");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (empid.Text != "" & empname.Text != "" & depid.Text != "" & basicsalary.Text != "" & yearbox.Text != "" & monthcombo.Text != "" & noofleavestaken.Text != "" & daysworked.Text != "" & leavedeductionamt.Text != "" & epfdeductionamt.Text != "" & totaldeduction.Text != "" & netpayamt.Text != "" & salstatus.Text != "")
                {
                    string salaryid = Functions.getNextID("SalId", "Salary", "SAL");
                    string employeeid = empid.Text;
                    string employeename = empname.Text;
                    string deptid = depid.Text;
                    string basicsal = basicsalary.Text;
                    string salaryyear = yearbox.Text;
                    string salmonth = monthcombo.SelectedItem.ToString();
                    string numofleavestaken = noofleavestaken.Text;
                    string numofdaysworked = daysworked.Text;
                    string leavdeduct = leavedeductionamt.Text;
                    string epfdeduct = epfdeductionamt.Text;
                    string totaldeductions = totaldeduction.Text;
                    string netpayment = netpayamt.Text;
                    string salarycrediteddate = salarydate.Value.ToString();
                    string salarystatus = salstatus.SelectedItem.ToString();

                    string salarycreditquery = "insert into Salary(SalId,EmpId,EmpName,DepId,BasicSalary,salYear,SalMonth,NumOfLeavesTaken,NumOfDaysWorked,Leavededuction,EPFdeduction,TotalDeduction,NetPay,SalaryCreditedDate,SalaryStatus)"
                    + "values('" + salaryid + "','" + employeeid + "','" + employeename + "','" + deptid + "','" + basicsal + "','" + salaryyear + "','" + salmonth + "', '" + numofleavestaken + "','" + numofdaysworked + "','" + leavdeduct + "','" + epfdeduct + "','" + totaldeductions + "','" + netpayment + "','" + salarycrediteddate + "','" + salarystatus + "')";

                    Functions.ExecuteQuery(salarycreditquery);
                    reset();
                    MessageBox.Show("The salary credited entry was added successfully");
                }
                else
                {
                    MessageBox.Show("Please Fill In The Relevant Fields To Add The Salary Entry");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Details");
                reset();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double leaveamt = (Convert.ToDouble(noofleavestaken.Text) * (2));
                leavedeductionamt.Text = (Convert.ToDouble(basicsalary.Text) * (leaveamt / 100)).ToString();

                double epfamt = 8;
                epfdeductionamt.Text = (Convert.ToDouble(basicsalary.Text) * (epfamt / 100)).ToString();

                totaldeduction.Text = (Convert.ToDouble(leavedeductionamt.Text) + Convert.ToDouble(epfdeductionamt.Text)).ToString();
                netpayamt.Text = (Convert.ToDouble(basicsalary.Text) - (Convert.ToDouble(totaldeduction.Text))).ToString();
            }

            catch( Exception ex)
            {
                MessageBox.Show("Fill in the relevant fields to process the payment details");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void empid_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        void reset()
        {

            empid.Text = "";
            empname.Text = "";
            depid.Text = "";
            basicsalary.Text = "";
            monthcombo.SelectedIndex = -1;
            yearbox.Text = "";
            noofleavestaken.Text = "";
            daysworked.Text = "";
            leavedeductionamt.Text = "";
            epfdeductionamt.Text = "";
            totaldeduction.Text = "";
            netpayamt.Text = "";
            salstatus.SelectedIndex = -1;
       





        }

        private void yearbox_TextChanged(object sender, EventArgs e)
        {
            string sal = yearbox.Text;

            if (Functions.isLetter(sal))
            {
                errorProvider1.SetError(yearbox, "can contain only numbers");
                button4.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                button4.Enabled = true;

            }
        }

    }
}
