using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace DataLayer
{
    public class ContextSeeder : DropCreateDatabaseIfModelChanges<Context>
    {
        //#region private variables
        //private string examType;
        //private int cuttOff;
        //private string question;
        //private string ans1;
        //private string ans2;
        //private string ans3;
        //private string ans4;
        //private int correct;
        //#endregion

        //#region properties
        //public int Correct
        //{
        //    get { return correct; }
        //    set { correct = value; }
        //}

        //public string Ans4
        //{
        //    get { return ans4; }
        //    set { ans4 = value; }
        //}

        //public string Ans3
        //{
        //    get { return ans3; }
        //    set { ans3 = value; }
        //}

        //public string Ans2
        //{
        //    get { return ans2; }
        //    set { ans2 = value; }
        //}

        //public string Ans1
        //{
        //    get { return ans1; }
        //    set { ans1 = value; }
        //}

        //public string Question
        //{
        //    get { return question; }
        //    set { question = value; }
        //}

        //public int CuttOff
        //{
        //    get { return cuttOff; }
        //    set { cuttOff = value; }
        //}

        //public string ExamType
        //{
        //    get { return examType; }
        //    set { examType = value; }
        //}
        //#endregion

        //public ContextSeeder(string type, int cut, string ques, string answer1, string answer2, string answer3, string answer4, int c)
        //{
        //    this.examType = type;
        //    this.cuttOff = cut;
        //    this.question = ques;
        //    this.ans1 = answer1;
        //    this.ans2 = answer2;
        //    this.ans3 = answer3;
        //    this.ans4 = answer4;
        //    this.correct = c;
        //}

        protected override void Seed(Context context)
        {
            //Examination e = new Examination()
            //{
            //    Description = "fromda console",
            //    CutOffMark = 1000,
            //    QuestionID = new List<Question>()
            //    { 
            //        new Question()
            //        {
            //            QuestionDes = "from da console",
            //            Answer1 = "from da console",
            //            Answer2 = "from da console",
            //            Answer3 = "from da console",
            //            Answer4 = "from da console",
            //            Correct = 1
            //            //ExaminationID = 1
            //        }
            //    }
            //};
            //context.Examinations.Add(e);

            User u1 = new User()
            {

                UserName = "dayan",
                Password = "dayan",
                Role = "Admin"

            };
            User u2 = new User()
            {
                UserName = "neranjan",
                Password = "neranjan",
                Role = "employee"
            };

            context.Users.Add(u1);
            context.Users.Add(u2);
            //context.SaveChanges();
            base.Seed(context);

        }
    }
}
