using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        /// <summary>
        /// イベント：問題開始ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartQuestions_Click(object sender, EventArgs e)
        {
            ExecuteExam();
        }

        /// <summary>
        /// 問題開始
        /// </summary>
        private void ExecuteExam()
        {
            // 問題マスタークラス作成
            QuestionMaster master = new QuestionMaster();

            // 合格判定
            if(master == master)
            {
                // 合格のふるまい
                MessageBox.Show("合格です");
            }
            else
            {
                // 失格のふるまい
                MessageBox.Show("残念でした。失格です。");
            }

        }

        private void GetAllQuestions()
        {

        }
    }
}
