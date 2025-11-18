using LIBRARY_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class Admin_Panel : Form
    {
        //public GroupBox Showcase;
        public GroupBox PublicGroupBox => Showcase;

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }

        public Admin_Panel()
        {
            InitializeComponent();
        }
        public void ShowFormInGroupBox(Form formToShow)
        {
            // Clear existing controls
            Showcase.Controls.Clear();

            // Configure the new form
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;

            // Add to groupbox and show
            Showcase.Controls.Add(formToShow);
            formToShow.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create the form you want to show
            AddForm childForm = new AddForm();
            childForm.mainForm = this;
            //formChange
            childForm.GetButton().Text = "Add";
            ShowFormInGroupBox(childForm);
            childForm.GetTextBoxId().Visible = false;
            childForm.GetLabelId().Visible = false;
            Showcase.Text = "ADD";
            childForm.buttonCode = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Create the form you want to show
            AddForm childForm = new AddForm();
            childForm.mainForm = this;
            childForm.GetButton().Text = "Update";
            ShowFormInGroupBox(childForm);
            Showcase.Text = "EDIT";
            childForm.GetTitleLabel().Text = "Edit Panel";
            childForm.buttonCode = 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Create the form you want to show
            AddForm childForm = new AddForm();
            childForm.mainForm = this;
            childForm.GetButton().Text = "Delete";
            ShowFormInGroupBox(childForm);
            childForm.GetTitleLabel().Text = "Delete Panel";
            Showcase.Text = "DELETE";
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
            childForm.buttonCode = 3;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            // Create the form you want to show
            searchReadForm childForm = new searchReadForm();
            childForm.mainForm = this; // ⭐ THIS IS CRITICAL ⭐
            ShowFormInGroupBox(childForm);
        }
    }
}
