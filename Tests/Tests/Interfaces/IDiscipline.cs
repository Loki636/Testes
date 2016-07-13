using System;
using Tests;

namespace Tester
{
     interface IDiscipline
    {
        Theme GetTheme(string NameTheme, IDataBase BaseDB);

        Theme GetTheme(string NameTheme);
    }
}