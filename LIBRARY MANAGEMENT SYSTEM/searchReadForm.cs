using LIBRARY_MANAGEMENT_SYSTEM.Models;
using LIBRARY_MANAGEMENT_SYSTEM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class searchReadForm : Form
    {
        public Admin_Panel mainForm { get; set; }
        public searchReadForm()
        {
            InitializeComponent();
            readBooks();
        }

        private void readBooks()
        {
            DataTable dT = new DataTable();
            dT.Columns.Add("ID");
            dT.Columns.Add("ISBN");
            dT.Columns.Add("TITLE");
            dT.Columns.Add("AUTHOR");
            dT.Columns.Add("CATEGORY");
            dT.Columns.Add("QUANTITY");

            var repo = new BookRepo();
            var books = repo.GetBooks();
            foreach (var book in books)
            {
                var Row = dT.NewRow();
                Row["ID"] = book.id;
                Row["ISBN"] = book.isbn;
                Row["TITLE"] = book.title;
                Row["AUTHOR"] = book.author;
                Row["CATEGORY"] = book.category;
                Row["QUANTITY"] = book.quantity;

                dT.Rows.Add(Row);
            }
            this.BookTable.DataSource = dT;
        }

        private void btn_EDIT_read_Click(object sender, EventArgs e)
        {
            // 1. Get selected book ID
            var val = this.BookTable.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(val))
            {
                return;
            }
            int bookID = int.Parse(val);

            // 2. Get book data from repository
            var repo = new BookRepo();
            var book = repo.GetBooks(bookID);
            if (book == null)
            {
                return;
            }

            // 3. Check if mainForm is available
            if (mainForm == null)
            {
                MessageBox.Show("MainForm reference is missing!", "Error");
                return;
            }

            // 4. Create ONLY ONE AddForm instance
            AddForm childForm = new AddForm();
            childForm.buttonCode = 2;
            childForm.mainForm = mainForm; // Set the mainForm reference
            childForm.buttonCode = 2; // Set edit mode
            childForm.GetTitleLabel().Text = "Edit Panel";
            childForm.GetButton().Text = "Update";

            // 5. Auto-fill the form with book data
            childForm.GetTextBoxId().Text = book.id.ToString();
            childForm.GetTextBoxIsbn().Text = book.isbn.ToString();
            childForm.GetTextBoxTitle().Text = book.title.ToString();
            childForm.GetTextBoxAuthour().Text = book.author.ToString();
            childForm.GetTextBoxQuantity().Text = book.quantity.ToString();
            childForm.GetTextBoxCategory().Text = book.category.ToString();

            // 6. Use mainForm's method to show the form in groupbox
            mainForm.ShowFormInGroupBox(childForm);
        }

        private void btn_DELETE_reade_Click(object sender, EventArgs e)
        {
            // 1. Get selected book ID
            var val = this.BookTable.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(val))
            {
                return;
            }
            int bookID = int.Parse(val);

            // 2. Get book data from repository
            var repo = new BookRepo();
            var book = repo.GetBooks(bookID);
            if (book == null)
            {
                return;
            }

            // 3. Check if mainForm is available
            if (mainForm == null)
            {
                MessageBox.Show("MainForm reference is missing!", "Error");
                return;
            }

            // 4. Create ONLY ONE AddForm instance
            AddForm childForm = new AddForm();
            childForm.mainForm = mainForm; // Set the mainForm reference
            childForm.buttonCode = 3; // Set Delete mode
            childForm.GetTitleLabel().Text = "Delete Panel";
            childForm.GetButton().Text = "Delete";
            // 5. Auto-fill the form with book data
            childForm.GetTextBoxId().Text = book.id.ToString();
            childForm.GetTextBoxIsbn().Text = book.isbn.ToString();

            //label
            childForm.GetLabelQuantity().Visible = false;
            childForm.GetLabelCategory().Visible = false;
            childForm.GetLabelAuthor().Visible = false;
            childForm.GetLabelTitle().Visible = false;
            //textbox
            childForm.GetTextBoxQuantity().Visible = false;
            childForm.GetTextBoxCategory().Visible = false;
            childForm.GetTextBoxAuthour().Visible = false;
            childForm.GetTextBoxTitle().Visible = false;

            // 6. Use mainForm's method to show the form in groupbox
            mainForm.ShowFormInGroupBox(childForm);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // Better null/empty check
            if (!string.IsNullOrWhiteSpace(this.tb_Search.Text))
            {
                try
                {
                    DataTable dT = new DataTable();
                    dT.Columns.Add("ID", typeof(int));
                    dT.Columns.Add("ISBN", typeof(string));
                    dT.Columns.Add("TITLE", typeof(string));
                    dT.Columns.Add("AUTHOR", typeof(string));
                    dT.Columns.Add("CATEGORY", typeof(string));
                    dT.Columns.Add("QUANTITY", typeof(int));

                    var repo = new BookRepo();
                    var books = repo.SearchBooks(this.tb_Search.Text.Trim());

                    // Debug: Check if books are returned
                    if (books.Count>0)
                    {
                        MessageBox.Show($"Found {books.Count} books", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Search Result Found", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }


                        foreach (var book in books)
                        {
                            var Row = dT.NewRow();
                            Row["ID"] = book.id;
                            Row["ISBN"] = book.isbn ?? "N/A";
                            Row["TITLE"] = book.title ?? "N/A";
                            Row["AUTHOR"] = book.author ?? "N/A";
                            Row["CATEGORY"] = book.category ?? "N/A";
                            Row["QUANTITY"] = book.quantity;

                            dT.Rows.Add(Row);
                        }

                    this.BookTable.DataSource = dT;

                    // Refresh the DataGridView
                    this.BookTable.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Search error: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term", "Info");
            }
        }
    }
}
