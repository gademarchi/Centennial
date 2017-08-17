using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300930749
{
    public class ScoreBoard
    {

        public TextBox _finalScoreTextBox;
        public int _score;
        public int _time;
        public TextBox _timeTextBox;


         public TextBox FinalScoreBox { get; set; }
        public int Score { get; set; }
        public TextBox ScoreTextBox { get; set; }
        public int Time { get; set; }
        public TextBox TimeTextBox { get; set; }


        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            Score = Convert.ToInt32(ScoreTextBox.Text);
            _score = Convert.ToInt32(finalScoreTextBox.Text);
            Time = Convert.ToInt32(TimeTextBox.Text);

        }

        public void UpdateTime()
        {

        }


    }
}