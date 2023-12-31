using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11___COSC_31112
{
    public partial class addNewAcc : Form
    {
        public addNewAcc()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home form2 = new Home();
            form2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewAcc_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                /*try
                {
                    Data
                }
                catch(Exception e1)
                {
                    MessageBox.Show("Error 1 in Acc")
                }*/
            }
        }

        private void subNewAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string accName = txtAccName.Text;
                string accDec = txtAccDesc.Text;
                string accCat = cmbAccCat.SelectedItem.ToString();

                string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlAccaddQuery = "INSERT INTO Account (Account_name,Account_catagory,Expence,Income,Balance) VALUES(@Account_name, @Account_catagory, @Expence, @Income, @Balance)";

                    using (SqlCommand com = new SqlCommand(sqlAccaddQuery, connection))
                    {
                        com.Parameters.AddWithValue("@Account_name", accName);
                        com.Parameters.AddWithValue("@Account_catagory", accCat);
                        com.Parameters.AddWithValue("@Expence", 0);
                        com.Parameters.AddWithValue("@Income", 0);
                        com.Parameters.AddWithValue("@Balance", 0);

                        com.ExecuteNonQuery();

                        MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtAccDesc.Text = string.Empty;
                        txtAccName.Text = string.Empty;
                        cmbAccCat.SelectedItem = null;


                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Fill all before submit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void newSubtaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAddNewSubT form4 = new frmAddNewSubT();
            form4.Show();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            deleteAcc form5 = new deleteAcc();
            form5.Close();
        }

        private void deleteSubtaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6 form6 = new Form6();
            form6.Show();
        }

        private void btnAddNewAcc_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
