using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			LabelTime.Text = DateTime.Now.ToString("hh:mm:ss tt"/*,System.Globalization.CultureInfo.InvariantCulture*/);
			if(cbShowDate.Checked)
			{
				LabelTime.Text += "\n";
				LabelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");
			}
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			cbShowDate.Visible = false;
			btnHideControls.Visible = false;
			this.TransparencyKey = this.BackColor;
			this.FormBorderStyle = FormBorderStyle.None;
			LabelTime.BackColor = Color.AliceBlue;
			this.ShowInTaskbar = false;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void LabelTime_DoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show(this,
			//	"Вы два раза щелкнули мышью по времени,  и теперь Вы управляете временем",
			//	"Info", MessageBoxButtons.OK,
			//	MessageBoxIcon.Information
			//	);
			cbShowDate.Visible = true;
			btnHideControls.Visible = true;
			this.ShowInTaskbar = true;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			
			this.TransparencyKey = Color.Empty;
		}
	}
}
