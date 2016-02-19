using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    /**抽象クラスの宣言。CZukeiはnewできない*/
    abstract class CZukei
    {
        /**CZukeiのリスト(配列のようなもの)*/
        protected static List<CZukei> we = new List<CZukei>();

        /** データの種類*/
        protected enum TYPE
        {
            SHIKAKU,     // 四角形
            SANKAKU     // 三角形
        };
        /** 種類。処理を分けるのに利用する*/
        protected TYPE type;
        /** 底辺*/
        protected float teihen;
        /** 高さ*/
        protected float takasa;

        /**コンストラクタ(インスタンスがnewされて生成されたときに実行する初期化処理)*/
        public CZukei()
        {
            // 底辺に1～10の乱数を求める
            teihen = Form1.rand.Next(1, 11);
            // 高さに1～10の乱数を求める
            takasa = Form1.rand.Next(1, 11);
        }

        /**子クラスがcalcを実装する必要がある*/
        protected abstract string clac();

        /**すべてのCZukeiの面積を求めて、文字列を返す*/
        public static string calcAll()
        {
            string ret = "";//戻り値の文字列

            //weから１つずつインスタンスを取り出して、meに入れてループ
            foreach (CZukei me in we)
            {
                ret += me.clac() + "\r\n";
            }
            return ret;
        }
    }
}
