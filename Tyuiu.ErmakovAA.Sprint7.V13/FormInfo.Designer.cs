using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    partial class FormInfo
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
            labelInfo_EAA = new Label();
            buttonClose_EAA = new Button();
            pictureBoxME_EAA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxME_EAA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_EAA
            // 
            labelInfo_EAA.AutoSize = true;
            labelInfo_EAA.Location = new Point(125, 10);
            labelInfo_EAA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_EAA.Name = "labelInfo_EAA";
            labelInfo_EAA.Size = new Size(302, 135);
            labelInfo_EAA.TabIndex = 0;
            labelInfo_EAA.Text = "Разработчик: Ермаков А.А.\r\nГруппа ПКТб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2024\r\nВысшая школа цифровых технологий (с) 2024\r\n\r\n\r\n";
            // 
            // buttonClose_EAA
            // 
            buttonClose_EAA.Location = new Point(336, 132);
            buttonClose_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonClose_EAA.Name = "buttonClose_EAA";
            buttonClose_EAA.Size = new Size(110, 40);
            buttonClose_EAA.TabIndex = 1;
            buttonClose_EAA.Text = "OK";
            buttonClose_EAA.UseVisualStyleBackColor = true;
            buttonClose_EAA.Click += textBox1_TextChanged;
            // 
            // pictureBoxME_EAA
            // 
            pictureBoxME_EAA.Image = Properties.Resources._5237952298578209921__1_;
            pictureBoxME_EAA.Location = new Point(10, 12);
            pictureBoxME_EAA.Margin = new Padding(4, 3, 4, 3);
            pictureBoxME_EAA.Name = "pictureBoxME_EAA";
            pictureBoxME_EAA.Size = new Size(96, 133);
            pictureBoxME_EAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxME_EAA.TabIndex = 2;
            pictureBoxME_EAA.TabStop = false;
            pictureBoxME_EAA.Click += pictureBoxME_EAA_Click;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 186);
            Controls.Add(pictureBoxME_EAA);
            Controls.Add(buttonClose_EAA);
            Controls.Add(labelInfo_EAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBoxME_EAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInfo_EAA;
        private System.Windows.Forms.Button buttonClose_EAA;
        private System.Windows.Forms.PictureBox pictureBoxME_EAA;
    }
}