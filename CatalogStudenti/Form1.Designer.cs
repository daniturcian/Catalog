namespace CatalogStudenti
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
            this.Autentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Adaugare = new System.Windows.Forms.Button();
            this.Stergere = new System.Windows.Forms.Button();
            this.Cautare = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Afiseaza = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.BirthDate = new System.Windows.Forms.TextBox();
            this.YearOfStudying = new System.Windows.Forms.TextBox();
            this.Group = new System.Windows.Forms.TextBox();
            this.NumeCurs = new System.Windows.Forms.TextBox();
            this.Nota = new System.Windows.Forms.TextBox();
            this.NumarCredite = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.datanasteri = new System.Windows.Forms.Label();
            this.anuldestudiu = new System.Windows.Forms.Label();
            this.grupa = new System.Windows.Forms.Label();
            this.materie = new System.Windows.Forms.Label();
            this.notaluata = new System.Windows.Forms.Label();
            this.nrcredite = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.panelUnderline = new System.Windows.Forms.Panel();
            this.AutontificationFailed = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.SaveMdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Autentificare
            // 
            this.Autentificare.Location = new System.Drawing.Point(363, 236);
            this.Autentificare.Name = "Autentificare";
            this.Autentificare.Size = new System.Drawing.Size(75, 23);
            this.Autentificare.TabIndex = 0;
            this.Autentificare.Text = "Autentificare";
            this.Autentificare.UseVisualStyleBackColor = true;
            this.Autentificare.Click += new System.EventHandler(this.Autentificare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalog cu Studenti";
            // 
            // Adaugare
            // 
            this.Adaugare.Location = new System.Drawing.Point(13, 47);
            this.Adaugare.Name = "Adaugare";
            this.Adaugare.Size = new System.Drawing.Size(75, 23);
            this.Adaugare.TabIndex = 2;
            this.Adaugare.Text = "Adaugare";
            this.Adaugare.UseVisualStyleBackColor = true;
            this.Adaugare.Click += new System.EventHandler(this.Adaugare_Click);
            // 
            // Stergere
            // 
            this.Stergere.Location = new System.Drawing.Point(12, 76);
            this.Stergere.Name = "Stergere";
            this.Stergere.Size = new System.Drawing.Size(75, 23);
            this.Stergere.TabIndex = 3;
            this.Stergere.Text = "Stergere";
            this.Stergere.UseVisualStyleBackColor = true;
            this.Stergere.Click += new System.EventHandler(this.Stergere_Click);
            // 
            // Cautare
            // 
            this.Cautare.Location = new System.Drawing.Point(619, 47);
            this.Cautare.Name = "Cautare";
            this.Cautare.Size = new System.Drawing.Size(75, 23);
            this.Cautare.TabIndex = 4;
            this.Cautare.Text = "Cautare";
            this.Cautare.UseVisualStyleBackColor = true;
            this.Cautare.Click += new System.EventHandler(this.Cautare_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(331, 126);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(190, 20);
            this.username.TabIndex = 5;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(331, 175);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(182, 20);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 446);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(402, 50);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(211, 20);
            this.SearchText.TabIndex = 8;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // Afiseaza
            // 
            this.Afiseaza.Location = new System.Drawing.Point(94, 47);
            this.Afiseaza.Name = "Afiseaza";
            this.Afiseaza.Size = new System.Drawing.Size(75, 23);
            this.Afiseaza.TabIndex = 9;
            this.Afiseaza.Text = "Afiseaza";
            this.Afiseaza.UseVisualStyleBackColor = true;
            this.Afiseaza.Click += new System.EventHandler(this.Afiseaza_Click);
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(244, 142);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(267, 20);
            this.StudentName.TabIndex = 10;
            this.StudentName.TextChanged += new System.EventHandler(this.StudentName_TextChanged);
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(244, 182);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(267, 20);
            this.BirthDate.TabIndex = 11;
            this.BirthDate.TextChanged += new System.EventHandler(this.BirthDate_TextChanged);
            this.BirthDate.Leave += new System.EventHandler(this.BirthDate_Leave);
            // 
            // YearOfStudying
            // 
            this.YearOfStudying.Location = new System.Drawing.Point(244, 220);
            this.YearOfStudying.Name = "YearOfStudying";
            this.YearOfStudying.Size = new System.Drawing.Size(267, 20);
            this.YearOfStudying.TabIndex = 12;
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(244, 265);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(267, 20);
            this.Group.TabIndex = 13;
            // 
            // NumeCurs
            // 
            this.NumeCurs.Location = new System.Drawing.Point(244, 312);
            this.NumeCurs.Name = "NumeCurs";
            this.NumeCurs.Size = new System.Drawing.Size(122, 20);
            this.NumeCurs.TabIndex = 14;
            // 
            // Nota
            // 
            this.Nota.Location = new System.Drawing.Point(244, 369);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(122, 20);
            this.Nota.TabIndex = 15;
            // 
            // NumarCredite
            // 
            this.NumarCredite.Location = new System.Drawing.Point(244, 421);
            this.NumarCredite.Name = "NumarCredite";
            this.NumarCredite.Size = new System.Drawing.Size(122, 20);
            this.NumarCredite.TabIndex = 16;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(261, 133);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(55, 13);
            this.username_label.TabIndex = 18;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(263, 181);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 19;
            this.password_label.Text = "Password";
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(143, 142);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(90, 13);
            this.nume.TabIndex = 20;
            this.nume.Text = "Nume si Prenume";
            // 
            // datanasteri
            // 
            this.datanasteri.AutoSize = true;
            this.datanasteri.Location = new System.Drawing.Point(143, 182);
            this.datanasteri.Name = "datanasteri";
            this.datanasteri.Size = new System.Drawing.Size(68, 13);
            this.datanasteri.TabIndex = 21;
            this.datanasteri.Text = "Data Nasterii";
            // 
            // anuldestudiu
            // 
            this.anuldestudiu.AutoSize = true;
            this.anuldestudiu.Location = new System.Drawing.Point(143, 223);
            this.anuldestudiu.Name = "anuldestudiu";
            this.anuldestudiu.Size = new System.Drawing.Size(74, 13);
            this.anuldestudiu.TabIndex = 22;
            this.anuldestudiu.Text = "Anul de studiu";
            // 
            // grupa
            // 
            this.grupa.AutoSize = true;
            this.grupa.Location = new System.Drawing.Point(143, 265);
            this.grupa.Name = "grupa";
            this.grupa.Size = new System.Drawing.Size(36, 13);
            this.grupa.TabIndex = 23;
            this.grupa.Text = "Grupa";
            // 
            // materie
            // 
            this.materie.AutoSize = true;
            this.materie.Location = new System.Drawing.Point(143, 315);
            this.materie.Name = "materie";
            this.materie.Size = new System.Drawing.Size(58, 13);
            this.materie.TabIndex = 24;
            this.materie.Text = "Nume curs";
            // 
            // notaluata
            // 
            this.notaluata.AutoSize = true;
            this.notaluata.Location = new System.Drawing.Point(143, 369);
            this.notaluata.Name = "notaluata";
            this.notaluata.Size = new System.Drawing.Size(30, 13);
            this.notaluata.TabIndex = 25;
            this.notaluata.Text = "Nota";
            // 
            // nrcredite
            // 
            this.nrcredite.AutoSize = true;
            this.nrcredite.Location = new System.Drawing.Point(143, 428);
            this.nrcredite.Name = "nrcredite";
            this.nrcredite.Size = new System.Drawing.Size(74, 13);
            this.nrcredite.TabIndex = 26;
            this.nrcredite.Text = "Numar Credite";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(384, 499);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Salveaza";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 76);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 28;
            this.DeleteBtn.Text = "Stergere";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Location = new System.Drawing.Point(93, 76);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyBtn.TabIndex = 29;
            this.ModifyBtn.Text = "Modifica";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // panelUnderline
            // 
            this.panelUnderline.BackColor = System.Drawing.Color.Chocolate;
            this.panelUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUnderline.Location = new System.Drawing.Point(331, 144);
            this.panelUnderline.Name = "panelUnderline";
            this.panelUnderline.Size = new System.Drawing.Size(190, 2);
            this.panelUnderline.TabIndex = 30;
            // 
            // AutontificationFailed
            // 
            this.AutontificationFailed.Location = new System.Drawing.Point(287, 158);
            this.AutontificationFailed.Name = "AutontificationFailed";
            this.AutontificationFailed.Size = new System.Drawing.Size(224, 20);
            this.AutontificationFailed.TabIndex = 31;
            this.AutontificationFailed.Visible = false;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(446, 385);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 32;
            this.btnAddCourse.Text = "AdaugaCurs";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(549, 294);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(213, 212);
            this.listBoxCourses.TabIndex = 33;
            // 
            // SaveMdf
            // 
            this.SaveMdf.Location = new System.Drawing.Point(363, 499);
            this.SaveMdf.Name = "SaveMdf";
            this.SaveMdf.Size = new System.Drawing.Size(75, 23);
            this.SaveMdf.TabIndex = 34;
            this.SaveMdf.Text = "Salveaza Modificarile";
            this.SaveMdf.UseVisualStyleBackColor = true;
            this.SaveMdf.Click += new System.EventHandler(this.SaveMdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 618);
            this.Controls.Add(this.SaveMdf);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.AutontificationFailed);
            this.Controls.Add(this.panelUnderline);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.nrcredite);
            this.Controls.Add(this.notaluata);
            this.Controls.Add(this.materie);
            this.Controls.Add(this.grupa);
            this.Controls.Add(this.anuldestudiu);
            this.Controls.Add(this.datanasteri);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.NumarCredite);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.NumeCurs);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.YearOfStudying);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.Afiseaza);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Cautare);
            this.Controls.Add(this.Stergere);
            this.Controls.Add(this.Adaugare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Autentificare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Autentificare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adaugare;
        private System.Windows.Forms.Button Stergere;
        private System.Windows.Forms.Button Cautare;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button Afiseaza;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox BirthDate;
        private System.Windows.Forms.TextBox YearOfStudying;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.TextBox NumeCurs;
        private System.Windows.Forms.TextBox Nota;
        private System.Windows.Forms.TextBox NumarCredite;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label datanasteri;
        private System.Windows.Forms.Label anuldestudiu;
        private System.Windows.Forms.Label grupa;
        private System.Windows.Forms.Label materie;
        private System.Windows.Forms.Label notaluata;
        private System.Windows.Forms.Label nrcredite;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Panel panelUnderline;
        private System.Windows.Forms.TextBox AutontificationFailed;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Button SaveMdf;
    }
}

