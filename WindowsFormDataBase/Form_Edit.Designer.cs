
namespace WindowsFormDataBase
{
    partial class Form_Edit
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
            this.txt_EditedName = new System.Windows.Forms.TextBox();
            this.txt_EditedLastName = new System.Windows.Forms.TextBox();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.num_EditedAge = new System.Windows.Forms.NumericUpDown();
            this.lblBadges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_EditedAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_EditedName
            // 
            this.txt_EditedName.Location = new System.Drawing.Point(128, 42);
            this.txt_EditedName.Name = "txt_EditedName";
            this.txt_EditedName.Size = new System.Drawing.Size(148, 20);
            this.txt_EditedName.TabIndex = 0;
            // 
            // txt_EditedLastName
            // 
            this.txt_EditedLastName.Location = new System.Drawing.Point(128, 98);
            this.txt_EditedLastName.Name = "txt_EditedLastName";
            this.txt_EditedLastName.Size = new System.Drawing.Size(148, 20);
            this.txt_EditedLastName.TabIndex = 1;
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveEdits.Location = new System.Drawing.Point(128, 340);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdits.TabIndex = 3;
            this.btnSaveEdits.Text = "Save Edits";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Click += new System.EventHandler(this.btn_SaveEdits_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(46, 101);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(55, 156);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(26, 13);
            this.lbl_Age.TabIndex = 8;
            this.lbl_Age.Text = "Age";
            // 
            // num_EditedAge
            // 
            this.num_EditedAge.Location = new System.Drawing.Point(128, 156);
            this.num_EditedAge.Name = "num_EditedAge";
            this.num_EditedAge.Size = new System.Drawing.Size(120, 20);
            this.num_EditedAge.TabIndex = 9;
            // 
            // lblBadges
            // 
            this.lblBadges.AutoSize = true;
            this.lblBadges.Location = new System.Drawing.Point(55, 209);
            this.lblBadges.Name = "lblBadges";
            this.lblBadges.Size = new System.Drawing.Size(43, 13);
            this.lblBadges.TabIndex = 10;
            this.lblBadges.Text = "Badges";
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 375);
            this.Controls.Add(this.lblBadges);
            this.Controls.Add(this.num_EditedAge);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSaveEdits);
            this.Controls.Add(this.txt_EditedLastName);
            this.Controls.Add(this.txt_EditedName);
            this.Name = "Form_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.num_EditedAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EditedName;
        private System.Windows.Forms.TextBox txt_EditedLastName;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.NumericUpDown num_EditedAge;
        private System.Windows.Forms.Label lblBadges;
    }
}