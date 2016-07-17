using System;

namespace Tests
{
    class Student:IUser
    {
        string FirstName;
        string LastName;
        public Student(string firstName,string lastName)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
        }
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }

    }
}