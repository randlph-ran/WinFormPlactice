using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinFormPlactice
{
    internal class Procces
    {
        public class MenuPrice
        {
            public int mID { get; set; }
            public string Name {  get; set; }
            public int Price {  get; set; }
            public string Img { get; set; }
            public string Thombnail {  get; set; }
        }
        public static List<MenuPrice> LoadMenuCsv(string filePath)
        {
            // CSV の全行を格納する List
            var list = new List<Procces.MenuPrice>();

            // CSV の全行を UTF-8 で読み込む
            var lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // ---------------------------------------------------------
            // ① 行数チェック（1行もない場合は空のリストを返す）
            // ---------------------------------------------------------
            if (lines.Length <= 1)
                return list;

            // ---------------------------------------------------------
            // ② i = 1 から開始することで「2行目以降」を読み込む
            // ---------------------------------------------------------
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var cols = line.Split(',');

                if (cols.Length < 5)
                    continue;

                var data = new Procces.MenuPrice
                {
                    mID = int.Parse(cols[0]),
                    Name = cols[1],
                    Price = int.Parse(cols[2]),
                    Img = cols[3],
                    Thombnail = cols[4]
                };

                list.Add(data);
            }

            return list;
        }
    }
}
