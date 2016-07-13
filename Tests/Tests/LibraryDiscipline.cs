using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.Interfaces;

namespace Tester
{
    class LibraryDiscipline : ILibraryDiscipline
    {
        List<Discipline> _Discipline;

        public LibraryDiscipline()
        {
            Disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return _Discipline;
            }

            set
            {
                _Discipline = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            Discipline discip = (from dscp in Disciplines where dscp.NameDiscipline.Equals(discipline.NameDiscipline) select dscp).First();
            if (discip == null)
            {
                Disciplines.Add(discipline);
            }
        }

        public void ChangeDiscipline(string OldNameDiscipline,string NewNameDiscipline)
        {
            if (OldNameDiscipline != null && NewNameDiscipline != null)
            {
                Discipline discp = (from discipline in Disciplines where discipline.NameDiscipline.Equals(OldNameDiscipline) select discipline).First();
                if (discp != null)
                {
                    discp.NameDiscipline = NewNameDiscipline;
                }
            }
        }

        public Discipline GetDiscipline(string NameDiscipline)
        {
            if (NameDiscipline != null )
            {
                Discipline discp = (from discipline in Disciplines where discipline.NameDiscipline.Equals(NameDiscipline) select discipline).First();
                if (discp != null)
                {
                    return discp;
                }
            }
            return null;
        }

        public Discipline GetDisciplineForIndex(int IndexDiscipline)
        {
            if(IndexDiscipline>0 && IndexDiscipline <= Disciplines.Count - 1)
            {
                return Disciplines[IndexDiscipline];
            }
            return null;
        }

        public void RemoveDisciplie(Discipline discipline)
        {
            if (discipline != null)
            {
                Discipline discp = (from disciplinik in Disciplines where disciplinik.NameDiscipline.Equals(discipline.NameDiscipline) select discipline).First();
                if (discp != null)
                {
                    Disciplines.Remove(discipline);
                }
            }
        }
    }
}
