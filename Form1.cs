using System;
using System.Collections.Generic;
using System.Drawing.Text;
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
        //選択している料理のflag
        static int selectedFoodIndex = 0;
        static bool CallStaff = false;

        //リポジトリをインスタンス化
        // CSVファイルを渡してリポジトリを作る（ファイルの場所はプロジェクトのルートからの相対パスで指定）
        private MenuRepository _repository = new MenuRepository(@"..\..\ShopData.csv");

        private readonly string[] bgImages =
        {
            @"..\..\img\肉料理.jpg",
            @"..\..\img\和食.jpg",
            @"..\..\img\白ベースのサイドメニュー向け背景.jpg",
            @"..\..\img\デザート向けピンク系背景.jpg",
            @"..\..\img\ドリンク向けオレンジ系背景.jpg"
        };               


        public Form1()
        {
            InitializeComponent();
            //メニュー情報リストの作成
            menuPrices = new List<Process.MenuPrice>();

            // LoadAllの呼び出し
            // 返ってきたリストを menuPrices に代入する
            menuPrices = _repository.LoadAll();

            //個数選択表示開始
            numericUpDown1.Value = 1;
            //金額表示の初期化
            TotalYenLabel.Text = "";

            //メニュー表示内の情報処理メソッドの呼び出し
            Menu1Reflesh();
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
        /// メニュータブ（カテゴリ）がクリックされた時の共通処理
        /// </summary>
        private void OnMenuTab_Click(object sender, EventArgs e)
        {
            // 1. 誰が押されたか特定し、Tagから番号（1〜5）を取得
            Control tab = (Control)sender;
            int tabIndex = int.Parse(tab.Tag.ToString());

            // 2. 現在のカテゴリ（menuStatus）を更新
            menuStatus = tabIndex;

            // 3. 画面の初期化と背景の変更
            DispClear();

            // 配列のインデックスは0から始まるので -1 する
            MenuBG.ImageLocation = bgImages[tabIndex - 1];

            // 4. 表示のリフレッシュ
            Menu1Reflesh();
        }

        /*
         * 上記のOnMenuTab_Clickに処理をまとめたため、以下の個別の処理は不要になった
         *

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
        */

        /// <summary>
        /// 料理画像がクリックされた時の共通処理
        /// </summary>
        private void OnMenuImage_Click(object sender, EventArgs e)
        {
            // 1. 「誰が私を呼んだの？」を特定する
            // sender を PictureBox 型として扱う（キャスト）
            PictureBox clickedBox = (PictureBox)sender;

            // 2. そのボタンの「背番号（Tag）」を読み取る
            // Tag に入れた 0～4 の数字を取り出す
            int localIndex = int.Parse(clickedBox.Tag.ToString());

            // 3. 共通の計算を行う
            DispON();
            selectedFoodIndex = (menuStatus - 1) * 5 + localIndex;

            // 4. 表示を更新する
            FoodInfo(localIndex);
        }
        

        /// <summary>
        /// numericボタンで数値切り替えた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)

        {
            //数値を切り替えたときに、合計金額の表示も切り替えるための処理
            TotalYenLabel.Visible = true;

            
            if (menuPrices.Count > selectedFoodIndex)
            {
                // 選択されている料理の情報を取得
                var currentItem = menuPrices[selectedFoodIndex];
                int price = currentItem.Price;
                int qty = (int)numericUpDown1.Value;

                TotalYenLabel.Text = (price * qty).ToString();
            }
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
            TotalOrderPrice.Visible = true;
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
            // 領収書のヘッダーとフッターを追加
            lines.Add("---------------------\n\n領収書\n\n---------------------\n");
            // ListBoxの各項目をリストに追加
            foreach (var item in OrderList.Items)
            {
                lines.Add(item.ToString());
            }
            // 合計金額を追加
            lines.Add("\n\n---------------------\n合計金額: " + TotalOrderPrice.Text + "\n---------------------\n");

            // 2. サウンド再生とメッセージ表示、そしてファイルへの書き出しをまとめて実行
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
                // レシート発行日時を追加
                string nowTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                lines.Add(nowTime);
                lines.Add("---------------------\n");
                File.WriteAllLines(filePath, lines);
                // 3. 注文カゴのクリア
                OrderList.Items.Clear();
                // 4. 合計金額のリセット&表示の更新
                DispClear();
                // 5.合計金額のリセット                
                TotalOrderPrice.Text = "";
                TotalOrderPrice.Visible = false;
            }
            // 5. 出力処理でエラーが発生した場合の例外処理
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました: " + ex.Message);
            }
        }


        private int animeIndex = 0;
        private readonly string[] animeImages = {
            @"..\..\img\sera0.png",
            @"..\..\img\sera1.png",
            @"..\..\img\sera2.png"
        };


        /// <summary>
        /// TimerのTickイベント（タイマーが鳴るたびに呼ばれる）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 次の画像へ（3枚なので 0→1→2→0... とループさせる）
            animeIndex = (animeIndex + 1) % animeImages.Length;
            // PictureBox（例：MainAnimationBox）に画像を表示
            if (CallStaff == true)
            {
                MainAnimationBox.Visible = true;
                MainAnimationBox.SuspendLayout();
                MainAnimationBox.ImageLocation = animeImages[animeIndex];
                MainAnimationBox.ResumeLayout();
            }
            
        }
        /// <summary>
        /// 呼び出しボタンで表示するメッセージ表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CallStaffButton_Click(object sender, EventArgs e)
        {
            using (var player = new SoundPlayer(@"maou_se_chime12.wav"))
            {
                player.Play();
            }
            if(CallStaff == false)
            {
                MessageBox.Show("店員を呼んでいます。\nお手数ですが、もうしばらくお待ちくださいｍ（＿）ｍ", "店員呼び出し");
                CallStaff = true;
            }
            else
            {
                MessageBox.Show("お待たせしました。いかがなさいましたでしょうか？", "店員が状況を確認させていただいております。");
                CallStaff = false;
                MainAnimationBox.Visible = false;
            }            
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
            TotalOrderPrice.Visible = !string.IsNullOrEmpty(TotalOrderPrice.Text);//空なら false、空でないなら true
 
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
            
        }
        /// <summary>
        /// 料理名と値段の表示メソッド
        /// </summary>
        /// <param name="foodInfo"></param>
        public void FoodInfo(int foodInfo)
        {
            // selectedFoodIndexを使えばswitch文なしで1行ですむ
            var item = menuPrices[selectedFoodIndex];
            MenuName.Text = item.Name;
            TotalYenLabel.Text = (item.Price * numericUpDown1.Value).ToString();
            
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
            FoodMenu01.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5].Thumbnail);
            FoodMenu01.ResumeLayout(); //待ち解除
            FoodMenu02.SuspendLayout();
            FoodMenu02.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 1].Thumbnail);
            FoodMenu02.ResumeLayout();
            FoodMenu03.SuspendLayout();
            FoodMenu03.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 2].Thumbnail);
            FoodMenu03.ResumeLayout();
            FoodMenu04.SuspendLayout();
            FoodMenu04.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 3].Thumbnail);
            FoodMenu04.ResumeLayout();
            FoodMenu05.SuspendLayout();
            FoodMenu05.ImageLocation = (@"..\..\img\" + menuPrices[mReflesh * 5 + 4].Thumbnail);
            FoodMenu05.ResumeLayout();
        }
    }
}