namespace LIBRARY_MANAGEMENT_SYSTEM
{
    partial class AddForm
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
            lb_titleBar = new Label();
            isbn = new Label();
            title = new Label();
            author = new Label();
            category = new Label();
            quantity = new Label();
            tb_category = new TextBox();
            tb_author = new TextBox();
            tb_title = new TextBox();
            tb_isbn = new TextBox();
            tb_quantity = new TextBox();
            btn_enter = new Button();
            btn_clear = new Button();
            tb_id = new TextBox();
            id = new Label();
            SuspendLayout();
            // 
            // lb_titleBar
            // 
            lb_titleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_titleBar.BackColor = SystemColors.Info;
            lb_titleBar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_titleBar.Location = new Point(-2, 0);
            lb_titleBar.Name = "lb_titleBar";
            lb_titleBar.Size = new Size(794, 61);
            lb_titleBar.TabIndex = 0;
            lb_titleBar.Text = "Adding A new Book";
            lb_titleBar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // isbn
            // 
            isbn.Location = new Point(98, 147);
            isbn.Name = "isbn";
            isbn.Size = new Size(69, 25);
            isbn.TabIndex = 1;
            isbn.Text = "ISBN";
            // 
            // title
            // 
            title.Location = new Point(98, 192);
            title.Name = "title";
            title.Size = new Size(69, 20);
            title.TabIndex = 2;
            title.Text = "Title";
            // 
            // author
            // 
            author.Location = new Point(98, 241);
            author.Name = "author";
            author.Size = new Size(69, 20);
            author.TabIndex = 3;
            author.Text = "Author";
            // 
            // category
            // 
            category.Location = new Point(98, 326);
            category.Name = "category";
            category.Size = new Size(69, 20);
            category.TabIndex = 4;
            category.Text = "Category";
            // 
            // quantity
            // 
            quantity.Location = new Point(98, 282);
            quantity.Name = "quantity";
            quantity.Size = new Size(69, 20);
            quantity.TabIndex = 5;
            quantity.Text = "Quantity";
            // 
            // tb_category
            // 
            tb_category.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_category.Location = new Point(168, 322);
            tb_category.Multiline = true;
            tb_category.Name = "tb_category";
            tb_category.Size = new Size(546, 80);
            tb_category.TabIndex = 6;
            // 
            // tb_author
            // 
            tb_author.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_author.Location = new Point(168, 236);
            tb_author.Name = "tb_author";
            tb_author.Size = new Size(546, 27);
            tb_author.TabIndex = 7;
            // 
            // tb_title
            // 
            tb_title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_title.Location = new Point(168, 190);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(546, 27);
            tb_title.TabIndex = 8;
            // 
            // tb_isbn
            // 
            tb_isbn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_isbn.Location = new Point(168, 146);
            tb_isbn.Name = "tb_isbn";
            tb_isbn.Size = new Size(546, 27);
            tb_isbn.TabIndex = 9;
            // 
            // tb_quantity
            // 
            tb_quantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_quantity.Location = new Point(168, 278);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(546, 27);
            tb_quantity.TabIndex = 10;
            // 
            // btn_enter
            // 
            btn_enter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_enter.Location = new Point(520, 408);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(94, 29);
            btn_enter.TabIndex = 11;
            btn_enter.Text = "Enter";
            btn_enter.UseVisualStyleBackColor = true;
            btn_enter.Click += btn_enter_Click;
            // 
            // btn_clear
            // 
            btn_clear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_clear.Location = new Point(620, 408);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 29);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // tb_id
            // 
            tb_id.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_id.Location = new Point(168, 104);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(546, 27);
            tb_id.TabIndex = 14;
            // 
            // id
            // 
            id.Location = new Point(98, 105);
            id.Name = "id";
            id.Size = new Size(69, 25);
            id.TabIndex = 13;
            id.Text = "ID";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(tb_id);
            Controls.Add(id);
            Controls.Add(btn_clear);
            Controls.Add(btn_enter);
            Controls.Add(tb_quantity);
            Controls.Add(tb_isbn);
            Controls.Add(tb_title);
            Controls.Add(tb_author);
            Controls.Add(tb_category);
            Controls.Add(quantity);
            Controls.Add(category);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(isbn);
            Controls.Add(lb_titleBar);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_titleBar;
        private Label isbn;
        private Label title;
        private Label author;
        private Label category;
        private Label quantity;
        private TextBox tb_category;
        private TextBox tb_author;
        private TextBox tb_title;
        private TextBox tb_isbn;
        private TextBox tb_quantity;
        private Button btn_enter;
        private Button btn_clear;
        private TextBox tb_id;
        private Label id;
    }
}