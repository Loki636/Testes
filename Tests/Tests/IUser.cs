namespace Tests
{
    internal interface IUser
    {
        string GetFirstName();
        string GetLastName();
        void SetLastName(string lastName);
        void SetFirstName(string firstName);
    }
}