`using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    class AnswersUser
    {
        Question _Quest = new Question();
        List<int> _AnswerUser = new List<int>();
        public AnswersUser(Question quest, List<int> ind)
        {
            SetQuest(quest);
            SetAnswer(ind);
        }
        public void SetQuest(Question ques)
        {
            _Quest = ques;
        }
        public Question GetUqest()
        {
            return _Quest;
        }
        public void SetAnswer(List<int> ind)
        {
            _AnswerUser = ind;
        }
        public List<int> GetAsnwer()
        {
            return _AnswerUser;
        }
        public int CountRightAnswers()
        {
            return GetUqest().GetRightAnswers().Count;
        }
    }
}
