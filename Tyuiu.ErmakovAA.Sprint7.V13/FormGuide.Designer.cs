namespace Tyuiu.ErmakovAA.Sprint7.V13
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
            groupBoxGuideDescription_SBI = new GroupBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            groupBoxGuideDescription_SBI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGuideDescription_SBI
            // 
            groupBoxGuideDescription_SBI.BackColor = SystemColors.Control;
            groupBoxGuideDescription_SBI.Controls.Add(richTextBox1);
            resources.ApplyResources(groupBoxGuideDescription_SBI, "groupBoxGuideDescription_SBI");
            groupBoxGuideDescription_SBI.Name = "groupBoxGuideDescription_SBI";
            groupBoxGuideDescription_SBI.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Control;
            richTextBox2.BorderStyle = BorderStyle.None;
            resources.ApplyResources(richTextBox2, "richTextBox2");
            richTextBox2.Name = "richTextBox2";
            // 
            // FormGuide
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox2);
            Controls.Add(groupBoxGuideDescription_SBI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGuide";
            groupBoxGuideDescription_SBI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxGuideDescription_SBI;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}