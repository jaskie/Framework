﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Svt.Caspar.Controls
{
	public partial class ShockwaveFlashControl : UserControl
	{
		public ShockwaveFlashControl()
		{
			InitializeComponent();
			this.Load += new EventHandler(ShockwaveFlashControl_Load);
		}

		void ShockwaveFlashControl_Load(object sender, EventArgs e)
		{
			int a = 01;
		}

		public AxShockwaveFlashObjects.AxShockwaveFlash FlashActiveX { get { return axShockwaveFlash1; } }
	}
}
