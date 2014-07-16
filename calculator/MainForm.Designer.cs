/*
 * Created by SharpDevelop.
 * User: matthias
 * Date: 12-6-2014
 * Time: 20:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculator
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(11, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(409, 102);
			this.textBox1.TabIndex = 0;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(426, 16);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(104, 90);
			this.button7.TabIndex = 7;
			this.button7.Text = "+";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(150, 130);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 120);
			this.button1.TabIndex = 8;
			this.button1.Text = "8";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(150, 256);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 120);
			this.button2.TabIndex = 9;
			this.button2.Text = "5";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(288, 382);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(132, 120);
			this.button3.TabIndex = 10;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(288, 256);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(132, 120);
			this.button8.TabIndex = 11;
			this.button8.Text = "6";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(288, 130);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(132, 120);
			this.button9.TabIndex = 12;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(11, 382);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(132, 120);
			this.button10.TabIndex = 13;
			this.button10.Text = "1";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(12, 256);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(132, 120);
			this.button11.TabIndex = 14;
			this.button11.Text = "4";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(150, 382);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(132, 120);
			this.button12.TabIndex = 15;
			this.button12.Text = "2";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(12, 130);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(132, 120);
			this.button13.TabIndex = 16;
			this.button13.Text = "7";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(426, 415);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(104, 97);
			this.button6.TabIndex = 17;
			this.button6.Text = "=";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(426, 317);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(104, 92);
			this.button14.TabIndex = 18;
			this.button14.Text = "/";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(426, 214);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(104, 97);
			this.button15.TabIndex = 19;
			this.button15.Text = "*";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(426, 112);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(104, 96);
			this.button16.TabIndex = 20;
			this.button16.Text = "-";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(11, 508);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(271, 120);
			this.button4.TabIndex = 21;
			this.button4.Text = "0";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(288, 508);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(132, 120);
			this.button5.TabIndex = 22;
			this.button5.Text = ",";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(426, 518);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(104, 102);
			this.button17.TabIndex = 23;
			this.button17.Text = "c";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 636);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox1);
			this.MaximumSize = new System.Drawing.Size(554, 683);
			this.MinimumSize = new System.Drawing.Size(554, 683);
			this.Name = "MainForm";
			this.Text = "My Calculator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox1;
	}
}
