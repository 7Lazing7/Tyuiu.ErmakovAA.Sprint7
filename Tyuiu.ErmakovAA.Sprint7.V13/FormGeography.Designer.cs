namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    partial class FormGeography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeography));
            panelGuideImage_EAA = new Panel();
            pictureBoxGuide_EAA = new PictureBox();
            panelGuideDescription_EAA = new Panel();
            groupBoxGuideDescription_EAA = new GroupBox();
            textBoxGuide_EAA = new TextBox();
            panelGuideImage_EAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_EAA).BeginInit();
            panelGuideDescription_EAA.SuspendLayout();
            groupBoxGuideDescription_EAA.SuspendLayout();
            SuspendLayout();
            // 
            // panelGuideImage_EAA
            // 
            panelGuideImage_EAA.Controls.Add(pictureBoxGuide_EAA);
            panelGuideImage_EAA.Dock = DockStyle.Top;
            panelGuideImage_EAA.Location = new Point(0, 0);
            panelGuideImage_EAA.Name = "panelGuideImage_EAA";
            panelGuideImage_EAA.Padding = new Padding(5);
            panelGuideImage_EAA.Size = new Size(573, 225);
            panelGuideImage_EAA.TabIndex = 0;
            // 
            // pictureBoxGuide_EAA
            // 
            pictureBoxGuide_EAA.Dock = DockStyle.Fill;
            pictureBoxGuide_EAA.Image = (Image)resources.GetObject("pictureBoxGuide_EAA.Image");
            pictureBoxGuide_EAA.Location = new Point(5, 5);
            pictureBoxGuide_EAA.Name = "pictureBoxGuide_EAA";
            pictureBoxGuide_EAA.Size = new Size(563, 215);
            pictureBoxGuide_EAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGuide_EAA.TabIndex = 0;
            pictureBoxGuide_EAA.TabStop = false;
            // 
            // panelGuideDescription_EAA
            // 
            panelGuideDescription_EAA.Controls.Add(groupBoxGuideDescription_EAA);
            panelGuideDescription_EAA.Dock = DockStyle.Bottom;
            panelGuideDescription_EAA.Location = new Point(0, 231);
            panelGuideDescription_EAA.Name = "panelGuideDescription_EAA";
            panelGuideDescription_EAA.Padding = new Padding(5);
            panelGuideDescription_EAA.Size = new Size(573, 219);
            panelGuideDescription_EAA.TabIndex = 1;
            // 
            // groupBoxGuideDescription_EAA
            // 
            groupBoxGuideDescription_EAA.Controls.Add(textBoxGuide_EAA);
            groupBoxGuideDescription_EAA.Dock = DockStyle.Fill;
            groupBoxGuideDescription_EAA.Location = new Point(5, 5);
            groupBoxGuideDescription_EAA.Name = "groupBoxGuideDescription_EAA";
            groupBoxGuideDescription_EAA.Size = new Size(563, 209);
            groupBoxGuideDescription_EAA.TabIndex = 0;
            groupBoxGuideDescription_EAA.TabStop = false;
            groupBoxGuideDescription_EAA.Text = "Описание";
            // 
            // textBoxGuide_EAA
            // 
            textBoxGuide_EAA.BorderStyle = BorderStyle.None;
            textBoxGuide_EAA.Dock = DockStyle.Fill;
            textBoxGuide_EAA.Location = new Point(3, 19);
            textBoxGuide_EAA.Multiline = true;
            textBoxGuide_EAA.Name = "textBoxGuide_EAA";
            textBoxGuide_EAA.ReadOnly = true;
            textBoxGuide_EAA.Size = new Size(557, 187);
            textBoxGuide_EAA.TabIndex = 0;
            textBoxGuide_EAA.Text = resources.GetString("textBoxGuide_EAA.Text");
           
            // 
            // FormGeography
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(panelGuideDescription_EAA);
            Controls.Add(panelGuideImage_EAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(589, 489);
            MinimumSize = new Size(589, 489);
            Name = "FormGeography";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство";
            panelGuideImage_EAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_EAA).EndInit();
            panelGuideDescription_EAA.ResumeLayout(false);
            groupBoxGuideDescription_EAA.ResumeLayout(false);
            groupBoxGuideDescription_EAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGuideImage_EAA;
        private Panel panelGuideDescription_EAA;
        private PictureBox pictureBoxGuide_EAA;
        private GroupBox groupBoxGuideDescription_EAA;
        private TextBox textBoxGuide_EAA;
    }
}
