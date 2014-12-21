using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text;
            string pwd = TextBox2.Text;
            bool res = IsValidEmployee(user, pwd);
            if (!res == true)
                Label1.Text = "Access is Denied";
            else
                Response.Redirect("WelcomePage1.aspx");
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    string user = TextBox3.Text;
        //    string pwd = TextBox4.Text;
        //    bool res = IsValidAdmin(user, pwd);
        //    if (!res == true)
        //        Label2.Text = "Access is Denied";
        //    else
        //        Response.Redirect("AddQuestions.aspx");

        //}

        protected void Button2_Click1(object sender, EventArgs e)
        {
            string user = TextBox3.Text;
            string pwd = TextBox4.Text;
            bool res = IsValidAdmin(user, pwd);
            if (!res == true)
                Label2.Text = "Access is Denied";
            else
                Response.Redirect("AddQues.aspx");
        }

        #region private methods
        private bool IsValidEmployee(string user, string pwd)
        {
            DataClassesDataContext myDB = new DataClassesDataContext();
            var userResults = from u in myDB.Users
                              where u.UserName == user
                              && u.Password == pwd
                              && u.Role == "employee"
                              select u;
            return Enumerable.Count(userResults) > 0;
        }
        private bool IsValidAdmin(string user, string pwd)
        {
            DataClassesDataContext myDB = new DataClassesDataContext();
            var userResults = from u in myDB.Users
                              where u.UserName == user
                              && u.Password == pwd
                              && u.Role == "admin"
                              select u;
            return Enumerable.Count(userResults) > 0;
        }

        #endregion

        
    }
}