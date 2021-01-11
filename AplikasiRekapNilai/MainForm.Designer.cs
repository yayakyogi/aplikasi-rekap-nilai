/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 23/04/2020
 * Time: 7:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AplikasiRekapNilai
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxUAS;
		private System.Windows.Forms.TextBox textBoxUTS;
		private System.Windows.Forms.TextBox textBoxUH;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.TextBox textBoxNoInduk;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxTotsiswa;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBoxUAS = new System.Windows.Forms.TextBox();
			this.textBoxUTS = new System.Windows.Forms.TextBox();
			this.textBoxUH = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxNoInduk = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTotsiswa = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.textBoxUAS);
			this.groupBox1.Controls.Add(this.textBoxUTS);
			this.groupBox1.Controls.Add(this.textBoxUH);
			this.groupBox1.Controls.Add(this.textBoxNama);
			this.groupBox1.Controls.Add(this.textBoxNoInduk);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(22, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 273);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Siswa";
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.LawnGreen;
			this.buttonSave.Location = new System.Drawing.Point(104, 208);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 32);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Text = "SAVE";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// textBoxUAS
			// 
			this.textBoxUAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUAS.Location = new System.Drawing.Point(104, 171);
			this.textBoxUAS.Name = "textBoxUAS";
			this.textBoxUAS.Size = new System.Drawing.Size(136, 21);
			this.textBoxUAS.TabIndex = 9;
			// 
			// textBoxUTS
			// 
			this.textBoxUTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUTS.Location = new System.Drawing.Point(104, 144);
			this.textBoxUTS.Name = "textBoxUTS";
			this.textBoxUTS.Size = new System.Drawing.Size(136, 21);
			this.textBoxUTS.TabIndex = 8;
			// 
			// textBoxUH
			// 
			this.textBoxUH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUH.Location = new System.Drawing.Point(104, 117);
			this.textBoxUH.Name = "textBoxUH";
			this.textBoxUH.Size = new System.Drawing.Size(136, 21);
			this.textBoxUH.TabIndex = 7;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNama.Location = new System.Drawing.Point(104, 64);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(136, 21);
			this.textBoxNama.TabIndex = 6;
			// 
			// textBoxNoInduk
			// 
			this.textBoxNoInduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNoInduk.Location = new System.Drawing.Point(104, 36);
			this.textBoxNoInduk.Name = "textBoxNoInduk";
			this.textBoxNoInduk.Size = new System.Drawing.Size(136, 21);
			this.textBoxNoInduk.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "UAS";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "UTS";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "UH";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama Siswa";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nomer Induk";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(309, 41);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(623, 213);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(309, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "DAFTAR NILAI SISWA";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.BackColor = System.Drawing.Color.Aquamarine;
			this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdate.Location = new System.Drawing.Point(311, 269);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 31);
			this.buttonUpdate.TabIndex = 3;
			this.buttonUpdate.Text = "UPDATE";
			this.buttonUpdate.UseVisualStyleBackColor = false;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.Red;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(399, 269);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 31);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "DELETE";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(607, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 15);
			this.label7.TabIndex = 5;
			this.label7.Text = "TOTAL SISWA";
			// 
			// textBoxTotsiswa
			// 
			this.textBoxTotsiswa.Location = new System.Drawing.Point(734, 269);
			this.textBoxTotsiswa.Name = "textBoxTotsiswa";
			this.textBoxTotsiswa.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotsiswa.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 314);
			this.Controls.Add(this.textBoxTotsiswa);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "AplikasiRekapNilai";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
