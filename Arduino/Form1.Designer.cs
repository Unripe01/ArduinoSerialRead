namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
            this.comboBox_RATE = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COM.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.comboBox_COM.Location = new System.Drawing.Point(34, 60);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(157, 39);
            this.comboBox_COM.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label1.Location = new System.Drawing.Point(28, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 31);
            label1.TabIndex = 1;
            label1.Text = "COMポート";
            // 
            // btnHigh
            // 
            this.btnHigh.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHigh.Location = new System.Drawing.Point(31, 149);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(157, 39);
            this.btnHigh.TabIndex = 2;
            this.btnHigh.Text = "High";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLow.Location = new System.Drawing.Point(220, 149);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(157, 39);
            this.btnLow.TabIndex = 2;
            this.btnLow.Text = "Low";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label2.Location = new System.Drawing.Point(25, 115);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(166, 31);
            label2.TabIndex = 1;
            label2.Text = "13番ピンの制御";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label3.Location = new System.Drawing.Point(214, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(197, 31);
            label3.TabIndex = 1;
            label3.Text = "転送レート（bps）";
            // 
            // comboBox_RATE
            // 
            this.comboBox_RATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RATE.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_RATE.FormattingEnabled = true;
            this.comboBox_RATE.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.comboBox_RATE.Location = new System.Drawing.Point(220, 60);
            this.comboBox_RATE.Name = "comboBox_RATE";
            this.comboBox_RATE.Size = new System.Drawing.Size(157, 39);
            this.comboBox_RATE.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 302);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox_RATE);
            this.Controls.Add(this.comboBox_COM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Arduino Uno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.ComboBox comboBox_RATE;
    }
}

