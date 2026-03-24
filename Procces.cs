using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinFormPlactice
{
    internal class Procces
    {
        public class MenuPrice
        {
            public int mID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Img { get; set; }
            public string Thombnail { get; set; }
        }
        public class DataManager
        {
            // 全体からアクセス可能なリスト
            public static List<MenuPrice> LoadCsv(string filePath)
            {
                var menuList = new List<MenuPrice>();

                try
                {
                    // 全ての行を読み込む（1行目はヘッダーと想定して飛ばす）
                    var lines = File.ReadAllLines(filePath).Skip(1);

                    foreach (var line in lines)
                    {
                        var values = line.Split(','); // カンマで分割

                        var user = new MenuPrice
                        {
                            mID = int.Parse(values[0]),
                            Name = values[1],
                            Price = int.Parse(values[2]),
                            Img = values[3],
                            Thombnail = values[4]
                        };

                        menuList.Add(user);
                    }
                    Console.WriteLine("読み込み完了！");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"エラーが発生しました: {ex.Message}");
                    // 例外発生時も空のリストを返す（必要ならここで再スローや null を返す設計に変更）
                }

                return menuList;
            }
        }
    }
}
