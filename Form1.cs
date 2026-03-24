using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static WinFormPlactice.Procces;

namespace WinFormPlactice
{
    public partial class Form1 : Form
    {
        List<Procces.MenuPrice> menuPrices;

        static int menuStatus = 0;


        public Form1()
        {
            InitializeComponent();
            menuPrices = new List<Procces.MenuPrice>();

            List<MenuPrice> menuList = DataManager.LoadCsv(@"..\..\ShopData.csv");

            numericUpDown1.Value = 1;
            TotalYenLabel.Text = "0";
            
            ReadFromFile();
            Menu1Reflesh();
        }
        private void ReadFromFile()
        {
            using (System.IO.StreamReader file =
                    new System.IO.StreamReader(@"..\..\ShopData.csv"))
            {
                while (!file.EndOfStream) //ファイルの終端まで
                {
                    string line = file.ReadLine(); //1行読み込んだものを変数lineに代入
                    string[] data = line.Split(','); //lineに読み込んだ文字列を「,」で区切ってdata配列に入れ込む
                    Procces.MenuPrice mPrice = new Procces.MenuPrice();
                    mPrice.mID = int.Parse(data[0]);
                    mPrice.Name = data[1];
                    mPrice.Price = int.Parse(data[2]);
                    mPrice.Thombnail = data[3];
                    mPrice.Img = data[4];
                    menuPrices.Add(mPrice);
                }
            }
        }

        private void Menu1Reflesh() //起動直後、またはMenuTab*を押したときにListの中身を更新
        {
            MenuName.Text = "";
            switch (menuStatus)
            {
                case (0):
                    Menu01Label.Text = menuPrices[0].Name; //デザインで作成したMenu01Labelにファイルから読み込んだ名前を追加
                    Menu02Label.Text = menuPrices[1].Name;
                    Menu03Label.Text = menuPrices[2].Name;
                    Menu04Label.Text = menuPrices[3].Name;
                    Menu05Label.Text = menuPrices[4].Name;
                    FoodMenu01.SuspendLayout();
                    FoodMenu01.ImageLocation = (@"..\..\img\" + menuPrices[0].Thombnail);
                    FoodMenu01.ResumeLayout();
                    FoodMenu02.SuspendLayout();
                    FoodMenu02.ImageLocation = (@"..\..\img\" + menuPrices[1].Thombnail);
                    FoodMenu02.ResumeLayout();
                    FoodMenu03.SuspendLayout();
                    FoodMenu03.ImageLocation = (@"..\..\img\" + menuPrices[2].Thombnail);
                    FoodMenu03.ResumeLayout();
                    FoodMenu04.SuspendLayout();
                    FoodMenu04.ImageLocation = (@"..\..\img\" + menuPrices[3].Thombnail);
                    FoodMenu04.ResumeLayout();
                    FoodMenu05.SuspendLayout();
                    FoodMenu05.ImageLocation = (@"..\..\img\" + menuPrices[4].Thombnail);
                    FoodMenu05.ResumeLayout();
                    break;
                case (1):
                    Menu01Label.Text = menuPrices[0].Name; //デザインで作成したMenu01Labelにファイルから読み込んだ名前を追加
                    Menu02Label.Text = menuPrices[1].Name;
                    Menu03Label.Text = menuPrices[2].Name;
                    Menu04Label.Text = menuPrices[3].Name;
                    Menu05Label.Text = menuPrices[4].Name;
                    FoodMenu01.SuspendLayout();
                    FoodMenu01.ImageLocation = (@"..\..\img\" + menuPrices[0].Thombnail);
                    FoodMenu01.ResumeLayout();
                    FoodMenu02.SuspendLayout();
                    FoodMenu02.ImageLocation = (@"..\..\img\" + menuPrices[1].Thombnail);
                    FoodMenu02.ResumeLayout();
                    FoodMenu03.SuspendLayout();
                    FoodMenu03.ImageLocation = (@"..\..\img\" + menuPrices[2].Thombnail);
                    FoodMenu03.ResumeLayout();
                    FoodMenu04.SuspendLayout();
                    FoodMenu04.ImageLocation = (@"..\..\img\" + menuPrices[3].Thombnail);
                    FoodMenu04.ResumeLayout();
                    FoodMenu05.SuspendLayout();
                    FoodMenu05.ImageLocation = (@"..\..\img\" + menuPrices[4].Thombnail);
                    FoodMenu05.ResumeLayout();
                    break;
                case (2):
                    Menu01Label.Text = menuPrices[5].Name;
                    Menu02Label.Text = menuPrices[6].Name;
                    Menu03Label.Text = menuPrices[7].Name;
                    Menu04Label.Text = menuPrices[8].Name;
                    Menu05Label.Text = menuPrices[9].Name;
                    FoodMenu01.SuspendLayout();
                    FoodMenu01.ImageLocation = (@"..\..\img\" + menuPrices[5].Thombnail);
                    FoodMenu01.ResumeLayout();
                    FoodMenu02.SuspendLayout();
                    FoodMenu02.ImageLocation = (@"..\..\img\" + menuPrices[6].Thombnail);
                    FoodMenu02.ResumeLayout();
                    FoodMenu03.SuspendLayout();
                    FoodMenu03.ImageLocation = (@"..\..\img\" + menuPrices[7].Thombnail);
                    FoodMenu03.ResumeLayout();
                    FoodMenu04.SuspendLayout();
                    FoodMenu04.ImageLocation = (@"..\..\img\" + menuPrices[8].Thombnail);
                    FoodMenu04.ResumeLayout();
                    FoodMenu05.SuspendLayout();
                    FoodMenu05.ImageLocation = (@"..\..\img\" + menuPrices[9].Thombnail);
                    FoodMenu05.ResumeLayout();
                    break;
                case (3):
                    Menu01Label.Text = menuPrices[10].Name;
                    Menu02Label.Text = menuPrices[11].Name;
                    Menu03Label.Text = menuPrices[12].Name;
                    Menu04Label.Text = menuPrices[13].Name;
                    Menu05Label.Text = menuPrices[14].Name;
                    FoodMenu01.SuspendLayout();
                    FoodMenu01.ImageLocation = (@"..\..\img\" + menuPrices[10].Thombnail);
                    FoodMenu01.ResumeLayout();
                    FoodMenu02.SuspendLayout();
                    FoodMenu02.ImageLocation = (@"..\..\img\" + menuPrices[11].Thombnail);
                    FoodMenu02.ResumeLayout();
                    FoodMenu03.SuspendLayout();
                    FoodMenu03.ImageLocation = (@"..\..\img\" + menuPrices[12].Thombnail);
                    FoodMenu03.ResumeLayout();
                    FoodMenu04.SuspendLayout();
                    FoodMenu04.ImageLocation = (@"..\..\img\" + menuPrices[13].Thombnail);
                    FoodMenu04.ResumeLayout();
                    FoodMenu05.SuspendLayout();
                    FoodMenu05.ImageLocation = (@"..\..\img\" + menuPrices[14].Thombnail);
                    FoodMenu05.ResumeLayout();
                    break;
            }
        }
        private void MenuTab1_Click(object sender, System.EventArgs e)
        {
            menuStatus = 1;
            numericUpDown1.Value = 1;
            TotalYenLabel.Text = "0";
            Menu1Reflesh();
        }

        private void MenuTab2_Click(object sender, System.EventArgs e)
        {
            menuStatus = 2;
            numericUpDown1.Value = 1;
            TotalYenLabel.Text = "0";
            Menu1Reflesh();
        }

        private void MenuTab3_Click(object sender, System.EventArgs e)
        {
            menuStatus = 3;
            numericUpDown1.Value = 1;
            TotalYenLabel.Text = "0";
            Menu1Reflesh();
        }

        private void MenuTab4_Click(object sender, System.EventArgs e)
        {
            menuStatus = 4;
            numericUpDown1.Value = 1;
            TotalYenLabel.Text = "0";
            Menu1Reflesh();
        }

        private void MenuTab5_Click(object sender, System.EventArgs e)
        {
            menuStatus = 5;
            numericUpDown1.Value = 1;
            TotalYenLabel.Text = "0";
            Menu1Reflesh();
        }

        private void Menu01Clicked(object sender, System.EventArgs e)
        {
            ReadFromFile();
            if (menuStatus == 1 || menuStatus == 0)
            {
                var firstItem = menuPrices[0];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if (menuStatus == 2)
            {
                var firstItem = menuPrices[5];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if (menuStatus == 3)
            {
                var firstItem = menuPrices[10];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
        }
        private void FoodMenu02_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            if (menuStatus == 1 || menuStatus == 0)
            {
                var firstItem = menuPrices[1];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if(menuStatus == 2)
            {
                var firstItem = menuPrices[6];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if(menuStatus == 3)
            {
                var firstItem = menuPrices[11];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }

        }
        private void FoodMenu03_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            if (menuStatus == 1 || menuStatus == 0)
            {
                var firstItem = menuPrices[2];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);

            }
            else if (menuStatus == 2)
            {
                var firstItem = menuPrices[7];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if (menuStatus == 3)
            {
                var firstItem = menuPrices[12];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
        }
        private void FoodMenu04_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            if (menuStatus == 1 || menuStatus == 0)
            {
                var firstItem = menuPrices[3];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if (menuStatus == 2)
            {
                var firstItem = menuPrices[8];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if (menuStatus == 3)
            {
                var firstItem = menuPrices[13];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
        }
        private void FoodMenu05_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            if (menuStatus == 1 || menuStatus == 0)
            {
                var firstItem = menuPrices[4];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if (menuStatus == 2)
            {
                var firstItem = menuPrices[9];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
            else if (menuStatus == 3)
            {
                var firstItem = menuPrices[14];
                MenuName.Text = firstItem.Name;
                TotalYenLabel.Text = (@"" + firstItem.Price * numericUpDown1.Value);
            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            ReadFromFile();
            var firstItem = menuPrices[0];
            int price = firstItem.Price;     // 価格

            // 現在の合計値を安全に取得（空や不正値なら 0 とする）
            int currentTotal = 0;
            int.TryParse(TotalYenLabel.Text, out currentTotal);

            // numericUpDown1.Value は decimal なので int に変換
            int qty = (int)numericUpDown1.Value;

            TotalYenLabel.Text = (currentTotal * qty).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }


    }
}

