using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace obj_prac
{
    public partial class Form1 : Form
    {
        public static Random rand = new Random();


        /** 初期化*/
        public Form1()
        {
            InitializeComponent();

            // 初期化
            for (int i = 0; i < 5; i++)
            {
                // 四角形の作成
                //instantiateShikaku();
                CSikaku.instantiate();
                // 三角形の作成
                //instantiateSankaku();
                CSankaku.instantiate();
            }
        }

        /** ボタンを押したら種類に応じて面積を求めてTextBox1に表示する*/
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(CZukei.calcAll());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
