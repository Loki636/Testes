using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    interface IDataBase
    {
       void CreateFiles();

       void AddQuestion(Question question);

       Question GetQuestion(int Number);

       void RemoveQuestion(Question question);

       void AddAnswer(Answer answer);

       Answer GetAnswer(int Number);

       void RemoveAnswer(Answer answer);

       void AddDiscipline(Discipline discipline);

       Discipline GetDiscipline(int Number);

       void RemoveDiscipline(Discipline discipline);

       void AddTheme(Theme theme);

       Theme GetTheme(int Number);

       void RemoveTheme(Theme theme);

       void AddTest(Test test);

       Test GetTest(int Number);

       void RemoveTest(Test test);
    }
}
