﻿/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/06/2022
 * Time: 15.41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kalkulator BMR";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(44, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mohon Isi data berikut :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(44, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nama";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(44, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Umur";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(130, 109);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(130, 140);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 20);
			this.textBox2.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(44, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(143, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Jenis Kelamin";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(240, 169);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 8;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Perempuan";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(130, 170);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Laki-laki";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(44, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(143, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Tinggi";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(130, 205);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 20);
			this.textBox3.TabIndex = 11;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(130, 237);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(184, 20);
			this.textBox4.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(44, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(143, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Berat";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(44, 275);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(143, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Tingkat";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(50, 378);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(143, 24);
			this.label9.TabIndex = 16;
			this.label9.Text = "Hasil BMR";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(50, 415);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(304, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "BMR (Basal Metabolic Rate) adalah banyaknya kalori yang ";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(50, 438);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(304, 23);
			this.label11.TabIndex = 18;
			this.label11.Text = "diperlukan oleh tubuh dalam keadaan tidak bergerak.";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(50, 461);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(304, 23);
			this.label12.TabIndex = 19;
			this.label12.Text = "(Kcal/hari)";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(108, 498);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(143, 24);
			this.label13.TabIndex = 20;
			this.label13.Text = "0";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(130, 271);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(184, 21);
			this.comboBox1.TabIndex = 27;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(371, 109);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(378, 241);
			this.dataGridView1.TabIndex = 28;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(44, 327);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 29;
			this.button1.Text = "Hitung";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(143, 327);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 30;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 565);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "UAS_PV";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
