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
            this.OrderedListButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FoodMenu01 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.MenuBG.Location = new System.Drawing.Point(-11, 84);
            this.MenuBG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuBG.Name = "MenuBG";
            this.MenuBG.Size = new System.Drawing.Size(1217, 640);
            this.MenuBG.TabIndex = 7;
            this.MenuBG.TabStop = false;
            // 
            // SeatNoLabel
            // 
            this.SeatNoLabel.AutoSize = true;
            this.SeatNoLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SeatNoLabel.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SeatNoLabel.Location = new System.Drawing.Point(36, 758);
            this.SeatNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeatNoLabel.Name = "SeatNoLabel";
            this.SeatNoLabel.Size = new System.Drawing.Size(265, 71);
            this.SeatNoLabel.TabIndex = 10;
            this.SeatNoLabel.Text = "席番号９９";
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 15;
            this.OrderList.Location = new System.Drawing.Point(1215, 134);
            this.OrderList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderList.Name = "OrderList";
            this.OrderList.ScrollAlwaysVisible = true;
            this.OrderList.Size = new System.Drawing.Size(296, 424);
            this.OrderList.TabIndex = 11;
            // 
            // MyOrder
            // 
            this.MyOrder.AutoSize = true;
            this.MyOrder.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MyOrder.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MyOrder.Location = new System.Drawing.Point(1257, 104);
            this.MyOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyOrder.Name = "MyOrder";
            this.MyOrder.Size = new System.Drawing.Size(189, 27);
            this.MyOrder.TabIndex = 13;
            this.MyOrder.Text = "注文カゴの中身";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfirmButton.Location = new System.Drawing.Point(1248, 696);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(240, 140);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "注文を確定する";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // CallStaffButton
            // 
            this.CallStaffButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CallStaffButton.Location = new System.Drawing.Point(1009, 731);
            this.CallStaffButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CallStaffButton.Name = "CallStaffButton";
            this.CallStaffButton.Size = new System.Drawing.Size(197, 105);
            this.CallStaffButton.TabIndex = 14;
            this.CallStaffButton.Text = "店員を呼ぶ";
            this.CallStaffButton.UseVisualStyleBackColor = true;
            // 
            // FoodMenu02
            // 
            this.FoodMenu02.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu02.Image")));
            this.FoodMenu02.Location = new System.Drawing.Point(413, 158);
            this.FoodMenu02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FoodMenu02.Name = "FoodMenu02";
            this.FoodMenu02.Size = new System.Drawing.Size(320, 175);
            this.FoodMenu02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu02.TabIndex = 16;
            this.FoodMenu02.TabStop = false;
            // 
            // FoodMenu03
            // 
            this.FoodMenu03.ErrorImage = null;
            this.FoodMenu03.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu03.Image")));
            this.FoodMenu03.InitialImage = null;
            this.FoodMenu03.Location = new System.Drawing.Point(761, 158);
            this.FoodMenu03.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FoodMenu03.Name = "FoodMenu03";
            this.FoodMenu03.Size = new System.Drawing.Size(320, 175);
            this.FoodMenu03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu03.TabIndex = 17;
            this.FoodMenu03.TabStop = false;
            // 
            // FoodMenu04
            // 
            this.FoodMenu04.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu04.Image")));
            this.FoodMenu04.Location = new System.Drawing.Point(59, 381);
            this.FoodMenu04.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FoodMenu04.Name = "FoodMenu04";
            this.FoodMenu04.Size = new System.Drawing.Size(320, 175);
            this.FoodMenu04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu04.TabIndex = 18;
            this.FoodMenu04.TabStop = false;
            // 
            // FoodMenu05
            // 
            this.FoodMenu05.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu05.Image")));
            this.FoodMenu05.Location = new System.Drawing.Point(413, 381);
            this.FoodMenu05.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FoodMenu05.Name = "FoodMenu05";
            this.FoodMenu05.Size = new System.Drawing.Size(320, 175);
            this.FoodMenu05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu05.TabIndex = 19;
            this.FoodMenu05.TabStop = false;
            // 
            // TotalYenLabel
            // 
            this.TotalYenLabel.AutoSize = true;
            this.TotalYenLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalYenLabel.Location = new System.Drawing.Point(547, 614);
            this.TotalYenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalYenLabel.Name = "TotalYenLabel";
            this.TotalYenLabel.Size = new System.Drawing.Size(137, 40);
            this.TotalYenLabel.TabIndex = 21;
            this.TotalYenLabel.Text = "合計￥";
            // 
            // MenuTab1
            // 
            this.MenuTab1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab1.BackgroundImage")));

            this.MenuTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab1.Location = new System.Drawing.Point(57, 40);
            this.MenuTab1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuTab1.Name = "MenuTab1";
            this.MenuTab1.Size = new System.Drawing.Size(171, 60);
            this.MenuTab1.TabIndex = 23;
            this.MenuTab1.UseVisualStyleBackColor = true;
            this.MenuTab1.Click += new System.EventHandler(this.MenuTab1_Click);
            // 
            // MenuTab2
            // 
            this.MenuTab2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab2.BackgroundImage")));
            this.MenuTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab2.Location = new System.Drawing.Point(217, 40);
            this.MenuTab2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuTab2.Name = "MenuTab2";
            this.MenuTab2.Size = new System.Drawing.Size(171, 60);
            this.MenuTab2.TabIndex = 24;
            this.MenuTab2.UseVisualStyleBackColor = true;
            this.MenuTab2.Click += new System.EventHandler(this.MenuTab2_Click);
            // 
            // MenuTab3
            // 
            this.MenuTab3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab3.BackgroundImage")));
            this.MenuTab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab3.Location = new System.Drawing.Point(377, 40);
            this.MenuTab3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuTab3.Name = "MenuTab3";
            this.MenuTab3.Size = new System.Drawing.Size(171, 60);
            this.MenuTab3.TabIndex = 25;
            this.MenuTab3.UseVisualStyleBackColor = true;
            this.MenuTab3.Click += new System.EventHandler(this.MenuTab3_Click);
            // 
            // MenuTab4
            // 
            this.MenuTab4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab4.BackgroundImage")));
            this.MenuTab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab4.Location = new System.Drawing.Point(537, 40);
            this.MenuTab4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuTab4.Name = "MenuTab4";
            this.MenuTab4.Size = new System.Drawing.Size(171, 60);
            this.MenuTab4.TabIndex = 26;
            this.MenuTab4.UseVisualStyleBackColor = true;
            this.MenuTab4.Click += new System.EventHandler(this.MenuTab4_Click);
            // 
            // MenuTab5
            // 
            this.MenuTab5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuTab5.BackgroundImage")));
            this.MenuTab5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTab5.Location = new System.Drawing.Point(697, 40);
            this.MenuTab5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuTab5.Name = "MenuTab5";
            this.MenuTab5.Size = new System.Drawing.Size(171, 60);
            this.MenuTab5.TabIndex = 27;
            this.MenuTab5.UseVisualStyleBackColor = true;
            this.MenuTab5.Click += new System.EventHandler(this.MenuTab5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown1.Location = new System.Drawing.Point(425, 609);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 43);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.UseWaitCursor = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.BackColor = System.Drawing.SystemColors.Window;
            this.NumLabel.Font = new System.Drawing.Font("MS UI Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumLabel.Location = new System.Drawing.Point(465, 609);
            this.NumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(66, 45);
            this.NumLabel.TabIndex = 29;
            this.NumLabel.Text = "個";
            // 
            // Menu01Label
            // 
            this.Menu01Label.AutoSize = true;
            this.Menu01Label.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu01Label.Location = new System.Drawing.Point(59, 329);
            this.Menu01Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu01Label.Name = "Menu01Label";
            this.Menu01Label.Size = new System.Drawing.Size(236, 27);
            this.Menu01Label.TabIndex = 30;
            this.Menu01Label.Text = "　　　　　　　　";
            // 
            // Menu02Label
            // 
            this.Menu02Label.AutoSize = true;
            this.Menu02Label.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu02Label.Location = new System.Drawing.Point(413, 329);
            this.Menu02Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu02Label.Name = "Menu02Label";
            this.Menu02Label.Size = new System.Drawing.Size(236, 27);
            this.Menu02Label.TabIndex = 31;
            this.Menu02Label.Text = "　　　　　　　　";
            // 
            // Menu03Label
            // 
            this.Menu03Label.AutoSize = true;
            this.Menu03Label.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu03Label.Location = new System.Drawing.Point(761, 329);
            this.Menu03Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu03Label.Name = "Menu03Label";
            this.Menu03Label.Size = new System.Drawing.Size(236, 27);
            this.Menu03Label.TabIndex = 32;
            this.Menu03Label.Text = "　　　　　　　　";
            // 
            // Menu04Label
            // 
            this.Menu04Label.AutoSize = true;
            this.Menu04Label.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu04Label.Location = new System.Drawing.Point(59, 555);
            this.Menu04Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu04Label.Name = "Menu04Label";
            this.Menu04Label.Size = new System.Drawing.Size(236, 27);
            this.Menu04Label.TabIndex = 33;
            this.Menu04Label.Text = "　　　　　　　　";
            // 
            // Menu05Label
            // 
            this.Menu05Label.AutoSize = true;
            this.Menu05Label.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu05Label.Location = new System.Drawing.Point(413, 555);
            this.Menu05Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu05Label.Name = "Menu05Label";
            this.Menu05Label.Size = new System.Drawing.Size(236, 27);
            this.Menu05Label.TabIndex = 34;
            this.Menu05Label.Text = "　　　　　　　　";
            // 
            // MenuName
            // 
            this.MenuName.BackColor = System.Drawing.SystemColors.Info;
            this.MenuName.Enabled = false;
            this.MenuName.Font = new System.Drawing.Font("UD デジタル 教科書体 NP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuName.Location = new System.Drawing.Point(71, 609);
            this.MenuName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuName.Multiline = true;
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(353, 44);
            this.MenuName.TabIndex = 35;
            this.MenuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NowOrderButton
            // 
            this.NowOrderButton.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NowOrderButton.Location = new System.Drawing.Point(967, 576);
            this.NowOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NowOrderButton.Name = "NowOrderButton";
            this.NowOrderButton.Size = new System.Drawing.Size(189, 96);
            this.NowOrderButton.TabIndex = 36;
            this.NowOrderButton.Text = "注文";
            this.NowOrderButton.UseVisualStyleBackColor = true;
            this.NowOrderButton.Visible = false;
            // 
            // OrderedListButton
            // 
            this.OrderedListButton.Font = new System.Drawing.Font("UD デジタル 教科書体 N", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderedListButton.Location = new System.Drawing.Point(1263, 576);
            this.OrderedListButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderedListButton.Name = "OrderedListButton";
            this.OrderedListButton.Size = new System.Drawing.Size(225, 112);
            this.OrderedListButton.TabIndex = 37;
            this.OrderedListButton.Text = "注文一覧";
            this.OrderedListButton.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceLabel.Location = new System.Drawing.Point(696, 614);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 40);
            this.PriceLabel.TabIndex = 38;
            // 
            // FoodMenu01
            // 
            this.FoodMenu01.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenu01.Image")));
            this.FoodMenu01.Location = new System.Drawing.Point(59, 158);
            this.FoodMenu01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FoodMenu01.Name = "FoodMenu01";
            this.FoodMenu01.Size = new System.Drawing.Size(320, 175);
            this.FoodMenu01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodMenu01.TabIndex = 39;
            this.FoodMenu01.TabStop = false;
            this.FoodMenu01.Click += new System.EventHandler(this.Menu01Clicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1519, 845);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button OrderedListButton;
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
    }
}

