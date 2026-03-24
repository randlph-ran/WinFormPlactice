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

            int rowCount = menuPrices.Count;
            int columnCount = typeof(Procces.MenuPrice).GetProperties().Length;
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

        private void Menu1Reflesh()
        {
            Menu01Label.Text = menuPrices[0].Name; //デザインで作成したMenu01Labelにファイルから読み込んだ名前を追加
            Menu02Label.Text = menuPrices[1].Name;
            Menu03Label.Text = menuPrices[2].Name;
            Menu04Label.Text = menuPrices[3].Name;
            Menu05Label.Text = menuPrices[4].Name;
            numericUpDown1.Value = 1;
            FoodMenu01.ImageLocation = (@"..\..\img\" + menuPrices[0].Thombnail);
            FoodMenu02.ImageLocation = (@"..\..\img\" + menuPrices[1].Thombnail);
            FoodMenu03.ImageLocation = (@"..\..\img\" + menuPrices[2].Thombnail);
            FoodMenu04.ImageLocation = (@"..\..\img\" + menuPrices[3].Thombnail);
            FoodMenu05.ImageLocation = (@"..\..\img\" + menuPrices[4].Thombnail);
        }


        private void MenuTab1_Click(object sender, System.EventArgs e)
        {
            menuStatus = 1;

            Menu1Reflesh();
        }

        private void MenuTab2_Click(object sender, System.EventArgs e)
        {
            menuStatus = 2;
            Menu1Reflesh();
        }

        private void MenuTab3_Click(object sender, System.EventArgs e)
        {
            menuStatus = 3;
            Menu1Reflesh();
        }

        private void MenuTab4_Click(object sender, System.EventArgs e)
        {
            menuStatus = 4;
            Menu1Reflesh();
        }

        private void MenuTab5_Click(object sender, System.EventArgs e)
        {
            menuStatus = 5;
            Menu1Reflesh();
        }

        private void Menu01Clicked(object sender, System.EventArgs e)
        {
            ReadFromFile();
            var firstItem = menuPrices[0];
            MenuName.Text = firstItem.Name;
            TotalYenLabel.Text = (@"合計￥" + firstItem.Price * numericUpDown1.Value);
        }
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            ReadFromFile();
            var firstItem = menuPrices[0];
            int price = firstItem.Price;     // 価格
            TotalYenLabel.Text = (@"合計￥" + firstItem.Price * numericUpDown1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
