namespace Tests
{
     class Answer
     {

        int _Id;
        string _Text;

        public Answer()
        {

        }
        public Answer(string Text,int Id)
        {
            _Text = Text;
            _Id = Id;
        }
         
        public void SetId(int Id)
        {
            _Id = Id;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetText(string Text)
        {
            _Text = Text;
        }
        public string GetText()
        {
            return _Text;
        }
    }
}