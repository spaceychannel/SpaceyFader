namespace SpaceyFader
{
    partial class SpaceyFader
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.btnOutDevice = new System.Windows.Forms.Button();
            this.lbOutDevice = new System.Windows.Forms.Label();
            this.trackbarHigh1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHigh1 = new System.Windows.Forms.Label();
            this.btnInDevice = new System.Windows.Forms.Button();
            this.lbInDevice = new System.Windows.Forms.Label();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxQue1 = new System.Windows.Forms.CheckBox();
            this.lbLev1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackbarLev1 = new System.Windows.Forms.TrackBar();
            this.lbLow1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackbarLow1 = new System.Windows.Forms.TrackBar();
            this.lbMid1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackbarMid1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxQue2 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbLev2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trackbarLev2 = new System.Windows.Forms.TrackBar();
            this.lbLow2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackbarLow2 = new System.Windows.Forms.TrackBar();
            this.lbMid2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackbarMid2 = new System.Windows.Forms.TrackBar();
            this.trackbarHigh2 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lbHigh2 = new System.Windows.Forms.Label();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnCutin1 = new System.Windows.Forms.Button();
            this.btnCutIn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarHigh1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLev1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarMid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLev2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarMid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarHigh2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOutDevice
            // 
            this.btnOutDevice.Location = new System.Drawing.Point(12, 12);
            this.btnOutDevice.Name = "btnOutDevice";
            this.btnOutDevice.Size = new System.Drawing.Size(110, 30);
            this.btnOutDevice.TabIndex = 0;
            this.btnOutDevice.Text = "出力デバイス";
            this.btnOutDevice.UseVisualStyleBackColor = true;
            this.btnOutDevice.Click += new System.EventHandler(this.btnOutDevice_Click);
            // 
            // lbOutDevice
            // 
            this.lbOutDevice.AutoSize = true;
            this.lbOutDevice.Location = new System.Drawing.Point(127, 20);
            this.lbOutDevice.Name = "lbOutDevice";
            this.lbOutDevice.Size = new System.Drawing.Size(52, 15);
            this.lbOutDevice.TabIndex = 1;
            this.lbOutDevice.Text = "未選択";
            // 
            // trackbarHigh1
            // 
            this.trackbarHigh1.Location = new System.Drawing.Point(55, 20);
            this.trackbarHigh1.Maximum = 127;
            this.trackbarHigh1.Name = "trackbarHigh1";
            this.trackbarHigh1.Size = new System.Drawing.Size(230, 56);
            this.trackbarHigh1.TabIndex = 2;
            this.trackbarHigh1.ValueChanged += new System.EventHandler(this.trackbarHigh1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "High";
            // 
            // lbHigh1
            // 
            this.lbHigh1.AutoSize = true;
            this.lbHigh1.Location = new System.Drawing.Point(291, 35);
            this.lbHigh1.Name = "lbHigh1";
            this.lbHigh1.Size = new System.Drawing.Size(34, 15);
            this.lbHigh1.TabIndex = 4;
            this.lbHigh1.Text = "NaN";
            // 
            // btnInDevice
            // 
            this.btnInDevice.Location = new System.Drawing.Point(12, 54);
            this.btnInDevice.Name = "btnInDevice";
            this.btnInDevice.Size = new System.Drawing.Size(110, 30);
            this.btnInDevice.TabIndex = 5;
            this.btnInDevice.Text = "入力デバイス";
            this.btnInDevice.UseVisualStyleBackColor = true;
            this.btnInDevice.Click += new System.EventHandler(this.btnInDevice_Click);
            // 
            // lbInDevice
            // 
            this.lbInDevice.AutoSize = true;
            this.lbInDevice.Location = new System.Drawing.Point(127, 62);
            this.lbInDevice.Name = "lbInDevice";
            this.lbInDevice.Size = new System.Drawing.Size(52, 15);
            this.lbInDevice.TabIndex = 6;
            this.lbInDevice.Text = "未選択";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(590, 386);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(115, 30);
            this.btnReset2.TabIndex = 7;
            this.btnReset2.Text = "リセット";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboxQue1);
            this.groupBox1.Controls.Add(this.lbLev1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackbarLev1);
            this.groupBox1.Controls.Add(this.lbLow1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackbarLow1);
            this.groupBox1.Controls.Add(this.lbMid1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackbarMid1);
            this.groupBox1.Controls.Add(this.trackbarHigh1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbHigh1);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 285);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deck1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "-Z--X+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "-A--S+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "-Q--W+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "-1--2+";
            // 
            // cboxQue1
            // 
            this.cboxQue1.AutoSize = true;
            this.cboxQue1.Location = new System.Drawing.Point(141, 258);
            this.cboxQue1.Name = "cboxQue1";
            this.cboxQue1.Size = new System.Drawing.Size(72, 19);
            this.cboxQue1.TabIndex = 14;
            this.cboxQue1.Text = "Queue";
            this.cboxQue1.UseVisualStyleBackColor = true;
            this.cboxQue1.CheckedChanged += new System.EventHandler(this.cboxQue1_CheckedChanged);
            // 
            // lbLev1
            // 
            this.lbLev1.AutoSize = true;
            this.lbLev1.Location = new System.Drawing.Point(291, 204);
            this.lbLev1.Name = "lbLev1";
            this.lbLev1.Size = new System.Drawing.Size(15, 15);
            this.lbLev1.TabIndex = 13;
            this.lbLev1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Level";
            // 
            // trackbarLev1
            // 
            this.trackbarLev1.Location = new System.Drawing.Point(55, 195);
            this.trackbarLev1.Maximum = 127;
            this.trackbarLev1.Name = "trackbarLev1";
            this.trackbarLev1.Size = new System.Drawing.Size(230, 56);
            this.trackbarLev1.TabIndex = 11;
            this.trackbarLev1.ValueChanged += new System.EventHandler(this.trackbarLev1_ValueChanged);
            // 
            // lbLow1
            // 
            this.lbLow1.AutoSize = true;
            this.lbLow1.Location = new System.Drawing.Point(291, 135);
            this.lbLow1.Name = "lbLow1";
            this.lbLow1.Size = new System.Drawing.Size(34, 15);
            this.lbLow1.TabIndex = 10;
            this.lbLow1.Text = "NaN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Low";
            // 
            // trackbarLow1
            // 
            this.trackbarLow1.Location = new System.Drawing.Point(55, 130);
            this.trackbarLow1.Maximum = 127;
            this.trackbarLow1.Name = "trackbarLow1";
            this.trackbarLow1.Size = new System.Drawing.Size(230, 56);
            this.trackbarLow1.TabIndex = 8;
            this.trackbarLow1.ValueChanged += new System.EventHandler(this.trackbarLow1_ValueChanged);
            // 
            // lbMid1
            // 
            this.lbMid1.AutoSize = true;
            this.lbMid1.Location = new System.Drawing.Point(291, 85);
            this.lbMid1.Name = "lbMid1";
            this.lbMid1.Size = new System.Drawing.Size(34, 15);
            this.lbMid1.TabIndex = 7;
            this.lbMid1.Text = "NaN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mid";
            // 
            // trackbarMid1
            // 
            this.trackbarMid1.Location = new System.Drawing.Point(55, 75);
            this.trackbarMid1.Maximum = 127;
            this.trackbarMid1.Name = "trackbarMid1";
            this.trackbarMid1.Size = new System.Drawing.Size(230, 56);
            this.trackbarMid1.TabIndex = 5;
            this.trackbarMid1.ValueChanged += new System.EventHandler(this.trackbarMid1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboxQue2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbLev2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.trackbarLev2);
            this.groupBox2.Controls.Add(this.lbLow2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.trackbarLow2);
            this.groupBox2.Controls.Add(this.lbMid2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.trackbarMid2);
            this.groupBox2.Controls.Add(this.trackbarHigh2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbHigh2);
            this.groupBox2.Location = new System.Drawing.Point(370, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 285);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deck2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "-C--V+";
            // 
            // cboxQue2
            // 
            this.cboxQue2.AutoSize = true;
            this.cboxQue2.Location = new System.Drawing.Point(141, 258);
            this.cboxQue2.Name = "cboxQue2";
            this.cboxQue2.Size = new System.Drawing.Size(72, 19);
            this.cboxQue2.TabIndex = 14;
            this.cboxQue2.Text = "Queue";
            this.cboxQue2.UseVisualStyleBackColor = true;
            this.cboxQue2.CheckedChanged += new System.EventHandler(this.cboxQue2_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(149, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "-D--F+";
            // 
            // lbLev2
            // 
            this.lbLev2.AutoSize = true;
            this.lbLev2.Location = new System.Drawing.Point(291, 204);
            this.lbLev2.Name = "lbLev2";
            this.lbLev2.Size = new System.Drawing.Size(15, 15);
            this.lbLev2.TabIndex = 13;
            this.lbLev2.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "-E--R+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Level";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(149, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "-3--4+";
            // 
            // trackbarLev2
            // 
            this.trackbarLev2.Location = new System.Drawing.Point(55, 195);
            this.trackbarLev2.Maximum = 127;
            this.trackbarLev2.Name = "trackbarLev2";
            this.trackbarLev2.Size = new System.Drawing.Size(230, 56);
            this.trackbarLev2.TabIndex = 11;
            this.trackbarLev2.ValueChanged += new System.EventHandler(this.trackbarLev2_ValueChanged);
            // 
            // lbLow2
            // 
            this.lbLow2.AutoSize = true;
            this.lbLow2.Location = new System.Drawing.Point(291, 135);
            this.lbLow2.Name = "lbLow2";
            this.lbLow2.Size = new System.Drawing.Size(34, 15);
            this.lbLow2.TabIndex = 10;
            this.lbLow2.Text = "NaN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Low";
            // 
            // trackbarLow2
            // 
            this.trackbarLow2.Location = new System.Drawing.Point(55, 130);
            this.trackbarLow2.Maximum = 127;
            this.trackbarLow2.Name = "trackbarLow2";
            this.trackbarLow2.Size = new System.Drawing.Size(230, 56);
            this.trackbarLow2.TabIndex = 8;
            this.trackbarLow2.ValueChanged += new System.EventHandler(this.trackbarLow2_ValueChanged);
            // 
            // lbMid2
            // 
            this.lbMid2.AutoSize = true;
            this.lbMid2.Location = new System.Drawing.Point(291, 85);
            this.lbMid2.Name = "lbMid2";
            this.lbMid2.Size = new System.Drawing.Size(34, 15);
            this.lbMid2.TabIndex = 7;
            this.lbMid2.Text = "NaN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mid";
            // 
            // trackbarMid2
            // 
            this.trackbarMid2.Location = new System.Drawing.Point(55, 75);
            this.trackbarMid2.Maximum = 127;
            this.trackbarMid2.Name = "trackbarMid2";
            this.trackbarMid2.Size = new System.Drawing.Size(230, 56);
            this.trackbarMid2.TabIndex = 5;
            this.trackbarMid2.ValueChanged += new System.EventHandler(this.trackbarMid2_ValueChanged);
            // 
            // trackbarHigh2
            // 
            this.trackbarHigh2.Location = new System.Drawing.Point(55, 20);
            this.trackbarHigh2.Maximum = 127;
            this.trackbarHigh2.Name = "trackbarHigh2";
            this.trackbarHigh2.Size = new System.Drawing.Size(230, 56);
            this.trackbarHigh2.TabIndex = 2;
            this.trackbarHigh2.ValueChanged += new System.EventHandler(this.trackbarHigh2_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "High";
            // 
            // lbHigh2
            // 
            this.lbHigh2.AutoSize = true;
            this.lbHigh2.Location = new System.Drawing.Point(291, 35);
            this.lbHigh2.Name = "lbHigh2";
            this.lbHigh2.Size = new System.Drawing.Size(34, 15);
            this.lbHigh2.TabIndex = 4;
            this.lbHigh2.Text = "NaN";
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(233, 386);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(115, 30);
            this.btnReset1.TabIndex = 10;
            this.btnReset1.Text = "リセット";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnCutin1
            // 
            this.btnCutin1.Location = new System.Drawing.Point(103, 386);
            this.btnCutin1.Name = "btnCutin1";
            this.btnCutin1.Size = new System.Drawing.Size(115, 30);
            this.btnCutin1.TabIndex = 11;
            this.btnCutin1.Text = "Cut In";
            this.btnCutin1.UseVisualStyleBackColor = true;
            this.btnCutin1.Click += new System.EventHandler(this.btnCutin1_Click);
            // 
            // btnCutIn2
            // 
            this.btnCutIn2.Location = new System.Drawing.Point(459, 386);
            this.btnCutIn2.Name = "btnCutIn2";
            this.btnCutIn2.Size = new System.Drawing.Size(115, 30);
            this.btnCutIn2.TabIndex = 12;
            this.btnCutIn2.Text = "Cut In";
            this.btnCutIn2.UseVisualStyleBackColor = true;
            this.btnCutIn2.Click += new System.EventHandler(this.btnCutIn2_Click);
            // 
            // SpaceyFader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 428);
            this.Controls.Add(this.btnCutIn2);
            this.Controls.Add(this.btnCutin1);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.lbInDevice);
            this.Controls.Add(this.btnInDevice);
            this.Controls.Add(this.lbOutDevice);
            this.Controls.Add(this.btnOutDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SpaceyFader";
            this.Text = "SpaceyFader";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceyFader_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarHigh1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLev1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarMid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLev2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarMid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarHigh2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutDevice;
        private System.Windows.Forms.Label lbOutDevice;
        private System.Windows.Forms.TrackBar trackbarHigh1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHigh1;
        private System.Windows.Forms.Button btnInDevice;
        private System.Windows.Forms.Label lbInDevice;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackbarMid1;
        private System.Windows.Forms.Label lbLow1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackbarLow1;
        private System.Windows.Forms.Label lbLev1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackbarLev1;
        private System.Windows.Forms.CheckBox cboxQue1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxQue2;
        private System.Windows.Forms.Label lbLev2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackbarLev2;
        private System.Windows.Forms.Label lbLow2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackbarLow2;
        private System.Windows.Forms.Label lbMid2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackbarMid2;
        private System.Windows.Forms.TrackBar trackbarHigh2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbHigh2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnCutin1;
        private System.Windows.Forms.Button btnCutIn2;
    }
}

