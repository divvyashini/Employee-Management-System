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
    public partial class ViewApprovals : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=OrdersLK;Integrated Security=True");
        public ViewApprovals()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (empidtxt.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ELId,FromDate,ToDate,Comment,LeaveCatergory,EmpId,Status,month,yearofleave FROM EmployeeLeaves WHERE EmpId= @1 ORDER BY FromDate ASC", conn);
                    cmd.Parameters.AddWithValue("@1", empidtxt.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "EmployeeLeaves");
                    dataGridView1.DataSource = ds.Tables["EmployeeLeaves"].DefaultView;

                    cmd.ExecuteNonQuery();


                    conn.Close();
                }

                else
                {
                    MessageBox.Show("Please Enter Your Employee ID To View The Approvals");
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ViewApprovals_Load(object sender, EventArgs e)
        {

        }
    }
}
