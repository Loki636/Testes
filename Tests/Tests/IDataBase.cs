using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public interface IDataBase
    {
       void CreateFiles();

       void AddQuestion(Object Question);

       Object GetQuestion(Object Number);

       void RemoveQuestion(Object Question);

       void AddAnswer(Object Answer);

       Object GetAnswer(Object Number);

       void RemoverAnswer(Object Answer);

       void AddDiscipline(Object Discipline);

       Object GetDiscipline(Object Name);

       void RemoveDiscipline(Object Dicsipline);

       void AddTheme(Object Theme);

       Object GetTheme(Object Name);

       void RemoveTheme(Object Theme);

       void AddTest(Object Test);

       Object GetTest(Object Number);

       void RemoveTest(Object Test);
    }
}
