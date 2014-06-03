namespace socket_debug
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.port_box = new System.Windows.Forms.TextBox();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.connectbt = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.send_bt = new System.Windows.Forms.Button();
            this.sdbox = new System.Windows.Forms.TextBox();
            this.recbox = new System.Windows.Forms.TextBox();
            this.sdishex = new System.Windows.Forms.CheckBox();
            this.reishex = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "PORT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "IP:";
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(261, 11);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(48, 21);
            this.port_box.TabIndex = 18;
            this.port_box.Text = "8080";
            // 
            // ip_box
            // 
            this.ip_box.Location = new System.Drawing.Point(108, 9);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(100, 21);
            this.ip_box.TabIndex = 17;
            this.ip_box.Text = "192.168.16.254";
            // 
            // connectbt
            // 
            this.connectbt.Location = new System.Drawing.Point(315, 9);
            this.connectbt.Name = "connectbt";
            this.connectbt.Size = new System.Drawing.Size(75, 23);
            this.connectbt.TabIndex = 21;
            this.connectbt.Text = "Connect";
            this.connectbt.UseVisualStyleBackColor = true;
            this.connectbt.Click += new System.EventHandler(this.connectbt_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(396, 14);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(41, 12);
            this.status.TabIndex = 22;
            this.status.Text = "Status";
            // 
            // send_bt
            // 
            this.send_bt.Location = new System.Drawing.Point(220, 252);
            this.send_bt.Name = "send_bt";
            this.send_bt.Size = new System.Drawing.Size(75, 23);
            this.send_bt.TabIndex = 30;
            this.send_bt.Text = "Send";
            this.send_bt.UseVisualStyleBackColor = true;
            this.send_bt.Click += new System.EventHandler(this.send_bt_Click);
            // 
            // sdbox
            // 
            this.sdbox.Location = new System.Drawing.Point(32, 89);
            this.sdbox.Multiline = true;
            this.sdbox.Name = "sdbox";
            this.sdbox.Size = new System.Drawing.Size(223, 144);
            this.sdbox.TabIndex = 31;
            // 
            // recbox
            // 
            this.recbox.Location = new System.Drawing.Point(261, 89);
            this.recbox.Multiline = true;
            this.recbox.Name = "recbox";
            this.recbox.Size = new System.Drawing.Size(223, 144);
            this.recbox.TabIndex = 32;
            // 
            // sdishex
            // 
            this.sdishex.AutoSize = true;
            this.sdishex.Location = new System.Drawing.Point(35, 67);
            this.sdishex.Name = "sdishex";
            this.sdishex.Size = new System.Drawing.Size(72, 16);
            this.sdishex.TabIndex = 33;
            this.sdishex.Text = "十六进制";
            this.sdishex.UseVisualStyleBackColor = true;
            this.sdishex.CheckedChanged += new System.EventHandler(this.sdishex_CheckedChanged);
            // 
            // reishex
            // 
            this.reishex.AutoSize = true;
            this.reishex.Location = new System.Drawing.Point(261, 67);
            this.reishex.Name = "reishex";
            this.reishex.Size = new System.Drawing.Size(72, 16);
            this.reishex.TabIndex = 34;
            this.reishex.Text = "十六进制";
            this.reishex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 300);
            this.Controls.Add(this.reishex);
            this.Controls.Add(this.sdishex);
            this.Controls.Add(this.recbox);
            this.Controls.Add(this.sdbox);
            this.Controls.Add(this.send_bt);
            this.Controls.Add(this.status);
            this.Controls.Add(this.connectbt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.ip_box);
            this.Name = "Form1";
            this.Text = "Socket_debug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Button connectbt;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button send_bt;
        private System.Windows.Forms.TextBox sdbox;
        private System.Windows.Forms.TextBox recbox;
        private System.Windows.Forms.CheckBox sdishex;
        private System.Windows.Forms.CheckBox reishex;
    }
}

