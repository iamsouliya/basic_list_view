namespace WindowFormListView
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtLname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colFistname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClassroom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtClassroom = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Location = new System.Drawing.Point(152, 12);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(243, 22);
            this.txtFname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtLname
            // 
            this.txtLname.Enabled = false;
            this.txtLname.Location = new System.Drawing.Point(150, 40);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(244, 22);
            this.txtLname.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(637, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(637, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(637, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(72, 18);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(72, 16);
            this.fnameLabel.TabIndex = 6;
            this.fnameLabel.Text = "First Name";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(72, 46);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(72, 16);
            this.lnameLabel.TabIndex = 7;
            this.lnameLabel.Text = "Last Name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFistname,
            this.colLastname,
            this.colPhone,
            this.colClassroom,
            this.colAddress});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 152);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 286);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colFistname
            // 
            this.colFistname.Text = "First Name";
            this.colFistname.Width = 195;
            // 
            // colLastname
            // 
            this.colLastname.Text = "Last Name";
            this.colLastname.Width = 157;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone";
            this.colPhone.Width = 106;
            // 
            // colClassroom
            // 
            this.colClassroom.Text = "Classroom";
            this.colClassroom.Width = 124;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 255;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(150, 68);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(244, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // txtClassroom
            // 
            this.txtClassroom.Enabled = false;
            this.txtClassroom.Location = new System.Drawing.Point(150, 96);
            this.txtClassroom.Name = "txtClassroom";
            this.txtClassroom.Size = new System.Drawing.Size(244, 22);
            this.txtClassroom.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(150, 124);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Classroom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtClassroom);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colFistname;
        private System.Windows.Forms.ColumnHeader colLastname;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colClassroom;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtClassroom;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

