namespace ADO.NET_HomeWork_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBoxName = new TextBox();
            label2 = new Label();
            txtBoxSurname = new TextBox();
            label3 = new Label();
            txtBoxId = new TextBox();
            btnAdd = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.UseWaitCursor = true;
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 15F);
            txtBoxName.Location = new Point(12, 171);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(313, 41);
            txtBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(167, 50);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            label2.UseWaitCursor = true;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Font = new Font("Segoe UI", 15F);
            txtBoxSurname.Location = new Point(12, 288);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(313, 41);
            txtBoxSurname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(54, 50);
            label3.TabIndex = 4;
            label3.Text = "Id";
            label3.UseWaitCursor = true;
            // 
            // txtBoxId
            // 
            txtBoxId.Font = new Font("Segoe UI", 15F);
            txtBoxId.Location = new Point(12, 62);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(313, 41);
            txtBoxId.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 18F);
            btnAdd.Location = new Point(12, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 72);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(184, 357);
            button1.Name = "button1";
            button1.Size = new Size(141, 72);
            button1.TabIndex = 7;
            button1.Text = "Fill";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnFill_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(570, 426);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(963, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxId);
            Controls.Add(label3);
            Controls.Add(txtBoxSurname);
            Controls.Add(label2);
            Controls.Add(txtBoxName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxName;
        private Label label2;
        private TextBox txtBoxSurname;
        private Label label3;
        private TextBox txtBoxId;
        private Button btnAdd;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
