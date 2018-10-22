namespace SyntecLayerClient
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_BtnConnect = new System.Windows.Forms.Button();
			this.m_BtnBackColor1 = new System.Windows.Forms.Button();
			this.m_BtnText1 = new System.Windows.Forms.Button();
			this.m_BtnTextColor1 = new System.Windows.Forms.Button();
			this.m_BtnSize1 = new System.Windows.Forms.Button();
			this.m_BtnLocation1 = new System.Windows.Forms.Button();
			this.m_BtnRemove1 = new System.Windows.Forms.Button();
			this.m_BtnRemoveAll = new System.Windows.Forms.Button();
			this.m_BtnRemove2 = new System.Windows.Forms.Button();
			this.m_BtnAdd1 = new System.Windows.Forms.Button();
			this.m_BtnAdd2 = new System.Windows.Forms.Button();
			this.m_BtnBackColor2 = new System.Windows.Forms.Button();
			this.m_BtnText2 = new System.Windows.Forms.Button();
			this.m_BtnGetSize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.m_tboxWidth = new System.Windows.Forms.TextBox();
			this.m_tboxHeight = new System.Windows.Forms.TextBox();
			this.m_BtnGetStatus = new System.Windows.Forms.Button();
			this.m_tboxStatus = new System.Windows.Forms.TextBox();
			this.m_BtnDisconnect = new System.Windows.Forms.Button();
			this.m_tboxIPAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.m_BtnTextColor2 = new System.Windows.Forms.Button();
			this.m_BtnSize2 = new System.Windows.Forms.Button();
			this.m_BtnLocation2 = new System.Windows.Forms.Button();
			this.m_BtnGetLatError = new System.Windows.Forms.Button();
			this.m_tboxLastError = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_BtnConnect
			// 
			this.m_BtnConnect.Location = new System.Drawing.Point( 236, 26 );
			this.m_BtnConnect.Name = "m_BtnConnect";
			this.m_BtnConnect.Size = new System.Drawing.Size( 107, 23 );
			this.m_BtnConnect.TabIndex = 0;
			this.m_BtnConnect.Text = "Connect";
			this.m_BtnConnect.UseVisualStyleBackColor = true;
			this.m_BtnConnect.Click += new System.EventHandler( this.m_BtnConnect_Click );
			// 
			// m_BtnBackColor1
			// 
			this.m_BtnBackColor1.Location = new System.Drawing.Point( 51, 117 );
			this.m_BtnBackColor1.Name = "m_BtnBackColor1";
			this.m_BtnBackColor1.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnBackColor1.TabIndex = 1;
			this.m_BtnBackColor1.Text = "ChangeBackColor 1";
			this.m_BtnBackColor1.UseVisualStyleBackColor = true;
			this.m_BtnBackColor1.Click += new System.EventHandler( this.m_BtnBackColor1_Click );
			// 
			// m_BtnText1
			// 
			this.m_BtnText1.Location = new System.Drawing.Point( 51, 160 );
			this.m_BtnText1.Name = "m_BtnText1";
			this.m_BtnText1.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnText1.TabIndex = 2;
			this.m_BtnText1.Text = "ChangeText 1";
			this.m_BtnText1.UseVisualStyleBackColor = true;
			this.m_BtnText1.Click += new System.EventHandler( this.m_BtnText1_Click );
			// 
			// m_BtnTextColor1
			// 
			this.m_BtnTextColor1.Location = new System.Drawing.Point( 51, 202 );
			this.m_BtnTextColor1.Name = "m_BtnTextColor1";
			this.m_BtnTextColor1.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnTextColor1.TabIndex = 3;
			this.m_BtnTextColor1.Text = "ChangeTextColor 1";
			this.m_BtnTextColor1.UseVisualStyleBackColor = true;
			this.m_BtnTextColor1.Click += new System.EventHandler( this.m_BtnTextColor1_Click );
			// 
			// m_BtnSize1
			// 
			this.m_BtnSize1.Location = new System.Drawing.Point( 51, 241 );
			this.m_BtnSize1.Name = "m_BtnSize1";
			this.m_BtnSize1.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnSize1.TabIndex = 4;
			this.m_BtnSize1.Text = "ChangeSize 1";
			this.m_BtnSize1.UseVisualStyleBackColor = true;
			this.m_BtnSize1.Click += new System.EventHandler( this.m_BtnSize1_Click );
			// 
			// m_BtnLocation1
			// 
			this.m_BtnLocation1.Location = new System.Drawing.Point( 51, 284 );
			this.m_BtnLocation1.Name = "m_BtnLocation1";
			this.m_BtnLocation1.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnLocation1.TabIndex = 5;
			this.m_BtnLocation1.Text = "ChangeLocation 1";
			this.m_BtnLocation1.UseVisualStyleBackColor = true;
			this.m_BtnLocation1.Click += new System.EventHandler( this.m_BtnLocation1_Click );
			// 
			// m_BtnRemove1
			// 
			this.m_BtnRemove1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ) );
			this.m_BtnRemove1.Location = new System.Drawing.Point( 51, 331 );
			this.m_BtnRemove1.Name = "m_BtnRemove1";
			this.m_BtnRemove1.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnRemove1.TabIndex = 6;
			this.m_BtnRemove1.Text = "Remove 1";
			this.m_BtnRemove1.UseVisualStyleBackColor = false;
			this.m_BtnRemove1.Click += new System.EventHandler( this.m_BtnRemove1_Click );
			// 
			// m_BtnRemoveAll
			// 
			this.m_BtnRemoveAll.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ) );
			this.m_BtnRemoveAll.Location = new System.Drawing.Point( 143, 379 );
			this.m_BtnRemoveAll.Name = "m_BtnRemoveAll";
			this.m_BtnRemoveAll.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnRemoveAll.TabIndex = 7;
			this.m_BtnRemoveAll.Text = "Remove All";
			this.m_BtnRemoveAll.UseVisualStyleBackColor = false;
			this.m_BtnRemoveAll.Click += new System.EventHandler( this.m_BtnRemoveAll_Click );
			// 
			// m_BtnRemove2
			// 
			this.m_BtnRemove2.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ) );
			this.m_BtnRemove2.Location = new System.Drawing.Point( 213, 331 );
			this.m_BtnRemove2.Name = "m_BtnRemove2";
			this.m_BtnRemove2.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnRemove2.TabIndex = 8;
			this.m_BtnRemove2.Text = "Remove 2";
			this.m_BtnRemove2.UseVisualStyleBackColor = false;
			this.m_BtnRemove2.Click += new System.EventHandler( this.m_BtnRemove2_Click );
			// 
			// m_BtnAdd1
			// 
			this.m_BtnAdd1.Location = new System.Drawing.Point( 51, 76 );
			this.m_BtnAdd1.Name = "m_BtnAdd1";
			this.m_BtnAdd1.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnAdd1.TabIndex = 9;
			this.m_BtnAdd1.Text = "Add 1";
			this.m_BtnAdd1.UseVisualStyleBackColor = true;
			this.m_BtnAdd1.Click += new System.EventHandler( this.m_BtnAdd1_Click );
			// 
			// m_BtnAdd2
			// 
			this.m_BtnAdd2.Location = new System.Drawing.Point( 213, 76 );
			this.m_BtnAdd2.Name = "m_BtnAdd2";
			this.m_BtnAdd2.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnAdd2.TabIndex = 10;
			this.m_BtnAdd2.Text = "Add 2";
			this.m_BtnAdd2.UseVisualStyleBackColor = true;
			this.m_BtnAdd2.Click += new System.EventHandler( this.m_BtnAdd2_Click );
			// 
			// m_BtnBackColor2
			// 
			this.m_BtnBackColor2.Location = new System.Drawing.Point( 213, 117 );
			this.m_BtnBackColor2.Name = "m_BtnBackColor2";
			this.m_BtnBackColor2.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnBackColor2.TabIndex = 11;
			this.m_BtnBackColor2.Text = "ChangeBackColor 2";
			this.m_BtnBackColor2.UseVisualStyleBackColor = true;
			this.m_BtnBackColor2.Click += new System.EventHandler( this.m_BtnBackColor2_Click );
			// 
			// m_BtnText2
			// 
			this.m_BtnText2.Location = new System.Drawing.Point( 213, 160 );
			this.m_BtnText2.Name = "m_BtnText2";
			this.m_BtnText2.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnText2.TabIndex = 12;
			this.m_BtnText2.Text = "ChangeText 2";
			this.m_BtnText2.UseVisualStyleBackColor = true;
			this.m_BtnText2.Click += new System.EventHandler( this.m_BtnText2_Click );
			// 
			// m_BtnGetSize
			// 
			this.m_BtnGetSize.Location = new System.Drawing.Point( 431, 76 );
			this.m_BtnGetSize.Name = "m_BtnGetSize";
			this.m_BtnGetSize.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnGetSize.TabIndex = 13;
			this.m_BtnGetSize.Text = "Get Layer Size";
			this.m_BtnGetSize.UseVisualStyleBackColor = true;
			this.m_BtnGetSize.Click += new System.EventHandler( this.m_BtnGetSize_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 431, 117 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 16, 12 );
			this.label1.TabIndex = 14;
			this.label1.Text = "W";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 431, 145 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 13, 12 );
			this.label2.TabIndex = 15;
			this.label2.Text = "H";
			// 
			// m_tboxWidth
			// 
			this.m_tboxWidth.Location = new System.Drawing.Point( 453, 114 );
			this.m_tboxWidth.Name = "m_tboxWidth";
			this.m_tboxWidth.ReadOnly = true;
			this.m_tboxWidth.Size = new System.Drawing.Size( 100, 22 );
			this.m_tboxWidth.TabIndex = 16;
			// 
			// m_tboxHeight
			// 
			this.m_tboxHeight.Location = new System.Drawing.Point( 453, 142 );
			this.m_tboxHeight.Name = "m_tboxHeight";
			this.m_tboxHeight.ReadOnly = true;
			this.m_tboxHeight.Size = new System.Drawing.Size( 100, 22 );
			this.m_tboxHeight.TabIndex = 17;
			// 
			// m_BtnGetStatus
			// 
			this.m_BtnGetStatus.Location = new System.Drawing.Point( 433, 202 );
			this.m_BtnGetStatus.Name = "m_BtnGetStatus";
			this.m_BtnGetStatus.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnGetStatus.TabIndex = 18;
			this.m_BtnGetStatus.Text = "Get Status";
			this.m_BtnGetStatus.UseVisualStyleBackColor = true;
			this.m_BtnGetStatus.Click += new System.EventHandler( this.m_BtnGetStatus_Click );
			// 
			// m_tboxStatus
			// 
			this.m_tboxStatus.Location = new System.Drawing.Point( 431, 241 );
			this.m_tboxStatus.Name = "m_tboxStatus";
			this.m_tboxStatus.ReadOnly = true;
			this.m_tboxStatus.Size = new System.Drawing.Size( 140, 22 );
			this.m_tboxStatus.TabIndex = 19;
			// 
			// m_BtnDisconnect
			// 
			this.m_BtnDisconnect.BackColor = System.Drawing.Color.Red;
			this.m_BtnDisconnect.Location = new System.Drawing.Point( 429, 379 );
			this.m_BtnDisconnect.Name = "m_BtnDisconnect";
			this.m_BtnDisconnect.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnDisconnect.TabIndex = 20;
			this.m_BtnDisconnect.Text = "Disconnect";
			this.m_BtnDisconnect.UseVisualStyleBackColor = false;
			this.m_BtnDisconnect.Click += new System.EventHandler( this.m_BtnDisconnect_Click );
			// 
			// m_tboxIPAddress
			// 
			this.m_tboxIPAddress.Location = new System.Drawing.Point( 51, 26 );
			this.m_tboxIPAddress.Name = "m_tboxIPAddress";
			this.m_tboxIPAddress.Size = new System.Drawing.Size( 168, 22 );
			this.m_tboxIPAddress.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 49, 11 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 52, 12 );
			this.label3.TabIndex = 22;
			this.label3.Text = "IP address";
			// 
			// m_BtnTextColor2
			// 
			this.m_BtnTextColor2.Location = new System.Drawing.Point( 213, 202 );
			this.m_BtnTextColor2.Name = "m_BtnTextColor2";
			this.m_BtnTextColor2.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnTextColor2.TabIndex = 23;
			this.m_BtnTextColor2.Text = "ChangeTextColor 2";
			this.m_BtnTextColor2.UseVisualStyleBackColor = true;
			this.m_BtnTextColor2.Click += new System.EventHandler( this.m_BtnTextColor2_Click );
			// 
			// m_BtnSize2
			// 
			this.m_BtnSize2.Location = new System.Drawing.Point( 213, 241 );
			this.m_BtnSize2.Name = "m_BtnSize2";
			this.m_BtnSize2.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnSize2.TabIndex = 24;
			this.m_BtnSize2.Text = "ChangeSize 2";
			this.m_BtnSize2.UseVisualStyleBackColor = true;
			this.m_BtnSize2.Click += new System.EventHandler( this.m_BtnSize2_Click );
			// 
			// m_BtnLocation2
			// 
			this.m_BtnLocation2.Location = new System.Drawing.Point( 213, 284 );
			this.m_BtnLocation2.Name = "m_BtnLocation2";
			this.m_BtnLocation2.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnLocation2.TabIndex = 25;
			this.m_BtnLocation2.Text = "ChangeLocation 2";
			this.m_BtnLocation2.UseVisualStyleBackColor = true;
			this.m_BtnLocation2.Click += new System.EventHandler( this.m_BtnLocation2_Click );
			// 
			// m_BtnGetLatError
			// 
			this.m_BtnGetLatError.Location = new System.Drawing.Point( 429, 302 );
			this.m_BtnGetLatError.Name = "m_BtnGetLatError";
			this.m_BtnGetLatError.Size = new System.Drawing.Size( 142, 23 );
			this.m_BtnGetLatError.TabIndex = 26;
			this.m_BtnGetLatError.Text = "Get Last Error";
			this.m_BtnGetLatError.UseVisualStyleBackColor = true;
			this.m_BtnGetLatError.Click += new System.EventHandler( this.m_BtnGetLatError_Click );
			// 
			// m_tboxLastError
			// 
			this.m_tboxLastError.Location = new System.Drawing.Point( 429, 331 );
			this.m_tboxLastError.Name = "m_tboxLastError";
			this.m_tboxLastError.ReadOnly = true;
			this.m_tboxLastError.Size = new System.Drawing.Size( 140, 22 );
			this.m_tboxLastError.TabIndex = 27;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 628, 417 );
			this.Controls.Add( this.m_tboxLastError );
			this.Controls.Add( this.m_BtnGetLatError );
			this.Controls.Add( this.m_BtnLocation2 );
			this.Controls.Add( this.m_BtnSize2 );
			this.Controls.Add( this.m_BtnTextColor2 );
			this.Controls.Add( this.label3 );
			this.Controls.Add( this.m_tboxIPAddress );
			this.Controls.Add( this.m_BtnDisconnect );
			this.Controls.Add( this.m_tboxStatus );
			this.Controls.Add( this.m_BtnGetStatus );
			this.Controls.Add( this.m_tboxHeight );
			this.Controls.Add( this.m_tboxWidth );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.m_BtnGetSize );
			this.Controls.Add( this.m_BtnText2 );
			this.Controls.Add( this.m_BtnBackColor2 );
			this.Controls.Add( this.m_BtnAdd2 );
			this.Controls.Add( this.m_BtnAdd1 );
			this.Controls.Add( this.m_BtnRemove2 );
			this.Controls.Add( this.m_BtnRemoveAll );
			this.Controls.Add( this.m_BtnRemove1 );
			this.Controls.Add( this.m_BtnLocation1 );
			this.Controls.Add( this.m_BtnSize1 );
			this.Controls.Add( this.m_BtnTextColor1 );
			this.Controls.Add( this.m_BtnText1 );
			this.Controls.Add( this.m_BtnBackColor1 );
			this.Controls.Add( this.m_BtnConnect );
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_BtnConnect;
		private System.Windows.Forms.Button m_BtnBackColor1;
		private System.Windows.Forms.Button m_BtnText1;
		private System.Windows.Forms.Button m_BtnTextColor1;
		private System.Windows.Forms.Button m_BtnSize1;
		private System.Windows.Forms.Button m_BtnLocation1;
		private System.Windows.Forms.Button m_BtnRemove1;
		private System.Windows.Forms.Button m_BtnRemoveAll;
		private System.Windows.Forms.Button m_BtnRemove2;
		private System.Windows.Forms.Button m_BtnAdd1;
		private System.Windows.Forms.Button m_BtnAdd2;
		private System.Windows.Forms.Button m_BtnBackColor2;
		private System.Windows.Forms.Button m_BtnText2;
		private System.Windows.Forms.Button m_BtnGetSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox m_tboxWidth;
		private System.Windows.Forms.TextBox m_tboxHeight;
		private System.Windows.Forms.Button m_BtnGetStatus;
		private System.Windows.Forms.TextBox m_tboxStatus;
		private System.Windows.Forms.Button m_BtnDisconnect;
		private System.Windows.Forms.TextBox m_tboxIPAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button m_BtnTextColor2;
		private System.Windows.Forms.Button m_BtnSize2;
		private System.Windows.Forms.Button m_BtnLocation2;
		private System.Windows.Forms.Button m_BtnGetLatError;
		private System.Windows.Forms.TextBox m_tboxLastError;
	}
}

