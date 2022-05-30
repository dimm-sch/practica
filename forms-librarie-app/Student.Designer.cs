namespace forms_librarie_app
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRequiresHostel = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowStudent = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.gbStudies = new System.Windows.Forms.GroupBox();
            this.rBtnContract = new System.Windows.Forms.RadioButton();
            this.rBtnBudget = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.gbSex.SuspendLayout();
            this.gbStudies.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anul admiterii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data nașterii:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Specialitatea:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Studii:";
            // 
            // cbRequiresHostel
            // 
            this.cbRequiresHostel.AutoSize = true;
            this.cbRequiresHostel.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRequiresHostel.Location = new System.Drawing.Point(286, 111);
            this.cbRequiresHostel.Name = "cbRequiresHostel";
            this.cbRequiresHostel.Size = new System.Drawing.Size(74, 24);
            this.cbRequiresHostel.TabIndex = 11;
            this.cbRequiresHostel.Text = "Cămin";
            this.cbRequiresHostel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Date completate:";
            // 
            // btnShowStudent
            // 
            this.btnShowStudent.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudent.Location = new System.Drawing.Point(264, 322);
            this.btnShowStudent.Name = "btnShowStudent";
            this.btnShowStudent.Size = new System.Drawing.Size(98, 49);
            this.btnShowStudent.TabIndex = 13;
            this.btnShowStudent.Text = "Afișează";
            this.btnShowStudent.UseVisualStyleBackColor = true;
            this.btnShowStudent.Click += new System.EventHandler(this.btnShowStudent_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(412, 169);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(258, 246);
            this.tbResult.TabIndex = 14;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(74, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 27);
            this.tbName.TabIndex = 15;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurname.Location = new System.Drawing.Point(286, 13);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 27);
            this.tbSurname.TabIndex = 16;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(383, 64);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(119, 27);
            this.dtpDate.TabIndex = 17;
            this.dtpDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Items.AddRange(new object[] {
            "Informatica",
            "Contabilitate",
            "Turism",
            "Secretariat"});
            this.cbSpeciality.Location = new System.Drawing.Point(655, 64);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(121, 28);
            this.cbSpeciality.TabIndex = 18;
            this.cbSpeciality.Text = "Informatica";
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(550, 18);
            this.nudYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(120, 27);
            this.nudYear.TabIndex = 19;
            this.nudYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(12, 212);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(98, 49);
            this.btnAddStudent.TabIndex = 20;
            this.btnAddStudent.Text = "Adaugă";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 49);
            this.button2.TabIndex = 21;
            this.button2.Text = "Editează";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 49);
            this.button3.TabIndex = 22;
            this.button3.Text = "Șterge";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 49);
            this.button4.TabIndex = 23;
            this.button4.Text = "Caută";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(690, 322);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 49);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export txt";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rBtnFemale);
            this.gbSex.Controls.Add(this.rBtnMale);
            this.gbSex.Location = new System.Drawing.Point(56, 57);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(213, 39);
            this.gbSex.TabIndex = 25;
            this.gbSex.TabStop = false;
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFemale.Location = new System.Drawing.Point(104, 9);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(85, 24);
            this.rBtnFemale.TabIndex = 7;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Feminin";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMale.Location = new System.Drawing.Point(6, 9);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(92, 24);
            this.rBtnMale.TabIndex = 6;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Masculin";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // gbStudies
            // 
            this.gbStudies.Controls.Add(this.rBtnContract);
            this.gbStudies.Controls.Add(this.rBtnBudget);
            this.gbStudies.Location = new System.Drawing.Point(67, 103);
            this.gbStudies.Name = "gbStudies";
            this.gbStudies.Size = new System.Drawing.Size(202, 39);
            this.gbStudies.TabIndex = 27;
            this.gbStudies.TabStop = false;
            // 
            // rBtnContract
            // 
            this.rBtnContract.AutoSize = true;
            this.rBtnContract.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnContract.Location = new System.Drawing.Point(98, 10);
            this.rBtnContract.Name = "rBtnContract";
            this.rBtnContract.Size = new System.Drawing.Size(90, 24);
            this.rBtnContract.TabIndex = 12;
            this.rBtnContract.TabStop = true;
            this.rBtnContract.Text = "Contract";
            this.rBtnContract.UseVisualStyleBackColor = true;
            // 
            // rBtnBudget
            // 
            this.rBtnBudget.AutoSize = true;
            this.rBtnBudget.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnBudget.Location = new System.Drawing.Point(15, 10);
            this.rBtnBudget.Name = "rBtnBudget";
            this.rBtnBudget.Size = new System.Drawing.Size(68, 24);
            this.rBtnBudget.TabIndex = 11;
            this.rBtnBudget.TabStop = true;
            this.rBtnBudget.Text = "Buget";
            this.rBtnBudget.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbStudies);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.cbSpeciality);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnShowStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbRequiresHostel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student";
            this.Text = "Date despre student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.gbStudies.ResumeLayout(false);
            this.gbStudies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbRequiresHostel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowStudent;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbSpeciality;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.GroupBox gbStudies;
        private System.Windows.Forms.RadioButton rBtnContract;
        private System.Windows.Forms.RadioButton rBtnBudget;
    }
}