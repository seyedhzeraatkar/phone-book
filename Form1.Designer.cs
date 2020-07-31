namespace WindowsFormsApp1
{
    partial class infofrm
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.lnametxtbox = new System.Windows.Forms.TextBox();
            this.phonetxtbox = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.infopanel = new System.Windows.Forms.Panel();
            this.info_tbl = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 17);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(36, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "name:";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(12, 65);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(52, 13);
            this.lbllastname.TabIndex = 1;
            this.lbllastname.Text = "lastname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "phone number:";
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(97, 14);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 20);
            this.nametxtbox.TabIndex = 0;
            this.nametxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametxtbox_KeyDown);
            // 
            // lnametxtbox
            // 
            this.lnametxtbox.Location = new System.Drawing.Point(97, 62);
            this.lnametxtbox.Name = "lnametxtbox";
            this.lnametxtbox.Size = new System.Drawing.Size(100, 20);
            this.lnametxtbox.TabIndex = 1;
            this.lnametxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametxtbox_KeyDown);
            // 
            // phonetxtbox
            // 
            this.phonetxtbox.Location = new System.Drawing.Point(352, 14);
            this.phonetxtbox.Name = "phonetxtbox";
            this.phonetxtbox.Size = new System.Drawing.Size(100, 20);
            this.phonetxtbox.TabIndex = 2;
            this.phonetxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametxtbox_KeyDown);
            this.phonetxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonetxtbox_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(384, 108);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(79, 26);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.btndelete);
            this.infopanel.Controls.Add(this.btncancel);
            this.infopanel.Controls.Add(this.nametxtbox);
            this.infopanel.Controls.Add(this.phonetxtbox);
            this.infopanel.Controls.Add(this.btnsave);
            this.infopanel.Controls.Add(this.label1);
            this.infopanel.Controls.Add(this.lblname);
            this.infopanel.Controls.Add(this.lbllastname);
            this.infopanel.Controls.Add(this.lnametxtbox);
            this.infopanel.Location = new System.Drawing.Point(12, 12);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(485, 145);
            this.infopanel.TabIndex = 0;
            // 
            // info_tbl
            // 
            this.info_tbl.AllowUserToAddRows = false;
            this.info_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_tbl.Location = new System.Drawing.Point(12, 163);
            this.info_tbl.Name = "info_tbl";
            this.info_tbl.ReadOnly = true;
            this.info_tbl.Size = new System.Drawing.Size(485, 251);
            this.info_tbl.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(12, 417);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 26);
            this.btnshow.TabIndex = 7;
            this.btnshow.Text = "show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(12, 467);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 28);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "&exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(15, 110);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(296, 108);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(82, 26);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // infofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 507);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.info_tbl);
            this.Controls.Add(this.infopanel);
            this.Name = "infofrm";
            this.Text = "contact";
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_tbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox lnametxtbox;
        private System.Windows.Forms.TextBox phonetxtbox;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.DataGridView info_tbl;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
    }
}

