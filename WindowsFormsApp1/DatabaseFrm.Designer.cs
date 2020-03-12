namespace WindowsFormsApp1
{
    partial class DatabaseFrm
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
            this.TableLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PledgeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableLbl
            // 
            this.TableLbl.AutoSize = true;
            this.TableLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLbl.Location = new System.Drawing.Point(12, 9);
            this.TableLbl.Name = "TableLbl";
            this.TableLbl.Size = new System.Drawing.Size(34, 13);
            this.TableLbl.TabIndex = 1;
            this.TableLbl.Text = "Table";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PledgeID,
            this.Amount,
            this.FirstName,
            this.LastName,
            this.Date,
            this.Email,
            this.MobileNumber});
            this.listView1.Location = new System.Drawing.Point(15, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 376);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PledgeID
            // 
            this.PledgeID.Text = "PledgeID";
            this.PledgeID.Width = 77;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount (£)";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount.Width = 75;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.Width = 82;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 78;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 68;
            // 
            // Email
            // 
            this.Email.Text = "Email Address";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 141;
            // 
            // MobileNumber
            // 
            this.MobileNumber.Text = "Mobile Number";
            this.MobileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MobileNumber.Width = 159;
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Location = new System.Drawing.Point(107, 433);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyBtn.TabIndex = 3;
            this.ModifyBtn.Text = "Modify";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(15, 433);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(199, 433);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // DatabaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 468);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TableLbl);
            this.Name = "DatabaseFrm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.DatabaseFrm_Load);
            this.Shown += new System.EventHandler(this.DatabaseFrm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TableLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PledgeID;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader MobileNumber;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}