using LIBRARY_MANAGEMENT_SYSTEM.Models;
using LIBRARY_MANAGEMENT_SYSTEM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class AddForm : Form
    {
        public Admin_Panel mainForm { get; set; }
        public int bookID;
        public AddForm()
        {
            InitializeComponent();
        }

        public string TextBoxValue
        {
            get { return tb_id.Text; }
            set { tb_id.Text = value; }
        }

        public string LabelText
        {
            get { return id.Text; }
            set { id.Text = value; }
        }

        public int buttonCode { get; set; }

        //Textbox
        public System.Windows.Forms.TextBox GetTextBoxId() => tb_id;
        public System.Windows.Forms.TextBox GetTextBoxIsbn() => tb_isbn;
        public System.Windows.Forms.TextBox GetTextBoxTitle() => tb_title;
        public System.Windows.Forms.TextBox GetTextBoxAuthour() => tb_author;
        public System.Windows.Forms.TextBox GetTextBoxCategory() => tb_category;
        public System.Windows.Forms.TextBox GetTextBoxQuantity() => tb_quantity;
        public System.Windows.Forms.Button GetButton() => btn_enter;
        //Label
        public Label GetLabelId() => id;
        public Label GetLabelIsbn() => isbn;
        public Label GetLabelTitle() => title;
        public Label GetLabelAuthor() => author;
        public Label GetLabelCategory() => category;
        public Label GetLabelQuantity() => quantity;
        public Label GetTitleLabel() => lb_titleBar;

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (buttonCode == 1)
            {
                //formChange
                btn_enter.Text = "Add";
                //Adding new book
                Books bookobj = new Books();
                if (this.tb_isbn.Text != ""
                   && this.tb_title.Text != ""
                   && this.tb_author.Text != ""
                   && this.tb_quantity.Text != ""
                   && this.tb_category.Text != "")
                {
                    bookobj.isbn = this.GetTextBoxIsbn().Text;
                    bookobj.title = this.GetTextBoxTitle().Text;
                    bookobj.author = this.GetTextBoxAuthour().Text;
                    bookobj.category = this.GetTextBoxCategory().Text;
                    bookobj.quantity = int.Parse(this.GetTextBoxQuantity().Text);
                    var repo = new Repositories.BookRepo();
                    repo.CreateBooks(bookobj);
                    MessageBox.Show(bookobj.isbn + "\n" + bookobj.title + " Was added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                 MessageBox.Show("Please Fill All the Required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
                }
                if (bookobj.isbn == null && bookobj.title == null && bookobj.author == null && bookobj.category == null)
                {
                    return;
                }
               
            }
            else if (buttonCode == 2)
            {
                //formChange
                btn_enter.Text = "Update";

                var repo = new BookRepo();
                Books bookObj = new Books();
                if (this.GetTextBoxId().Text!=""
                    && this.GetTextBoxIsbn().Text != ""
                    && this.GetTextBoxTitle().Text != ""
                    && this.GetTextBoxAuthour().Text != ""
                    && this.GetTextBoxQuantity().Text != ""
                    && this.GetTextBoxCategory().Text != "")
                {
                    bookObj.id = int.Parse(this.GetTextBoxId().Text);
                    bookObj.isbn = this.GetTextBoxIsbn().Text;
                    bookObj.title = this.GetTextBoxTitle().Text;
                    bookObj.author = this.GetTextBoxAuthour().Text;
                    bookObj.category = this.GetTextBoxCategory().Text;
                    bookObj.quantity = int.Parse(this.GetTextBoxQuantity().Text);
                }
                else
                {
                    MessageBox.Show("Please Fill All the Required fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (bookObj.isbn == null && bookObj.title == null && bookObj.author == null && bookObj.category == null)
                {
                    return;
                }
                else
                {
                    repo.updateBooks(bookObj);
                    MessageBox.Show("Book ID: " + bookObj.id + " Was Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (buttonCode == 3)
            {
                //formChange
                btn_enter.Text = "Delete";

                var repo = new BookRepo();
                Books bookObj = new Books();
                if (this.GetTextBoxId().Text != "" && this.GetTextBoxIsbn().Text != "")
                {
                    bookObj.id = int.Parse(this.GetTextBoxId().Text);
                    bookObj.isbn = this.GetTextBoxIsbn().Text;
                }
                else
                {
                  MessageBox.Show("Please Fill All the Required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
                }
               
                repo.deleteBooks(bookObj.id);
                MessageBox.Show("Book ID: " + bookObj.id + " Was Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.tb_id.Text = "";
            this.tb_isbn.Text = "";
            this.tb_title.Text = "";
            this.tb_author.Text = "";
            this.tb_quantity.Text = "";
            this.tb_category.Text = "";
        }
    }
}
