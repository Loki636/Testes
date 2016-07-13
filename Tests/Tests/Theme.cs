using System;
using System.Collections.Generic;
using System.Linq;
using Tests.Interfaces;

namespace Tests
{
    class Theme
    {
        int _Id;
        List<Test> _CollectionTest;
        String _NameTheme;

        public Theme()
        {
            CollectionTest = new List<Test>();
        }

        public Theme(String Theme)
        {
            NameTheme = Theme;
        }

        public void SetName(string Name)
        {
            _NameTheme = Name;
        }

        public string GetName()
        {
            return _NameTheme;
        }

        public void SetTests(List<Test> CollectionTest)
        {
            _CollectionTest = CollectionTest;
        }

        public List<Test> GetTests()
        {
            return _CollectionTest;
        }

        public List<Test> CollectionTest { get { return _CollectionTest; } set { if (value != null) { _CollectionTest = value; } } }

        public void CheckObject( int index)
        {
            
            if (index < 0 || index >= this.GetCountTests())
            {
                throw new Exception("Индекс теста находится впределах недопустимого значения");
            }
        }

        public int GetCountTests()
        {
            return CollectionTest.Count;
        }

        public Test GetTestForIndex(int IndexTest)
        {
            if(IndexTest<0 || IndexTest > CollectionTest.Count)
            {
                throw new System.Exception("Неверный индекс");
            }
            else
            {
                Test Test = (from test in CollectionTest where test.GetId() == IndexTest select test).FirstOrDefault();
                return Test;
            }
        }

        public String NameTheme { get { return _NameTheme; } set { _NameTheme = value; } }


        public void ChangeNameTheme(String NameTheme)
        {
            this.NameTheme = NameTheme;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public void AddTest(Test test)
        {
            _CollectionTest.Add(test);
        }
    }
}