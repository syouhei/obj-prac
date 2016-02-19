using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class CZukei
    {
        static Random rand = new Random();
        /** データの種類*/
        enum TYPE
        {
            SHIKAKU,     // 四角形
            SANKAKU     // 三角形
        };
        /** 種類。処理を分けるのに利用する*/
        TYPE type;
        /** 底辺*/
        float teihen;
        /** 高さ*/
        float takasa;

        Form1()
        {
            InitializeComponent();

            // 初期化
            for (int i = 0; i < 5; i++)
            {
                // 四角形の作成
                instantiateShikaku();
                // 三角形の作成
                instantiateSankaku();
            }
        }

        private void instantiateSankaku()
        {
            throw new NotImplementedException();
        }

        private void instantiateShikaku()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
}
