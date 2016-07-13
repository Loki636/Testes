using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    class Question
    {
        int _id;
        List<Answer> _Answers = new List<Answer>();
        List<int> IndexRightAnswers = new List<int>();
        string _question;

        public Question()
        {
        }

        public Question(string question)
        {
            this._question = question;
        }

        public List<Answer> Answers
        {
            get { return _Answers; }
            set { _Answers = value; }
        }

        public string GetText()
        {
            return _question;
        }

        public void SetText(string text)
        {
            _question = text;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public List<Answer> GetAnswers()
        {
            return _Answers;
        }

        public void AddAnswer(Answer answer)
        {
            if (!IsThisAnswer(answer))
            {
                Answers.Add(answer);
            }
        }

        public void SetAnswers(List<Answer> answers)
        {
            for (int count = 0; count < answers.Count; count++)
            {
                if (!IsThisAnswer(answers[count]))
                {
                    Answers.Add(answers[count]);
                }
            }
        }

        public bool IsThisAnswer(Answer answer)
        {
            int Count = (from answr in Answers where answr.GetText() == answer.GetText() select answr).Count();
            if (Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangeQuestion(string NewQuestion)
        {
            if (NewQuestion != null || NewQuestion.Length > 3)
            {
                _question = NewQuestion;
            }
        }

        public void ChangeAnswer(int Index, string Answer)
        {
            if (Index > 0 && Index < Answers.Count - 1)
            {
                Answers[Index].SetText(Answer);
            }
        }

        public void RemoveAnswers()
        {
            Answers.Clear();
        }

        public void RemoveAnswer(int Index)
        {
            if (Index > 0 && Index < Answers.Count - 1)
            {
                Answers.RemoveAt(Index);
            }
        }

        public void RemoveAnswer(string Answer)
        {
            Answer _Answer = (from answerik in Answers where answerik.GetText().Equals(Answer) select answerik).First();
            if (_Answer != null)
            {
                Answers.Remove(_Answer);
            }

        }
        public List<int> GetRightAnswers()
        {
            return IndexRightAnswers;
        }
        public void SetRightAnswers(List<int> Index)
        {
            IndexRightAnswers = Index;
        }


    }
}