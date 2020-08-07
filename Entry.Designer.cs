namespace Diten.Test.Phonebook
{
	partial class Entry
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonNewContact = new System.Windows.Forms.Button();
			this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.tableLayoutPanelName = new System.Windows.Forms.TableLayoutPanel();
			this.lableFirstName = new System.Windows.Forms.Label();
			this.tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelLastName = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.lableLastName = new System.Windows.Forms.Label();
			this.tableLayoutPanelPhoneNumber = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
			this.labelPhoneNumber = new System.Windows.Forms.Label();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tblcontactBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetMain = new Diten.Test.Phonebook.DataSetMain();
			this.tblcontactTableAdapter = new Diten.Test.Phonebook.DataSetMainTableAdapters.tblcontactTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
			this.flowLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelName.SuspendLayout();
			this.tableLayoutPanelHeader.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelLastName.SuspendLayout();
			this.tableLayoutPanelPhoneNumber.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonNewContact
			// 
			this.buttonNewContact.Location = new System.Drawing.Point(489, 3);
			this.buttonNewContact.Name = "buttonNewContact";
			this.buttonNewContact.Size = new System.Drawing.Size(75, 28);
			this.buttonNewContact.TabIndex = 8;
			this.buttonNewContact.Text = "&New";
			this.buttonNewContact.UseVisualStyleBackColor = true;
			this.buttonNewContact.Click += new System.EventHandler(this.buttonNewContact_Click);
			// 
			// dataGridViewContacts
			// 
			this.dataGridViewContacts.AllowUserToAddRows = false;
			this.dataGridViewContacts.AllowUserToDeleteRows = false;
			this.dataGridViewContacts.AllowUserToResizeRows = false;
			this.dataGridViewContacts.AutoGenerateColumns = false;
			this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
			this.dataGridViewContacts.DataSource = this.tblcontactBindingSource;
			this.dataGridViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewContacts.Location = new System.Drawing.Point(3, 73);
			this.dataGridViewContacts.MultiSelect = false;
			this.dataGridViewContacts.Name = "dataGridViewContacts";
			this.dataGridViewContacts.ReadOnly = true;
			this.dataGridViewContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewContacts.Size = new System.Drawing.Size(648, 277);
			this.dataGridViewContacts.TabIndex = 1;
			this.dataGridViewContacts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContacts_RowEnter);
			// 
			// flowLayoutPanelMain
			// 
			this.flowLayoutPanelMain.Controls.Add(this.buttonExit);
			this.flowLayoutPanelMain.Controls.Add(this.buttonNewContact);
			this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelMain.Location = new System.Drawing.Point(3, 356);
			this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
			this.flowLayoutPanelMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanelMain.Size = new System.Drawing.Size(648, 31);
			this.flowLayoutPanelMain.TabIndex = 2;
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(570, 3);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 28);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "&Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSave.Enabled = false;
			this.buttonSave.Location = new System.Drawing.Point(435, 35);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(210, 26);
			this.buttonSave.TabIndex = 11;
			this.buttonSave.Text = "&Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonEdit.Location = new System.Drawing.Point(219, 35);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(210, 26);
			this.buttonEdit.TabIndex = 10;
			this.buttonEdit.Text = "&Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Location = new System.Drawing.Point(3, 35);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(210, 26);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxFirstName.Location = new System.Drawing.Point(103, 3);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.ReadOnly = true;
			this.textBoxFirstName.Size = new System.Drawing.Size(104, 20);
			this.textBoxFirstName.TabIndex = 3;
			// 
			// tableLayoutPanelName
			// 
			this.tableLayoutPanelName.ColumnCount = 2;
			this.tableLayoutPanelName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelName.Controls.Add(this.textBoxFirstName, 0, 0);
			this.tableLayoutPanelName.Controls.Add(this.lableFirstName, 0, 0);
			this.tableLayoutPanelName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelName.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelName.Name = "tableLayoutPanelName";
			this.tableLayoutPanelName.RowCount = 1;
			this.tableLayoutPanelName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelName.Size = new System.Drawing.Size(210, 26);
			this.tableLayoutPanelName.TabIndex = 0;
			// 
			// lableFirstName
			// 
			this.lableFirstName.AutoSize = true;
			this.lableFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lableFirstName.Location = new System.Drawing.Point(3, 0);
			this.lableFirstName.Name = "lableFirstName";
			this.lableFirstName.Size = new System.Drawing.Size(94, 26);
			this.lableFirstName.TabIndex = 2;
			this.lableFirstName.Text = "name:";
			// 
			// tableLayoutPanelHeader
			// 
			this.tableLayoutPanelHeader.ColumnCount = 3;
			this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelHeader.Controls.Add(this.tableLayoutPanelPhoneNumber, 2, 0);
			this.tableLayoutPanelHeader.Controls.Add(this.tableLayoutPanelLastName, 1, 0);
			this.tableLayoutPanelHeader.Controls.Add(this.buttonSave, 2, 1);
			this.tableLayoutPanelHeader.Controls.Add(this.buttonEdit, 1, 1);
			this.tableLayoutPanelHeader.Controls.Add(this.buttonCancel, 0, 1);
			this.tableLayoutPanelHeader.Controls.Add(this.tableLayoutPanelName, 0, 0);
			this.tableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelHeader.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
			this.tableLayoutPanelHeader.RowCount = 2;
			this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelHeader.Size = new System.Drawing.Size(648, 64);
			this.tableLayoutPanelHeader.TabIndex = 0;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Controls.Add(this.dataGridViewContacts, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelHeader, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelMain, 0, 2);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(654, 390);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// tableLayoutPanelLastName
			// 
			this.tableLayoutPanelLastName.ColumnCount = 2;
			this.tableLayoutPanelLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLastName.Controls.Add(this.textBoxLastName, 0, 0);
			this.tableLayoutPanelLastName.Controls.Add(this.lableLastName, 0, 0);
			this.tableLayoutPanelLastName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLastName.Location = new System.Drawing.Point(219, 3);
			this.tableLayoutPanelLastName.Name = "tableLayoutPanelLastName";
			this.tableLayoutPanelLastName.RowCount = 1;
			this.tableLayoutPanelLastName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLastName.Size = new System.Drawing.Size(210, 26);
			this.tableLayoutPanelLastName.TabIndex = 12;
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxLastName.Location = new System.Drawing.Point(103, 3);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.ReadOnly = true;
			this.textBoxLastName.Size = new System.Drawing.Size(104, 20);
			this.textBoxLastName.TabIndex = 3;
			// 
			// lableLastName
			// 
			this.lableLastName.AutoSize = true;
			this.lableLastName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lableLastName.Location = new System.Drawing.Point(3, 0);
			this.lableLastName.Name = "lableLastName";
			this.lableLastName.Size = new System.Drawing.Size(94, 26);
			this.lableLastName.TabIndex = 2;
			this.lableLastName.Text = "lastname:";
			// 
			// tableLayoutPanelPhoneNumber
			// 
			this.tableLayoutPanelPhoneNumber.ColumnCount = 2;
			this.tableLayoutPanelPhoneNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelPhoneNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPhoneNumber.Controls.Add(this.textBoxPhoneNumber, 0, 0);
			this.tableLayoutPanelPhoneNumber.Controls.Add(this.labelPhoneNumber, 0, 0);
			this.tableLayoutPanelPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelPhoneNumber.Location = new System.Drawing.Point(435, 3);
			this.tableLayoutPanelPhoneNumber.Name = "tableLayoutPanelPhoneNumber";
			this.tableLayoutPanelPhoneNumber.RowCount = 1;
			this.tableLayoutPanelPhoneNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPhoneNumber.Size = new System.Drawing.Size(210, 26);
			this.tableLayoutPanelPhoneNumber.TabIndex = 13;
			// 
			// textBoxPhoneNumber
			// 
			this.textBoxPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxPhoneNumber.Location = new System.Drawing.Point(103, 3);
			this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			this.textBoxPhoneNumber.ReadOnly = true;
			this.textBoxPhoneNumber.Size = new System.Drawing.Size(104, 20);
			this.textBoxPhoneNumber.TabIndex = 4;
			// 
			// labelPhoneNumber
			// 
			this.labelPhoneNumber.AutoSize = true;
			this.labelPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPhoneNumber.Location = new System.Drawing.Point(3, 0);
			this.labelPhoneNumber.Name = "labelPhoneNumber";
			this.labelPhoneNumber.Size = new System.Drawing.Size(94, 26);
			this.labelPhoneNumber.TabIndex = 3;
			this.labelPhoneNumber.Text = "phone number:";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "First Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 82;
			// 
			// lnameDataGridViewTextBoxColumn
			// 
			this.lnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
			this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
			this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
			this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneDataGridViewTextBoxColumn.Width = 63;
			// 
			// tblcontactBindingSource
			// 
			this.tblcontactBindingSource.DataMember = "tblcontact";
			this.tblcontactBindingSource.DataSource = this.dataSetMain;
			// 
			// dataSetMain
			// 
			this.dataSetMain.DataSetName = "DataSetMain";
			this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblcontactTableAdapter
			// 
			this.tblcontactTableAdapter.ClearBeforeFill = true;
			// 
			// Entry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "Entry";
			this.Size = new System.Drawing.Size(654, 390);
			this.Load += new System.EventHandler(this.Entry_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
			this.flowLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelName.ResumeLayout(false);
			this.tableLayoutPanelName.PerformLayout();
			this.tableLayoutPanelHeader.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelLastName.ResumeLayout(false);
			this.tableLayoutPanelLastName.PerformLayout();
			this.tableLayoutPanelPhoneNumber.ResumeLayout(false);
			this.tableLayoutPanelPhoneNumber.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonNewContact;
		private System.Windows.Forms.DataGridView dataGridViewContacts;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelName;
		private System.Windows.Forms.Label lableFirstName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeader;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource tblcontactBindingSource;
		private DataSetMain dataSetMain;
		private DataSetMainTableAdapters.tblcontactTableAdapter tblcontactTableAdapter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPhoneNumber;
		private System.Windows.Forms.TextBox textBoxPhoneNumber;
		private System.Windows.Forms.Label labelPhoneNumber;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLastName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Label lableLastName;
	}
}
