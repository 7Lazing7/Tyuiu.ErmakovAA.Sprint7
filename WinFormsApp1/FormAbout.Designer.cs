namespace WinFormsApp1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            panelAboutText_SBI = new Panel();
            groupBoxAbout_SBI = new GroupBox();
            textBox1 = new TextBox();
            pictureBoxAbout_SBI = new PictureBox();
            panelAboutText_SBI.SuspendLayout();
            groupBoxAbout_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_SBI).BeginInit();
            SuspendLayout();
            // 
            // panelAboutText_SBI
            // 
            panelAboutText_SBI.Controls.Add(groupBoxAbout_SBI);
            panelAboutText_SBI.Dock = DockStyle.Right;
            panelAboutText_SBI.Location = new Point(183, 0);
            panelAboutText_SBI.Name = "panelAboutText_SBI";
            panelAboutText_SBI.Padding = new Padding(5, 0, 0, 0);
            panelAboutText_SBI.Size = new Size(273, 246);
            panelAboutText_SBI.TabIndex = 0;
            // 
            // groupBoxAbout_SBI
            // 
            groupBoxAbout_SBI.Controls.Add(textBox1);
            groupBoxAbout_SBI.Dock = DockStyle.Fill;
            groupBoxAbout_SBI.Location = new Point(5, 0);
            groupBoxAbout_SBI.Name = "groupBoxAbout_SBI";
            groupBoxAbout_SBI.Size = new Size(268, 246);
            groupBoxAbout_SBI.TabIndex = 1;
            groupBoxAbout_SBI.TabStop = false;
            groupBoxAbout_SBI.Text = "Описание";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(262, 224);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBoxAbout_SBI
            // 
            pictureBoxAbout_SBI.Dock = DockStyle.Fill;
            pictureBoxAbout_SBI.Image = (Image)resources.GetObject("pictureBoxAbout_SBI.Image");
            pictureBoxAbout_SBI.Location = new Point(0, 0);
            pictureBoxAbout_SBI.Name = "pictureBoxAbout_SBI";
            pictureBoxAbout_SBI.Size = new Size(183, 246);
            pictureBoxAbout_SBI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAbout_SBI.TabIndex = 1;
            pictureBoxAbout_SBI.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 246);
            Controls.Add(pictureBoxAbout_SBI);
            Controls.Add(panelAboutText_SBI);
            MaximumSize = new Size(472, 285);
            MinimumSize = new Size(472, 285);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            panelAboutText_SBI.ResumeLayout(false);
            groupBoxAbout_SBI.ResumeLayout(false);
            groupBoxAbout_SBI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_SBI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAboutText_SBI;
        private PictureBox pictureBoxAbout_SBI;
        private GroupBox groupBoxAbout_SBI;
        private TextBox textBox1;
    }
}