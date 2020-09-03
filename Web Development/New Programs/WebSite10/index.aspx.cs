using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Postback = " + IsPostBack);
        if (IsPostBack == false)
        {
            UserData u1 = new UserData();
            ViewState["userobj"] = u1;
        }
    }

    protected void btnSignUpClick(object sender, EventArgs e)
    {
     UserData x = (UserData)ViewState["userobj"];
     string gender = "";
     if (radioMale.Checked)
         gender = "Male";
     else
         gender = "Female";

     Response.Write(x.recordsdb.Count);

     x.addUserData(txtName.Value, gender, txtEmail.Value, txtSignUsername.Value, txtSignPassword.Value);
  
     Response.Write("<script>alert(\"Total Records in ArrayList = "+x.recordsdb.Count+"\");</script>");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int cnt = 0;
        UserData x = (UserData)ViewState["userobj"];

        for (int i = 0; i < x.recordsdb.Count; i++)
        {
            UserData row = (UserData)x.recordsdb[i];
            if (txtUsername.Value.Equals(row.username) && txtPassword.Value.Equals(row.password))
            {
                cnt++;
            }
        }

        if(cnt==0)
            Response.Write("<script>alert(\"Total Records in ArrayList = Incorrect Username or Password\");</script>");
        else
            Response.Write("<script>alert(\"Total Records in ArrayList = Login Successfull\");</script>");
    }
}