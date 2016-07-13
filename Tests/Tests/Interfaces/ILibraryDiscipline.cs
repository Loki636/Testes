using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Interfaces
{
    interface ILibraryDiscipline
    {
        List<Discipline> Disciplines { get; set; }

        void AddDiscipline(Discipline discipline);

        void ChangeDiscipline(String NameDiscipline);

        void RemoveDisciplie(Discipline discipline);

        Discipline GetDiscipline(string NameDiscipline);

        Discipline GetDisciplineForIndex(int IndexDiscipline);
    }
}
