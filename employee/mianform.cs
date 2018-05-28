using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    public partial class mianform : Form
    {
        public mianform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           RegisterEmployee form = new RegisterEmployee();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             ViewEmployee form = new ViewEmployee();
             form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchUpdateDeleteEmployee form = new SearchUpdateDeleteEmployee();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeaveRequest form = new LeaveRequest();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            directorleaverequestapproval form = new directorleaverequestapproval();
            form.Show()
;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Salary form = new Salary();
            form.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewApprovals form = new ViewApprovals();
            form.Show();
        }
    }
}
