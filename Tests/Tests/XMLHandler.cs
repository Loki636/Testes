using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Tests
{
    class XMLHandler : IDataBase
    {
        public XMLHandler()
        {
        }

        public void CreateFiles()
        {
            CreateFile("Questions");
            CreateFile("Answers");
            CreateFile("Disciplines");
            CreateFile("Themes");
            CreateFile("Tests");
        }

        public void AddAnswer(Answer answer)
        {
            XmlDocument Document = new XmlDocument();
            Document.Load("Answers.xml");
            XmlNode MainField = Document.CreateElement("Answer");
            Document.DocumentElement.AppendChild(MainField);

            XmlAttribute attribute = Document.CreateAttribute("Id");
            attribute.Value = (GetNumber("Answers")).ToString();
            MainField.Attributes.Append(attribute);
            XmlNode textOfAnswer = Document.CreateElement("Text");
            textOfAnswer.InnerText = answer.GetText().ToString();
            MainField.AppendChild(textOfAnswer);

            Document.Save("Answers.xml");
        }

        public Answer GetAnswer(int Number)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("Answers.xml");
            XmlElement Root = Doc.DocumentElement;
            Answer answer = new Answer();
            foreach (XmlNode Node in Root)
            {
                foreach (XmlNode childnode in Node.ChildNodes)
                {
                    if (Node.Attributes.GetNamedItem("Id").Value.Equals(Number.ToString()))
                    {
                        if (childnode.Name == "Id")
                        {
                            answer.SetId(Convert.ToInt32(childnode.InnerText));
                        }
                        if (childnode.Name == "Text")
                        {
                            answer.SetText(childnode.InnerText);
                        }
                    }
                }
            }
            return answer;
        }

        public void RemoveAnswer(Answer answer)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Answers.xml");
            XmlElement Root = document.DocumentElement;
            for (int i = 0; i < Root.ChildNodes.Count; i++)
            {
                if (Root.ChildNodes[i].Attributes.GetNamedItem("Id").Value == answer.GetId().ToString())
                {
                    Root.RemoveChild(Root.ChildNodes[i]);
                    break;
                }
            }
            document.Save("Answers.xml");
        }

        public void AddQuestion(Question question)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Questions.xml");
            XmlNode MainField = document.CreateElement("Question");
            document.DocumentElement.AppendChild(MainField);
            XmlAttribute attribute = document.CreateAttribute("Id");
            attribute.Value = (GetNumber("Questions")).ToString();
            MainField.Attributes.Append(attribute);
            XmlNode QuestionText = document.CreateElement("Text");
            QuestionText.InnerText = question.GetText();
            MainField.AppendChild(QuestionText);

            XmlNode Answers = document.CreateElement("Answers");
            MainField.AppendChild(Answers);
            for (int i = 0; i < question.GetAnswers().Count; i++)
            {
                XmlNode Answer = document.CreateElement("IdOfAnswer");
                Answer.InnerText = question.GetAnswers()[i].GetId().ToString();
                Answers.AppendChild(Answer);
            }

            document.Save("Questions.xml");
        }

        public Question GetQuestion(int Number)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("Questions.xml");
            XmlElement Root = Doc.DocumentElement;
            Question question = new Question();
            question.SetId(Number);
            foreach (XmlNode Node in Root)
            {
                foreach (XmlNode childnode in Node.ChildNodes)
                {
                    if (Node.Attributes.GetNamedItem("Id").Value.Equals(Number.ToString()))
                    {
                        if (childnode.Name == "Text")
                        {
                            question.SetText(childnode.InnerText);
                        }
                        if (childnode.Name == "Answers")
                        {
                            List<Answer> Answers = new List<Answer>();
                            for (int i = 0; i < childnode.ChildNodes.Count; i++)
                            {
                                int Value = Convert.ToInt32(childnode.ChildNodes[i].Value);
                                Answers.Add(GetAnswer(Value));
                            }
                            question.SetAnswers(Answers);
                        }
                    }
                }
            }
            return question;
        }

        public void RemoveQuestion(Question question)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Questions.xml");
            XmlElement Root = document.DocumentElement;
            for (int i = 0; i < Root.ChildNodes.Count; i++)
            {
                if (Root.ChildNodes[i].Attributes.GetNamedItem("Id").Value == question.GetId().ToString())
                {
                    Root.RemoveChild(Root.ChildNodes[i]);
                    break;
                }
            }
            document.Save("Questions.xml");
        }

        public void AddTest(Test test)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Tests.xml");
            XmlNode MainField = document.CreateElement("Test");
            document.DocumentElement.AppendChild(MainField);
            XmlAttribute attribute = document.CreateAttribute("Id");
            attribute.Value = (GetNumber("Tests")).ToString();
            MainField.Attributes.Append(attribute);
            XmlNode TestNumber = document.CreateElement("Number");
            TestNumber.InnerText = test.GetNumber().ToString();
            MainField.AppendChild(TestNumber);
            XmlNode Questions = document.CreateElement("Questions");
            MainField.AppendChild(Questions);
            for (int i = 0; i < test.GetQuestions().Count; i++)
            {
                XmlNode Question = document.CreateElement("IdOfQuestion");
                Question.InnerText = test.GetQuestions()[i].GetId().ToString();
                Questions.AppendChild(Question);
            }

            document.Save("Tests.xml");
        }

        public Test GetTest(int Number)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("Tests.xml");
            XmlElement Root = Doc.DocumentElement;
            Test test = new Test();
            test.SetId(Number);
            foreach (XmlNode Node in Root)
            {
                foreach (XmlNode childnode in Node.ChildNodes)
                {
                    if (Node.Attributes.GetNamedItem("Id").Value == Number.ToString())
                    {
                        if (childnode.Name == "Number")
                        {
                            test.SetNumber(Convert.ToInt32(childnode.InnerText));
                        }
                        if (childnode.Name == "Questions")
                        {
                            List<Question> Questions = new List<Question>();
                            for (int i = 0; i < childnode.ChildNodes.Count; i++)
                            {
                                int Value = Convert.ToInt32(childnode.ChildNodes[i].Value);
                                Questions.Add(GetQuestion(Value));
                            }
                            test.SetQuestions(Questions);
                        }
                    }
                }
            }
            return test;
        }

        public void RemoveTest(Test test)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Tests.xml");
            XmlElement Root = document.DocumentElement;
            for (int i = 0; i < Root.ChildNodes.Count; i++)
            {
                if (Root.ChildNodes[i].Attributes.GetNamedItem("Id").Value == test.GetId().ToString())
                {
                    Root.RemoveChild(Root.ChildNodes[i]);
                    break;
                }
            }
            document.Save("Tests.xml");
        }

        public void AddTheme(Theme theme)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Themes.xml");
            XmlNode MainField = document.CreateElement("Theme");
            document.DocumentElement.AppendChild(MainField);
            XmlAttribute attribute = document.CreateAttribute("Id");
            attribute.Value = (GetNumber("Themes")).ToString();
            MainField.Attributes.Append(attribute);
            XmlNode Number = document.CreateElement("Number");
            MainField.AppendChild(Number);
            XmlNode Tests = document.CreateElement("Tests");
            MainField.AppendChild(Tests);
            for (int i = 0; i < theme.GetTests().Count; i++)
            {
                XmlNode Test = document.CreateElement("IdOfTest");
                Test.InnerText = theme.GetTests()[i].GetId().ToString();
                Tests.AppendChild(Test);
            }

            document.Save("Themes.xml");
        }

        public Theme GetTheme(int Number)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("Themes.xml");
            XmlElement Root = Doc.DocumentElement;
            Theme theme = new Theme();
            theme.SetId(Number);
            foreach (XmlNode Node in Root)
            {
                foreach (XmlNode childnode in Node.ChildNodes)
                {
                    if (Node.Attributes.GetNamedItem("Id").Value == Number.ToString())
                    {
                        if(childnode.Name == "Number")
                        {
                            theme.SetName(childnode.Value);
                        }
                        if (childnode.Name == "Tests")
                        {
                            List<Test> Tests = new List<Test>();
                            for (int i = 0; i < childnode.ChildNodes.Count; i++)
                            {
                                int Value = Convert.ToInt32(childnode.ChildNodes[i].Value);
                                Tests.Add(GetTest(Value));
                            }
                            theme.SetTests(Tests);
                        }
                    }
                }
            }
            return theme;
        }

        public void RemoveTheme(Theme theme)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Themes.xml");
            XmlElement Root = document.DocumentElement;
            for (int i = 0; i < Root.ChildNodes.Count; i++)
            {
                if (Root.ChildNodes[i].Attributes.GetNamedItem("Id").Value == theme.GetId().ToString())
                {
                    Root.RemoveChild(Root.ChildNodes[i]);
                }
            }
            document.Save("Themes.xml");
        }

        public void AddDiscipline(Discipline discipline)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Disciplines.xml");
            XmlNode MainField = document.CreateElement("Discipline");
            document.DocumentElement.AppendChild(MainField);
            XmlAttribute attribute = document.CreateAttribute("Id");
            attribute.Value = (GetNumber("Disciplines")).ToString();
            MainField.Attributes.Append(attribute);
            XmlNode Name = document.CreateElement("Name");
            MainField.AppendChild(Name);
            XmlNode Themes = document.CreateElement("Themes");
            MainField.AppendChild(Themes);
            for (int i = 0; i < discipline.GetThemes().Count; i++)
            {
                XmlNode Theme = document.CreateElement("IdOfTheme");
                Theme.InnerText = discipline.GetThemes()[i].GetId().ToString();
                Themes.AppendChild(Theme);
            }

            document.Save("Disciplines.xml");
        }

        public Discipline GetDiscipline(int Number)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("Disciplines.xml");
            XmlElement Root = Doc.DocumentElement;
            Discipline discipline = new Discipline();
            discipline.SetId(Number);
            foreach (XmlNode Node in Root)
            {
                foreach (XmlNode childnode in Node.ChildNodes)
                {
                    if (Node.Attributes.GetNamedItem("Id").Value == Number.ToString())
                    {
                        if (childnode.Name == "Name")
                        {
                            discipline.SetName(childnode.InnerText);
                        }

                        if (childnode.Name == "Themes")
                        {
                            List<Theme> Themes = new List<Theme>();
                            for (int i = 0; i < childnode.ChildNodes.Count; i++)
                            {
                                int Value = Convert.ToInt32(childnode.ChildNodes[i].Value);
                                Themes.Add(GetTheme(Value));
                            }
                            discipline.SetThemes(Themes);
                        }
                    }
                }
            }
            return discipline;
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Disciplines.xml");
            XmlElement Root = document.DocumentElement;
            for (int i = 0; i < Root.ChildNodes.Count; i++)
            {
                if (Root.ChildNodes[i].Attributes.GetNamedItem("Id").Value == discipline.GetId().ToString())
                {
                    Root.RemoveChild(Root.ChildNodes[i]);
                }
            }
            document.Save("Disciplines.xml");
        }

        private void CreateFile(String text)
        {
            if (!CheckFile(text))
            {
                XmlTextWriter TextWriter = new XmlTextWriter(text + ".xml", Encoding.UTF8);
                TextWriter.WriteStartDocument();
                TextWriter.WriteStartElement(text);
                TextWriter.WriteEndElement();
                TextWriter.Close();
            }
        }

        private static Boolean CheckFile(String text)
        {
            //logic
            return false;
        }

        private int GetNumber(String File)
        {
            //List<Object> Objects = new List<Object>();
            XmlDocument Doc = new XmlDocument();
            Doc.Load(File+".xml");
            XmlElement Root = Doc.DocumentElement;
            int Value = 0;
            int NextValue = 0;
            foreach (XmlNode Node in Root)
            {
                XmlNode attr = Node.Attributes.GetNamedItem("Id");
                NextValue = Int32.Parse(attr.Value);
                if (NextValue - Value > 1)
                {
                    return Value + 1;
                }
                else Value = NextValue;
            }
            return Value+1;
        }
    }
}
