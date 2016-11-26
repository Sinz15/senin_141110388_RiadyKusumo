namespace Latihan_3_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UnderlineButton = new System.Windows.Forms.CheckBox();
            this.ItalicButton = new System.Windows.Forms.CheckBox();
            this.BoldButton = new System.Windows.Forms.CheckBox();
            this.FontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.FontComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Location = new System.Drawing.Point(13, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 285);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorDialog1
            // 
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ScriptsOnly = true;
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.ShowHelp = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(385, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.UnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineButton.Image")));
            this.UnderlineButton.Location = new System.Drawing.Point(111, 26);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(23, 23);
            this.UnderlineButton.TabIndex = 34;
            this.UnderlineButton.UseVisualStyleBackColor = true;
            // 
            // ItalicButton
            // 
            this.ItalicButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ItalicButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicButton.Image")));
            this.ItalicButton.Location = new System.Drawing.Point(82, 26);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(23, 23);
            this.ItalicButton.TabIndex = 35;
            this.ItalicButton.UseVisualStyleBackColor = true;
            // 
            // BoldButton
            // 
            this.BoldButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
            this.BoldButton.Location = new System.Drawing.Point(53, 26);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(23, 23);
            this.BoldButton.TabIndex = 36;
            this.BoldButton.UseVisualStyleBackColor = true;
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FontSizeComboBox.DropDownWidth = 200;
            this.FontSizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSizeComboBox.FormattingEnabled = true;
            this.FontSizeComboBox.Location = new System.Drawing.Point(12, 28);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(35, 21);
            this.FontSizeComboBox.TabIndex = 31;
            // 
            // FontComboBox
            // 
            this.FontComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FontComboBox.DropDownWidth = 200;
            this.FontComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Location = new System.Drawing.Point(140, 28);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(112, 21);
            this.FontComboBox.TabIndex = 32;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorComboBox.DropDownWidth = 200;
            this.ColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(258, 29);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(112, 21);
            this.ColorComboBox.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 365);
            this.Controls.Add(this.UnderlineButton);
            this.Controls.Add(this.ItalicButton);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.FontSizeComboBox);
            this.Controls.Add(this.FontComboBox);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox UnderlineButton;
        private System.Windows.Forms.CheckBox ItalicButton;
        private System.Windows.Forms.CheckBox BoldButton;
        private System.Windows.Forms.ComboBox FontSizeComboBox;
        private System.Windows.Forms.ComboBox FontComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
    }
}

