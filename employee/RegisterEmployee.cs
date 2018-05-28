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
    public partial class RegisterEmployee : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=employee;Integrated Security=True");



        public RegisterEmployee()

        {
            InitializeComponent();
        }


        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
              genderCombo.Items.Add("Male");
              genderCombo.Items.Add("Female");
             
              jobrolecombo.Items.Add("Manager");
              jobrolecombo.Items.Add("Assistant");
              jobrolecombo.Items.Add("Salesman");
              jobrolecombo.Items.Add("Deliveryboy");

              String query = "SELECT * FROM Department";

              Functions.ComboWithKey(depidcombo, query, "DeptId", "DeptName");
           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fname.Text != "" & lname.Text != "" & genderCombo.Text != "" & contactnum.Text != "" & email.Text != "" & address.Text != "" & nic.Text != "" & txtsalary.Text != "" & jobrolecombo.Text != "" & usernametxt.Text != "" & passwordtxt.Text != "")
                {
                    string employeeid = Functions.getNextID("EmpId", "Employee", "EMP");
                    string firstname = fname.Text;
                    string lastname = lname.Text;
                    string gender = genderCombo.SelectedItem.ToString();
                    string dob = dobirth.Value.ToString();
                    string contact = contactnum.Text;
                    string emailid = email.Text;
                    string addressemp = address.Text;
                    string identitynic = nic.Text;
                    string departmentid = (((KeyValuePair<String, String>)depidcombo.SelectedItem).Key);
                    string salaryamt = txtsalary.Text;
                    string jobrole = jobrolecombo.SelectedItem.ToString();
                    string regisdate = regdate.Value.ToString();
                    string username = usernametxt.Text;
                    string passwrd = passwordtxt.Text;

                    string employeeregistrationquery = "insert into Employee(EmpId,FirstName,LastName,Gender,Contact,NIC,Email,DOB,Address,Position,BasicSalary,DateOfRegistered,DeptId)"
                    + "values('" + employeeid + "','" + firstname + "','" + lastname + "','" + gender + "','" + contact + "','" + identitynic + "','" + emailid + "', '" + dob + "','" + addressemp + "','" + jobrole + "','" + salaryamt + "','" + regisdate + "','" + departmentid + "')";

                    Functions.ExecuteQuery(employeeregistrationquery);
                    string userid = Functions.getNextID("UserId", "Users", "USR");
                    string userquery = "insert into Users VALUES('" + userid + "','" + username + "','" + passwrd + "','" + employeeid + "')";
                    Functions.ExecuteQuery(userquery);
                    reset();
                    MessageBox.Show("The Employee Was Registered Successfully");
                }
                else
                {
                    MessageBox.Show("One or more fields are empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This employee has been registered already");
                reset();
            }
          /*try
            {
                if ( fname.Text != "" & lname.Text != "" & genderCombo.Text != "" & dobdate.Text != "" & contactnum.Text != "" & email.Text != "" & address.Text != ""
           & nic.Text != "" & depidcombo.Text != "" & txtsalary.Text != "" & jobrolecombo.Text != "" & regdate.Text != "")
                {
                
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO  Employee (FirstName,LastName,Gender,DOB,Contact,Email,Address,nic,DepID,Salary,JobRole,DateOfReg) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@11,@12,@13,@14);", conn);

                   
                    cmd.Parameters.AddWithValue("@2", fname.Text);
                    cmd.Parameters.AddWithValue("@3", lname.Text);
                    cmd.Parameters.AddWithValue("@4", genderCombo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@5", dobdate.Text);
                    cmd.Parameters.AddWithValue("@6", contactnum.Text);
                    cmd.Parameters.AddWithValue("@7", email.Text);
                    cmd.Parameters.AddWithValue("@8", address.Text);
                    cmd.Parameters.AddWithValue("@9", nic.Text);
                    cmd.Parameters.AddWithValue("@11", depidcombo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@12",txtsalary.Text);
                    cmd.Parameters.AddWithValue("@13", jobrolecombo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@14", regdate.Text);
                       

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The employee entry was successfully registered.");

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
            }
            
            */
         }


        void reset()
        {
          
            fname.Text = "";
            lname.Text = "";
            genderCombo.SelectedIndex = -1;
            dobirth.Text = "";
            contactnum.Text = "";
            email.Text = "";
            address.Text = "";
            nic.Text = "";
            depidcombo.SelectedIndex = -1;
            txtsalary.Text = "";
            jobrolecombo.SelectedIndex = -1;
            regdate.Text = "";
            usernametxt.Text = "";
            passwordtxt.Text = "";

           




        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            string sfname = fname.Text;
            if (Functions.isNumber(sfname))
            {
                errorProvider1.SetError(fname, "can contain only letters");
                addbtn.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                addbtn.Enabled = true;


            }
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {
            string lastname = lname.Text;
            if (Functions.isNumber(lastname))
            {
                errorProvider1.SetError(lname, "can contain only letters");
                addbtn.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                addbtn.Enabled = true;


            }
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
           /* string addrs = address.Text;
            if (employeeValidate.IsAllLettersOrDigits(addrs))
            {
                errorProvider1.Clear();
                addbtn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(address, "can contain only letters and digits");
                addbtn.Enabled = false;
            }*/
        }

        private void contactnum_TextChanged(object sender, EventArgs e)
        {

            string ph = contactnum.Text;
            int no = ph.Length;

            

            if (no != 10)
            {
                errorProvider1.SetError(contactnum, "can contain only 10 Numbers");
                addbtn.Enabled = false;
                
            }


            else if (Functions.isLetter(ph))
            {
                errorProvider1.SetError(contactnum, "can contain only numbers");
                addbtn.Enabled = false;
                
            }
            else
            {
                errorProvider1.Clear();
                addbtn.Enabled = true;
                
            }
        }

        private void nic_TextChanged(object sender, EventArgs e)
        {
            string ni = nic.Text;
            int nicone = ni.Length;
            if (nicone < 10)
            {


                if (Functions.isNumber(ni))
                {
                    errorProvider1.SetError(nic, "can contain only numbers");
                    addbtn.Enabled = false;
                  
                }
                else
                {
                    errorProvider1.Clear();
                    addbtn.Enabled = true;
                   
                }
            }
            else if (nicone == 10)
            {

                if (!(ni[9].Equals('v') || ni[9].Equals('V')))
                {
                    errorProvider1.SetError(nic, "last character should be V");
                    addbtn.Enabled = false;
                  
                }
                else
                {
                    errorProvider1.Clear();
                    addbtn.Enabled = true;
                   
                }
            }

            else
                if (Functions.isMaxLength(nicone))
                {
                    errorProvider1.SetError(nic, "can contain only 10 Characters");
                    addbtn.Enabled = false;
                    
                }
                else
                {
                    errorProvider1.Clear();
                    addbtn.Enabled = true;
                    
                }

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            string m2 = email.Text;

            if (Functions.EmailIsValid(m2))
            {

                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(email, "Enter correct E-mail");

            }
        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {
            string sal = txtsalary.Text;

            if (Functions.isLetter(sal))
            {
                errorProvider1.SetError(txtsalary, "can contain only numbers");
                addbtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                addbtn.Enabled = true;
               
            }
        }

   
    }
}
