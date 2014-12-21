using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using System.Data.Entity;
using Entities;

namespace WebUI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();

            //if (!Page.IsPostBack)
            //{
            //    DropDownList_Answers.DataSource = GetChoices();
            //    DropDownList_Answers.DataTextField = "Answer1";
            //    DropDownList_Answers.DataValueField = "Answer1";
            //    DropDownList_Answers.DataBind();
            //}
        }

        #region private Methods
        private List<Question> GetQuestions()
        {
            using (DataClassesDataContext context = new DataClassesDataContext())
            {
                //Question qu = new Question();
                return (from c in context.Questions select c).ToList();
            }
        }
        private List<Choice> GetChoices(int qID)
        {
            using (DataClassesDataContext context = new DataClassesDataContext())
            {
                return (from c in context.Choices
                        where c.ID == qID
                        select c).ToList();
            }
        }
        #endregion
    }
}