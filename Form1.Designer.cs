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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuBG = new System.Windows.Forms.PictureBox();
            this.SeatNoLabel = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.MyOrder = new System.Windows.Forms.Label();
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
            this.NumLabel = new System.Windows.Forms.Label();
            this.Menu01Label = new System.Windows.Forms.Label();
            this.Menu02Label = new System.Windows.Forms.Label();
            this.Menu03Label = new System.Windows.Forms.Label();
            this.Menu04Label = new System.Windows.Forms.Label();
            this.Menu05Label = new System.Windows.Forms.Label();
            this.MenuName = new System.Windows.Forms.TextBox();
            this.NowOrderButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FoodMenu01 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalOrderPrice = new System.Windows.Forms.TextBox();
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
            this.OrderList.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 18;
            this.OrderList.Location = new System.Drawing.Point(910, 67);
            this.OrderList.Name = "OrderList";
            this.OrderList.ScrollAlwaysVisible = true;
            this.OrderList.Size = new System.Drawing.Size(223, 364);
            this.OrderList.TabIndex = 11;
            // 
            // MyOrder
            // 
            this.MyOrder.AutoSize = true;
            this.MyOrder.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MyOrder.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MyOrder.Location = new System.Drawing.Point(942, 42);
            this.MyOrder.Name = "MyOrder";
            this.MyOrder.Size = new System.Drawing.Size(149, 21);
            this.MyOrder.TabIndex = 13;
            this.MyOrder.Text = "注文カゴの中身";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfirmButton.Location = new System.Drawing.Point(977, 504);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(152, 112);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "注文確定(会計)";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CallStaffButton
            // 
            this.CallStaffButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CallStaffButton.Location = new System.Drawing.Point(757, 596);
            this.CallStaffButton.Name = "CallStaffButton";
            this.CallStaffButton.Size = new System.Drawing.Size(130, 73);
            this.CallStaffButton.TabIndex = 14;
            this.CallStaffButton.Text = "店員を呼ぶ";
            this.CallStaffButton.UseVisualStyleBackColor = true;
            this.CallStaffButton.Click += new System.EventHandler(this.CallStaffButton_Click);
            // 
            // FoodMenu02
            // 
            this.FoodMenu02.Location = new System.Drawing.Point(310, 126);
            this.FoodMenu02.Name = "FoodMenu02";
            this.FoodMenu02.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu02.TabIndex = 16;
            this.FoodMenu02.TabStop = false;
            this.FoodMenu02.Tag = "1";
            this.FoodMenu02.Click += new System.EventHandler(this.OnMenuImage_Click);
            // 
            // FoodMenu03
            // 
            this.FoodMenu03.ErrorImage = null;
            this.FoodMenu03.InitialImage = null;
            this.FoodMenu03.Location = new System.Drawing.Point(569, 126);
            this.FoodMenu03.Name = "FoodMenu03";
            this.FoodMenu03.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu03.TabIndex = 17;
            this.FoodMenu03.TabStop = false;
            this.FoodMenu03.Tag = "2";
            this.FoodMenu03.Click += new System.EventHandler(this.OnMenuImage_Click);
            // 
            // FoodMenu04
            // 
            this.FoodMenu04.Location = new System.Drawing.Point(44, 305);
            this.FoodMenu04.Name = "FoodMenu04";
            this.FoodMenu04.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu04.TabIndex = 18;
            this.FoodMenu04.TabStop = false;
            this.FoodMenu04.Tag = "3";
            this.FoodMenu04.Click += new System.EventHandler(this.OnMenuImage_Click);
            // 
            // FoodMenu05
            // 
            this.FoodMenu05.Location = new System.Drawing.Point(310, 305);
            this.FoodMenu05.Name = "FoodMenu05";
            this.FoodMenu05.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu05.TabIndex = 19;
            this.FoodMenu05.TabStop = false;
            this.FoodMenu05.Tag = "4";
            this.FoodMenu05.Click += new System.EventHandler(this.OnMenuImage_Click);
            // 
            // TotalYenLabel
            // 
            this.TotalYenLabel.AutoSize = true;
            this.TotalYenLabel.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalYenLabel.Location = new System.Drawing.Point(450, 487);
            this.TotalYenLabel.Name = "TotalYenLabel";
            this.TotalYenLabel.Size = new System.Drawing.Size(0, 38);
            this.TotalYenLabel.TabIndex = 21;
            // 
            // MenuTab1
            // 
            this.MenuTab1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab1.BackgroundImage")));
            this.MenuTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab1.Location = new System.Drawing.Point(43, 32);
            this.MenuTab1.Name = "MenuTab1";
            this.MenuTab1.Size = new System.Drawing.Size(128, 48);
            this.MenuTab1.TabIndex = 23;
            this.MenuTab1.Tag = "1";
            this.MenuTab1.UseVisualStyleBackColor = true;
            this.MenuTab1.Click += new System.EventHandler(this.OnMenuTab_Click);
            // 
            // MenuTab2
            // 
            this.MenuTab2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab2.BackgroundImage")));
            this.MenuTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab2.Location = new System.Drawing.Point(163, 32);
            this.MenuTab2.Name = "MenuTab2";
            this.MenuTab2.Size = new System.Drawing.Size(128, 48);
            this.MenuTab2.TabIndex = 24;
            this.MenuTab2.Tag = "2";
            this.MenuTab2.UseVisualStyleBackColor = true;
            this.MenuTab2.Click += new System.EventHandler(this.OnMenuTab_Click);
            // 
            // MenuTab3
            // 
            this.MenuTab3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab3.BackgroundImage")));
            this.MenuTab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab3.Location = new System.Drawing.Point(283, 32);
            this.MenuTab3.Name = "MenuTab3";
            this.MenuTab3.Size = new System.Drawing.Size(128, 48);
            this.MenuTab3.TabIndex = 25;
            this.MenuTab3.Tag = "3";
            this.MenuTab3.UseVisualStyleBackColor = true;
            this.MenuTab3.Click += new System.EventHandler(this.OnMenuTab_Click);
            // 
            // MenuTab4
            // 
            this.MenuTab4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab4.BackgroundImage")));
            this.MenuTab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab4.Location = new System.Drawing.Point(403, 32);
            this.MenuTab4.Name = "MenuTab4";
            this.MenuTab4.Size = new System.Drawing.Size(128, 48);
            this.MenuTab4.TabIndex = 26;
            this.MenuTab4.Tag = "4";
            this.MenuTab4.UseVisualStyleBackColor = true;
            this.MenuTab4.Click += new System.EventHandler(this.OnMenuTab_Click);
            // 
            // MenuTab5
            // 
            this.MenuTab5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab5.BackgroundImage")));
            this.MenuTab5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab5.Location = new System.Drawing.Point(523, 32);
            this.MenuTab5.Name = "MenuTab5";
            this.MenuTab5.Size = new System.Drawing.Size(128, 48);
            this.MenuTab5.TabIndex = 27;
            this.MenuTab5.Tag = "5";
            this.MenuTab5.UseVisualStyleBackColor = true;
            this.MenuTab5.Click += new System.EventHandler(this.OnMenuTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown1.Location = new System.Drawing.Point(316, 486);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(33, 40);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.UseWaitCursor = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.BackColor = System.Drawing.SystemColors.Info;
            this.NumLabel.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumLabel.Location = new System.Drawing.Point(349, 487);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(56, 38);
            this.NumLabel.TabIndex = 29;
            this.NumLabel.Text = "個";
            this.NumLabel.Visible = false;
            // 
            // Menu01Label
            // 
            this.Menu01Label.AutoSize = true;
            this.Menu01Label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu01Label.Location = new System.Drawing.Point(44, 263);
            this.Menu01Label.Name = "Menu01Label";
            this.Menu01Label.Size = new System.Drawing.Size(181, 30);
            this.Menu01Label.TabIndex = 30;
            this.Menu01Label.Text = "　　　　　　　　";
            // 
            // Menu02Label
            // 
            this.Menu02Label.AutoSize = true;
            this.Menu02Label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu02Label.Location = new System.Drawing.Point(310, 263);
            this.Menu02Label.Name = "Menu02Label";
            this.Menu02Label.Size = new System.Drawing.Size(181, 30);
            this.Menu02Label.TabIndex = 31;
            this.Menu02Label.Text = "　　　　　　　　";
            // 
            // Menu03Label
            // 
            this.Menu03Label.AutoSize = true;
            this.Menu03Label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu03Label.Location = new System.Drawing.Point(571, 263);
            this.Menu03Label.Name = "Menu03Label";
            this.Menu03Label.Size = new System.Drawing.Size(181, 30);
            this.Menu03Label.TabIndex = 32;
            this.Menu03Label.Text = "　　　　　　　　";
            // 
            // Menu04Label
            // 
            this.Menu04Label.AutoSize = true;
            this.Menu04Label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu04Label.Location = new System.Drawing.Point(44, 444);
            this.Menu04Label.Name = "Menu04Label";
            this.Menu04Label.Size = new System.Drawing.Size(181, 30);
            this.Menu04Label.TabIndex = 33;
            this.Menu04Label.Text = "　　　　　　　　";
            // 
            // Menu05Label
            // 
            this.Menu05Label.AutoSize = true;
            this.Menu05Label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu05Label.Location = new System.Drawing.Point(310, 444);
            this.Menu05Label.Name = "Menu05Label";
            this.Menu05Label.Size = new System.Drawing.Size(181, 30);
            this.Menu05Label.TabIndex = 34;
            this.Menu05Label.Text = "　　　　　　　　";
            // 
            // MenuName
            // 
            this.MenuName.BackColor = System.Drawing.SystemColors.Info;
            this.MenuName.Enabled = false;
            this.MenuName.Font = new System.Drawing.Font("UD デジタル 教科書体 NP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuName.Location = new System.Drawing.Point(43, 487);
            this.MenuName.Multiline = true;
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(276, 38);
            this.MenuName.TabIndex = 35;
            this.MenuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuName.Visible = false;
            // 
            // NowOrderButton
            // 
            this.NowOrderButton.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NowOrderButton.Location = new System.Drawing.Point(725, 461);
            this.NowOrderButton.Name = "NowOrderButton";
            this.NowOrderButton.Size = new System.Drawing.Size(145, 77);
            this.NowOrderButton.TabIndex = 36;
            this.NowOrderButton.Text = "注文カゴに入れる";
            this.NowOrderButton.UseCompatibleTextRendering = true;
            this.NowOrderButton.UseVisualStyleBackColor = true;
            this.NowOrderButton.Visible = false;
            this.NowOrderButton.Click += new System.EventHandler(this.NowOrderButton_Click);
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
            this.FoodMenu01.Location = new System.Drawing.Point(44, 126);
            this.FoodMenu01.Name = "FoodMenu01";
            this.FoodMenu01.Size = new System.Drawing.Size(240, 140);
            this.FoodMenu01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu01.TabIndex = 39;
            this.FoodMenu01.TabStop = false;
            this.FoodMenu01.Tag = "0";
            this.FoodMenu01.Click += new System.EventHandler(this.OnMenuImage_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalLabel.Location = new System.Drawing.Point(400, 487);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(55, 38);
            this.TotalLabel.TabIndex = 40;
            this.TotalLabel.Text = "￥";
            this.TotalLabel.Visible = false;
            // 
            // TotalOrderPrice
            // 
            this.TotalOrderPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalOrderPrice.Enabled = false;
            this.TotalOrderPrice.Font = new System.Drawing.Font("UD デジタル 教科書体 NP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalOrderPrice.Location = new System.Drawing.Point(910, 461);
            this.TotalOrderPrice.Multiline = true;
            this.TotalOrderPrice.Name = "TotalOrderPrice";
            this.TotalOrderPrice.Size = new System.Drawing.Size(197, 38);
            this.TotalOrderPrice.TabIndex = 41;
            this.TotalOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalOrderPrice.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1139, 676);
            this.Controls.Add(this.TotalOrderPrice);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.Menu04Label);
            this.Controls.Add(this.Menu01Label);
            this.Controls.Add(this.FoodMenu01);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NowOrderButton);
            this.Controls.Add(this.MenuName);
            this.Controls.Add(this.Menu05Label);
            this.Controls.Add(this.Menu03Label);
            this.Controls.Add(this.Menu02Label);
            this.Controls.Add(this.NumLabel);
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
            this.Controls.Add(this.MyOrder);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.SeatNoLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.MenuBG);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label MyOrder;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CallStaffButton;
        private System.Windows.Forms.PictureBox FoodMenu02;
        private System.Windows.Forms.PictureBox FoodMenu03;
        private System.Windows.Forms.PictureBox FoodMenu04;
        private System.Windows.Forms.PictureBox FoodMenu05;
        private System.Windows.Forms.Button MenuTab1;
        private System.Windows.Forms.Button MenuTab2;
        private System.Windows.Forms.Button MenuTab3;
        private System.Windows.Forms.Button MenuTab4;
        private System.Windows.Forms.Button MenuTab5;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Button NowOrderButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.PictureBox FoodMenu01;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label TotalYenLabel;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Label Menu01Label;
        public System.Windows.Forms.Label Menu02Label;
        public System.Windows.Forms.Label Menu03Label;
        public System.Windows.Forms.Label Menu04Label;
        public System.Windows.Forms.Label Menu05Label;
        public System.Windows.Forms.TextBox MenuName;
        public System.Windows.Forms.Label TotalLabel;
        public System.Windows.Forms.TextBox TotalOrderPrice;
    }
}

