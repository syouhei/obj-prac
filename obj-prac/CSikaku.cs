using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    /**CZukeiを継承。clacが必要*/
    class CSikaku : CZukei
    {
        /**コンストラクタ*/
        public CSikaku()
        {
            // 種類を四角形にする
            type = TYPE.SHIKAKU;
        }

        /** 四角形を作成*/
        public static void instantiate()
        {
            we.Add(new CSikaku());
        }

        /**計算*/
        protected override string clac()
        {
            return "四角形：底辺" + teihen + " 高さ" + takasa + "=" + (takasa * teihen);
        }
    }
}
