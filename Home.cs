using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Viewer
{
    public partial class Home : Form
    {
        // Define a class to hold information for each entry
        public class BatchEntry
        {
            public string BatchNo { get; set; }
            public string FileName { get; set; }
            public string Status { get; set; }
            public DateTime UploadDateTime { get; set; }
        }

        private List<BatchEntry> batchEntries = new List<BatchEntry>();

        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Title = "Open PDF File";
            //dialog.Filter = "PDF Files | *.pdf";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    button2.Text = dialog.FileName;
            //}
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] pdfFilePaths = File.ReadAllLines(openFileDialog.FileName);
                // Skip the first line as it is the header
                for (int i = 1; i < pdfFilePaths.Length; i++)
                {
                    // Remove the quotes around the file path
                    string pdfFilePath = pdfFilePaths[i].Trim('"');
                    string fileName = Path.GetFileName(pdfFilePath);
                    string batchNo = "YourBatchNo"; // Replace with your actual batch number
                    SaveDataToDatabase(batchNo, fileName, pdfFilePath);
                }
            }
        }

        private void SaveDataToDatabase(string batchNo, string fileName, string imagePath)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\selva\Desktop\xsoftsolution\PDF Viewer\Database1.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM BatchTable WHERE BatchNo = @BatchNo", con);
                cmd.Parameters.AddWithValue("@BatchNo", batchNo);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    cmd = new SqlCommand("UPDATE BatchTable SET FileName = @FileName, ImagePath = @ImagePath, ModifiedDateTime = @ModifiedDateTime, ModifiedBy = @ModifiedBy, Status = @Status WHERE BatchNo = @BatchNo", con);
                    cmd.Parameters.AddWithValue("@ModifiedDateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ModifiedBy", "Your Name");
                    cmd.Parameters.AddWithValue("@Status", "Updated");
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO BatchTable (BatchNo, FileName, ImagePath, AddedDateTime, AddedBy, Status) VALUES (@BatchNo, @FileName, @ImagePath, @AddedDateTime, @AddedBy, @Status)", con);
                    cmd.Parameters.AddWithValue("@AddedDateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@AddedBy", "Your Name");
                    cmd.Parameters.AddWithValue("@Status", "New");
                }
                cmd.Parameters.AddWithValue("@BatchNo", batchNo);
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                cmd.ExecuteNonQuery();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Status" column
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex > 0)
            {
                // Get the status value
                string status = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Open corresponding form based on status
                switch (status)
                {
                    case "In Progress":
                        // Open progress form
                        ProgressBatch progressForm = new ProgressBatch();
                        progressForm.ShowDialog();
                        break;
                    case "Completed":
                        // Open completed form
                        CompleteBatch completedForm = new CompleteBatch();
                        completedForm.ShowDialog();
                        break;
                    case "Pending":
                        // Open pending form
                        //PendingForm pendingForm = new PendingForm();
                        //pendingForm.ShowDialog();
                        break;
                    default:
                        break;
                }
            }

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            string batchNo = textBox1.Text;
            string fileName = button2.Text;

            // Check if batch number and file name are provided
            if (string.IsNullOrEmpty(batchNo) || string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please provide Batch Number and select a file.");
                return;
            }

            // Create a new entry
            BatchEntry entry = new BatchEntry()
            {
                BatchNo = batchNo,
                FileName = fileName,
                Status = "In Progress", // Default status
                UploadDateTime = DateTime.Now
            };

            // Add the entry to the list
            batchEntries.Add(entry);

            // Refresh the DataGridView
            RefreshDataGridView();

        }

        private void RefreshDataGridView()
        {
            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Add each entry to the DataGridView
            foreach (var entry in batchEntries)
            {
                dataGridView1.Rows.Add(entry.BatchNo, entry.Status, entry.UploadDateTime);
            }
        }
    }
}
