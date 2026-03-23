using System.Windows.Forms;

namespace WinFormPlactice
{
    public partial class Form1 : Form
    {
        int menuStatus = 0;
        public Form1()
        {
            InitializeComponent();
            Procces.MenuRun();


        }

        private void MenuTab1_Click(object sender, System.EventArgs e)
        {
            menuStatus = 0;
        }

        private void MenuTab2_Click(object sender, System.EventArgs e)
        {
            menuStatus = 1;
        }

        private void MenuTab3_Click(object sender, System.EventArgs e)
        {
            menuStatus = 2;
        }

        private void MenuTab4_Click(object sender, System.EventArgs e)
        {
            menuStatus = 3;
        }

        private void MenuTab5_Click(object sender, System.EventArgs e)
        {
            menuStatus = 4;
        }
    }
}
