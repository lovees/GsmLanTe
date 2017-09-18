namespace GsmLanTe
{
    partial class GoodsWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsWeb));
            this.WebGoods = new System.Windows.Forms.DataGridView();
            this.sechs = new System.Windows.Forms.TextBox();
            this.searc = new System.Windows.Forms.Button();
            this.Reseta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textsn = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textnum = new System.Windows.Forms.TextBox();
            this.texttien = new System.Windows.Forms.TextBox();
            this.textpreci = new System.Windows.Forms.TextBox();
            this.textvip = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WebGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WebGoods
            // 
            this.WebGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WebGoods.Location = new System.Drawing.Point(1, 42);
            this.WebGoods.Margin = new System.Windows.Forms.Padding(2);
            this.WebGoods.Name = "WebGoods";
            this.WebGoods.RowTemplate.Height = 27;
            this.WebGoods.Size = new System.Drawing.Size(729, 680);
            this.WebGoods.TabIndex = 0;
            this.WebGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WebGoods_CellContentClick);
            // 
            // sechs
            // 
            this.sechs.Location = new System.Drawing.Point(200, 15);
            this.sechs.Name = "sechs";
            this.sechs.Size = new System.Drawing.Size(197, 21);
            this.sechs.TabIndex = 2;
            // 
            // searc
            // 
            this.searc.Location = new System.Drawing.Point(421, 17);
            this.searc.Name = "searc";
            this.searc.Size = new System.Drawing.Size(96, 20);
            this.searc.TabIndex = 18;
            this.searc.Text = "搜  索";
            this.searc.UseVisualStyleBackColor = true;
            this.searc.Click += new System.EventHandler(this.searc_Click);
            // 
            // Reseta
            // 
            this.Reseta.Location = new System.Drawing.Point(532, 16);
            this.Reseta.Name = "Reseta";
            this.Reseta.Size = new System.Drawing.Size(85, 20);
            this.Reseta.TabIndex = 19;
            this.Reseta.Text = "重  载";
            this.Reseta.UseVisualStyleBackColor = true;
            this.Reseta.Click += new System.EventHandler(this.Reseta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "库存：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "店存：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(766, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "单价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(760, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "VIP价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "图片展示：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(735, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // textsn
            // 
            this.textsn.Location = new System.Drawing.Point(807, 54);
            this.textsn.Name = "textsn";
            this.textsn.Size = new System.Drawing.Size(189, 21);
            this.textsn.TabIndex = 28;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(807, 98);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(189, 47);
            this.textname.TabIndex = 29;
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(807, 168);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(189, 21);
            this.textnum.TabIndex = 30;
            // 
            // texttien
            // 
            this.texttien.Location = new System.Drawing.Point(807, 216);
            this.texttien.Name = "texttien";
            this.texttien.Size = new System.Drawing.Size(189, 21);
            this.texttien.TabIndex = 31;
            // 
            // textpreci
            // 
            this.textpreci.Location = new System.Drawing.Point(807, 266);
            this.textpreci.Name = "textpreci";
            this.textpreci.Size = new System.Drawing.Size(189, 21);
            this.textpreci.TabIndex = 32;
            // 
            // textvip
            // 
            this.textvip.Location = new System.Drawing.Point(807, 314);
            this.textvip.Name = "textvip";
            this.textvip.Size = new System.Drawing.Size(189, 21);
            this.textvip.TabIndex = 33;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(637, 17);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 20);
            this.Exit.TabIndex = 34;
            this.Exit.Text = "关 闭";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GoodsWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textvip);
            this.Controls.Add(this.textpreci);
            this.Controls.Add(this.texttien);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textsn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reseta);
            this.Controls.Add(this.searc);
            this.Controls.Add(this.sechs);
            this.Controls.Add(this.WebGoods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoodsWeb";
            this.Text = "蓝特线上价格表";
            this.Load += new System.EventHandler(this.GoodsWeb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WebGoods;
        private System.Windows.Forms.TextBox sechs;
        private System.Windows.Forms.Button searc;
        private System.Windows.Forms.Button Reseta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textsn;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.TextBox texttien;
        private System.Windows.Forms.TextBox textpreci;
        private System.Windows.Forms.TextBox textvip;
        private System.Windows.Forms.Button Exit;
    }
}