/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 6/7/2022
 * Time: 1:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Net;


namespace PV2_LAB
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void OpenImgClick(object sender, EventArgs e)
		{
			Ofd.Filter = "JPG | *.jpg; *.jpeg | Bit Map | *.bmp | PNG | *.png";
				if(Ofd.ShowDialog() == DialogResult.OK)
				{
				Gambar.Image = Image.FromFile(Ofd.FileName);
				}
		}
		void SaveImgClick(object sender, EventArgs e)
		{
	
			Sfd.Filter = "JPG | *.jpg; *.jpeg | Bit Map | *.bmp | PNG | *.png";
			if(Sfd.ShowDialog() == DialogResult.OK)
			{
			Gambar.Image.Save(Sfd.FileName);
			}
						
		}
		
		void OpenTextClick(object sender, EventArgs e)
		{
			Ofd.Filter = "File Text|*.txt|html|*.html|css|*.css";
			Ofd.FileName = "";
			if (Ofd.ShowDialog() == DialogResult.OK)
			{
			string filetext = File.ReadAllText(Ofd.FileName);
			txtContent.Text = filetext;
			}
		}
		void SaveTextClick(object sender, EventArgs e)
		{
			Sfd.Filter = "File Text|*.txt|html|*.html|css|*.css";
			Sfd.FileName = "";
			if (Sfd.ShowDialog() == DialogResult.OK)
			{
				string txtVal = txtContent.Text;
				File.WriteAllText(Sfd.FileName,txtVal);
			}
		}
		void BtnasteriskClick(object sender, EventArgs e)
		{
			SystemSounds.Asterisk.Play();
		}
		void BtnbeepClick(object sender, EventArgs e)
		{
			SystemSounds.Beep.Play();
		}
		void BtnexclamationClick(object sender, EventArgs e)
		{
			SystemSounds.Exclamation.Play();
		}
		void BtnhandClick(object sender, EventArgs e)
		{
			SystemSounds.Hand.Play();
		}
		
		
		
		
		
	}
}
