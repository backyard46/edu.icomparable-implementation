using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfaceSample
{
    public partial class ComparableSample : Form
    {

        // private List<OverWatchCharacter> charInfo = new List<OverWatchCharacter>();
        private List<OverWatchCharacter> charInfo = new List<OverWatchCharacter>();

        public ComparableSample()
        {
            InitializeComponent();
        }


        /// <summary>
        /// フォームロード時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComparableSample_Load(object sender, EventArgs e)
        {
            // List「charList」にキャラクター情報を格納する。
            charInfo.Add(new OverWatchCharacter("ドゥームフィスト","Doomfist",Roles.Offence));
            charInfo.Add(new OverWatchCharacter("ゲンジ", "Genji", Roles.Offence));
            charInfo.Add(new OverWatchCharacter("マクリー", "McCree", Roles.Offence));
            charInfo.Add(new OverWatchCharacter("ファラ", "Pharah", Roles.Offence));
            charInfo.Add(new OverWatchCharacter("リーパー", "Reaper", Roles.Offence));
            charInfo.Add(new OverWatchCharacter("ソルジャー76", "Soldier:76", Roles.Offence));
            charInfo.Add(new OverWatchCharacter("ソンブラ", "Sombra", Roles.Offence));
            charInfo.Add(new OverWatchCharacter("トレーサー", "Tracer", Roles.Offence));
            charInfo.Add(new OverWatchCharacter("バスティオン", "Bastion", Roles.Defense));
            charInfo.Add(new OverWatchCharacter("ハンゾー", "Hanzo", Roles.Defense));
            charInfo.Add(new OverWatchCharacter("ジャンクラット", "Hunkrat", Roles.Defense));
            charInfo.Add(new OverWatchCharacter("メイ", "Mei", Roles.Defense));
            charInfo.Add(new OverWatchCharacter("トールビョーン", "Torbjörn", Roles.Defense));
            charInfo.Add(new OverWatchCharacter("ウィドウメーカー", "Widowmaker", Roles.Defense));
            charInfo.Add(new OverWatchCharacter("ディーヴァ", "D.Va", Roles.Tank));
            charInfo.Add(new OverWatchCharacter("オリーサ", "Orisa", Roles.Tank));
            charInfo.Add(new OverWatchCharacter("ラインハルト", "Reinhardt", Roles.Tank));
            charInfo.Add(new OverWatchCharacter("ロードホッグ", "Roadhog", Roles.Tank));
            charInfo.Add(new OverWatchCharacter("ウィンストン", "Winston", Roles.Tank));
            charInfo.Add(new OverWatchCharacter("ザリア", "Zarya", Roles.Tank));
            charInfo.Add(new OverWatchCharacter("アナ", "Ana", Roles.Support));
            charInfo.Add(new OverWatchCharacter("ブリギッテ", "Brigitte", Roles.Support));
            charInfo.Add(new OverWatchCharacter("ルシオ", "Lúcio", Roles.Support));
            charInfo.Add(new OverWatchCharacter("マーシー", "Mercy", Roles.Support));
            charInfo.Add(new OverWatchCharacter("モイラ", "Moira", Roles.Support));
            charInfo.Add(new OverWatchCharacter("シンメトラ", "Symmetra", Roles.Support));
            charInfo.Add(new OverWatchCharacter("ゼニヤッタ", "Zenyatta", Roles.Support));

            // リストボックスに設定。表示項目は「CharacterFullName」プロパティを使うよう設定。
            listCharacters.DataSource = charInfo;
            listCharacters.DisplayMember = "CharacterFullName";
        }

        /// <summary>
        /// 並べ替えボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSort_Click(object sender, EventArgs e)
        {
            // ソート実行
            charInfo.Sort();
            // 再表示
            listCharacters.DataSource = null;
            listCharacters.DataSource = charInfo;
            listCharacters.DisplayMember = "CharacterFullName";
        }
    }
}
