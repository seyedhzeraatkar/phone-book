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
		//this function is constractors
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
		//finish function constractor
		/*
		 * this function for relation between this form and datagrid(databse)
		 */
		private void dataGridViewContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			textBoxFirstName.Text = GetSelectedContact().FirstName;
			textBoxLastName.Text = GetSelectedContact().LastName;
			textBoxPhoneNumber.Text = GetSelectedContact().PhoneNumber;
		}
		/*
		 * this function for save new record
		 */
		private void buttonSave_Click(object sender, EventArgs e)
		{
			var tmp00 = tblcontactTableAdapter.HasItem(GetSelectedContact().PhoneNumber);
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
			else
			{
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
		/*
		 * exit button
		 */
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.ParentForm.Close();
		}
		/*
		 * this function for insert new record
		 */
		private void buttonNewContact_Click(object sender, EventArgs e)
		{
			EditMode = true;
			ClearTextBoxes();
			buttonDelete.Enabled = false;
			dataGridViewContacts.SelectedRows[0].Selected = false;
		}
		/*
		 * this function for enable form text box
		 * that user can update record
		 * and enable button save and cancele
		 */
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			EditMode = true;
			buttonDelete.Enabled = false;
		}
		/*
		 * this function for cancel button
		 * if user click 
		 * then editmood form will disabled
		 * button delete will enabled
		 */
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
			try
			{
				this.tblcontactTableAdapter.Fill(dataSetMain.tblcontact);
			}
			catch { }
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

		#endregion
		/*
		 * this function for delete record by phone number
		 *first search record According to phone number if there was a record 
		 *then this function ask questien from user
		 *if user click yes record removed
		 */
		private void buttonDelete_Click(object sender, EventArgs e)
        {
			var tmp00 = tblcontactTableAdapter.HasItem(GetSelectedContact().PhoneNumber);
			if (tmp00.Rows.Count > 0)
			{
				if(MessageBox.Show($"do you want to delete record : {GetContact().PhoneNumber} ",
					"question",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
				tblcontactTableAdapter.DeleteQuery(
					GetSelectedContact().PhoneNumber);
			}
			LoadData();
		}
    }
}
