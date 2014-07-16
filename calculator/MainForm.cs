/*
 * Created by SharpDevelop.
 * User: matthias
 * Date: 12-6-2014
 * Time: 20:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	

	public partial class MainForm : Form
	{
		
		float tmp;
		char operation;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			tmp = float.Parse(textBox1.Text);
			operation = '+';
			textBox1.Text = "";
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text += "0"; 
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Text += ",";
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if(operation == '+')
			{
				float tmp2;
				tmp2 = tmp + float.Parse(textBox1.Text);
				tmp = float.Parse(textBox1.Text);
				textBox1.Text = ""+tmp2; 
			}
			if(operation == '-')
			{
				float tmp2;
				tmp2 = tmp - float.Parse(textBox1.Text);
				tmp = float.Parse(textBox1.Text);
				textBox1.Text = ""+tmp2; 
			}
			if(operation == '*')
			{
				float tmp2;
				tmp2 = tmp * float.Parse(textBox1.Text);
				tmp = float.Parse(textBox1.Text);
				textBox1.Text = ""+tmp2; 
			}
			if(operation == '/')
			{
				float tmp2;
				tmp2 = tmp / float.Parse(textBox1.Text);
				tmp = float.Parse(textBox1.Text);
				textBox1.Text = ""+tmp2; 
			}
			System.Diagnostics.Debug.WriteLine("{0}", textBox1.Text);
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			tmp = 0;
			textBox1.Text = "";
			operation = ' ';
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			tmp = float.Parse(textBox1.Text);
			operation = '-';
			textBox1.Text = "";
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			tmp = float.Parse(textBox1.Text);
			operation = '*';
			textBox1.Text = "";
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			tmp = float.Parse(textBox1.Text);
			operation = '/';
			textBox1.Text = "";
		}
	}
}
