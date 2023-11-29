using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isAdd;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.ToLower() == "add")
            {
                txtFname.Enabled = true;
                txtLname.Enabled = true;
                txtPhone.Enabled = true;
                txtClassroom.Enabled = true;
                txtAddress.Enabled = true;
                btnAdd.Text = "Save";
                btnEdit.Text = "Cancel";
                btnDelete.Enabled = false;
                txtFname.Text = "";
                txtLname.Text = "";
                txtPhone.Text = "";
                txtClassroom.Text = "";
                txtAddress.Text = "";
                isAdd = true;
            }
            else
            {
                txtFname.Enabled = false;
                txtLname.Enabled = false;
                txtPhone.Enabled = false;
                txtClassroom.Enabled = false;
                txtAddress.Enabled = false;
                btnAdd.Text = "Add";
                btnEdit.Text = "Edit";
                btnDelete.Enabled = true;
                if (isAdd == true)
                {
                    AddItemToListView();
                }
                else
                {
                    EditItemInListView();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFname.Text.Length > 0)
            {
                if (btnEdit.Text.ToLower() == "edit")
                {
                    txtFname.Enabled = true;
                    txtLname.Enabled = true;
                    txtPhone.Enabled = true;
                    txtClassroom.Enabled = true;
                    txtAddress.Enabled = true;
                    btnAdd.Text = "Save";
                    btnEdit.Text = "Cancel";
                    btnDelete.Enabled = false;
                    isAdd = false;
                }
                else
                {
                    txtFname.Enabled = false;
                    txtLname.Enabled = false;
                    txtPhone.Enabled = false;
                    txtClassroom.Enabled = false;
                    txtAddress.Enabled = false;
                    btnAdd.Text = "Add";
                    btnEdit.Text = "Edit";
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please select row to edit");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && MessageBox.Show("Do you want to delete this item?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listView1.SelectedItems[0].Remove();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtFname.Text = listView1.SelectedItems[0].Text;
                txtLname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPhone.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtClassroom.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }
        public void AddItemToListView()
        {
            ListViewItem lv = listView1.Items.Add(txtFname.Text);
            lv.SubItems.Add(txtLname.Text);
            lv.SubItems.Add(txtPhone.Text);
            lv.SubItems.Add(txtClassroom.Text);
            lv.SubItems.Add(txtAddress.Text);
        }
        public void EditItemInListView()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Text = txtFname.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtLname.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtClassroom.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtAddress.Text;
            }
        }
    }
}
