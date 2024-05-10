namespace PDF_Viewer
{
    partial class CompleteBatch
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            imagePath = new DataGridViewTextBoxColumn();
            CIF = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            nid = new DataGridViewTextBoxColumn();
            accountOpeningDate = new DataGridViewTextBoxColumn();
            accountNo = new DataGridViewTextBoxColumn();
            branchCode = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 57);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Batch No";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imagePath, CIF, customerName, nid, accountOpeningDate, accountNo, branchCode });
            dataGridView1.Location = new Point(30, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 237);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // imagePath
            // 
            imagePath.HeaderText = "Image Path";
            imagePath.Name = "imagePath";
            // 
            // CIF
            // 
            CIF.HeaderText = "CIF";
            CIF.Name = "CIF";
            // 
            // customerName
            // 
            customerName.HeaderText = "CustomerName";
            customerName.Name = "customerName";
            // 
            // nid
            // 
            nid.HeaderText = "NID";
            nid.Name = "nid";
            // 
            // accountOpeningDate
            // 
            accountOpeningDate.HeaderText = "Account Opening Date";
            accountOpeningDate.Name = "accountOpeningDate";
            // 
            // accountNo
            // 
            accountNo.HeaderText = "Account No";
            accountNo.Name = "accountNo";
            // 
            // branchCode
            // 
            branchCode.HeaderText = "Branch Code";
            branchCode.Name = "branchCode";
            // 
            // button1
            // 
            button1.Location = new Point(656, 41);
            button1.Name = "button1";
            button1.Size = new Size(118, 31);
            button1.TabIndex = 2;
            button1.Text = "Export Batch File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CompleteBatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CompleteBatch";
            Text = "ProgressBatch";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn imagePath;
        private DataGridViewTextBoxColumn CIF;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn nid;
        private DataGridViewTextBoxColumn accountOpeningDate;
        private DataGridViewTextBoxColumn accountNo;
        private DataGridViewTextBoxColumn branchCode;
        private Button button1;
    }
}