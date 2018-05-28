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
    public partial class SearchUpdateDeleteEmployee : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=OrdersLK;Integrated Security=True");
        public SearchUpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlDataReader dr1;

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                if (searchemp.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM  Employee where EmpId = @1", conn);
                    cmd.Parameters.AddWithValue("@1", searchemp.Text);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {

                            fname.Text = dr["FirstName"].ToString();
                            lname.Text = dr["LastName"].ToString();
                            genderCombo.Text = dr["Gender"].ToString();
                            dobdate.Text = dr["DOB"].ToString();
                            contactnum.Text = dr["Contact"].ToString();
                            email.Text = dr["Email"].ToString();
                            address.Text = dr["Address"].ToString();
                            nic.Text = dr["NIC"].ToString();
                            //depNameCombo.Text = dr["DepName"].ToString();
                            depidcombo.Text = dr["DeptId"].ToString();
                            txtsalary.Text = dr["BasicSalary"].ToString();
                            jobrolecombo.Text = dr["Position"].ToString();
                            regdate.Text = dr["DateOfRegistered"].ToString();

                        }

                    }
                    dr.Close();
                    conn.Close();
                    conn.Open();

                    SqlCommand cmdthree = new SqlCommand("SELECT Username,Password FROM Users where EmpId = @1", conn);
                    cmdthree.Parameters.AddWithValue("@1", searchemp.Text);
                    dr1 = cmdthree.ExecuteReader();
                    if (dr1.HasRows)
                    {
                        if (dr1.Read())
                        {

                            usernametxt.Text = dr1["Username"].ToString();
                            passwrdtxt.Text = dr1["Password"].ToString();


                        }

                    }


                    //    dr.Close();
                    dr1.Close();
                }

                else
                {
                    MessageBox.Show("Please Enter An Employee ID To Search The Details");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter A Valid Employee ID");
            }
            finally
            {
                conn.Close();
              
            }       

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (fname.Text != "" & lname.Text != "" & genderCombo.Text != "" & dobdate.Text != "" & contactnum.Text != "" & email.Text != "" & address.Text != ""
          & nic.Text != ""  & depidcombo.Text != "" & txtsalary.Text != "" & jobrolecombo.Text != "" & regdate.Text != "")

                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Employee SET FirstName=@2,LastName=@3,Gender=@4,DOB=@5,Contact=@6,Email=@7,Address=@8,NIC=@10,DeptId=@12,BasicSalary=@13,Position=@14 WHERE EmpId =@1 ", conn);


                    cmd.Parameters.AddWithValue("@1", searchemp.Text);
                    cmd.Parameters.AddWithValue("@2", fname.Text);
                    cmd.Parameters.AddWithValue("@3", lname.Text);
                    cmd.Parameters.AddWithValue("@4", genderCombo.Text);
                    cmd.Parameters.AddWithValue("@5", dobdate.Value.ToString());
                    cmd.Parameters.AddWithValue("@6", contactnum.Text);
                    cmd.Parameters.AddWithValue("@7", email.Text);
                    cmd.Parameters.AddWithValue("@8", address.Text);
                    cmd.Parameters.AddWithValue("@10", nic.Text);
                    cmd.Parameters.AddWithValue("@12", depidcombo.Text);
                    cmd.Parameters.AddWithValue("@13", txtsalary.Text);
                    cmd.Parameters.AddWithValue("@14", jobrolecombo.Text);
                    cmd.Parameters.AddWithValue("@15", regdate.Value.ToString());
                    SqlCommand cmdtwo = new SqlCommand("UPDATE Users SET Username=@2,Password=@3 WHERE EmpId=@4", conn);
                    cmdtwo.Parameters.AddWithValue("@2", usernametxt.Text);
                    cmdtwo.Parameters.AddWithValue("@3", passwrdtxt.Text);
                    cmdtwo.Parameters.AddWithValue("@4", searchemp.Text);
                 

                    int a = cmd.ExecuteNonQuery();
                    int b = cmdtwo.ExecuteNonQuery();
                    if (a > 0 && b > 0)
                    {
                        MessageBox.Show("Employee Information Updated");
                    }
                }
                else
                {

                    MessageBox.Show("One or more fields are empty");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                reset();
            }
        }

        private void SearchUpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            genderCombo.Items.Add("Male");
            genderCombo.Items.Add("Female");
            depidcombo.Items.Add("INV01");
            depidcombo.Items.Add("DEL01");
            depidcombo.Items.Add("SAL01");
            depidcombo.Items.Add("FIN01");
            jobrolecombo.Items.Add("Manager");
            jobrolecombo.Items.Add("Assistant");
            jobrolecombo.Items.Add("Salesman");
            jobrolecombo.Items.Add("Deliveryboy");
        }



        void reset()
        {
            searchemp.Text = "";
            fname.Text = "";
            lname.Text = "";
            genderCombo.SelectedIndex = -1;
            dobdate.Text = "";
            contactnum.Text = "";
            email.Text = "";
            address.Text = "";
            nic.Text = "";
            depidcombo.SelectedIndex = -1;
            txtsalary.Text = "";
            jobrolecombo.SelectedIndex = -1;
            regdate.Text = "";
            usernametxt.Text = "";
            passwrdtxt.Text = "";





        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchemp.Text != "")
                {
                    if (MessageBox.Show("Employee entry will be deleted. Do you want to proceed?", "Delete Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        SqlCommand cmd = new SqlCommand("delete from Employee where EmpId=@a", conn);
                        cmd.Parameters.AddWithValue("@a", searchemp.Text);
                        conn.Open();
                        int a = cmd.ExecuteNonQuery();
                        reset();
                        if (a > 0)
                        {
                            MessageBox.Show("Employee Entry Deleted");

                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please Enter An Employee ID To Delete The Employee Entry");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the employee id");
            }
            finally
            {
                conn.Close();
                reset();
            }

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            string sfname = fname.Text;
            if (Functions.isNumber(sfname))
            {
                errorProvider1.SetError(fname, "can contain only letters");
                deletebtn.Enabled = false;
                updatebtn.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                deletebtn.Enabled = true;
                updatebtn.Enabled = true;



            }
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {
            string lastname = lname.Text;
            if (Functions.isNumber(lastname))
            {
                errorProvider1.SetError(lname, "can contain only letters");
                deletebtn.Enabled = false;
                updatebtn.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                deletebtn.Enabled = true;
                updatebtn.Enabled = true;


            }
        }

        private void contactnum_TextChanged(object sender, EventArgs e)
        {
            string ph = contactnum.Text;
            int no = ph.Length;



            if (no > 10)
            {
                errorProvider1.SetError(contactnum, "can contain only 10 Numbers");
                deletebtn.Enabled = false;
                updatebtn.Enabled = false;

            }


            else if (Functions.isLetter(ph))
            {
                errorProvider1.SetError(contactnum, "can contain only numbers");
                deletebtn.Enabled = false;
                updatebtn.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                deletebtn.Enabled = true;
                updatebtn.Enabled = true;

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

        private void address_TextChanged(object sender, EventArgs e)
        {
            string addrs = address.Text;
            if (Functions.IsAllLettersOrDigits(addrs))
            {
                errorProvider1.Clear();
                deletebtn.Enabled = true;
                updatebtn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(address, "can contain only letters and digits");
                deletebtn.Enabled = false;
                updatebtn.Enabled = false;
            }
        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {
            string sal = txtsalary.Text;

            if (Functions.isLetter(sal))
            {
                errorProvider1.SetError(txtsalary, "can contain only numbers");
                
            }
            else
            {
                errorProvider1.Clear();
                deletebtn.Enabled = true;
                updatebtn.Enabled = true; 

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
                    updatebtn.Enabled = false;
                    deletebtn.Enabled = false;

                }
                else
                {
                    errorProvider1.Clear();
                    updatebtn.Enabled = true;
                    deletebtn.Enabled = true;


                }
            }
            else if (nicone == 10)
            {

                if (!(ni[9].Equals('v') || ni[9].Equals('V')))
                {
                    errorProvider1.SetError(nic, "last character should be V");
                    updatebtn.Enabled = true;
                    deletebtn.Enabled = true;
                    
                }
                else
                {
                    errorProvider1.Clear();
                    updatebtn.Enabled = true;
                    deletebtn.Enabled = true;
                  

                }
            }

            else
                if (Functions.isMaxLength(nicone))
                {
                    errorProvider1.SetError(nic, "can contain only 10 Characters");
                    updatebtn.Enabled = true;
                    deletebtn.Enabled = true;

                }
                else
                {
                    errorProvider1.Clear();
                    updatebtn.Enabled = true;
                    deletebtn.Enabled = true;

                }

        }

    }
}
