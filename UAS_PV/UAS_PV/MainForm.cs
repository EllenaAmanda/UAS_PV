/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/06/2022
 * Time: 15.41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_PV
{
	
	public partial class MainForm : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		
		Koneksi Konn = new Koneksi();
		
		public MainForm()
		{
			InitializeComponent();
			tampil();
			Bersihkan();
			munculKeterangan();
		}
		
		void tampil(){
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TAB_BMR", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TAB_BMR");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TAB_BMR";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception G)
			{
				MessageBox.Show(G.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		string gender;
		double hsl1;
			
		int berat, tinggi, umur;		
		
		void hitung(){
			if (gender == "Perempuan"){
				if(int.TryParse(textBox4.Text,out berat) && int.TryParse(textBox3.Text,out tinggi) && int.TryParse(textBox2.Text,out umur)){
					hsl1 = (655.1 + (9.563*berat) + (1.85*tinggi) - (4.676*umur));
				}
			}
			else {
				if(int.TryParse(textBox4.Text,out berat) && int.TryParse(textBox3.Text,out tinggi) && int.TryParse(textBox2.Text,out umur)){
				hsl1 = (66.47 + (13.75*berat) + (5.003*tinggi) - (6.755*umur));
				}
			}
		}
		
		void munculKeterangan(){
			comboBox1.Items.Add("Sedikit/Tidak berolahraga");
			comboBox1.Items.Add("Olahraga ringan");
			comboBox1.Items.Add("Olahraga sedang (3-5 hari/seminggu)");
			comboBox1.Items.Add("Olahraga sangat aktif (6-7 hari/seminggu)");
			comboBox1.Items.Add("Ekstra Aktif (sangat aktif dan pekerjaan fisik)");
		}
		
		void Bersihkan(){
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			comboBox1.Text = "";
			radioButton1.Checked = false;
			radioButton2.Checked = false;
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			gender = "Laki-laki";
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			gender = "Perempuan";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			hitung();
			if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" ||  textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox4.Text.Trim() == "")
 			{
 				MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
 			}
			else
			{
			 	SqlConnection conn = Konn.GetConn();
			 	try{
			 		cmd = new SqlCommand("INSERT INTO TAB_BMR VALUES('"+textBox1.Text+"','"+gender+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"','"+Convert.ToInt32(hsl1)+"')", conn);
 					conn.Open();
			 		cmd.ExecuteNonQuery();
 					MessageBox.Show("Insert Data Berhasil!");
 					tampil();
 					Bersihkan();  
			 	}
			 	catch(Exception ex){
			 		MessageBox.Show(ex.ToString());
			 	}
			}
			label13.Text = hsl1.ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
	}
}
