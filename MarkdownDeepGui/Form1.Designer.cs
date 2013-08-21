namespace MarkdownDeepGui
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
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtMarkdown = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.webPreview = new System.Windows.Forms.WebBrowser();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.checkExtraMode = new System.Windows.Forms.CheckBox();
			this.checkSafeMode = new System.Windows.Forms.CheckBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtMarkdown);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.checkExtraMode);
			this.splitContainer1.Panel2.Controls.Add(this.checkSafeMode);
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(754, 454);
			this.splitContainer1.SplitterDistance = 188;
			this.splitContainer1.TabIndex = 4;
			// 
			// txtMarkdown
			// 
			this.txtMarkdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarkdown.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMarkdown.Location = new System.Drawing.Point(3, 3);
			this.txtMarkdown.Multiline = true;
			this.txtMarkdown.Name = "txtMarkdown";
			this.txtMarkdown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMarkdown.Size = new System.Drawing.Size(748, 182);
			this.txtMarkdown.TabIndex = 2;
			this.txtMarkdown.TextChanged += new System.EventHandler(this.txtMarkdown_TextChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(748, 233);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.webPreview);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(740, 207);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Preview";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// webPreview
			// 
			this.webPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webPreview.Location = new System.Drawing.Point(3, 6);
			this.webPreview.MinimumSize = new System.Drawing.Size(20, 20);
			this.webPreview.Name = "webPreview";
			this.webPreview.Size = new System.Drawing.Size(731, 195);
			this.webPreview.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtSource);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(740, 207);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Source";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtSource
			// 
			this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSource.BackColor = System.Drawing.SystemColors.Window;
			this.txtSource.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSource.Location = new System.Drawing.Point(6, 6);
			this.txtSource.Multiline = true;
			this.txtSource.Name = "txtSource";
			this.txtSource.ReadOnly = true;
			this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSource.Size = new System.Drawing.Size(728, 195);
			this.txtSource.TabIndex = 0;
			// 
			// checkExtraMode
			// 
			this.checkExtraMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkExtraMode.AutoSize = true;
			this.checkExtraMode.Checked = true;
			this.checkExtraMode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkExtraMode.Location = new System.Drawing.Point(87, 242);
			this.checkExtraMode.Name = "checkExtraMode";
			this.checkExtraMode.Size = new System.Drawing.Size(80, 17);
			this.checkExtraMode.TabIndex = 5;
			this.checkExtraMode.Text = "E&xtra Mode";
			this.checkExtraMode.UseVisualStyleBackColor = true;
			this.checkExtraMode.CheckedChanged += new System.EventHandler(this.checkExtraMode_CheckedChanged);
			// 
			// checkSafeMode
			// 
			this.checkSafeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkSafeMode.AutoSize = true;
			this.checkSafeMode.Location = new System.Drawing.Point(3, 242);
			this.checkSafeMode.Name = "checkSafeMode";
			this.checkSafeMode.Size = new System.Drawing.Size(78, 17);
			this.checkSafeMode.TabIndex = 4;
			this.checkSafeMode.Text = "&Safe Mode";
			this.checkSafeMode.UseVisualStyleBackColor = true;
			this.checkSafeMode.CheckedChanged += new System.EventHandler(this.checkSafeMode_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 478);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtMarkdown;
		private System.Windows.Forms.CheckBox checkExtraMode;
		private System.Windows.Forms.CheckBox checkSafeMode;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.WebBrowser webPreview;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtSource;
	}
}

