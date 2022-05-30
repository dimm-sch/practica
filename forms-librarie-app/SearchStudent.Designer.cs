namespace forms_librarie_app
{
	partial class SearchStudent
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudent));
			this.tbSearchBar = new System.Windows.Forms.TextBox();
			this.btnSearchStudent = new System.Windows.Forms.Button();
			this.dgwSearchResult = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgwSearchResult)).BeginInit();
			this.SuspendLayout();
			// 
			// tbSearchBar
			// 
			this.tbSearchBar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearchBar.Location = new System.Drawing.Point(117, 113);
			this.tbSearchBar.Name = "tbSearchBar";
			this.tbSearchBar.Size = new System.Drawing.Size(459, 30);
			this.tbSearchBar.TabIndex = 0;
			// 
			// btnSearchStudent
			// 
			this.btnSearchStudent.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchStudent.Location = new System.Drawing.Point(582, 113);
			this.btnSearchStudent.Name = "btnSearchStudent";
			this.btnSearchStudent.Size = new System.Drawing.Size(109, 32);
			this.btnSearchStudent.TabIndex = 2;
			this.btnSearchStudent.Text = "Caută";
			this.btnSearchStudent.UseVisualStyleBackColor = true;
			this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
			// 
			// dgwSearchResult
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgwSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwSearchResult.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgwSearchResult.Location = new System.Drawing.Point(117, 185);
			this.dgwSearchResult.Name = "dgwSearchResult";
			this.dgwSearchResult.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgwSearchResult.Size = new System.Drawing.Size(574, 236);
			this.dgwSearchResult.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(255, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(288, 37);
			this.label2.TabIndex = 22;
			this.label2.Text = "Căutare de studenți";
			// 
			// SearchStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgwSearchResult);
			this.Controls.Add(this.btnSearchStudent);
			this.Controls.Add(this.tbSearchBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchStudent";
			this.Text = "Căutare Student";
			((System.ComponentModel.ISupportInitialize)(this.dgwSearchResult)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbSearchBar;
		private System.Windows.Forms.Button btnSearchStudent;
		private System.Windows.Forms.DataGridView dgwSearchResult;
		private System.Windows.Forms.Label label2;
	}
}