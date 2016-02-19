using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class CSankaku : CZukei
    {
        /**コンストラクタ*/
        public CSankaku()
        {
            // 種類を四角形にする
            type = TYPE.SHIKAKU;
        }

        /** 四角形を作成*/
        public static void instantiate()
        {
            we.Add(new CSankaku());
        }

        /**計算*/
        protected override string clac()
        {
            return "三角形：底辺" + teihen + " 高さ" + takasa + "=" + (teihen * takasa / 2f);
        }
    }
}
