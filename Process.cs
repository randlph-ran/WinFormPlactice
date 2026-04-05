namespace WinFormPlactice
{
    public class Process
    {
        /// <summary>
        /// メニュー情報のList用クラス
        /// </summary>
        public class MenuPrice
        {
            public int mID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Img { get; set; }
            public string Thumbnail { get; set; }
        }
        /// <summary>
        /// 注文カゴに入れた料理のListBoxに入れる情報用
        /// </summary>
        public class NowOrder
        {
            public string oName;
            public string oNum;
            public string tPrice;
        }

    }
}
