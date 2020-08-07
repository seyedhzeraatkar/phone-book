using Diten.Test.Phonebook.DataSetMainTableAdapters;
using System;
using System.Windows.Forms;

namespace Diten.Test.Phonebook
{
	/// <summary>
	/// The UserControl for Contacts.
	/// </summary>
	public partial class Entry : UserControl
	{
		private bool editMode;

		/// <summary>
		/// Constructor.
		/// </summary>
		public Entry()
		{
			InitializeComponent();
		}

		#region Events
		private void Entry_Load(object sender, EventArgs e)
		{
			EditMode = false;
			LoadData();
		}
		/// <summary>
		/// this function for relation between this form and datagrid(databse)
		/// </summary>
		private void dataGridViewContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			textBoxFirstName.Text = GetSelectedContact().FirstName;
			textBoxLastName.Text = GetSelectedContact().LastName;
			textBoxPhoneNumber.Text = GetSelectedContact().PhoneNumber;
		}

		 /// <summary>
		 /// This function for save update or insert new record 
		 /// </summary>
		private void buttonSave_Click(object sender, EventArgs e)
		{
			//First search record by phone number.
			var tmp00 = tblcontactTableAdapter.HasItem(GetSelectedContact().PhoneNumber);
			//If found it user can update information.
			if (tmp00.Rows.Count > 0)
			{
				
				tblcontactTableAdapter.UpdateContact(
					GetContact().FirstName,
					GetContact().LastName,
					GetContact().PhoneNumber,
					GetSelectedContact().PhoneNumber);

				MessageBox.Show($@"Contact of [{GetContact().FirstName} {GetContact().LastName}] is updated.",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

			}
			//Otherwise
			else
			{
				//Insert the new record.
				tblcontactTableAdapter.InsertContact(
					GetContact().FirstName,
					GetContact().LastName,
					GetContact().PhoneNumber);
				MessageBox.Show("New Contact Inserted",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}

			EditMode = false;
			dataGridViewContacts.Enabled = !EditMode;
			LoadData();
		}
		/// <summary>
		/// Exit button
		/// </summary>
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.ParentForm.Close();
		}
		/// <summary>
		/// This function for insert new record
		/// <summary>
		private void buttonNewContact_Click(object sender, EventArgs e)
		{
			EditMode = true;
			ClearTextBoxes();
			buttonDelete.Enabled = false;
			dataGridViewContacts.SelectedRows[0].Selected = false;
		}
		/// <summary>
		/// this function for enable form for user
		/// </summary>
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			EditMode = true;
		}
		
		/// This function for disable input form
		 
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			EditMode = false;
			dataGridViewContacts.Rows[0].Selected = !EditMode;
			buttonDelete.Enabled = true;
		}
		#endregion

		#region Additional Items
		/// <summary>
		/// Clear TextBoxes.
		/// </summary>
		public void ClearTextBoxes() => textBoxFirstName.Text = textBoxLastName.Text = textBoxPhoneNumber.Text = string.Empty;
		/// <summary>
		/// Get selected contact from DataGridView.
		/// </summary>
		/// <returns>A tuble of selected contact data.</returns>
		public (string FirstName, string LastName, string PhoneNumber) GetSelectedContact()
		{
			try
			{
				var row = dataGridViewContacts.SelectedRows?[0];
				return (row.Cells[0].Value.ToString(),
				row.Cells[1].Value.ToString(),
				row.Cells[2].Value.ToString());
			}
			catch
			{
				return (string.Empty, string.Empty, string.Empty);
			}
		}
		/// <summary>
		/// Get TextBoxes information.
		/// </summary>
		/// <returns>A tuble of TextBoxes information.</returns>
		public (string FirstName, string LastName, string PhoneNumber) GetContact() =>
			(textBoxFirstName.Text,
					textBoxLastName.Text,
					textBoxPhoneNumber.Text);
		/// <summary>
		/// Loading data from database.
		/// </summary>
		private void LoadData()
		{
			this.tblcontactTableAdapter.Fill(dataSetMain.tblcontact);
		}
		/// <summary>
		/// Change the enable property value of <see cref="TextBox"/>es.
		/// </summary>
		/// <param name="value">The enablity of the <see cref="TextBox"/>es.</param>
		public bool ChangeTextBoxesReadOnly(bool value) => textBoxFirstName.ReadOnly =
			textBoxLastName.ReadOnly =
			textBoxPhoneNumber.ReadOnly =
			value;
		/// <summary>
		/// Switichin to edit mode for the contact.
		/// </summary>
		/// <param name="value">The switing mode value. Editable contact if <see cref="true"/></param>
		public void SwitchToEditMode(bool value)
		{
			ChangeTextBoxesReadOnly(!value);
			ChangeButtonsToEditMode(value);
			buttonEdit.Text = value ? "&Cancel" : "&Edit";
			dataGridViewContacts.Enabled = !value;
			buttonNewContact.Enabled = !value;
			buttonDelete.Enabled = value;
		}
		/// <summary>
		/// Change the enable property value of <see cref="Button"/>s.
		/// </summary>
		/// <param name="value">The enablity of the <see cref="Button"/>s.</param>
		public void ChangeButtonsToEditMode(bool value)
		{
			buttonSave.Enabled = value;
			buttonEdit.Enabled = !value;
			buttonCancel.Enabled = value;
			buttonDelete.Enabled = value;
		}
		/// <summary>
		/// Get Set edit mode of form.
		/// </summary>
		private bool EditMode
		{
			get => editMode;
			set
			{
				editMode = value;
				SwitchToEditMode(value);
			}
		}
		/// <summary>
		/// This function for delete by button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			///Delete record by phone number
			if (MessageBox.Show($"Do you want to Delete record: {GetContact().PhoneNumber} ",
				"question",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				tblcontactTableAdapter.DeleteQuery(
				GetContact().PhoneNumber);
				LoadData();
			}
			EditMode = false;
		}/// <summary>
		 /// Delete the record with the Delete Keyboard button
		 /// </summary>
		 /// <param name="sender"></param>
		 /// <param name="e"></param>

		private void dataGridViewContacts_KeyDown(object sender, KeyEventArgs e)
		{
			var tmp00 = tblcontactTableAdapter.HasItem(GetSelectedContact().PhoneNumber);
			if (tmp00.Rows.Count > 0)
			{
				if (e.KeyCode == Keys.Delete)
				{
					if (MessageBox.Show($"Do you want to Deleterecord name:{GetContact().FirstName} and last name: {GetContact().LastName} ",
					"question",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						tblcontactTableAdapter.DeleteQuery(
						GetSelectedContact().PhoneNumber);
						LoadData();
					}
				}
			}
		}
		#endregion


	}
 }

