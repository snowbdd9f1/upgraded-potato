using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TYAP_Lab1
{
    public partial class Form1 : Form
    {
        private enum State {H, A, B, AS, BS, ERROR}
  
        public Form1()
        {
            InitializeComponent();
        }

        //AnalyzeString() - анализируем строку
        //Reverse() - переворачиваем строку, так как правая грамматика
        //AdvanceState() - переходим в следующее состояние
        //ValidateString() - проверяем, принадлежит ли языку. Не уверен, что делать с пустой строкой
        //ShowResult() - выводим строку состояний

        private void button1_Click(object sender, EventArgs e)
        {
            AnalyzeString(textBox1.Text);
        }

        private void AnalyzeString(string input)
        {
            string result = "";
            State currentState = State.H;
            input = Reverse(input);
            foreach (char c in input)
            {
               if (currentState != State.ERROR)
               {
                  currentState = AdvanceState(currentState, c);
                  result += currentState.ToString() + "; ";
               }
               else
               {
                  break;
               }
            }

            ValidateString(currentState);
            ShowResult(result);
        }

        //Если я правильно понял, то потому, что у меня правая грамматика, терминалы будет "кушать" справа налево,
        //поэтому для более удобной итерации имеет смысл перевернуть строку
        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private State AdvanceState(State state, char c)
        {
         	State nextState;
            switch (state)
            {
               case State.H:
               {
                  if (c == '0')
                     nextState = State.B;
                  else if (c == '1')
                     nextState = State.A;
                  else
                     nextState = State.ERROR;
                  break;
               }
               case State.A:
               {
                  if (c == '1')
                     nextState = State.BS;
                  else
                     nextState = State.ERROR;
                  break;
               }
               case State.B:
               {
                  if (c == '0')
                     nextState = State.AS;
                  else
                     nextState = State.ERROR;
                  break;
               }
               case State.AS:
               {
                  if (c == '0')
                     nextState = State.A;
                  else if (c == '1')
                     nextState = State.BS;
                  else
                     nextState = State.ERROR;
                  break;
               }
               case State.BS:
               {
                  if (c == '0')
                     nextState = State.AS;
                  else if (c == '1')
                     nextState = State.B;
                  else
                     nextState = State.ERROR;
                  break;
               }
               default:
               {
                  nextState = State.ERROR;
                  break;
            	}
         	}

         	return nextState;
        }

        private void ValidateString(State endState)
        {
            //Если все успешно, и строка кончается на одном из конечных состояний, то она принадлежит языку
            if (endState == State.AS || endState == State.BS)
            {
               checkBox1.Checked = true;
            }
            else
            {
               checkBox1.Checked = false;
            }
        }

        private void ShowResult(string result)
        {
            textBox2.Text = result;
        }
    }
}
