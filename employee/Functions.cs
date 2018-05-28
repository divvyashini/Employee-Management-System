using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace employee
{
    class Functions
    {
        public static SqlConnection con = ConnectionManager.GetConnection();
        static Regex ValidEmailRegex = CreateValidEmailRegex();
        public static bool isLetter(String text)
        {
            bool hasLetter = false;
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    hasLetter = true;
                    return hasLetter;
                }
            }
            return hasLetter;
        }

        public static bool isNumber(String text)
        {
            bool hasNumber = false;
            foreach (char number in text)
            {
                if (char.IsDigit(number))
                {
                    hasNumber = true;
                    return hasNumber;
                }
            }
            return hasNumber;
        }

        public static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }


        public static bool isMaxLength(int text)
        {
            bool hasMax = false;

            if (text > 10)
            {
                hasMax = true;
                return hasMax;
            }



            return hasMax;
        }

        public static String getNextID(String col, String table, String prefix)
        {
            int id = 0;
            String query = "select max (substring(" + col + ",4,len(" + col + "))) as id from " + table;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "table");
                DataTable dt = ds.Tables["table"];
                foreach (DataRow dr in dt.Rows)
                {

                    if (dr["id"].ToString() == "")
                        id = 10000;
                    else
                        id = int.Parse(dr["id"].ToString()) + 1;
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return prefix + id;
        }

        public static void ExecuteQuery(String query)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

        }

        public static void loadTable(string query, DataGridView dvg)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
                dvg.DataSource = dt;
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        public static void ComboWithKey(ComboBox combo, string query, string key, string value)
        {
            try
            {
                combo.Items.Clear();
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1, "Table");
                DataTable dt1 = ds1.Tables["Table"];

                foreach (DataRow dr in dt1.Rows)
                {
                    combo.Items.Add(new KeyValuePair<String, String>(dr[key].ToString(), dr[value].ToString()));
                    combo.ValueMember = "Key";
                    combo.DisplayMember = "Value";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

    }
}
