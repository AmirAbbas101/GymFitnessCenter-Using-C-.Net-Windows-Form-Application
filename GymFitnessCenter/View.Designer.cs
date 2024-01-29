namespace GymFitnessCenter
{
    partial class View
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MDGV = new DataGridView();
            searchtb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1012, -2);
            label3.Name = "label3";
            label3.Size = new Size(31, 29);
            label3.TabIndex = 25;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(422, 75);
            label2.Name = "label2";
            label2.Size = new Size(194, 29);
            label2.TabIndex = 24;
            label2.Text = "VIEW MEMBERS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(422, 30);
            label1.Name = "label1";
            label1.Size = new Size(236, 29);
            label1.TabIndex = 23;
            label1.Text = "FITNESS CENTER";
            // 
            // MDGV
            // 
            MDGV.AllowUserToAddRows = false;
            MDGV.AllowUserToDeleteRows = false;
            MDGV.AllowUserToResizeColumns = false;
            MDGV.AllowUserToResizeRows = false;
            MDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MDGV.DefaultCellStyle = dataGridViewCellStyle2;
            MDGV.GridColor = Color.Blue;
            MDGV.Location = new Point(131, 178);
            MDGV.Margin = new Padding(3, 2, 3, 2);
            MDGV.Name = "MDGV";
            MDGV.ReadOnly = true;
            MDGV.RowHeadersWidth = 51;
            MDGV.RowTemplate.DividerHeight = 2;
            MDGV.RowTemplate.Height = 29;
            MDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MDGV.Size = new Size(814, 290);
            MDGV.TabIndex = 39;
            MDGV.CellContentClick += MDGV_CellContentClick;
            // 
            // searchtb
            // 
            searchtb.BackColor = Color.AliceBlue;
            searchtb.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            searchtb.ForeColor = Color.Crimson;
            searchtb.Location = new Point(413, 146);
            searchtb.Margin = new Padding(3, 2, 3, 2);
            searchtb.Name = "searchtb";
            searchtb.PlaceholderText = "Enter Name";
            searchtb.Size = new Size(146, 24);
            searchtb.TabIndex = 40;
            searchtb.TextChanged += searchtb_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(577, 137);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(80, 33);
            button1.TabIndex = 41;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(686, 137);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 33);
            button2.TabIndex = 42;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(472, 472);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 43;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 30);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1046, 518);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchtb);
            Controls.Add(MDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)MDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView MDGV;
        private TextBox searchtb;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}