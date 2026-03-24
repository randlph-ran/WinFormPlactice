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

            var menuList = LoadMenuCsv(@"..\..\ShopData.csv");

            foreach (Procces.MenuPrice m in menuList)
            {
                Menu01Label.Text = m.Name; //デザインで作成したMenu01Labelにファイルから読み込んだ名前を追加
                MenuName.Text = m.Name;
                numericUpDown1.Value = 1;
                TotalYenLabel.Text = (@"合計￥" + m.Price * numericUpDown1.Value);
            }
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


        private void MenuTab1_Click(object sender, System.EventArgs e)
        {
            menuStatus = 1;

        }

        private void MenuTab2_Click(object sender, System.EventArgs e)
        {
            menuStatus = 2;
        }

        private void MenuTab3_Click(object sender, System.EventArgs e)
        {
            menuStatus = 3;
        }

        private void MenuTab4_Click(object sender, System.EventArgs e)
        {
            menuStatus = 4;
        }

        private void MenuTab5_Click(object sender, System.EventArgs e)
        {
            menuStatus = 5;
        }

        private void Menu01Clicked(object sender, System.EventArgs e)
        {
            var menuList = LoadMenuCsv(@"..\..\ShopData.csv");

            foreach (Procces.MenuPrice m in menuList)
            {
                Menu01Label.Text = m.Name; //デザインで作成したMenu01Labelにファイルから読み込んだ名前を追加
                MenuName.Text = m.Name;
                numericUpDown1.Value = 1;
                TotalYenLabel.Text = (@"合計￥" + m.Price * numericUpDown1.Value);
            }
        }
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            var menuList = LoadMenuCsv(@"..\..\ShopData.csv");

            foreach (Procces.MenuPrice m in menuList)
            {
                Menu01Label.Text = m.Name; //デザインで作成したMenu01Labelにファイルから読み込んだ名前を追加
                MenuName.Text = m.Name;
                numericUpDown1.Value = 1;
                TotalYenLabel.Text = (@"合計￥" + m.Price * numericUpDown1.Value);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
