/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 23/04/2020
 * Time: 7:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AplikasiRekapNilai
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String noinduk,nama,uh,uts,uas,ket,rerata;
		int Nomor,nilaiUH,nilaiUTS,nilaiUAS,rataRata;
		int i,totalSiswa;
		int indexRow;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			dataGridView1.Columns.Add("nomer","Nomer Induk");
			dataGridView1.Columns.Add("nama","Nama");
			dataGridView1.Columns.Add("uh","UH");
			dataGridView1.Columns.Add("uts","UTS");
			dataGridView1.Columns.Add("uas","UAS");
			dataGridView1.Columns.Add("rerata","Rata-rata");
			dataGridView1.Columns.Add("keterangan","Keterangan");
			
			dataGridView1.Columns[0].Width=100;
			dataGridView1.Columns[1].Width=170;
			dataGridView1.Columns[2].Width=50;
			dataGridView1.Columns[3].Width=50;
			dataGridView1.Columns[4].Width=50;
			dataGridView1.Columns[5].Width=60;
			dataGridView1.Columns[6].Width=100;
			
		}
		
		// Membuat prosedur konversi
		void konversi(){
			// hitung rata-rata
			rataRata = (nilaiUH+nilaiUTS+nilaiUAS)/3;
			rerata=rataRata+"";
			if(rataRata<50)
				ket="Sangat kurang";
			else if(rataRata>=50 && rataRata<60)
				ket="Kurang baik sekali";
			else if(rataRata>=60 && rataRata<70)
				ket="Kurang baik";
			else if(rataRata>=70 && rataRata<80)
				ket="Cukup baik";
			else if(rataRata>=80 && rataRata<90)
				ket="Baik";
			else if(rataRata>=90)
				ket="Sangat baik";
		}
		// Button Save
		void ButtonSaveClick(object sender, EventArgs e)
		{
			// membuat inputan dari user
			noinduk = textBoxNoInduk.Text;
			nama = textBoxNama.Text;
			uh = textBoxUH.Text;
			uts = textBoxUTS.Text;
			uas = textBoxUAS.Text;
			
			// konversi nilai String to int
			Nomor=int.Parse(noinduk);
			nilaiUH=int.Parse(uh);
			nilaiUTS=int.Parse(uts);
			nilaiUAS=int.Parse(uas);
			
			// memanggil prosedur konversi
			konversi();
			
			// membuat array
			String[] NO_INDUK = {noinduk};
			String[] NAMA = {nama};
			String[] UH = {uh};
			String[] UTS = {uts};
			String[] UAS = {uas};
			String[] RERATA = {rerata};
			String[] KET = {ket};
			
			// membuat looping untuk menampilkan array di datagridView
			for(i=0; i<NO_INDUK.Length; i++){
				dataGridView1.Rows.Add(new object[] {NO_INDUK[i],NAMA[i],UH[i],UTS[i],UAS[i],RERATA[i],KET[i]});
			}
			
			// menghitung total siswa yang telah di inputkan
			totalSiswa+=i;
			textBoxTotsiswa.Text=totalSiswa+" Siswa";
			
			textBoxNoInduk.Clear();
			textBoxNama.Clear();
			textBoxUH.Clear();
			textBoxUTS.Clear();
			textBoxUAS.Clear();
		}
	
		
		// memilih index row dari datagrid
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			indexRow = e.RowIndex;
			DataGridViewRow row = dataGridView1.Rows[indexRow];
			
			textBoxNoInduk.Text=row.Cells[0].Value.ToString();
			textBoxNama.Text=row.Cells[1].Value.ToString();
			textBoxUH.Text=row.Cells[2].Value.ToString();
			textBoxUTS.Text=row.Cells[3].Value.ToString();
			textBoxUAS.Text=row.Cells[4].Value.ToString();
			buttonSave.Enabled=false;
		}
		
		// Button update
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			DataGridViewRow newrow = dataGridView1.Rows[indexRow];
			newrow.Cells[0].Value=textBoxNoInduk.Text;
			newrow.Cells[1].Value=textBoxNama.Text;
			newrow.Cells[2].Value=textBoxUH.Text;
			newrow.Cells[3].Value=textBoxUTS.Text;
			newrow.Cells[4].Value=textBoxUAS.Text;
			
			// konversi nilai String to int
			Nomor=int.Parse(noinduk);
			nilaiUH=int.Parse(textBoxUH.Text);
			nilaiUTS=int.Parse(textBoxUTS.Text);
			nilaiUAS=int.Parse(textBoxUAS.Text);
			konversi();
			newrow.Cells[5].Value=rerata;
			newrow.Cells[6].Value=ket;
			
			textBoxNoInduk.Clear();
			textBoxNama.Clear();
			textBoxUH.Clear();
			textBoxUTS.Clear();
			textBoxUAS.Clear();
			buttonSave.Enabled=true;
		}
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data siswa ini?","Warning",MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes){
					indexRow=dataGridView1.CurrentCell.RowIndex;
					dataGridView1.Rows.RemoveAt(indexRow);
					totalSiswa-=1;
				    textBoxTotsiswa.Text=totalSiswa+" Siswa";
			}
		}
		
	}
}
