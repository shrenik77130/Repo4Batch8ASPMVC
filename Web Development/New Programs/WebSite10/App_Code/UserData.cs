using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

[Serializable]
public class UserData
{
    public string name, gender, email, username, password;
    public ArrayList recordsdb = new ArrayList();

	public UserData()
	{	
	}

    public UserData(string name, string gender, string email, string username, string password)
    {
        this.name = name;
        this.gender = gender;
        this.email = email;
        this.username = username;
        this.password = password;

        recordsdb.Add(this);
    }
    public void addUserData(string name,string gender,string email,string username,string password)
    {
        this.name = name;
        this.gender = gender;
        this.email = email;
        this.username = username;
        this.password = password;

        recordsdb.Add(this);
    }
}