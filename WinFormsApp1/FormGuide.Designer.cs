namespace WinFormsApp1
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            panelGuideImage_SBI = new Panel();
            pictureBoxGuide_SBI = new PictureBox();
            panelGuideDescription_SBI = new Panel();
            groupBoxGuideDescription_SBI = new GroupBox();
            textBoxGuide_SBI = new TextBox();
            panelGuideImage_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_SBI).BeginInit();
            panelGuideDescription_SBI.SuspendLayout();
            groupBoxGuideDescription_SBI.SuspendLayout();
            SuspendLayout();
            // 
            // panelGuideImage_SBI
            // 
            panelGuideImage_SBI.Controls.Add(pictureBoxGuide_SBI);
            panelGuideImage_SBI.Dock = DockStyle.Top;
            panelGuideImage_SBI.Location = new Point(0, 0);
            panelGuideImage_SBI.Name = "panelGuideImage_SBI";
            panelGuideImage_SBI.Padding = new Padding(5);
            panelGuideImage_SBI.Size = new Size(573, 225);
            panelGuideImage_SBI.TabIndex = 0;
            // 
            // pictureBoxGuide_SBI
            // 
            pictureBoxGuide_SBI.Dock = DockStyle.Fill;
            pictureBoxGuide_SBI.Image = (Image)resources.GetObject("pictureBoxGuide_SBI.Image");
            pictureBoxGuide_SBI.Location = new Point(5, 5);
            pictureBoxGuide_SBI.Name = "pictureBoxGuide_SBI";
            pictureBoxGuide_SBI.Size = new Size(563, 215);
            pictureBoxGuide_SBI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGuide_SBI.TabIndex = 0;
            pictureBoxGuide_SBI.TabStop = false;
            // 
            // panelGuideDescription_SBI
            // 
            panelGuideDescription_SBI.Controls.Add(groupBoxGuideDescription_SBI);
            panelGuideDescription_SBI.Dock = DockStyle.Bottom;
            panelGuideDescription_SBI.Location = new Point(0, 231);
            panelGuideDescription_SBI.Name = "panelGuideDescription_SBI";
            panelGuideDescription_SBI.Padding = new Padding(5);
            panelGuideDescription_SBI.Size = new Size(573, 219);
            panelGuideDescription_SBI.TabIndex = 1;
            // 
            // groupBoxGuideDescription_SBI
            // 
            groupBoxGuideDescription_SBI.Controls.Add(textBoxGuide_SBI);
            groupBoxGuideDescription_SBI.Dock = DockStyle.Fill;
            groupBoxGuideDescription_SBI.Location = new Point(5, 5);
            groupBoxGuideDescription_SBI.Name = "groupBoxGuideDescription_SBI";
            groupBoxGuideDescription_SBI.Size = new Size(563, 209);
            groupBoxGuideDescription_SBI.TabIndex = 0;
            groupBoxGuideDescription_SBI.TabStop = false;
            groupBoxGuideDescription_SBI.Text = "Описание";
            // 
            // textBoxGuide_SBI
            // 
            textBoxGuide_SBI.BorderStyle = BorderStyle.None;
            textBoxGuide_SBI.Dock = DockStyle.Fill;
            textBoxGuide_SBI.Location = new Point(3, 19);
            textBoxGuide_SBI.Multiline = true;
            textBoxGuide_SBI.Name = "textBoxGuide_SBI";
            textBoxGuide_SBI.ReadOnly = true;
            textBoxGuide_SBI.Size = new Size(557, 187);
            textBoxGuide_SBI.TabIndex = 0;
            textBoxGuide_SBI.Text = resources.GetString("textBoxGuide_SBI.Text");
            textBoxGuide_SBI.Enter += textBoxGuide_SBI_Enter;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(panelGuideDescription_SBI);
            Controls.Add(panelGuideImage_SBI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(589, 489);
            MinimumSize = new Size(589, 489);
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство";
            panelGuideImage_SBI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_SBI).EndInit();
            panelGuideDescription_SBI.ResumeLayout(false);
            groupBoxGuideDescription_SBI.ResumeLayout(false);
            groupBoxGuideDescription_SBI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGuideImage_SBI;
        private Panel panelGuideDescription_SBI;
        private PictureBox pictureBoxGuide_SBI;
        private GroupBox groupBoxGuideDescription_SBI;
        private TextBox textBoxGuide_SBI;
    }
}