using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diten.Test.Phonebook
{
    public partial class infofrm : Form
    {
        //constructor****
        public infofrm()
        {
            InitializeComponent();
        }
        //function--------------------
        //function for show information in table****
        public void show_info()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\work\WindowsFormsApp1\database\contact.accdb");
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from tblcontact";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            info_tbl.DataSource = dt;
            cn.Close();
        }
        //function for insert information in database****
        public void insert_phone()
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\work\WindowsFormsApp1\database\contact.accdb";
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "insert into tblcontact(name,lname,phone) values('" + nametxtbox.Text + "','" + lnametxtbox.Text + "','" + phonetxtbox.Text + "')";
            cmd.ExecuteNonQuery();
            nametxtbox.Text = "";
            lnametxtbox.Text = "";
            phonetxtbox.Text = "";
            cn.Close();
        }
        //function for delete record in table****
        public void delete_info()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\work\WindowsFormsApp1\database\contact.accdb");
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from tblcontact where phone ='" + phonetxtbox.Text +"'";
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //event for save button
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (nametxtbox.Text == "")
            {
                MessageBox.Show("please enter the name.");
                nametxtbox.Focus();
            }
            else if (lnametxtbox.Text == "")
            {
                MessageBox.Show("please enter the last name.");
                lnametxtbox.Focus();
            }
            else if (phonetxtbox.Text == "")
            {
                MessageBox.Show("please enter the phone number.");
                phonetxtbox.Focus();
            }
            else
            {
                try
                {
                    insert_phone();
                }
                catch (Exception h)
                {
                    h.GetBaseException();
                    MessageBox.Show(h.Message, "error!!");
                }
            }
            show_info();
            nametxtbox.Focus();
        }
        //event for show information button
        private void btnshow_Click(object sender, EventArgs e)
        {
            show_info();
        }
        //event exit button
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //event cancel button
        private void btncancel_Click(object sender, EventArgs e)
        {
            nametxtbox.Text = "";
            lnametxtbox.Text = "";
            phonetxtbox.Text = "";
        }
        //this function for move to the next box
        private void nametxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
        //This function is for just entering a number in the phone number box
        private void phonetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>='0') && (e.KeyChar<='9')==false)
            {
                e.Handled = true;
                MessageBox.Show("please enter the number?!","error!!");
            }
        }
        //event delete button
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (phonetxtbox.Text == "")
            {
                MessageBox.Show("please enter the phone number.", "fill the phone number");
            }
            else
            {
                if (MessageBox.Show("do you want to delete this phone number?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delete_info();
                    show_info();
                    nametxtbox.Text = "";
                    lnametxtbox.Text = "";
                    phonetxtbox.Text = "";
                }
            }
        }
    }
}
