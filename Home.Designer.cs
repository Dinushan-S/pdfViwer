namespace PDF_Viewer
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Upload = new Button();
            dataGridView1 = new DataGridView();
            Batch = new DataGridViewTextBoxColumn();
            Status = new DataGridViewButtonColumn();
            UploadedDateTime = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Upload
            // 
            Upload.Location = new Point(178, 92);
            Upload.Name = "Upload";
            Upload.Size = new Size(148, 23);
            Upload.TabIndex = 0;
            Upload.Text = "Upload Batch File";
            Upload.UseVisualStyleBackColor = true;
            Upload.Click += Upload_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Batch, Status, UploadedDateTime });
            dataGridView1.Location = new Point(178, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 202);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Batch
            // 
            Batch.HeaderText = "Batch";
            Batch.Name = "Batch";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // UploadedDateTime
            // 
            UploadedDateTime.HeaderText = "Uploaded Date & Time";
            UploadedDateTime.Name = "UploadedDateTime";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 48);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Batch No";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(300, 47);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 3;
            button2.Text = "Choose a file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(400, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Search By Batch No";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Upload);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Upload;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Batch;
        private DataGridViewButtonColumn Status;
        private DataGridViewTextBoxColumn UploadedDateTime;
    }
}