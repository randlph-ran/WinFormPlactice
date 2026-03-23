namespace WinFormPlactice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuBG = new System.Windows.Forms.PictureBox();
            this.SeatNoLabel = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CallStaffButton = new System.Windows.Forms.Button();
            this.FoodMenu02 = new System.Windows.Forms.PictureBox();
            this.FoodMenu03 = new System.Windows.Forms.PictureBox();
            this.FoodMenu04 = new System.Windows.Forms.PictureBox();
            this.FoodMenu05 = new System.Windows.Forms.PictureBox();
            this.TotalYenLabel = new System.Windows.Forms.Label();
            this.MenuTab1 = new System.Windows.Forms.Button();
            this.MenuTab2 = new System.Windows.Forms.Button();
            this.MenuTab3 = new System.Windows.Forms.Button();
            this.MenuTab4 = new System.Windows.Forms.Button();
            this.MenuTab5 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Menu01Label = new System.Windows.Forms.Label();
            this.Menu02Label = new System.Windows.Forms.Label();
            this.Menu03Label = new System.Windows.Forms.Label();
            this.Menu04Label = new System.Windows.Forms.Label();
            this.Menu05Label = new System.Windows.Forms.Label();
            this.MenuName = new System.Windows.Forms.TextBox();
            this.NowOrderButton = new System.Windows.Forms.Button();
            this.OrderedListButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FoodMenu01 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBG
            // 
            this.MenuBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuBG.BackgroundImage")));
            this.MenuBG.Location = new System.Drawing.Point(-8, 67);
            this.MenuBG.Name = "MenuBG";
            this.MenuBG.Size = new System.Drawing.Size(913, 512);
            this.MenuBG.TabIndex = 7;
            this.MenuBG.TabStop = false;
            // 
            // SeatNoLabel
            // 
            this.SeatNoLabel.AutoSize = true;
            this.SeatNoLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SeatNoLabel.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SeatNoLabel.Location = new System.Drawing.Point(27, 606);
            this.SeatNoLabel.Name = "SeatNoLabel";
            this.SeatNoLabel.Size = new System.Drawing.Size(209, 55);
            this.SeatNoLabel.TabIndex = 10;
            this.SeatNoLabel.Text = "席番号９９";
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 12;
            this.OrderList.Location = new System.Drawing.Point(911, 107);
            this.OrderList.Name = "OrderList";
            this.OrderList.ScrollAlwaysVisible = true;
            this.OrderList.Size = new System.Drawing.Size(223, 340);
            this.OrderList.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1071, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(943, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "注文カゴの中身";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfirmButton.Location = new System.Drawing.Point(936, 557);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(180, 112);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "注文を　確定する";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // CallStaffButton
            // 
            this.CallStaffButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CallStaffButton.Location = new System.Drawing.Point(757, 585);
            this.CallStaffButton.Name = "CallStaffButton";
            this.CallStaffButton.Size = new System.Drawing.Size(148, 84);
            this.CallStaffButton.TabIndex = 14;
            this.CallStaffButton.Text = "店員を呼ぶ";
            this.CallStaffButton.UseVisualStyleBackColor = true;
            // 
            // FoodMenu02
            // 
            this.FoodMenu02.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu02.Image")));
            this.FoodMenu02.Location = new System.Drawing.Point(310, 126);
            this.FoodMenu02.Name = "FoodMenu02";
            this.FoodMenu02.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu02.TabIndex = 16;
            this.FoodMenu02.TabStop = false;
            // 
            // FoodMenu03
            // 
            this.FoodMenu03.ErrorImage = null;
            this.FoodMenu03.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu03.Image")));
            this.FoodMenu03.InitialImage = null;
            this.FoodMenu03.Location = new System.Drawing.Point(571, 126);
            this.FoodMenu03.Name = "FoodMenu03";
            this.FoodMenu03.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu03.TabIndex = 17;
            this.FoodMenu03.TabStop = false;
            // 
            // FoodMenu04
            // 
            this.FoodMenu04.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu04.Image")));
            this.FoodMenu04.Location = new System.Drawing.Point(44, 305);
            this.FoodMenu04.Name = "FoodMenu04";
            this.FoodMenu04.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu04.TabIndex = 18;
            this.FoodMenu04.TabStop = false;
            // 
            // FoodMenu05
            // 
            this.FoodMenu05.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu05.Image")));
            this.FoodMenu05.Location = new System.Drawing.Point(310, 305);
            this.FoodMenu05.Name = "FoodMenu05";
            this.FoodMenu05.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu05.TabIndex = 19;
            this.FoodMenu05.TabStop = false;
            // 
            // TotalYenLabel
            // 
            this.TotalYenLabel.AutoSize = true;
            this.TotalYenLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalYenLabel.Location = new System.Drawing.Point(410, 491);
            this.TotalYenLabel.Name = "TotalYenLabel";
            this.TotalYenLabel.Size = new System.Drawing.Size(111, 33);
            this.TotalYenLabel.TabIndex = 21;
            this.TotalYenLabel.Text = "合計￥";
            // 
            // MenuTab1
            // 
            this.MenuTab1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab1.BackgroundImage")));
            this.MenuTab1.Location = new System.Drawing.Point(43, 32);
            this.MenuTab1.Name = "MenuTab1";
            this.MenuTab1.Size = new System.Drawing.Size(128, 48);
            this.MenuTab1.TabIndex = 23;
            this.MenuTab1.UseVisualStyleBackColor = true;
            this.MenuTab1.Click += new System.EventHandler(this.MenuTab1_Click);
            // 
            // MenuTab2
            // 
            this.MenuTab2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab2.BackgroundImage")));
            this.MenuTab2.Location = new System.Drawing.Point(163, 32);
            this.MenuTab2.Name = "MenuTab2";
            this.MenuTab2.Size = new System.Drawing.Size(128, 48);
            this.MenuTab2.TabIndex = 24;
            this.MenuTab2.UseVisualStyleBackColor = true;
            this.MenuTab2.Click += new System.EventHandler(this.MenuTab2_Click);
            // 
            // MenuTab3
            // 
            this.MenuTab3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab3.BackgroundImage")));
            this.MenuTab3.Location = new System.Drawing.Point(283, 32);
            this.MenuTab3.Name = "MenuTab3";
            this.MenuTab3.Size = new System.Drawing.Size(128, 48);
            this.MenuTab3.TabIndex = 25;
            this.MenuTab3.UseVisualStyleBackColor = true;
            this.MenuTab3.Click += new System.EventHandler(this.MenuTab3_Click);
            // 
            // MenuTab4
            // 
            this.MenuTab4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab4.BackgroundImage")));
            this.MenuTab4.Location = new System.Drawing.Point(403, 32);
            this.MenuTab4.Name = "MenuTab4";
            this.MenuTab4.Size = new System.Drawing.Size(128, 48);
            this.MenuTab4.TabIndex = 26;
            this.MenuTab4.UseVisualStyleBackColor = true;
            this.MenuTab4.Click += new System.EventHandler(this.MenuTab4_Click);
            // 
            // MenuTab5
            // 
            this.MenuTab5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab5.BackgroundImage")));
            this.MenuTab5.Location = new System.Drawing.Point(523, 32);
            this.MenuTab5.Name = "MenuTab5";
            this.MenuTab5.Size = new System.Drawing.Size(128, 48);
            this.MenuTab5.TabIndex = 27;
            this.MenuTab5.UseVisualStyleBackColor = true;
            this.MenuTab5.Click += new System.EventHandler(this.MenuTab5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown1.Location = new System.Drawing.Point(319, 487);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(33, 36);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(349, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "個";
            // 
            // Menu01Label
            // 
            this.Menu01Label.AutoSize = true;
            this.Menu01Label.Location = new System.Drawing.Point(44, 263);
            this.Menu01Label.Name = "Menu01Label";
            this.Menu01Label.Size = new System.Drawing.Size(35, 12);
            this.Menu01Label.TabIndex = 30;
            this.Menu01Label.Text = "label6";
            // 
            // Menu02Label
            // 
            this.Menu02Label.AutoSize = true;
            this.Menu02Label.Location = new System.Drawing.Point(310, 263);
            this.Menu02Label.Name = "Menu02Label";
            this.Menu02Label.Size = new System.Drawing.Size(35, 12);
            this.Menu02Label.TabIndex = 31;
            this.Menu02Label.Text = "label7";
            // 
            // Menu03Label
            // 
            this.Menu03Label.AutoSize = true;
            this.Menu03Label.Location = new System.Drawing.Point(571, 263);
            this.Menu03Label.Name = "Menu03Label";
            this.Menu03Label.Size = new System.Drawing.Size(35, 12);
            this.Menu03Label.TabIndex = 32;
            this.Menu03Label.Text = "label8";
            // 
            // Menu04Label
            // 
            this.Menu04Label.AutoSize = true;
            this.Menu04Label.Location = new System.Drawing.Point(44, 444);
            this.Menu04Label.Name = "Menu04Label";
            this.Menu04Label.Size = new System.Drawing.Size(35, 12);
            this.Menu04Label.TabIndex = 33;
            this.Menu04Label.Text = "label9";
            // 
            // Menu05Label
            // 
            this.Menu05Label.AutoSize = true;
            this.Menu05Label.Location = new System.Drawing.Point(310, 444);
            this.Menu05Label.Name = "Menu05Label";
            this.Menu05Label.Size = new System.Drawing.Size(41, 12);
            this.Menu05Label.TabIndex = 34;
            this.Menu05Label.Text = "label10";
            // 
            // MenuName
            // 
            this.MenuName.BackColor = System.Drawing.SystemColors.Info;
            this.MenuName.Enabled = false;
            this.MenuName.Font = new System.Drawing.Font("UD デジタル 教科書体 NP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuName.Location = new System.Drawing.Point(53, 487);
            this.MenuName.Multiline = true;
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(266, 36);
            this.MenuName.TabIndex = 35;
            this.MenuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NowOrderButton
            // 
            this.NowOrderButton.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NowOrderButton.Location = new System.Drawing.Point(725, 461);
            this.NowOrderButton.Name = "NowOrderButton";
            this.NowOrderButton.Size = new System.Drawing.Size(142, 77);
            this.NowOrderButton.TabIndex = 36;
            this.NowOrderButton.Text = "注文";
            this.NowOrderButton.UseVisualStyleBackColor = true;
            this.NowOrderButton.Visible = false;
            // 
            // OrderedListButton
            // 
            this.OrderedListButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderedListButton.Location = new System.Drawing.Point(947, 461);
            this.OrderedListButton.Name = "OrderedListButton";
            this.OrderedListButton.Size = new System.Drawing.Size(169, 90);
            this.OrderedListButton.TabIndex = 37;
            this.OrderedListButton.Text = "注文一覧";
            this.OrderedListButton.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceLabel.Location = new System.Drawing.Point(522, 491);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 33);
            this.PriceLabel.TabIndex = 38;
            // 
            // FoodMenu01
            // 
            this.FoodMenu01.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu01.Image")));
            this.FoodMenu01.Location = new System.Drawing.Point(44, 126);
            this.FoodMenu01.Name = "FoodMenu01";
            this.FoodMenu01.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu01.TabIndex = 39;
            this.FoodMenu01.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1139, 681);
            this.Controls.Add(this.Menu04Label);
            this.Controls.Add(this.Menu01Label);
            this.Controls.Add(this.FoodMenu01);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.OrderedListButton);
            this.Controls.Add(this.NowOrderButton);
            this.Controls.Add(this.MenuName);
            this.Controls.Add(this.Menu05Label);
            this.Controls.Add(this.Menu03Label);
            this.Controls.Add(this.Menu02Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.MenuTab5);
            this.Controls.Add(this.MenuTab4);
            this.Controls.Add(this.MenuTab3);
            this.Controls.Add(this.MenuTab2);
            this.Controls.Add(this.MenuTab1);
            this.Controls.Add(this.TotalYenLabel);
            this.Controls.Add(this.FoodMenu05);
            this.Controls.Add(this.FoodMenu04);
            this.Controls.Add(this.FoodMenu03);
            this.Controls.Add(this.FoodMenu02);
            this.Controls.Add(this.CallStaffButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.SeatNoLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.MenuBG);
            this.Name = "Form1";
            this.Text = "ファミレスメニューシミュレータ";
            ((System.ComponentModel.ISupportInitialize)(this.MenuBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MenuBG;
        private System.Windows.Forms.Label SeatNoLabel;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CallStaffButton;
        private System.Windows.Forms.PictureBox FoodMenu02;
        private System.Windows.Forms.PictureBox FoodMenu03;
        private System.Windows.Forms.PictureBox FoodMenu04;
        private System.Windows.Forms.PictureBox FoodMenu05;
        private System.Windows.Forms.Label TotalYenLabel;
        private System.Windows.Forms.Button MenuTab1;
        private System.Windows.Forms.Button MenuTab2;
        private System.Windows.Forms.Button MenuTab3;
        private System.Windows.Forms.Button MenuTab4;
        private System.Windows.Forms.Button MenuTab5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Menu01Label;
        private System.Windows.Forms.Label Menu02Label;
        private System.Windows.Forms.Label Menu03Label;
        private System.Windows.Forms.Label Menu04Label;
        private System.Windows.Forms.Label Menu05Label;
        private System.Windows.Forms.TextBox MenuName;
        private System.Windows.Forms.Button NowOrderButton;
        private System.Windows.Forms.Button OrderedListButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.PictureBox FoodMenu01;
    }
}

