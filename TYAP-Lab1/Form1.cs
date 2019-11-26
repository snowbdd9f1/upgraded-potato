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
        private enum State {H, A, B, AS, BS, ERROR, END}
  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalyzeString(textBox1.Text);
        }

        private void AnalyzeString(string input)
        {
            string result = "";
            State currentState = State.H;
            foreach (char c in input)
            {
                if (currentState != State.ERROR && currentState != State.END)
                {
                  currentState = AdvanceState(c, currentState);
                  result += currentState.ToString() + "; ";
                }
                else 
                break;
            }

            if (currentState == State.A || currentState == State.B)
            {
               result += "String does not end with one of the final states";
            }

            ShowResult(result);
        }

        private State AdvanceState(char c, State state)
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

        private void ShowResult(string result)
        {
            textBox2.Text = result;
        }
    }
}
