using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diten.Test.Phonebook
{
	public partial class Entry : UserControl
	{
		public Entry()
		{
			InitializeComponent();
		}

		private void Entry_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			try
			{
				this.tblcontactTableAdapter.Fill(dataSetMain.tblcontact);
			}
			catch { }
		}

		private void dataGridViewContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
				textBoxFirstName.Text = GetSelectedContact().FirstName;
				textBoxLastName.Text = GetSelectedContact().LastName;
				textBoxPhoneNumber.Text = GetSelectedContact().PhoneNumber;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var tmp00 =tblcontactTableAdapter.HasItem(GetSelectedContact().PhoneNumber);
			if(tmp00.Rows.Count>0)
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

			LoadData();
		}


		public void ClearTextBoxes() =>textBoxFirstName.Text = textBoxLastName.Text = textBoxPhoneNumber.Text = string.Empty;
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

		public (string FirstName, string LastName, string PhoneNumber) GetContact() =>
			(textBoxFirstName.Text,
					textBoxLastName.Text,
					textBoxPhoneNumber.Text);

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.ParentForm.Close();
		}

		private void buttonNewContact_Click(object sender, EventArgs e)
		{
			ClearTextBoxes();
			dataGridViewContacts.SelectedRows[0].Selected = false;
		}
	}
}
