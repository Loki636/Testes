using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace Tests
{
    class Discipline:IDiscipline
    {

        int _Id;
        List<Theme> _ListThemes;
        string _NameDiscipline;

        public Discipline()
        {
            ListThemes = new List<Theme>();
        }
        public Discipline(string nameDiscipline)
        {
            _NameDiscipline = nameDiscipline;
            ListThemes = new List<Theme>();
        }

        public void SetName(string name)
        {
            _NameDiscipline = name;
        }

        public string GetName()
        {
            return _NameDiscipline;
        }

        public List<Theme> GetThemes()
        {
            return _ListThemes;
        }

        public void SetThemes(List<Theme> Themes)
        {
            _ListThemes = Themes;
        }

        public List<Theme> ListThemes { get { return _ListThemes; } set { if (value != null) { _ListThemes = value; } } }

        public Theme GetTheme(String NameTheme, IDataBase BaseDB)
        {
            if(NameTheme!=null && NameTheme.Length > 2)
            {
                IDataBase DataBase = BaseDB;
                Theme Theme = (Theme)DataBase.GetTheme(Convert.ToInt32(NameTheme));
                return Theme;
            }
            else
            {
                throw new Exception("Не существует данной темы");
            }
        }

        public Theme GetTheme(String NameTheme)
        {
            if (NameTheme != null && NameTheme.Length > 2)
            {
                Theme theme=(from themik in ListThemes where themik.NameTheme==NameTheme select themik).First();
                return theme;
            }
            else
            {
                throw new Exception("Не существует данной темы");
            }
        }

        public void RemoveTheme(Theme theme)
        {
            if (theme != null)
            {
                ListThemes.Remove(theme);
            }
        }

        public void RemoveTheme(String NameTheme)
        {
            Theme theme = (from themik in ListThemes where themik.NameTheme.Equals(NameTheme) select themik).First();
            ListThemes.Remove(theme);
        }

        public void ChangeNameTheme(string OldNameTheme, string NewNameTheme)
        {
            Theme theme = (from themik in ListThemes where themik.NameTheme.Equals(OldNameTheme) select themik).First();
            theme.ChangeNameTheme(NewNameTheme);
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public int GetId()
        {
            return _Id;
        }

        public void AddTheme(Theme theme)
        {
            _ListThemes.Add(theme);
        }
    }
}
