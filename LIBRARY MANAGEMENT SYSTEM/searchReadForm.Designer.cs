namespace LIBRARY_MANAGEMENT_SYSTEM
{
    partial class searchReadForm
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
            lb_title = new Label();
            tb_Search = new TextBox();
            label1 = new Label();
            BookTable = new DataGridView();
            btn_Search = new Button();
            btn_DELETE_reade = new Button();
            btn_EDIT_read = new Button();
            ((System.ComponentModel.ISupportInitialize)BookTable).BeginInit();
            SuspendLayout();
            // 
            // lb_title
            // 
            lb_title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_title.BackColor = SystemColors.Info;
            lb_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title.ForeColor = Color.DarkGoldenrod;
            lb_title.Location = new Point(-3, -1);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(741, 59);
            lb_title.TabIndex = 0;
            lb_title.Text = "Search and Find Panel";
            lb_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_Search
            // 
            tb_Search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Search.Location = new Point(71, 71);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(556, 27);
            tb_Search.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookTable
            // 
            BookTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BookTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookTable.Location = new Point(12, 104);
            BookTable.MultiSelect = false;
            BookTable.Name = "BookTable";
            BookTable.RowHeadersVisible = false;
            BookTable.RowHeadersWidth = 51;
            BookTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookTable.Size = new Size(715, 334);
            BookTable.TabIndex = 3;
            // 
            // btn_Search
            // 
            btn_Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Search.Location = new Point(633, 70);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 4;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_DELETE_reade
            // 
            btn_DELETE_reade.Anchor = AnchorStyles.Right;
            btn_DELETE_reade.Location = new Point(633, 444);
            btn_DELETE_reade.Name = "btn_DELETE_reade";
            btn_DELETE_reade.Size = new Size(94, 29);
            btn_DELETE_reade.TabIndex = 5;
            btn_DELETE_reade.Text = "Delete";
            btn_DELETE_reade.UseVisualStyleBackColor = true;
            btn_DELETE_reade.Click += btn_DELETE_reade_Click;
            // 
            // btn_EDIT_read
            // 
            btn_EDIT_read.Anchor = AnchorStyles.Right;
            btn_EDIT_read.Location = new Point(533, 444);
            btn_EDIT_read.Name = "btn_EDIT_read";
            btn_EDIT_read.Size = new Size(94, 29);
            btn_EDIT_read.TabIndex = 6;
            btn_EDIT_read.Text = "Edit";
            btn_EDIT_read.UseVisualStyleBackColor = true;
            btn_EDIT_read.Click += btn_EDIT_read_Click;
            // 
            // searchReadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 515);
            Controls.Add(btn_EDIT_read);
            Controls.Add(btn_DELETE_reade);
            Controls.Add(btn_Search);
            Controls.Add(BookTable);
            Controls.Add(label1);
            Controls.Add(tb_Search);
            Controls.Add(lb_title);
            Name = "searchReadForm";
            Text = "searchReadForm";
            ((System.ComponentModel.ISupportInitialize)BookTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_title;
        private TextBox tb_Search;
        private Label label1;
        private DataGridView BookTable;
        private Button btn_Search;
        private Button btn_DELETE_reade;
        private Button btn_EDIT_read;
    }
}