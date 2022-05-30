namespace forms_librarie_app
{
	partial class EditStudent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudent));
			this.nudYear = new System.Windows.Forms.NumericUpDown();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbSpeciality = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.gbStudies = new System.Windows.Forms.GroupBox();
			this.rBtnContract = new System.Windows.Forms.RadioButton();
			this.rBtnBudget = new System.Windows.Forms.RadioButton();
			this.gbSex = new System.Windows.Forms.GroupBox();
			this.rBtnFemale = new System.Windows.Forms.RadioButton();
			this.rBtnMale = new System.Windows.Forms.RadioButton();
			this.inYear = new System.Windows.Forms.NumericUpDown();
			this.inSpecialty = new System.Windows.Forms.ComboBox();
			this.inDate = new System.Windows.Forms.DateTimePicker();
			this.inSurname = new System.Windows.Forms.TextBox();
			this.inName = new System.Windows.Forms.TextBox();
			this.cbRequiresHostel = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnSubmitEditStudent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
			this.gbStudies.SuspendLayout();
			this.gbSex.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inYear)).BeginInit();
			this.SuspendLayout();
			// 
			// nudYear
			// 
			this.nudYear.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudYear.Location = new System.Drawing.Point(521, 54);
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
			this.nudYear.TabIndex = 25;
			this.nudYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			// 
			// tbSurname
			// 
			this.tbSurname.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSurname.Location = new System.Drawing.Point(241, 96);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(100, 27);
			this.tbSurname.TabIndex = 24;
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbName.Location = new System.Drawing.Point(219, 56);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(100, 27);
			this.tbName.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(390, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 20);
			this.label3.TabIndex = 22;
			this.label3.Text = "Anul admiterii";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(157, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 21;
			this.label2.Text = "Prenume:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(157, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nume:";
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
			this.cbSpeciality.Location = new System.Drawing.Point(517, 100);
			this.cbSpeciality.Name = "cbSpeciality";
			this.cbSpeciality.Size = new System.Drawing.Size(121, 28);
			this.cbSpeciality.TabIndex = 27;
			this.cbSpeciality.Text = "Informatica";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(390, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 20);
			this.label6.TabIndex = 26;
			this.label6.Text = "Specialitatea:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(268, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(271, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "Datele studentului dorit spre editare";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(294, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(210, 20);
			this.label5.TabIndex = 29;
			this.label5.Text = "Editați datele dorite mai jos";
			// 
			// gbStudies
			// 
			this.gbStudies.Controls.Add(this.rBtnContract);
			this.gbStudies.Controls.Add(this.rBtnBudget);
			this.gbStudies.Location = new System.Drawing.Point(84, 335);
			this.gbStudies.Name = "gbStudies";
			this.gbStudies.Size = new System.Drawing.Size(202, 39);
			this.gbStudies.TabIndex = 44;
			this.gbStudies.TabStop = false;
			// 
			// rBtnContract
			// 
			this.rBtnContract.AutoSize = true;
			this.rBtnContract.Checked = true;
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
			this.rBtnBudget.Text = "Buget";
			this.rBtnBudget.UseVisualStyleBackColor = true;
			// 
			// gbSex
			// 
			this.gbSex.Controls.Add(this.rBtnFemale);
			this.gbSex.Controls.Add(this.rBtnMale);
			this.gbSex.Location = new System.Drawing.Point(73, 289);
			this.gbSex.Name = "gbSex";
			this.gbSex.Size = new System.Drawing.Size(213, 39);
			this.gbSex.TabIndex = 43;
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
			this.rBtnFemale.Text = "Feminin";
			this.rBtnFemale.UseVisualStyleBackColor = true;
			// 
			// rBtnMale
			// 
			this.rBtnMale.AutoSize = true;
			this.rBtnMale.Checked = true;
			this.rBtnMale.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtnMale.Location = new System.Drawing.Point(6, 9);
			this.rBtnMale.Name = "rBtnMale";
			this.rBtnMale.Size = new System.Drawing.Size(92, 24);
			this.rBtnMale.TabIndex = 6;
			this.rBtnMale.TabStop = true;
			this.rBtnMale.Text = "Masculin";
			this.rBtnMale.UseVisualStyleBackColor = true;
			// 
			// inYear
			// 
			this.inYear.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inYear.Location = new System.Drawing.Point(567, 250);
			this.inYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
			this.inYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.inYear.Name = "inYear";
			this.inYear.Size = new System.Drawing.Size(120, 27);
			this.inYear.TabIndex = 42;
			this.inYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			// 
			// inSpecialty
			// 
			this.inSpecialty.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inSpecialty.FormattingEnabled = true;
			this.inSpecialty.Items.AddRange(new object[] {
            "Informatica",
            "Contabilitate",
            "Turism",
            "Secretariat"});
			this.inSpecialty.Location = new System.Drawing.Point(672, 296);
			this.inSpecialty.Name = "inSpecialty";
			this.inSpecialty.Size = new System.Drawing.Size(121, 28);
			this.inSpecialty.TabIndex = 41;
			this.inSpecialty.Text = "Informatica";
			// 
			// inDate
			// 
			this.inDate.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.inDate.Location = new System.Drawing.Point(400, 296);
			this.inDate.Name = "inDate";
			this.inDate.Size = new System.Drawing.Size(119, 27);
			this.inDate.TabIndex = 40;
			this.inDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// inSurname
			// 
			this.inSurname.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inSurname.Location = new System.Drawing.Point(303, 245);
			this.inSurname.Name = "inSurname";
			this.inSurname.Size = new System.Drawing.Size(100, 27);
			this.inSurname.TabIndex = 39;
			// 
			// inName
			// 
			this.inName.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inName.Location = new System.Drawing.Point(91, 245);
			this.inName.Name = "inName";
			this.inName.Size = new System.Drawing.Size(100, 27);
			this.inName.TabIndex = 38;
			// 
			// cbRequiresHostel
			// 
			this.cbRequiresHostel.AutoSize = true;
			this.cbRequiresHostel.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRequiresHostel.Location = new System.Drawing.Point(303, 343);
			this.cbRequiresHostel.Name = "cbRequiresHostel";
			this.cbRequiresHostel.Size = new System.Drawing.Size(74, 24);
			this.cbRequiresHostel.TabIndex = 37;
			this.cbRequiresHostel.Text = "Cămin";
			this.cbRequiresHostel.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(29, 343);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 20);
			this.label7.TabIndex = 36;
			this.label7.Text = "Studii:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(545, 299);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 20);
			this.label8.TabIndex = 35;
			this.label8.Text = "Specialitatea:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(289, 299);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(105, 20);
			this.label9.TabIndex = 34;
			this.label9.Text = "Data nașterii:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(33, 299);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 20);
			this.label10.TabIndex = 33;
			this.label10.Text = "Sex:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(436, 252);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(114, 20);
			this.label11.TabIndex = 32;
			this.label11.Text = "Anul admiterii";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(219, 252);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 20);
			this.label12.TabIndex = 31;
			this.label12.Text = "Prenume:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(29, 252);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 20);
			this.label13.TabIndex = 30;
			this.label13.Text = "Nume:";
			// 
			// btnSubmitEditStudent
			// 
			this.btnSubmitEditStudent.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitEditStudent.Location = new System.Drawing.Point(517, 358);
			this.btnSubmitEditStudent.Name = "btnSubmitEditStudent";
			this.btnSubmitEditStudent.Size = new System.Drawing.Size(98, 49);
			this.btnSubmitEditStudent.TabIndex = 45;
			this.btnSubmitEditStudent.Text = "Editează";
			this.btnSubmitEditStudent.UseVisualStyleBackColor = true;
			this.btnSubmitEditStudent.Click += new System.EventHandler(this.btnSubmitEditStudent_Click);
			// 
			// EditStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSubmitEditStudent);
			this.Controls.Add(this.gbStudies);
			this.Controls.Add(this.gbSex);
			this.Controls.Add(this.inYear);
			this.Controls.Add(this.inSpecialty);
			this.Controls.Add(this.inDate);
			this.Controls.Add(this.inSurname);
			this.Controls.Add(this.inName);
			this.Controls.Add(this.cbRequiresHostel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbSpeciality);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nudYear);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditStudent";
			this.Text = "Editează Student";
			((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
			this.gbStudies.ResumeLayout(false);
			this.gbStudies.PerformLayout();
			this.gbSex.ResumeLayout(false);
			this.gbSex.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.inYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudYear;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbSpeciality;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox gbStudies;
		private System.Windows.Forms.RadioButton rBtnContract;
		private System.Windows.Forms.RadioButton rBtnBudget;
		private System.Windows.Forms.GroupBox gbSex;
		private System.Windows.Forms.RadioButton rBtnFemale;
		private System.Windows.Forms.RadioButton rBtnMale;
		private System.Windows.Forms.NumericUpDown inYear;
		private System.Windows.Forms.ComboBox inSpecialty;
		private System.Windows.Forms.DateTimePicker inDate;
		private System.Windows.Forms.TextBox inSurname;
		private System.Windows.Forms.TextBox inName;
		private System.Windows.Forms.CheckBox cbRequiresHostel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnSubmitEditStudent;
	}
}