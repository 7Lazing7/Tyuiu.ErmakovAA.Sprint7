namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    partial class FormRoute
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
            panelRouteDescription_EAA = new Panel();
            groupBoxRouteDescription_EAA = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxRouteTime_EAA = new TextBox();
            textBoxRouteType_EAA = new TextBox();
            textBox4 = new TextBox();
            textBoxRouteEnd_EAA = new TextBox();
            textBoxRouteStart_EAA = new TextBox();
            textBoxRouteId_EAA = new TextBox();
            panelRouteImage_EAA = new Panel();
            pictureBoxRoute_EAA = new PictureBox();
            panelRouteStops_EAA = new Panel();
            groupBoxRouteList_EAA = new GroupBox();
            flowLayoutPanel_EAA = new FlowLayoutPanel();
            panelRouteDescription_EAA.SuspendLayout();
            groupBoxRouteDescription_EAA.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRouteImage_EAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_EAA).BeginInit();
            panelRouteStops_EAA.SuspendLayout();
            groupBoxRouteList_EAA.SuspendLayout();
            SuspendLayout();
            // 
            // panelRouteDescription_EAA
            // 
            panelRouteDescription_EAA.Controls.Add(groupBoxRouteDescription_EAA);
            panelRouteDescription_EAA.Dock = DockStyle.Left;
            panelRouteDescription_EAA.Location = new Point(0, 0);
            panelRouteDescription_EAA.Name = "panelRouteDescription_EAA";
            panelRouteDescription_EAA.Padding = new Padding(5);
            panelRouteDescription_EAA.Size = new Size(200, 318);
            panelRouteDescription_EAA.TabIndex = 1;
            // 
            // groupBoxRouteDescription_EAA
            // 
            groupBoxRouteDescription_EAA.Controls.Add(groupBox1);
            groupBoxRouteDescription_EAA.Controls.Add(textBoxRouteType_EAA);
            groupBoxRouteDescription_EAA.Controls.Add(textBox4);
            groupBoxRouteDescription_EAA.Controls.Add(textBoxRouteEnd_EAA);
            groupBoxRouteDescription_EAA.Controls.Add(textBoxRouteStart_EAA);
            groupBoxRouteDescription_EAA.Controls.Add(textBoxRouteId_EAA);
            groupBoxRouteDescription_EAA.Dock = DockStyle.Fill;
            groupBoxRouteDescription_EAA.Location = new Point(5, 5);
            groupBoxRouteDescription_EAA.Name = "groupBoxRouteDescription_EAA";
            groupBoxRouteDescription_EAA.Size = new Size(190, 308);
            groupBoxRouteDescription_EAA.TabIndex = 0;
            groupBoxRouteDescription_EAA.TabStop = false;
            groupBoxRouteDescription_EAA.Text = "Описание";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxRouteTime_EAA);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Время";
            // 
            // textBoxRouteTime_EAA
            // 
            textBoxRouteTime_EAA.BorderStyle = BorderStyle.None;
            textBoxRouteTime_EAA.Dock = DockStyle.Fill;
            textBoxRouteTime_EAA.Location = new Point(3, 19);
            textBoxRouteTime_EAA.Multiline = true;
            textBoxRouteTime_EAA.Name = "textBoxRouteTime_EAA";
            textBoxRouteTime_EAA.ReadOnly = true;
            textBoxRouteTime_EAA.Size = new Size(178, 78);
            textBoxRouteTime_EAA.TabIndex = 5;
            textBoxRouteTime_EAA.Text = "Примерное время ожидания   автобуса - ";
            // 
            // textBoxRouteType_EAA
            // 
            textBoxRouteType_EAA.BorderStyle = BorderStyle.None;
            textBoxRouteType_EAA.Location = new Point(3, 135);
            textBoxRouteType_EAA.Multiline = true;
            textBoxRouteType_EAA.Name = "textBoxRouteType_EAA";
            textBoxRouteType_EAA.ReadOnly = true;
            textBoxRouteType_EAA.Size = new Size(184, 39);
            textBoxRouteType_EAA.TabIndex = 4;
            textBoxRouteType_EAA.Text = "Вид транспорта - ";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(3, 139);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(184, 39);
            textBox4.TabIndex = 3;
            textBox4.Text = "Вид транспорта - ";
            // 
            // textBoxRouteEnd_EAA
            // 
            textBoxRouteEnd_EAA.BorderStyle = BorderStyle.None;
            textBoxRouteEnd_EAA.Location = new Point(3, 90);
            textBoxRouteEnd_EAA.Multiline = true;
            textBoxRouteEnd_EAA.Name = "textBoxRouteEnd_EAA";
            textBoxRouteEnd_EAA.ReadOnly = true;
            textBoxRouteEnd_EAA.Size = new Size(184, 39);
            textBoxRouteEnd_EAA.TabIndex = 2;
            textBoxRouteEnd_EAA.Text = "Конечная остановка - ";
            // 
            // textBoxRouteStart_EAA
            // 
            textBoxRouteStart_EAA.BorderStyle = BorderStyle.None;
            textBoxRouteStart_EAA.Location = new Point(3, 51);
            textBoxRouteStart_EAA.Multiline = true;
            textBoxRouteStart_EAA.Name = "textBoxRouteStart_EAA";
            textBoxRouteStart_EAA.ReadOnly = true;
            textBoxRouteStart_EAA.Size = new Size(184, 37);
            textBoxRouteStart_EAA.TabIndex = 1;
            textBoxRouteStart_EAA.Text = "Начальная остановка - ";
            // 
            // textBoxRouteId_EAA
            // 
            textBoxRouteId_EAA.BorderStyle = BorderStyle.None;
            textBoxRouteId_EAA.Location = new Point(3, 22);
            textBoxRouteId_EAA.Multiline = true;
            textBoxRouteId_EAA.Name = "textBoxRouteId_EAA";
            textBoxRouteId_EAA.ReadOnly = true;
            textBoxRouteId_EAA.Size = new Size(184, 23);
            textBoxRouteId_EAA.TabIndex = 0;
            textBoxRouteId_EAA.Text = "Номер маршрута -";
            // 
            // panelRouteImage_EAA
            // 
            panelRouteImage_EAA.Controls.Add(pictureBoxRoute_EAA);
            panelRouteImage_EAA.Location = new Point(200, 0);
            panelRouteImage_EAA.Name = "panelRouteImage_EAA";
            panelRouteImage_EAA.Padding = new Padding(5);
            panelRouteImage_EAA.Size = new Size(223, 159);
            panelRouteImage_EAA.TabIndex = 2;
            // 
            // pictureBoxRoute_EAA
            // 
            pictureBoxRoute_EAA.Dock = DockStyle.Fill;
            pictureBoxRoute_EAA.ErrorImage = null;
            pictureBoxRoute_EAA.Location = new Point(5, 5);
            pictureBoxRoute_EAA.Name = "pictureBoxRoute_EAA";
            pictureBoxRoute_EAA.Size = new Size(213, 149);
            pictureBoxRoute_EAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRoute_EAA.TabIndex = 0;
            pictureBoxRoute_EAA.TabStop = false;
            // 
            // panelRouteStops_EAA
            // 
            panelRouteStops_EAA.Controls.Add(groupBoxRouteList_EAA);
            panelRouteStops_EAA.Dock = DockStyle.Bottom;
            panelRouteStops_EAA.Location = new Point(200, 160);
            panelRouteStops_EAA.Name = "panelRouteStops_EAA";
            panelRouteStops_EAA.Padding = new Padding(5);
            panelRouteStops_EAA.Size = new Size(223, 158);
            panelRouteStops_EAA.TabIndex = 3;
            // 
            // groupBoxRouteList_EAA
            // 
            groupBoxRouteList_EAA.Controls.Add(flowLayoutPanel_EAA);
            groupBoxRouteList_EAA.Dock = DockStyle.Fill;
            groupBoxRouteList_EAA.Location = new Point(5, 5);
            groupBoxRouteList_EAA.Name = "groupBoxRouteList_EAA";
            groupBoxRouteList_EAA.Size = new Size(213, 148);
            groupBoxRouteList_EAA.TabIndex = 0;
            groupBoxRouteList_EAA.TabStop = false;
            groupBoxRouteList_EAA.Text = "Остановки";
            // 
            // flowLayoutPanel_EAA
            // 
            flowLayoutPanel_EAA.Dock = DockStyle.Fill;
            flowLayoutPanel_EAA.Location = new Point(3, 19);
            flowLayoutPanel_EAA.Name = "flowLayoutPanel_EAA";
            flowLayoutPanel_EAA.Size = new Size(207, 126);
            flowLayoutPanel_EAA.TabIndex = 4;
            // 
            // FormRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 318);
            Controls.Add(panelRouteStops_EAA);
            Controls.Add(panelRouteImage_EAA);
            Controls.Add(panelRouteDescription_EAA);
            MinimumSize = new Size(439, 357);
            Name = "FormRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormRoute_Load;
            panelRouteDescription_EAA.ResumeLayout(false);
            groupBoxRouteDescription_EAA.ResumeLayout(false);
            groupBoxRouteDescription_EAA.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRouteImage_EAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_EAA).EndInit();
            panelRouteStops_EAA.ResumeLayout(false);
            groupBoxRouteList_EAA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelRouteDescription_EAA;
        private GroupBox groupBoxRouteDescription_EAA;
        private Panel panelRouteImage_EAA;
        private PictureBox pictureBoxRoute_EAA;
        private GroupBox groupBox1;
        private TextBox textBoxRouteTime_EAA;
        private TextBox textBoxRouteType_EAA;
        private TextBox textBox4;
        private TextBox textBoxRouteEnd_EAA;
        private TextBox textBoxRouteStart_EAA;
        private TextBox textBoxRouteId_EAA;
        private Panel panelRouteStops_EAA;
        private GroupBox groupBoxRouteList_EAA;
        private FlowLayoutPanel flowLayoutPanel_EAA;
    }
}