﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_241213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //MessageBox.Show("안녕하세요?");

            /*
             텍스트 박스에 메시지 출력
             */
            // textBox_print.Text = "이것은\r\n멀티라인\r\n텍스트박스\r\n인데요.";

            // ctrl + k + c 블럭 전체 주석 처리
            // ctrl + k + u 블럭 전체 주석 해제

            #region 241213
            //241213
            //byte theNumberOfStudent = 30;
            //short fiveHourToSecond= 18000;
            //int moneyOfDream_dollar = 2000000000;
            //float myFatherHeight_cm = 174.8f;
            //double incomeTaxPercent= 3.3;
            //decimal grossDomesticProduct_korea = 105400000000000;

            //textBox_print.Text = theNumberOfStudent.GetType().ToString();
            //textBox_print.Text += " theNumberOfStudent: " + theNumberOfStudent.ToString() + "\r\n";
            //textBox_print.Text += fiveHourToSecond.GetType();
            //textBox_print.Text += " fiveHourToSecond: " + fiveHourToSecond.ToString() + "\r\n";
            //textBox_print.Text += moneyOfDream_dollar.GetType();
            //textBox_print.Text += " moneyOfDream: " + moneyOfDream_dollar.ToString() + "\r\n";
            //textBox_print.Text += myFatherHeight_cm.GetType();
            //textBox_print.Text += " myFatherHeight: " + myFatherHeight_cm.ToString() + "\r\n";
            //textBox_print.Text += incomeTaxPercent.GetType();
            //textBox_print.Text += " incomeTax: " + incomeTaxPercent.ToString() + "\r\n";
            //textBox_print.Text += grossDomesticProduct_korea.GetType();
            //textBox_print.Text += " grossDomesticProduct: " + grossDomesticProduct_korea.ToString() + "\r\n";
            #endregion

            #region 241217 실습1
            //string[] stringArr = new string[10];
            //stringArr[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            //stringArr[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            //stringArr[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            //stringArr[3] = "그 사람의 그림자는 그랬다".Replace("그", "이").ToString();
            //stringArr[4] = "삼성 갤럭시".Insert(2, " 애플");
            //stringArr[5] = "오늘은 왠지 더 배고프다".Remove(7, 1);
            //string[] tmp = "이름,나이,전화번호".Split(',');
            //stringArr[6] = tmp[0];
            //stringArr[7] = tmp[1];
            //stringArr[8] = tmp[2];
            //stringArr[9] = "우리 나라 만세".Substring(3, 2);
            
            //textBox_print.Text = "";
            //for(int i = 0; i<10; i++)
            //{
            //    textBox_print.Text += stringArr[i] + "\r\n";
            //}
            #endregion


            // 241217 실습2
            string message = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다.-공자";

            // 1 "-공자" 부분 삭제
            int findidx = message.LastIndexOf("-");
            string delete_gongja = message.Remove(findidx, 3);
            textBox_print.Text = delete_gongja + "\r\n";

            // 2 "얼마나", "천천히", "가는지" 단어 각각 나눠서 배열에 저장
            int keyword1_index = message.IndexOf("얼마나");
            int keyword2_index = message.LastIndexOf("가는지");
            string message2 = message.Substring(keyword1_index, (keyword2_index+3) - keyword1_index);
            string[] split = message2.Split(' ');
            for(int i = 0;i < split.Length; i++)
            {
                textBox_print.Text += split[i] + "\r\n";
            }

            // 3 ".", "-" 제거, 공백 문자(" ") ","로 바꾸기
            string remove_dot = message.Remove(message.LastIndexOf('.'),1);
            string remove = remove_dot.Remove(remove_dot.LastIndexOf('-'),1);
            string replace = remove.Replace(' ', ',');
            textBox_print.Text += replace + "\r\n";

        }

      
    }
}
