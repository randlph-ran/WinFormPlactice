using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace WinFormPlactice
{
    public partial class Form1 : Form
    {
        //メニュー情報リスト
        List<Process.MenuPrice> menuPrices;
        //注文カゴ情報リスト
        List<Process.NowOrder> nowOrders;
        //合計金額表示用変数
        int ePrice = 0;
        //選択しているメニュータブのflag
        static int menuStatus = 1;

        public Form1()
        {
            InitializeComponent();
            //メニュー情報リストの作成
            menuPrices = new List<Process.MenuPrice>();

            //個数選択表示開始
            numericUpDown1.Value = 1;
            //金額表示の初期化
            TotalYenLabel.Text = "";

            //ファイル読み込みメソッドの呼び出し
            ReadFromFile();
            //メニュー表示内の情報処理メソッドの呼び出し
            Menu1Reflesh();
        }

        /// <summary>
        /// csvファイルをdata配列に入れ、ｍPriceリストへ代入するメソッド
        /// </summary>
        private void ReadFromFile()
        {
            using (System.IO.StreamReader file =
                    new System.IO.StreamReader(@"..\..\ShopData.csv"))
            {
                //ファイルの終端まで繰り返し
                while (!file.EndOfStream)
                {
                    //1行読み込んだものを変数lineに代入
                    string line = file.ReadLine();
                    //lineに読み込んだ文字列を「,」で区切ってdata配列に入れ込む
                    string[] data = line.Split(',');
                    //mPriceリストの作成
                    Process.MenuPrice mPrice = new Process.MenuPrice();
                    mPrice.mID = int.Parse(data[0]);
                    mPrice.Name = data[1];
                    mPrice.Price = int.Parse(data[2]);
                    mPrice.Thombnail = data[3];
                    mPrice.Img = data[4];
                    //menuPricesリストにmPriceリストを加える
                    menuPrices.Add(mPrice);
                }
            }
        }

        /// <summary>
        /// 起動直後、または洋食タブを押したときにListの中身を更新
        /// </summary>
        private void Menu1Reflesh()
        {
            MenuName.Text = "";
            switch (menuStatus)
            {
                case (1): //MenuTab1が選択されている状態なので、MenuTab1の内容を表示する
                    RefMethod(menuStatus - 1);
                    break;
                case (2): //MenuTab2が選択されている状態なので、MenuTab2の内容を表示する
                    RefMethod(menuStatus - 1);

                    break;
                case (3): //MenuTab3が選択されている状態なので、MenuTab3の内容を表示する
                    RefMethod(menuStatus - 1);

                    break;
                case (4): //MenuTab4が選択されている状態なので、MenuTab4の内容を表示する
                    RefMethod(menuStatus - 1);

                    break;
                case (5): //MenuTab5が選択されている状態なので、MenuTab4の内容を表示する
                    RefMethod(menuStatus - 1);
                    break;
            }
        }

        /// <summary>
        /// 画面上部の料理カテゴリタブをクリックしたときに料理カテゴリ(menuStatus)を切り替える処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuTab1_Click(object sender, System.EventArgs e)
        {
            menuStatus = 1;
            DispClear();
            MenuBG.ImageLocation = @"..\..\img\肉料理.jpg"; //MenuBGの画像を変更
            Menu1Reflesh();
        }

        private void MenuTab2_Click(object sender, System.EventArgs e)
        {
            menuStatus = 2;
            DispClear();
            MenuBG.ImageLocation = @"..\..\img\和食.jpg"; //MenuBGの画像を変更
            Menu1Reflesh();
        }

        private void MenuTab3_Click(object sender, System.EventArgs e)
        {
            menuStatus = 3;
            DispClear();
            MenuBG.ImageLocation = @"..\..\img\白ベースのサイドメニュー向け背景.jpg"; //MenuBGの画像を変更
            Menu1Reflesh();
        }

        private void MenuTab4_Click(object sender, System.EventArgs e)
        {
            menuStatus = 4;
            DispClear();
            MenuBG.ImageLocation = @"..\..\img\デザート向けピンク系背景.jpg"; //MenuBGの画像を変更
            Menu1Reflesh();
        }

        private void MenuTab5_Click(object sender, System.EventArgs e)
        {
            menuStatus = 5;
            DispClear();
            MenuBG.ImageLocation = @"..\..\img\ドリンク向けオレンジ系背景.jpg"; //MenuBGの画像を変更
            Menu1Reflesh();
        }


        /// <summary>
        /// 料理画像クリック時の処理（1画面5個の料理画像)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu01Clicked(object sender, System.EventArgs e)
        {
            DispON();
            ReadFromFile();
            FoodInfo(0);
        }
        private void FoodMenu02_Click(object sender, EventArgs e)
        {
            DispON();
            ReadFromFile();
            FoodInfo(1);

        }
        private void FoodMenu03_Click(object sender, EventArgs e)
        {
            DispON();
            ReadFromFile();
            FoodInfo(2);
        }
        private void FoodMenu04_Click(object sender, EventArgs e)
        {
            DispON();
            ReadFromFile();
            FoodInfo(3);
        }
        private void FoodMenu05_Click(object sender, EventArgs e)
        {
            DispON();
            ReadFromFile();
            FoodInfo(4);
        }

        /// <summary>
        /// numericボタンで数値切り替えた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            TotalYenLabel.Visible = true;
            ReadFromFile();
            var firstItem = menuPrices[0];
            int price = firstItem.Price;     // 価格

            // 現在の合計値を安全に取得（空や不正値なら 0 にする）
            int currentTotal = 0;
            int.TryParse(TotalYenLabel.Text, out currentTotal);

            // numericUpDown1.Value は decimal なので int に変換
            int qty = (int)numericUpDown1.Value;

            TotalYenLabel.Text = (currentTotal * qty).ToString();
        }
        /// <summary>
        /// 注文カゴListBoxに入れる処理
        /// ここがちょっとわからなくてAI頼りになってる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NowOrderButton_Click(object sender, EventArgs e)
        {
            TotalOrderPrice.Visible = true;
            Process.NowOrder nOrders = new Process.NowOrder();
            nOrders.oName = MenuName.Text;
            nOrders.oNum = numericUpDown1.Value.ToString();
            nOrders.tPrice = TotalYenLabel.Text;

            if (nowOrders == null) nowOrders = new List<Process.NowOrder>();
            nowOrders.Add(nOrders);

            OrderList.Items.Add(nOrders.oName + " " + nOrders.oNum + "個" + " " + nOrders.tPrice + "円");

            int nPrice = int.Parse(nOrders.tPrice);

            ePrice += nPrice;
            TotalOrderPrice.Text = (ePrice.ToString() + "円");
        }

        /// <summary>
        /// 注文確定ボタン
        /// メッセージボックスにメッセージ表示後、＋サウンド再生して注文したものをテキストファイルに出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string filePath = "receipt.txt";

            // 1. ListBoxの全項目を文字列のリストに変換
            List<string> lines = new List<string>();
            lines.Add("---------------------\n\n領収書\n\n---------------------\n");
            foreach (var item in OrderList.Items)
            {
                lines.Add(item.ToString());
            }

            try
            {
                using (var player = new SoundPlayer(@"maou_se_onepoint18.wav"))
                {
                    player.Play();
                }
                // 2. ファイルに一括書き出し（上書き保存）
                MessageBox.Show("ありがとうございました。\nレシートをお受け取り下さい。");
                lines.Add("\n\n---------------------\nご来店ありがとうございました。" +
                    "\n");
                string nowTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                lines.Add(nowTime);
                lines.Add("---------------------\n");
                File.WriteAllLines(filePath, lines);
                OrderList.Items.Clear();
                DispClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました: " + ex.Message);
            }
        }

        /// <summary>
        /// 使うつもりがまったく使わなかったため残っている空のタイマーイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 呼び出しボタンで表示するメッセージ表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CallStaffButton_Click(object sender, EventArgs e)
        {
            using (var player = new SoundPlayer(@"maou_se_chime12.wav"))
            {
                player.Play();
            }

            MessageBox.Show("店員を呼んでいます。\nお手数ですが、もうしばらくお待ちくださいｍ（＿）ｍ", "店員呼び出し");
        }
        /// <summary>
        /// 不要な情報ボックスのOffメソッド
        /// </summary>
        public void DispClear()
        {
            MenuName.Visible = false;
            numericUpDown1.Visible = false;
            TotalYenLabel.Visible = false;
            TotalLabel.Visible = false;
            NumLabel.Visible = false;
            NowOrderButton.Visible = false;
            ConfirmButton.Visible = false;
            TotalOrderPrice.Visible = false;
        }
        /// <summary>
        /// メニュー情報のOnメソッド
        /// </summary>
        public void DispON()
        {
            MenuName.Visible = true;
            numericUpDown1.Visible = true;
            numericUpDown1.Value = 1;
            TotalLabel.Visible = true;
            TotalYenLabel.Visible = true;
            NumLabel.Visible = true;
            NowOrderButton.Visible = true;
            ConfirmButton.Visible = true;
            TotalOrderPrice.Visible = true;
        }
        /// <summary>
        /// 料理名と値段の表示メソッド
        /// </summary>
        /// <param name="foodInfo"></param>
        public void FoodInfo(int foodInfo)
        {
            switch (menuStatus)
            {
                case (0):
                    var firstItem = menuPrices[foodInfo];
                    MenuName.Text = firstItem.Name;
                    TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
                    break;
                case (1):
                    var firstItem1 = menuPrices[foodInfo];
                    MenuName.Text = firstItem1.Name;
                    TotalYenLabel.Text = (@"" + firstItem1.Price * numericUpDown1.Value);
                    break;
                case (2):
                    var firstItem2 = menuPrices[foodInfo + 5];
                    MenuName.Text = firstItem2.Name;
                    TotalYenLabel.Text = (@"" + firstItem2.Price * numericUpDown1.Value);
                    break;
                case (3):
                    var firstItem3 = menuPrices[foodInfo + 10];
                    MenuName.Text = firstItem3.Name;
                    TotalYenLabel.Text = (@"" + firstItem3.Price * numericUpDown1.Value);
                    break;
                case (4):
                    var firstItem4 = menuPrices[foodInfo + 15];
                    MenuName.Text = firstItem4.Name;
                    TotalYenLabel.Text = (@"" + firstItem4.Price * numericUpDown1.Value);
                    break;
                case (5):
                    var firstItem5 = menuPrices[foodInfo + 20];
                    MenuName.Text = firstItem5.Name;
                    TotalYenLabel.Text = (@"" + firstItem5.Price * numericUpDown1.Value);
                    break;
            }
        }
        /// <summary>
        /// タブ切り替え時の各種料理画像とテキスト情報の再表示用メソッド 
        /// </summary>
        /// <param name="mReflesh"></param>
        public void RefMethod(int mReflesh)
        {
            Menu01Label.Text = menuPrices[mReflesh * 5].Name; //デザインで作成したMenu01Labelにファイルから読み込んだ名前を追加
            Menu02Label.Text = menuPrices[mReflesh * 5 + 1].Name;
            Menu03Label.Text = menuPrices[mReflesh * 5 + 2].Name;
            Menu04Label.Text = menuPrices[mReflesh * 5 + 3].Name;
            Menu05Label.Text = menuPrices[mReflesh * 5 + 4].Name;
            FoodMenu01.SuspendLayout(); //いったん画像表示を待つちらつき対策
            FoodMenu01.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5].Thombnail);
            FoodMenu01.ResumeLayout(); //待ち解除
            FoodMenu02.SuspendLayout();
            FoodMenu02.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 1].Thombnail);
            FoodMenu02.ResumeLayout();
            FoodMenu03.SuspendLayout();
            FoodMenu03.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 2].Thombnail);
            FoodMenu03.ResumeLayout();
            FoodMenu04.SuspendLayout();
            FoodMenu04.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 3].Thombnail);
            FoodMenu04.ResumeLayout();
            FoodMenu05.SuspendLayout();
            FoodMenu05.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 4].Thombnail);
            FoodMenu05.ResumeLayout();
        }
    }
}