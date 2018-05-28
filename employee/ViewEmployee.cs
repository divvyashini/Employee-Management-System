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
using Excel = Microsoft.Office.Interop.Excel;



namespace employee
{
    public partial class ViewEmployee : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=OrdersLK;Integrated Security=True");

        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
             try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmpId,FirstName,LastName,Gender,Contact,NIC,Email,DOB,Address,Position,BasicSalary,DateOfRegistered,DeptId FROM Employee ORDER BY DateOfRegistered ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "Employee");
                dataGridView1.DataSource = ds.Tables["Employee"].DefaultView;

                cmd.ExecuteNonQuery();


                conn.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        
        }


        
    }
}
