using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using neggs.core;

namespace neggs
{
	public partial class ThrottleForm : Form
	{
		private Throttle<string> throttle;

		public ThrottleForm()
		{
			InitializeComponent();
			throttle = new Throttle<string>(1000, this.TextChangedThrottled);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			throttle.Signal(textBox1.Text);
		}

		private void TextChangedThrottled(string text)
		{
			listBox1.Items.Add(text);
		}

	}
}
