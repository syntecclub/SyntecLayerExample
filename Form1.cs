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
		Poster m_poster;
		Poster m_poster2;
		Layer m_layer;

		public Form1()
		{
			InitializeComponent();
			m_layer = new Layer();
			m_poster = new Poster();
			m_poster2 = new Poster();
		}

		private void m_BtnConnect_Click( object sender, EventArgs e )
		{
			if( m_layer.Connect( m_tboxIPAddress.Text ) ) {
				MessageBox.Show( "Connect Success!" );
			}
			else {
				MessageBox.Show( "Connect Fail!" );
			}
		}

		private void m_BtnBackColor1_Click( object sender, EventArgs e )
		{
			m_poster.BackColor = Color.Red;
		}

		private void m_BtnText1_Click( object sender, EventArgs e )
		{
			m_poster.Text.Content = "第一個訊息字變多了, 所以字變小了";
		}

		private void m_BtnTextColor1_Click( object sender, EventArgs e )
		{
			m_poster.Text.Color = Color.Orange;
		}

		private void m_BtnSize1_Click( object sender, EventArgs e )
		{
			m_poster.Size = new Size( 600, 80 );
		}

		private void m_BtnLocation1_Click( object sender, EventArgs e )
		{
			m_poster.Location = new Point( 50, 50 );
		}

		private void m_BtnRemove1_Click( object sender, EventArgs e )
		{
			m_layer.Remove( m_poster );
		}

		private void m_BtnRemoveAll_Click( object sender, EventArgs e )
		{
			m_layer.RemoveAll();
		}

		private void m_BtnAdd1_Click( object sender, EventArgs e )
		{
			m_poster.Text.Content = "第一個訊息";
			m_poster.Text.Color = Color.Black;
			m_poster.BackColor = Color.Green;
			m_poster.Size = new Size( 250, 40 );
			m_poster.Location = new Point( 10, 10 );

			m_layer.Add( m_poster );
		}

		private void m_BtnAdd2_Click( object sender, EventArgs e )
		{
			m_poster2.Text.Content = "第二個訊息";
			m_poster2.Text.Color = Color.Blue;
			m_poster2.BackColor = Color.Yellow;
			m_poster2.Size = new Size( 250, 40 );
			m_poster2.Location = new Point( 400, 100 );

			m_layer.Add( m_poster2 );
		}

		private void m_BtnRemove2_Click( object sender, EventArgs e )
		{
			m_layer.Remove( m_poster2 );
		}

		private void m_BtnBackColor2_Click( object sender, EventArgs e )
		{
			m_poster2.BackColor = Color.YellowGreen;
		}

		private void m_BtnText2_Click( object sender, EventArgs e )
		{
			m_poster2.Text.Content = "第二個訊息改變囉";
		}

		private void m_BtnGetSize_Click( object sender, EventArgs e )
		{
			m_tboxWidth.Text = m_layer.Size.Width.ToString();
			m_tboxHeight.Text = m_layer.Size.Height.ToString();
		}

		private void m_BtnGetStatus_Click( object sender, EventArgs e )
		{
			if( m_layer.isConnect ) {
				m_tboxStatus.Text = "Connected";
			}
			else {
				m_tboxStatus.Text = "Disconnected";
			}
		}

		private void m_BtnDisconnect_Click( object sender, EventArgs e )
		{
			m_layer.Disconnect();
		}

		private void m_BtnTextColor2_Click( object sender, EventArgs e )
		{
			m_poster2.Text.Color = Color.Pink;
		}

		private void m_BtnSize2_Click( object sender, EventArgs e )
		{
			m_poster2.Size = new Size( 500, 60 );
		}

		private void m_BtnLocation2_Click( object sender, EventArgs e )
		{
			m_poster2.Location = new Point( 100, 200 );
		}

		private void m_BtnGetLatError_Click( object sender, EventArgs e )
		{
			m_tboxLastError.Text = m_layer.GetLastError().ToString();
		}
	}
}