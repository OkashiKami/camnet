namespace Camsnet
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.iptextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xAxis = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yAxis = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.zoomAxis = new System.Windows.Forms.HScrollBar();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.yAxisLabel = new System.Windows.Forms.Label();
            this.xAxisLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetXAxis = new System.Windows.Forms.Button();
            this.resetYAxis = new System.Windows.Forms.Button();
            this.resetZAxis = new System.Windows.Forms.Button();
            this.actionbutton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionIndicator});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(420, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionIndicator
            // 
            this.connectionIndicator.BackColor = System.Drawing.Color.Red;
            this.connectionIndicator.Name = "connectionIndicator";
            this.connectionIndicator.Size = new System.Drawing.Size(10, 17);
            this.connectionIndicator.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // iptextbox
            // 
            this.iptextbox.Enabled = false;
            this.iptextbox.Location = new System.Drawing.Point(77, 10);
            this.iptextbox.Name = "iptextbox";
            this.iptextbox.Size = new System.Drawing.Size(146, 20);
            this.iptextbox.TabIndex = 2;
            this.iptextbox.Text = "000.000.0.00";
            this.iptextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iptextbox.WordWrap = false;
            this.iptextbox.TextChanged += new System.EventHandler(this.iptextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // porttextbox
            // 
            this.porttextbox.Location = new System.Drawing.Point(77, 43);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(146, 20);
            this.porttextbox.TabIndex = 4;
            this.porttextbox.Text = "0000";
            this.porttextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porttextbox.WordWrap = false;
            this.porttextbox.TextChanged += new System.EventHandler(this.porttextbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // xAxis
            // 
            this.xAxis.Location = new System.Drawing.Point(52, 93);
            this.xAxis.Minimum = -100;
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(288, 13);
            this.xAxis.TabIndex = 9;
            this.xAxis.ValueChanged += new System.EventHandler(this.xAxis_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X Axis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y Axis";
            // 
            // yAxis
            // 
            this.yAxis.Location = new System.Drawing.Point(52, 120);
            this.yAxis.Minimum = -100;
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(288, 13);
            this.yAxis.TabIndex = 11;
            this.yAxis.ValueChanged += new System.EventHandler(this.yAxis_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zoom";
            // 
            // zoomAxis
            // 
            this.zoomAxis.Location = new System.Drawing.Point(52, 152);
            this.zoomAxis.Name = "zoomAxis";
            this.zoomAxis.Size = new System.Drawing.Size(288, 13);
            this.zoomAxis.TabIndex = 13;
            this.zoomAxis.ValueChanged += new System.EventHandler(this.zoom_ValueChanged);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(343, 152);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(34, 13);
            this.zoomLabel.TabIndex = 15;
            this.zoomLabel.Text = "Zoom";
            // 
            // yAxisLabel
            // 
            this.yAxisLabel.AutoSize = true;
            this.yAxisLabel.Location = new System.Drawing.Point(343, 120);
            this.yAxisLabel.Name = "yAxisLabel";
            this.yAxisLabel.Size = new System.Drawing.Size(34, 13);
            this.yAxisLabel.TabIndex = 16;
            this.yAxisLabel.Text = "Zoom";
            // 
            // xAxisLabel
            // 
            this.xAxisLabel.AutoSize = true;
            this.xAxisLabel.Location = new System.Drawing.Point(343, 93);
            this.xAxisLabel.Name = "xAxisLabel";
            this.xAxisLabel.Size = new System.Drawing.Size(34, 13);
            this.xAxisLabel.TabIndex = 17;
            this.xAxisLabel.Text = "Zoom";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Tick);
            // 
            // resetXAxis
            // 
            this.resetXAxis.AutoSize = true;
            this.resetXAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetXAxis.Location = new System.Drawing.Point(383, 88);
            this.resetXAxis.Name = "resetXAxis";
            this.resetXAxis.Size = new System.Drawing.Size(25, 23);
            this.resetXAxis.TabIndex = 18;
            this.resetXAxis.Text = "R";
            this.resetXAxis.UseVisualStyleBackColor = true;
            this.resetXAxis.Click += new System.EventHandler(this.resetX);
            // 
            // resetYAxis
            // 
            this.resetYAxis.AutoSize = true;
            this.resetYAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetYAxis.Location = new System.Drawing.Point(383, 115);
            this.resetYAxis.Name = "resetYAxis";
            this.resetYAxis.Size = new System.Drawing.Size(25, 23);
            this.resetYAxis.TabIndex = 19;
            this.resetYAxis.Text = "R";
            this.resetYAxis.UseVisualStyleBackColor = true;
            this.resetYAxis.Click += new System.EventHandler(this.resetY);
            // 
            // resetZAxis
            // 
            this.resetZAxis.AutoSize = true;
            this.resetZAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetZAxis.Location = new System.Drawing.Point(383, 147);
            this.resetZAxis.Name = "resetZAxis";
            this.resetZAxis.Size = new System.Drawing.Size(25, 23);
            this.resetZAxis.TabIndex = 20;
            this.resetZAxis.Text = "R";
            this.resetZAxis.UseVisualStyleBackColor = true;
            this.resetZAxis.Click += new System.EventHandler(this.resetZ);
            // 
            // actionbutton
            // 
            this.actionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.actionbutton.Location = new System.Drawing.Point(171, 237);
            this.actionbutton.Name = "actionbutton";
            this.actionbutton.Size = new System.Drawing.Size(75, 23);
            this.actionbutton.TabIndex = 21;
            this.actionbutton.Text = "Start";
            this.actionbutton.UseVisualStyleBackColor = true;
            this.actionbutton.Click += new System.EventHandler(this.actionbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 285);
            this.Controls.Add(this.actionbutton);
            this.Controls.Add(this.resetZAxis);
            this.Controls.Add(this.resetYAxis);
            this.Controls.Add(this.resetXAxis);
            this.Controls.Add(this.xAxisLabel);
            this.Controls.Add(this.yAxisLabel);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zoomAxis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yAxis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xAxis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.porttextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iptextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iptextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox porttextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HScrollBar xAxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar yAxis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar zoomAxis;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.Label yAxisLabel;
        private System.Windows.Forms.Label xAxisLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetXAxis;
        private System.Windows.Forms.Button resetYAxis;
        private System.Windows.Forms.Button resetZAxis;
        private System.Windows.Forms.Button actionbutton;
    }
}

