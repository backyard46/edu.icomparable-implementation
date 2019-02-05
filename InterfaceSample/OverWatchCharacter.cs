using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSample
{
    class OverWatchCharacter:IComparable
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="nameEN"></param>
        /// <param name="role"></param>
        public OverWatchCharacter(string name, string nameEN, Roles role)
        {
            _characterName = name;
            _characterNameEN = nameEN;
            _role = role;
        }


        private string _characterName;

        /// <summary>
        /// キャラクター和名。
        /// </summary>
        public string CharacterName
        {
            get { return _characterName; }
            set { _characterName = value; }
        }

        private string _characterNameEN;

        /// <summary>
        /// キャラクター英名。
        /// </summary>
        public string CharacterNameEN
        {
            get { return _characterNameEN; }
            set { _characterNameEN = value; }
        }

        /// <summary>
        /// キャラクターフルネーム。
        /// </summary>
        public string CharacterFullName
        {
            get { return _characterName + "(" + _characterNameEN + " / " + _role.ToString() + ")"; }
        }

        private Roles _role;

        /// <summary>
        /// キャラクターの役割情報。
        /// </summary>
        public Roles Role
        {
            get { return _role; }
            set { _role = value; }
        }

        /// <summary>
        /// Sortメソッドで利用される並べ替え順序判断処理。IComparableに定義されたメソッド。
        /// List.Sortメソッドなどは、収められているインスタンスがIComparableを持っているならば、
        /// このメソッドを使って大小比較を行うようになっている。
        /// </summary>
        /// <remarks>
        /// 引数 obj のインスタンスと、このインスタンスを比較して
        /// 　　objのほうが大きい …… 戻り値 1
        /// 　　objと同じ ……………… 戻り値 0
        /// 　　objのほうが小さい …… 戻り値 -1
        /// を返すように処理を記述する。
        /// </remarks>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            // Object型で渡された引数をOverWatchCharacter
            OverWatchCharacter target = (OverWatchCharacter)obj;

            // 自分自身が持っている情報と、外部から渡された情報を比較して、大小関係を「大きい」「小さい」「等しい」で返す。

            if (string.Compare(target.CharacterName, _characterName) > 0)
            {
                // target.CharacterName < this.CharacterName
                return -1;
            }
            else if (string.Compare(target.CharacterName, _characterName) < 0)
            {
                // target.CharacterName > this.CharacterName
                return 1;
            }
            else
            {
                // target.CharacterName = this.CharacterName
                return 0;
            }

        }

    }
}
