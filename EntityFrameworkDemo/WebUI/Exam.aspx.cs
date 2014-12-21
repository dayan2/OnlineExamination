using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;

namespace WebUI
{
    public partial class Exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context con = new Context();
            //var test2 = con.Questions.Where(a => a.ID == 4).Select(x => new { newcolname = x.QuestionDes + x.Answer1 + x.Answer2 + x.Answer3 + x.Answer4}).ToList();
            var query = from c in con.Questions 
                        select new
                        {
                            c.ID,
                            c.QuestionDes,
                            c.Answer1,
                            c.Answer2,
                            c.Answer3,
                            c.Answer4
                        };

            GridView1.DataSource = query.ToList(); //con.Questions.ToList();
            GridView1.DataBind();
        }


        /// <summary>
        /// LINQ query to get the answers in to the exam page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            //DataClassesDataContext db = new DataClassesDataContext();

            //var con = (from Ques in db.GetTable<Question>()
            //           from Cho in db.GetTable<Choice>()
            //           where (Ques.ID == Cho.QuestionID_ID)
            //           select new Result 
            //           {
            //               Answer1 = Ques.Answer1,
            //               Answer2 = Ques.Answer2,
            //               Answer3 = Ques.Answer3,
            //               Answer4 = Ques.Answer4
                       
            //           }).ToList<Result>();

            //GridView1.DataSource = con;
            //GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList1.Visible = true;
        }
    }
}