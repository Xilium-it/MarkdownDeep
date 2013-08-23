using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xilium.MarkdownDeep;

namespace MarkdownDeepGui
{
	public partial class Form1 : Form {

		private const string cssStyle = @"
table		{ font-size:10pt; }
table td	{ background-color: #ddd; }
table th	{ background-color: #aca; font-weight: bold; }
table thead th	{ background-color: #447; color: white; font-weight: bold; font-size:110%; }
";

		public Form1()
		{
			InitializeComponent();
			this.txtMarkdown.Text = "# Welcome to MarkdownDeep #\r\n\r\nType markdown text above, see formatted text below!";
			this.txtMarkdown.SelectionStart = this.txtMarkdown.Text.Length;
			m_Markdown.ExtraMode = true;
		}

		private void doUpdate()
		{
			this.txtSource.Text = m_Markdown.Transform(txtMarkdown.Text).Replace("\n", "\r\n");
			this.webPreview.DocumentText = "<style type=\"text/css\">" + cssStyle + "</style>\n" + this.txtSource.Text;
		}

		private void txtMarkdown_TextChanged(object sender, EventArgs e)
		{
			doUpdate();
		}



		Markdown m_Markdown = new Markdown();

		private void checkSafeMode_CheckedChanged(object sender, EventArgs e)
		{
			m_Markdown.SafeMode = this.checkSafeMode.Checked;
			doUpdate();
		}

		private void checkExtraMode_CheckedChanged(object sender, EventArgs e)
		{
			m_Markdown.ExtraMode = this.checkExtraMode.Checked;
			doUpdate();
		}

		private void Form1_Load(object sender, EventArgs e) {

		}
	}
}
