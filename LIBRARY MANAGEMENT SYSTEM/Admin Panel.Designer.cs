namespace LIBRARY_MANAGEMENT_SYSTEM
{
    partial class Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            groupBox1 = new GroupBox();
            btn_read = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            label1 = new Label();
            Showcase = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(btn_read);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(-1, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 621);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // btn_read
            // 
            btn_read.BackColor = Color.DarkGoldenrod;
            btn_read.FlatStyle = FlatStyle.Popup;
            btn_read.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_read.ForeColor = SystemColors.Info;
            btn_read.Location = new Point(7, 520);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(169, 62);
            btn_read.TabIndex = 4;
            btn_read.Text = "Explore Book";
            btn_read.UseVisualStyleBackColor = false;
            btn_read.Click += btn_read_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkGoldenrod;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Info;
            btnDelete.Location = new Point(6, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 62);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Book";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkGoldenrod;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.Info;
            btnEdit.Location = new Point(7, 241);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(169, 62);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Book";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGoldenrod;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Info;
            btnAdd.Location = new Point(7, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 62);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New Book";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 3);
            label1.Name = "label1";
            label1.Size = new Size(1003, 63);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Showcase
            // 
            Showcase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Showcase.BackgroundImage = Properties.Resources.carousel__1_;
            Showcase.BackgroundImageLayout = ImageLayout.Stretch;
            Showcase.ForeColor = Color.DarkGoldenrod;
            Showcase.Location = new Point(186, 74);
            Showcase.Name = "Showcase";
            Showcase.Size = new Size(995, 533);
            Showcase.TabIndex = 2;
            Showcase.TabStop = false;
            // 
            // Admin_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 610);
            Controls.Add(Showcase);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Panel";
            Text = "Admin Panel";
            Load += Admin_Panel_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btn_read;
        private Label label1;
        private GroupBox Showcase;
    }
}