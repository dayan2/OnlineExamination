using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    //this is where u retrieve table data and keep it as a repository
    public class Repository
    {
        public List<Examination> GetExams()
        {
            Context con = new Context();
            return con.Examinations.ToList();
        }
        public List<Question> GetQuestions()
        {
            Context con = new Context();
            return con.Questions.ToList();
        }
        public List<Choice> GetChoices()
        {
            Context con = new Context();
            return con.Choices.ToList();
        }
        public List<User> GetUsers()
        {
            Context con = new Context();
            return con.Users.ToList();
        }
        

        //public void AddExam(Context con)
        //{ 
            //Examination ex = new Examination()
            //{               

            //    Description = examType,
            //    CutOffMark = cuttOff,
            //    QuestionID = new List<Question>() 
            //    { 
            //        new Question()
            //        {
            //            QuestionDes = Question,
            //            Answer1 = Ans1,
            //            Answer2 = Ans2,
            //            Answer3 = Ans3,
            //            Answer4 = Ans4,
            //            Correct = Correct
            //            //ExaminationID = 1
            //        }
            //    }

            //};
            //con.Examinations.Add(ex);
            //con.SaveChanges();
        //}

    }
}
