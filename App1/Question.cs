using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    class Answer
    {
        string content;
        bool isGood;
    }

    class Question
    {

        string question;
        List<Answer> answers;

        int Get_Answer_Count()
        {
            return answers.Count;
        }

        List<Answer> Get_Answers()
        {
            return answers;
        }

    }
}