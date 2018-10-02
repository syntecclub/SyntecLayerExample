using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SyntecLayer;

namespace SyntecLayerClient
{
	public partial class Form1 : Form
	{
		const int MAJOR_VERSION = 1;
		const int MINOR_VERSION = 0;
		const int FIXED_VERSION = 0;

		Poster m_poster;
		Poster m_poster2;
		Layer m_layer;

		public Form1()
		{
			InitializeComponent();
			m_layer = new Layer();
			m_poster = new Poster();
			m_poster2 = new Poster();

			// display version info in title
			this.Text += "_v" + MAJOR_VERSION.ToString() + "." + MINOR_VERSION.ToString() + "." + FIXED_VERSION.ToString();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			if( m_layer.Connect( textBox4.Text ) ) {
				MessageBox.Show( "Connect Success!" );
			}
			else {
				MessageBox.Show( "Connect Fail!" );
			}
		}

		private void button2_Click( object sender, EventArgs e )
		{
			m_poster.BackColor = Color.Red;
		}

		private void button3_Click( object sender, EventArgs e )
		{
			m_poster.Text.Content = "简体中文测试";
		}

		private void button4_Click( object sender, EventArgs e )
		{
			m_poster.Text.Color = Color.Orange;
		}

		private void button5_Click( object sender, EventArgs e )
		{
			m_poster.Size = new Size( 600, 80 );
		}

		private void button6_Click( object sender, EventArgs e )
		{
			m_poster.Location = new Point( 50, 50 );
		}

		private void button7_Click( object sender, EventArgs e )
		{
			m_layer.Remove( m_poster );
		}

		private void button8_Click( object sender, EventArgs e )
		{
			m_layer.RemoveAll();
		}

		private void button10_Click( object sender, EventArgs e )
		{
			m_poster.Text.Content = "我是第一個";
			m_poster.Text.Color = Color.Black;
			m_poster.BackColor = Color.Green;
			m_poster.Size = new Size( 250, 40 );
			m_poster.Location = new Point( 10, 10 );

			m_layer.Add( m_poster );
		}

		private void button11_Click( object sender, EventArgs e )
		{
			m_poster2.Text.Content = "我是第二個, English";
			m_poster2.Text.Color = Color.Blue;
			m_poster2.BackColor = Color.Yellow;
			m_poster2.Size = new Size( 250, 40 );
			m_poster2.Location = new Point( 400, 100 );

			m_layer.Add( m_poster2 );
		}

		private void button9_Click( object sender, EventArgs e )
		{
			m_layer.Remove( m_poster2 );
		}

		private void button12_Click( object sender, EventArgs e )
		{
			m_poster2.BackColor = Color.YellowGreen;
		}

		private void button13_Click( object sender, EventArgs e )
		{
			m_poster2.Text.Content = "第二個字變囉";
		}

		private void button14_Click( object sender, EventArgs e )
		{
			textBox1.Text = m_layer.Size.Width.ToString();
			textBox2.Text = m_layer.Size.Height.ToString();
		}

		private void button15_Click( object sender, EventArgs e )
		{
			if( m_layer.isConnect ) {
				textBox3.Text = "Connected";
			}
			else {
				textBox3.Text = "Disconnected";
			}
		}

		private void button16_Click( object sender, EventArgs e )
		{
			m_layer.Disconnect();
		}

		private void button17_Click( object sender, EventArgs e )
		{
			m_poster2.Text.Color = Color.Pink;
		}

		private void button18_Click( object sender, EventArgs e )
		{
			m_poster2.Size = new Size( 500, 60 );
		}

		private void button19_Click( object sender, EventArgs e )
		{
			m_poster2.Location = new Point( 100, 200 );
		}
	}
}