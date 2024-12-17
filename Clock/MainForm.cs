using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			LabelTime.BackColor = Color.AntiqueWhite;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			
		}
		void SetVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.ShowInTaskbar = visible;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			LabelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
			if (cbShowDate.Checked)
			{
				LabelTime.Text += "\n";
				LabelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");
			}
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile("C:\\Users\\ASUTP\\source\\repos\\WindowsForms\\Font\\digital-7.ttf");
			foreach (Control c in this.Controls)
			{
				c.Font = new Font(pfc.Families[0], 32, FontStyle.Regular);
			}
			if (cbShowWeekDay.Checked)
			{
				LabelTime.Text += "\n";
				LabelTime.Text += DateTime.Now.DayOfWeek;
			}
			notifyIcon.Text = LabelTime.Text;

		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			//cbShowDate.Visible = false;
			//btnHideControls.Visible = false;
			//this.TransparencyKey = this.BackColor;
			//this.FormBorderStyle = FormBorderStyle.None;
			//LabelTime.BackColor = Color.AliceBlue;
			//this.ShowInTaskbar = false;
			SetVisibility(false);
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
			//cbShowDate.Visible = true;
			//btnHideControls.Visible = true;
			//this.ShowInTaskbar = true;
			//this.FormBorderStyle = FormBorderStyle.FixedDialog;
			//this.TransparencyKey = Color.Empty;
			SetVisibility(true);
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cmShowWeekDay.Checked = cbShowWeekDay.Checked;
		}


		private void cmTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = cmTopmost.Checked;
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cbShowDate.Checked = cmShowDate.Checked;
		}

		private void cmShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cbShowWeekDay.Checked = cmShowWeekDay.Checked;
		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cmShowDate.Checked = cbShowDate.Checked;
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void cmBackColor_CheckedChanged(object sender, EventArgs e)
		{
			if(cmBackColor.Checked)
			LabelTime.BackColor = Color.Black;
			else
			LabelTime.BackColor = Color.AntiqueWhite;
		
		}

		private void cmForeColor_Click(object sender, EventArgs e)
		{
			if(cmForeColor.Checked)
			
				LabelTime.ForeColor = Color.White;
				else
					LabelTime.ForeColor = Color.Red;
			
		}
	}
}
