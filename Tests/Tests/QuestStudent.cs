using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    class QuestStudent
    {
        Student _Student;
        Test _Test;
        String _NameDiscipline;
        String _NameTheme;
        int IndexQestion;
        List<AnswersUser> AnswersUser = new List<AnswersUser>();
        public QuestStudent(Student student, Test test,String discipline,String theme)
        {
            Student = student;
            Test = test;
            NameDiscipline = discipline;
            NameTheme = theme;
        }

        public Student Student { get { return _Student; } set { _Student = value; } }
        public Test Test { get { return _Test; } set { _Test = value; } }
        public String NameDiscipline { get { return _NameDiscipline; } set { _NameDiscipline = value; } }
        public String NameTheme { get { return _NameTheme; } set { _NameTheme = value; } }

        public int CountQestion()
        {
            return Test.GetCountQuestion();
        }

        public bool IsNextQuestion()
        {
            if (IndexQestion < CountQestion())
            {
                return true;
            }
            return false;
        }
        public Question GetQuestion()
        {
            if (IsNextQuestion())
            {
                Question quest=Test.GetQuestions()[IndexQestion];
                IndexQestion++;
                return quest;
            }
            return null;
        }
        public void ResetQuestion()
        {
            if (IndexQestion!=0)
            {
                IndexQestion = 0;
            }
        }

    }
}
