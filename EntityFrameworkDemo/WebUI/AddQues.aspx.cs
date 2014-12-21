using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class AddQues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Inserting Question objects to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Question object
            DataClassesDataContext con = new DataClassesDataContext();
            Question cust = new Question();

            cust.QuestionDes = TextBox1.Text; ;
            cust.Answer1 = TextBox2.Text;
            cust.Answer2 = TextBox3.Text;
            cust.Answer3 = TextBox4.Text;
            cust.Answer4 = TextBox5.Text;
            cust.Correct = Convert.ToInt32(TextBox6.Text);

            //Insert the new Question object
            con.Questions.InsertOnSubmit(cust);
            //Sumbit changes to the database
            con.SubmitChanges();

            //Display Message for successful operation
            Label1.Text = "<p style='color:Green;'>Information Successfully saved!</p>";
            
        }
    }
}