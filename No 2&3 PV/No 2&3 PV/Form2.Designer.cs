/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 6/7/2022
 * Time: 1:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV2_LAB
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button saveImg;
		private System.Windows.Forms.Button openImg;
		private System.Windows.Forms.PictureBox Gambar;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.RichTextBox txtContent;
		private System.Windows.Forms.Button SaveText;
		private System.Windows.Forms.Button OpenText;
		private System.Windows.Forms.OpenFileDialog Ofd;
		private System.Windows.Forms.Button btnhand;
		private System.Windows.Forms.Button btnexclamation;
		private System.Windows.Forms.Button btnbeep;
		private System.Windows.Forms.Button btnasterisk;
		private System.Windows.Forms.SaveFileDialog Sfd;
		
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.saveImg = new System.Windows.Forms.Button();
			this.openImg = new System.Windows.Forms.Button();
			this.Gambar = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtContent = new System.Windows.Forms.RichTextBox();
			this.SaveText = new System.Windows.Forms.Button();
			this.OpenText = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnhand = new System.Windows.Forms.Button();
			this.btnexclamation = new System.Windows.Forms.Button();
			this.btnbeep = new System.Windows.Forms.Button();
			this.btnasterisk = new System.Windows.Forms.Button();
			this.Ofd = new System.Windows.Forms.OpenFileDialog();
			this.Sfd = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Gambar)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(347, 273);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.saveImg);
			this.tabPage1.Controls.Add(this.openImg);
			this.tabPage1.Controls.Add(this.Gambar);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(339, 247);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Picture";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// saveImg
			// 
			this.saveImg.Location = new System.Drawing.Point(258, 139);
			this.saveImg.Name = "saveImg";
			this.saveImg.Size = new System.Drawing.Size(75, 23);
			this.saveImg.TabIndex = 2;
			this.saveImg.Text = "Save";
			this.saveImg.UseVisualStyleBackColor = true;
			this.saveImg.Click += new System.EventHandler(this.SaveImgClick);
			// 
			// openImg
			// 
			this.openImg.Location = new System.Drawing.Point(258, 68);
			this.openImg.Name = "openImg";
			this.openImg.Size = new System.Drawing.Size(75, 26);
			this.openImg.TabIndex = 1;
			this.openImg.Text = "Open";
			this.openImg.UseVisualStyleBackColor = true;
			this.openImg.Click += new System.EventHandler(this.OpenImgClick);
			// 
			// Gambar
			// 
			this.Gambar.Location = new System.Drawing.Point(6, 6);
			this.Gambar.Name = "Gambar";
			this.Gambar.Size = new System.Drawing.Size(207, 235);
			this.Gambar.TabIndex = 0;
			this.Gambar.TabStop = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtContent);
			this.tabPage2.Controls.Add(this.SaveText);
			this.tabPage2.Controls.Add(this.OpenText);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(339, 247);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Text File";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(6, 6);
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(221, 235);
			this.txtContent.TabIndex = 2;
			this.txtContent.Text = "";
			// 
			// SaveText
			// 
			this.SaveText.Location = new System.Drawing.Point(233, 114);
			this.SaveText.Name = "SaveText";
			this.SaveText.Size = new System.Drawing.Size(75, 23);
			this.SaveText.TabIndex = 1;
			this.SaveText.Text = "Save";
			this.SaveText.UseVisualStyleBackColor = true;
			this.SaveText.Click += new System.EventHandler(this.SaveTextClick);
			// 
			// OpenText
			// 
			this.OpenText.Location = new System.Drawing.Point(233, 48);
			this.OpenText.Name = "OpenText";
			this.OpenText.Size = new System.Drawing.Size(75, 23);
			this.OpenText.TabIndex = 0;
			this.OpenText.Text = "Open";
			this.OpenText.UseVisualStyleBackColor = true;
			this.OpenText.Click += new System.EventHandler(this.OpenTextClick);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnhand);
			this.tabPage3.Controls.Add(this.btnexclamation);
			this.tabPage3.Controls.Add(this.btnbeep);
			this.tabPage3.Controls.Add(this.btnasterisk);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(339, 247);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "AUDIO";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnhand
			// 
			this.btnhand.Location = new System.Drawing.Point(203, 135);
			this.btnhand.Name = "btnhand";
			this.btnhand.Size = new System.Drawing.Size(75, 23);
			this.btnhand.TabIndex = 3;
			this.btnhand.Text = "Hand";
			this.btnhand.UseVisualStyleBackColor = true;
			this.btnhand.Click += new System.EventHandler(this.BtnhandClick);
			// 
			// btnexclamation
			// 
			this.btnexclamation.Location = new System.Drawing.Point(203, 77);
			this.btnexclamation.Name = "btnexclamation";
			this.btnexclamation.Size = new System.Drawing.Size(75, 23);
			this.btnexclamation.TabIndex = 2;
			this.btnexclamation.Text = "Exclamation";
			this.btnexclamation.UseVisualStyleBackColor = true;
			this.btnexclamation.Click += new System.EventHandler(this.BtnexclamationClick);
			// 
			// btnbeep
			// 
			this.btnbeep.Location = new System.Drawing.Point(44, 135);
			this.btnbeep.Name = "btnbeep";
			this.btnbeep.Size = new System.Drawing.Size(75, 23);
			this.btnbeep.TabIndex = 1;
			this.btnbeep.Text = "Beep";
			this.btnbeep.UseVisualStyleBackColor = true;
			this.btnbeep.Click += new System.EventHandler(this.BtnbeepClick);
			// 
			// btnasterisk
			// 
			this.btnasterisk.Location = new System.Drawing.Point(44, 77);
			this.btnasterisk.Name = "btnasterisk";
			this.btnasterisk.Size = new System.Drawing.Size(75, 23);
			this.btnasterisk.TabIndex = 0;
			this.btnasterisk.Text = "Asterisk";
			this.btnasterisk.UseVisualStyleBackColor = true;
			this.btnasterisk.Click += new System.EventHandler(this.BtnasteriskClick);
			// 
			// Ofd
			// 
			this.Ofd.FileName = "openFileDialog1";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 326);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Gambar)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
