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

		private void dataGridViewContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			textBoxFirstName.Text = GetSelectedContact().FirstName;
			textBoxLastName.Text = GetSelectedContact().LastName;
			textBoxPhoneNumber.Text = GetSelectedContact().PhoneNumber;
		}

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

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.ParentForm.Close();
		}

		private void buttonNewContact_Click(object sender, EventArgs e)
		{
			EditMode = true;
			ClearTextBoxes();

			dataGridViewContacts.SelectedRows[0].Selected = false;
		}
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			EditMode = true;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			EditMode = false;
			dataGridViewContacts.Rows[0].Selected = !EditMode;
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


	}
}
