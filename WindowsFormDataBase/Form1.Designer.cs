
namespace WindowsFormDataBase
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
            this.lbl_voornaam = new System.Windows.Forms.Label();
            this.lbl_achternaam = new System.Windows.Forms.Label();
            this.lbl_leeftijd = new System.Windows.Forms.Label();
            this.txt_voornaam = new System.Windows.Forms.TextBox();
            this.txt_achternaam = new System.Windows.Forms.TextBox();
            this.num_leeftijd = new System.Windows.Forms.NumericUpDown();
            this.btn_bewerk = new System.Windows.Forms.Button();
            this.cbNaam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_addSection = new System.Windows.Forms.Label();
            this.lbl_Edit_Delete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_newname = new System.Windows.Forms.TextBox();
            this.txt_newlastname = new System.Windows.Forms.TextBox();
            this.num_newage = new System.Windows.Forms.NumericUpDown();
            this.btn_edit_existing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_leeftijd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_newage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_voornaam
            // 
            this.lbl_voornaam.AutoSize = true;
            this.lbl_voornaam.Location = new System.Drawing.Point(36, 51);
            this.lbl_voornaam.Name = "lbl_voornaam";
            this.lbl_voornaam.Size = new System.Drawing.Size(55, 13);
            this.lbl_voornaam.TabIndex = 0;
            this.lbl_voornaam.Text = "Voornaam";
            // 
            // lbl_achternaam
            // 
            this.lbl_achternaam.AutoSize = true;
            this.lbl_achternaam.Location = new System.Drawing.Point(36, 109);
            this.lbl_achternaam.Name = "lbl_achternaam";
            this.lbl_achternaam.Size = new System.Drawing.Size(64, 13);
            this.lbl_achternaam.TabIndex = 1;
            this.lbl_achternaam.Text = "Achternaam";
            // 
            // lbl_leeftijd
            // 
            this.lbl_leeftijd.AutoSize = true;
            this.lbl_leeftijd.Location = new System.Drawing.Point(36, 170);
            this.lbl_leeftijd.Name = "lbl_leeftijd";
            this.lbl_leeftijd.Size = new System.Drawing.Size(41, 13);
            this.lbl_leeftijd.TabIndex = 2;
            this.lbl_leeftijd.Text = "Leeftijd";
            // 
            // txt_voornaam
            // 
            this.txt_voornaam.Location = new System.Drawing.Point(39, 77);
            this.txt_voornaam.Name = "txt_voornaam";
            this.txt_voornaam.Size = new System.Drawing.Size(100, 20);
            this.txt_voornaam.TabIndex = 3;
            // 
            // txt_achternaam
            // 
            this.txt_achternaam.Location = new System.Drawing.Point(39, 135);
            this.txt_achternaam.Name = "txt_achternaam";
            this.txt_achternaam.Size = new System.Drawing.Size(100, 20);
            this.txt_achternaam.TabIndex = 4;
            // 
            // num_leeftijd
            // 
            this.num_leeftijd.Location = new System.Drawing.Point(39, 196);
            this.num_leeftijd.Name = "num_leeftijd";
            this.num_leeftijd.Size = new System.Drawing.Size(120, 20);
            this.num_leeftijd.TabIndex = 5;
            // 
            // btn_bewerk
            // 
            this.btn_bewerk.Location = new System.Drawing.Point(39, 237);
            this.btn_bewerk.Name = "btn_bewerk";
            this.btn_bewerk.Size = new System.Drawing.Size(75, 23);
            this.btn_bewerk.TabIndex = 6;
            this.btn_bewerk.Text = "Toevoegen";
            this.btn_bewerk.UseVisualStyleBackColor = true;
            this.btn_bewerk.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbNaam
            // 
            this.cbNaam.FormattingEnabled = true;
            this.cbNaam.Location = new System.Drawing.Point(293, 90);
            this.cbNaam.Name = "cbNaam";
            this.cbNaam.Size = new System.Drawing.Size(121, 21);
            this.cbNaam.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naam";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(293, 132);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Verwijder";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_verwijder_Click);
            // 
            // lbl_addSection
            // 
            this.lbl_addSection.AutoSize = true;
            this.lbl_addSection.Location = new System.Drawing.Point(36, 26);
            this.lbl_addSection.Name = "lbl_addSection";
            this.lbl_addSection.Size = new System.Drawing.Size(78, 13);
            this.lbl_addSection.TabIndex = 11;
            this.lbl_addSection.Text = "ADD PERSON";
            // 
            // lbl_Edit_Delete
            // 
            this.lbl_Edit_Delete.AutoSize = true;
            this.lbl_Edit_Delete.Location = new System.Drawing.Point(290, 26);
            this.lbl_Edit_Delete.Name = "lbl_Edit_Delete";
            this.lbl_Edit_Delete.Size = new System.Drawing.Size(127, 13);
            this.lbl_Edit_Delete.TabIndex = 12;
            this.lbl_Edit_Delete.Text = "EDIT/DELETE PERSON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Voornaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Achternaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Leeftijd";
            // 
            // txt_newname
            // 
            this.txt_newname.Location = new System.Drawing.Point(293, 210);
            this.txt_newname.Name = "txt_newname";
            this.txt_newname.Size = new System.Drawing.Size(100, 20);
            this.txt_newname.TabIndex = 16;
            // 
            // txt_newlastname
            // 
            this.txt_newlastname.Location = new System.Drawing.Point(406, 210);
            this.txt_newlastname.Name = "txt_newlastname";
            this.txt_newlastname.Size = new System.Drawing.Size(100, 20);
            this.txt_newlastname.TabIndex = 17;
            // 
            // num_newage
            // 
            this.num_newage.Location = new System.Drawing.Point(543, 210);
            this.num_newage.Name = "num_newage";
            this.num_newage.Size = new System.Drawing.Size(120, 20);
            this.num_newage.TabIndex = 18;
            // 
            // btn_edit_existing
            // 
            this.btn_edit_existing.Location = new System.Drawing.Point(293, 249);
            this.btn_edit_existing.Name = "btn_edit_existing";
            this.btn_edit_existing.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_existing.TabIndex = 19;
            this.btn_edit_existing.Text = "Bewerk";
            this.btn_edit_existing.UseVisualStyleBackColor = true;
            this.btn_edit_existing.Click += new System.EventHandler(this.btn_edit_existing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_edit_existing);
            this.Controls.Add(this.num_newage);
            this.Controls.Add(this.txt_newlastname);
            this.Controls.Add(this.txt_newname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Edit_Delete);
            this.Controls.Add(this.lbl_addSection);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNaam);
            this.Controls.Add(this.btn_bewerk);
            this.Controls.Add(this.num_leeftijd);
            this.Controls.Add(this.txt_achternaam);
            this.Controls.Add(this.txt_voornaam);
            this.Controls.Add(this.lbl_leeftijd);
            this.Controls.Add(this.lbl_achternaam);
            this.Controls.Add(this.lbl_voornaam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_leeftijd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_newage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_voornaam;
        private System.Windows.Forms.Label lbl_achternaam;
        private System.Windows.Forms.Label lbl_leeftijd;
        private System.Windows.Forms.TextBox txt_voornaam;
        private System.Windows.Forms.TextBox txt_achternaam;
        private System.Windows.Forms.NumericUpDown num_leeftijd;
        private System.Windows.Forms.Button btn_bewerk;
        private System.Windows.Forms.ComboBox cbNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_addSection;
        private System.Windows.Forms.Label lbl_Edit_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_newname;
        private System.Windows.Forms.TextBox txt_newlastname;
        private System.Windows.Forms.NumericUpDown num_newage;
        private System.Windows.Forms.Button btn_edit_existing;
    }
}

