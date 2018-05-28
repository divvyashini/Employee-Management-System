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
    public partial class directorleaverequestapproval : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=OrdersLK;Integrated Security=True");

        public directorleaverequestapproval()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeLeaves WHERE Status IS NULL", conn);
             

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "EmployeeLeaves");
                dataGridView1.DataSource = ds.Tables["EmployeeLeaves"].DefaultView;

                cmd.ExecuteNonQuery();


                conn.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void directorleaverequestapproval_Load(object sender, EventArgs e)
        {
            decisioncombo.Items.Add("Approved");
            decisioncombo.Items.Add("Rejected");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                string leaverequestid = dataGridView1.Rows[row].Cells[0].Value.ToString();

                conn.Open();
                SqlCommand cmdtwo = new SqlCommand();
                cmdtwo.CommandText = "SELECT EmployeeLeaves.Comment From EmployeeLeaves WHERE ELId ='" + leaverequestid + "'";
                cmdtwo.Connection = conn;
                descriptiontxt.Text = cmdtwo.ExecuteScalar().ToString();

              
            }
            catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (decisioncombo.Text != "")
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    string leaverequestid = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    string comboselect = decisioncombo.SelectedItem.ToString();

                    string updateQuery = "update EmployeeLeaves set status ='" + comboselect + "' where ELId = '" + leaverequestid + "'";
                    Functions.ExecuteQuery(updateQuery);

                    string selectQuery = "select * from EmployeeLeaves";
                    Functions.loadTable(selectQuery, dataGridView1);

                }
                else
                {
                    MessageBox.Show("Please select a decision and update the request");
                }
                   
           }
             catch (Exception ex)
            {
                MessageBox.Show("Invalid details");
            }
               


            }
           
        }
    
}
