using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;

namespace Anugraha_Construction
{
    public partial class ac_app : Form
    {
        public ac_app()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection("Data Source = ASUSVIVOBOOK14P; Initial Catalog = ac; Integrated Security = True; TrustServerCertificate = True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientName = clientname.Text;
            string clientPhone = clientno.Text;
            string location = locationbox.Text;
            string condetails = projectName.Text;
            string prodate = proDate.Text;
            int status = progressButton.Checked ? 0 : 1;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertMainAc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@clientName", clientName);
                cmd.Parameters.AddWithValue("@clientPhone", clientPhone);
                cmd.Parameters.AddWithValue("@con_details", condetails);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@prodate", prodate);

                // Execute the command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully!");

                // Refresh the DataGridView after insertion
                GetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        void GetList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM actable", con); // Change to select all rows from 'mainac'
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                datashow.DataSource = dt; // Set the DataGridView DataSource
                datashow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string clientPhone = clientno.Text; // The phone number to identify the record
            string clientName = clientname.Text;
            string condetails = projectName.Text;
            string location = locationbox.Text;
            int status = progressButton.Checked ? 1 : 0; // Assuming progressButton is a CheckBox
            string prodate = proDate.Text; // Assuming proDate is a DateTimePicker

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE actable SET clientName = @clientName, con_details = @con_details, location = @location, status = @status, prodate = @prodate WHERE clientPhone = @clientPhone", con);

                // Add parameters
                cmd.Parameters.AddWithValue("@clientName", clientName);
                cmd.Parameters.AddWithValue("@con_details", condetails);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@prodate", prodate);
                cmd.Parameters.AddWithValue("@clientPhone", clientPhone);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully!");
                    GetList(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("No record found to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ac_app_Load(object sender, EventArgs e)
        {
            GetList();
            ShowEarliestDeadline();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string clientPhone = searchbox.Text; // Assume this is your search input TextBox
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM actable WHERE clientPhone = @clientPhone", con);
                cmd.Parameters.AddWithValue("@clientPhone", clientPhone);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Populate your form fields with data from dt (the DataTable)
                    // Assuming you have fields like clientname, clientno, etc.
                    DataRow row = dt.Rows[0];
                    clientname.Text = row["clientName"].ToString();
                    clientno.Text = row["clientPhone"].ToString();
                    projectName.Text = row["con_details"].ToString();
                    locationbox.Text = row["location"].ToString();
                    progressButton.Checked = (bool)row["status"];
                    proDate.Text = row["prodate"].ToString(); // Assuming proDate is a DateTimePicker
                }
                else
                {
                    MessageBox.Show("No record found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string clientPhone = clientno.Text; // Assume this is the input for deletion
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM actable WHERE clientPhone = @clientPhone", con);
                cmd.Parameters.AddWithValue("@clientPhone", clientPhone);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully!");
                    GetList(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("No record found to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void ShowEarliestDeadline()
        {
            try
            {
                con.Open();
                // Query to get the project with the earliest deadline
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 clientName, prodate FROM actable ORDER BY prodate ASC", con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Check if data is available
                {
                    string clientName = reader["clientName"].ToString();
                    DateTime deadline = Convert.ToDateTime(reader["prodate"]);

                    // Display notification about the earliest deadline
                    MessageBox.Show($"Earliest Project Deadline:\nClient: {clientName}\nDeadline: {deadline.ToShortDateString()}", "Project Deadline Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If no data is found
                    MessageBox.Show("No projects found.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    

private void readbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
