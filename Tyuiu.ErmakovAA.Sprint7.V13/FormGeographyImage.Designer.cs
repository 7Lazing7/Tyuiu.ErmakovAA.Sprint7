namespace Tyuiu.ErmakovAA.Sprint7.V13
{

        partial class FormGeographyImage
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
            groupBoxGuideImageDescription_EAA = new GroupBox();
            textBoxGuideImage_EAA = new TextBox();
            panelGuideImageDescription_EAA = new Panel();
            panelGuideImage_EAA = new Panel();
            pictureBoxGuideImage_EAA = new PictureBox();
            groupBoxGuideImageDescription_EAA.SuspendLayout();
            panelGuideImageDescription_EAA.SuspendLayout();
            panelGuideImage_EAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuideImage_EAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGuideImageDescription_EAA
            // 
            groupBoxGuideImageDescription_EAA.Controls.Add(textBoxGuideImage_EAA);
            groupBoxGuideImageDescription_EAA.Dock = DockStyle.Fill;
            groupBoxGuideImageDescription_EAA.Location = new Point(5, 5);
            groupBoxGuideImageDescription_EAA.Name = "groupBoxGuideImageDescription_EAA";
            groupBoxGuideImageDescription_EAA.Size = new Size(563, 209);
            groupBoxGuideImageDescription_EAA.TabIndex = 0;
            groupBoxGuideImageDescription_EAA.TabStop = false;
            groupBoxGuideImageDescription_EAA.Text = "Описание";
            // 
            // textBoxGuideImage_EAA
            // 
            textBoxGuideImage_EAA.BorderStyle = BorderStyle.None;
            textBoxGuideImage_EAA.Dock = DockStyle.Fill;
            textBoxGuideImage_EAA.Location = new Point(3, 19);
            textBoxGuideImage_EAA.Multiline = true;
            textBoxGuideImage_EAA.Name = "textBoxGuideImage_EAA";
            textBoxGuideImage_EAA.ReadOnly = true;
            textBoxGuideImage_EAA.Size = new Size(557, 187);
            textBoxGuideImage_EAA.TabIndex = 0;
            textBoxGuideImage_EAA.TextChanged += textBoxGuideImage_EAA_TextChanged;
            // 
            // panelGuideImageDescription_EAA
            // 
            panelGuideImageDescription_EAA.Controls.Add(groupBoxGuideImageDescription_EAA);
            panelGuideImageDescription_EAA.Dock = DockStyle.Bottom;
            panelGuideImageDescription_EAA.Location = new Point(0, 231);
            panelGuideImageDescription_EAA.Name = "panelGuideImageDescription_EAA";
            panelGuideImageDescription_EAA.Padding = new Padding(5);
            panelGuideImageDescription_EAA.Size = new Size(573, 219);
            panelGuideImageDescription_EAA.TabIndex = 3;
            // 
            // panelGuideImage_EAA
            // 
            panelGuideImage_EAA.Controls.Add(pictureBoxGuideImage_EAA);
            panelGuideImage_EAA.Dock = DockStyle.Top;
            panelGuideImage_EAA.Location = new Point(0, 0);
            panelGuideImage_EAA.Name = "panelGuideImage_EAA";
            panelGuideImage_EAA.Padding = new Padding(5);
            panelGuideImage_EAA.Size = new Size(573, 225);
            panelGuideImage_EAA.TabIndex = 2;
            // 
            // pictureBoxGuideImage_EAA
            // 
            pictureBoxGuideImage_EAA.Dock = DockStyle.Fill;
            pictureBoxGuideImage_EAA.Location = new Point(5, 5);
            pictureBoxGuideImage_EAA.Name = "pictureBoxGuideImage_EAA";
            pictureBoxGuideImage_EAA.Size = new Size(563, 215);
            pictureBoxGuideImage_EAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGuideImage_EAA.TabIndex = 0;
            pictureBoxGuideImage_EAA.TabStop = false;
            // 
            // FormGeographyImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(panelGuideImageDescription_EAA);
            Controls.Add(panelGuideImage_EAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(589, 489);
            MinimumSize = new Size(589, 489);
            Name = "FormGeographyImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство";
            groupBoxGuideImageDescription_EAA.ResumeLayout(false);
            groupBoxGuideImageDescription_EAA.PerformLayout();
            panelGuideImageDescription_EAA.ResumeLayout(false);
            panelGuideImage_EAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuideImage_EAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGuideImageDescription_EAA;
            private TextBox textBoxGuideImage_EAA;
            private Panel panelGuideImageDescription_EAA;
            private Panel panelGuideImage_EAA;
            private PictureBox pictureBoxGuideImage_EAA;
        }
    }
