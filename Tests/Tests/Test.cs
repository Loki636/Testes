using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Test
    {
        int _Id;

        int _Number;

        List<Question> _Questions = new List<Question>();

        public Test()
        {
            
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetNumber(int Number)
        {
            _Number = Number;
        }

        public int GetNumber()
        {
            return _Number;
        }

        public List<Question> GetQuestions()
        {
            return _Questions;
        }

        public void SetQuestions(List<Question> Questions)
        {
            _Questions = Questions;
        }

        public void AddQuestion(Question question)
        {
            _Questions.Add(question);
        }

        public int GetCountQuestion()
        {
            return GetQuestions().Count;
        }
    }
}
