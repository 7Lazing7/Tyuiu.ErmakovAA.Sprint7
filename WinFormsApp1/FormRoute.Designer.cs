namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoute));
            panelRouteDescription_SBI = new Panel();
            groupBoxRouteDescription_SBI = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxRouteTime_SBI = new TextBox();
            textBoxRouteType_SBI = new TextBox();
            textBox4 = new TextBox();
            textBoxRouteEnd_SBI = new TextBox();
            textBoxRouteStart_SBI = new TextBox();
            textBoxRouteId_SBI = new TextBox();
            panelRouteImage_SBI = new Panel();
            pictureBoxRoute_SBI = new PictureBox();
            panelRouteStops_SBI = new Panel();
            groupBoxRouteList_SBI = new GroupBox();
            flowLayoutPanel_SBI = new FlowLayoutPanel();
            panelRouteDescription_SBI.SuspendLayout();
            groupBoxRouteDescription_SBI.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRouteImage_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_SBI).BeginInit();
            panelRouteStops_SBI.SuspendLayout();
            groupBoxRouteList_SBI.SuspendLayout();
            SuspendLayout();
            // 
            // panelRouteDescription_SBI
            // 
            panelRouteDescription_SBI.Controls.Add(groupBoxRouteDescription_SBI);
            panelRouteDescription_SBI.Dock = DockStyle.Left;
            panelRouteDescription_SBI.Location = new Point(0, 0);
            panelRouteDescription_SBI.Name = "panelRouteDescription_SBI";
            panelRouteDescription_SBI.Padding = new Padding(5);
            panelRouteDescription_SBI.Size = new Size(200, 318);
            panelRouteDescription_SBI.TabIndex = 1;
            // 
            // groupBoxRouteDescription_SBI
            // 
            groupBoxRouteDescription_SBI.Controls.Add(groupBox1);
            groupBoxRouteDescription_SBI.Controls.Add(textBoxRouteType_SBI);
            groupBoxRouteDescription_SBI.Controls.Add(textBox4);
            groupBoxRouteDescription_SBI.Controls.Add(textBoxRouteEnd_SBI);
            groupBoxRouteDescription_SBI.Controls.Add(textBoxRouteStart_SBI);
            groupBoxRouteDescription_SBI.Controls.Add(textBoxRouteId_SBI);
            groupBoxRouteDescription_SBI.Dock = DockStyle.Fill;
            groupBoxRouteDescription_SBI.Location = new Point(5, 5);
            groupBoxRouteDescription_SBI.Name = "groupBoxRouteDescription_SBI";
            groupBoxRouteDescription_SBI.Size = new Size(190, 308);
            groupBoxRouteDescription_SBI.TabIndex = 0;
            groupBoxRouteDescription_SBI.TabStop = false;
            groupBoxRouteDescription_SBI.Text = "Описание";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxRouteTime_SBI);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Время";
            // 
            // textBoxRouteTime_SBI
            // 
            textBoxRouteTime_SBI.BorderStyle = BorderStyle.None;
            textBoxRouteTime_SBI.Dock = DockStyle.Fill;
            textBoxRouteTime_SBI.Location = new Point(3, 19);
            textBoxRouteTime_SBI.Multiline = true;
            textBoxRouteTime_SBI.Name = "textBoxRouteTime_SBI";
            textBoxRouteTime_SBI.ReadOnly = true;
            textBoxRouteTime_SBI.Size = new Size(178, 78);
            textBoxRouteTime_SBI.TabIndex = 5;
            textBoxRouteTime_SBI.Text = "Примерное время ожидания автобуса - ";
            // 
            // textBoxRouteType_SBI
            // 
            textBoxRouteType_SBI.BorderStyle = BorderStyle.None;
            textBoxRouteType_SBI.Location = new Point(3, 135);
            textBoxRouteType_SBI.Multiline = true;
            textBoxRouteType_SBI.Name = "textBoxRouteType_SBI";
            textBoxRouteType_SBI.ReadOnly = true;
            textBoxRouteType_SBI.Size = new Size(184, 39);
            textBoxRouteType_SBI.TabIndex = 4;
            textBoxRouteType_SBI.Text = "Вид транспорта - ";
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
            // textBoxRouteEnd_SBI
            // 
            textBoxRouteEnd_SBI.BorderStyle = BorderStyle.None;
            textBoxRouteEnd_SBI.Location = new Point(3, 90);
            textBoxRouteEnd_SBI.Multiline = true;
            textBoxRouteEnd_SBI.Name = "textBoxRouteEnd_SBI";
            textBoxRouteEnd_SBI.ReadOnly = true;
            textBoxRouteEnd_SBI.Size = new Size(184, 39);
            textBoxRouteEnd_SBI.TabIndex = 2;
            textBoxRouteEnd_SBI.Text = "Конечная остановка - ";
            // 
            // textBoxRouteStart_SBI
            // 
            textBoxRouteStart_SBI.BorderStyle = BorderStyle.None;
            textBoxRouteStart_SBI.Location = new Point(3, 51);
            textBoxRouteStart_SBI.Multiline = true;
            textBoxRouteStart_SBI.Name = "textBoxRouteStart_SBI";
            textBoxRouteStart_SBI.ReadOnly = true;
            textBoxRouteStart_SBI.Size = new Size(184, 37);
            textBoxRouteStart_SBI.TabIndex = 1;
            textBoxRouteStart_SBI.Text = "Начальная остановка - ";
            // 
            // textBoxRouteId_SBI
            // 
            textBoxRouteId_SBI.BorderStyle = BorderStyle.None;
            textBoxRouteId_SBI.Location = new Point(3, 22);
            textBoxRouteId_SBI.Multiline = true;
            textBoxRouteId_SBI.Name = "textBoxRouteId_SBI";
            textBoxRouteId_SBI.ReadOnly = true;
            textBoxRouteId_SBI.Size = new Size(184, 23);
            textBoxRouteId_SBI.TabIndex = 0;
            textBoxRouteId_SBI.Text = "Номер маршрута -";
            // 
            // panelRouteImage_SBI
            // 
            panelRouteImage_SBI.Controls.Add(pictureBoxRoute_SBI);
            panelRouteImage_SBI.Location = new Point(200, 0);
            panelRouteImage_SBI.Name = "panelRouteImage_SBI";
            panelRouteImage_SBI.Padding = new Padding(5);
            panelRouteImage_SBI.Size = new Size(223, 159);
            panelRouteImage_SBI.TabIndex = 2;
            // 
            // pictureBoxRoute_SBI
            // 
            pictureBoxRoute_SBI.Dock = DockStyle.Fill;
            pictureBoxRoute_SBI.ErrorImage = (Image)resources.GetObject("pictureBoxRoute_SBI.ErrorImage");
            pictureBoxRoute_SBI.Location = new Point(5, 5);
            pictureBoxRoute_SBI.Name = "pictureBoxRoute_SBI";
            pictureBoxRoute_SBI.Size = new Size(213, 149);
            pictureBoxRoute_SBI.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRoute_SBI.TabIndex = 0;
            pictureBoxRoute_SBI.TabStop = false;
            // 
            // panelRouteStops_SBI
            // 
            panelRouteStops_SBI.Controls.Add(groupBoxRouteList_SBI);
            panelRouteStops_SBI.Dock = DockStyle.Bottom;
            panelRouteStops_SBI.Location = new Point(200, 160);
            panelRouteStops_SBI.Name = "panelRouteStops_SBI";
            panelRouteStops_SBI.Padding = new Padding(5);
            panelRouteStops_SBI.Size = new Size(223, 158);
            panelRouteStops_SBI.TabIndex = 3;
            // 
            // groupBoxRouteList_SBI
            // 
            groupBoxRouteList_SBI.Controls.Add(flowLayoutPanel_SBI);
            groupBoxRouteList_SBI.Dock = DockStyle.Fill;
            groupBoxRouteList_SBI.Location = new Point(5, 5);
            groupBoxRouteList_SBI.Name = "groupBoxRouteList_SBI";
            groupBoxRouteList_SBI.Size = new Size(213, 148);
            groupBoxRouteList_SBI.TabIndex = 0;
            groupBoxRouteList_SBI.TabStop = false;
            groupBoxRouteList_SBI.Text = "Остановки";
            // 
            // flowLayoutPanel_SBI
            // 
            flowLayoutPanel_SBI.Dock = DockStyle.Fill;
            flowLayoutPanel_SBI.Location = new Point(3, 19);
            flowLayoutPanel_SBI.Name = "flowLayoutPanel_SBI";
            flowLayoutPanel_SBI.Size = new Size(207, 126);
            flowLayoutPanel_SBI.TabIndex = 4;
            // 
            // FormRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 318);
            Controls.Add(panelRouteStops_SBI);
            Controls.Add(panelRouteImage_SBI);
            Controls.Add(panelRouteDescription_SBI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(439, 357);
            Name = "FormRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormRoute_Load;
            panelRouteDescription_SBI.ResumeLayout(false);
            groupBoxRouteDescription_SBI.ResumeLayout(false);
            groupBoxRouteDescription_SBI.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRouteImage_SBI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_SBI).EndInit();
            panelRouteStops_SBI.ResumeLayout(false);
            groupBoxRouteList_SBI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelRouteDescription_SBI;
        private GroupBox groupBoxRouteDescription_SBI;
        private Panel panelRouteImage_SBI;
        private PictureBox pictureBoxRoute_SBI;
        private GroupBox groupBox1;
        private TextBox textBoxRouteTime_SBI;
        private TextBox textBoxRouteType_SBI;
        private TextBox textBox4;
        private TextBox textBoxRouteEnd_SBI;
        private TextBox textBoxRouteStart_SBI;
        private TextBox textBoxRouteId_SBI;
        private Panel panelRouteStops_SBI;
        private GroupBox groupBoxRouteList_SBI;
        private FlowLayoutPanel flowLayoutPanel_SBI;
    }
}