using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormPlactice.Process;
using System.IO;

namespace WinFormPlactice
{
    /// <summary>
    /// アプリケーション内で使用するメニュー項目データをCSVファイルから読み込む機能を提供します。
    /// <備考>このリポジトリは、指定されたCSVファイルからメニュー情報を読み込み、メニュー項目のコレクションとして返します。
    /// ファイルが存在しない場合、または空の場合は、空のリストが返されます。
    /// このクラスは、メニューデータがファイルで外部的に管理され、処理のためにメモリにロードする必要があるシナリオを想定しています。
    /// </summary>
    public class MenuRepository
    {
        private string _filePath; //（CSV）がどこにあるか覚えておく変数

        public MenuRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<Process.MenuPrice> LoadAll()
        {
            var list = new List<Process.MenuPrice>(); // 空のメニューリストを用意する

            // もしファイルが無ければ、空のままリストを返す（エラーで止まらないように）
            if (!File.Exists(_filePath)) return list;

            // ファイルを開いて読み込む準備
            using (var file = new StreamReader(_filePath))
            {
                // ファイルの最後まで1行ずつループ
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine(); // 1行読み込む
                    if (string.IsNullOrWhiteSpace(line)) continue; // 空行なら飛ばす

                    string[] data = line.Split(','); // カンマで区切って配列にする

                    // 読み取った1行分のデータを「MenuPrice（料理1品）」として組み立てる
                    var mPrice = new Process.MenuPrice
                    {
                        mID = int.Parse(data[0]),      // ID
                        Name = data[1],                 // 名前
                        Price = int.Parse(data[2]),     // 価格
                        Thumbnail = data[3],            // サムネイル画像名
                        Img = data[4]                   // 大きい画像名
                    };

                    list.Add(mPrice); // 組み立てた料理をリストに追加する
                }
            }
            return list; // 全部の料理が入ったリストを渡す
        }
    }
}
