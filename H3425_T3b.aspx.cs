using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class H3425_T3b : System.Web.UI.Page
{
    string pathToAppData = HttpContext.Current.Server.MapPath("~/App_Data/");
    string pathToAccounts = HttpContext.Current.Server.MapPath("~/App_Data/accounts.xml");
    SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //private void CreateAccounts()
    //{
    //    XDocument doc = XDocument.Load(pathToAccounts);
    //    XElement root = doc.Element("accounts");
    //    IEnumerable<XElement> rows = root.Descendants("account");
    //    XElement firstRow = rows.First();

    //    string pass = "gitgud";
    //    var data = GetHash(pass);

    //    firstRow.AddAfterSelf(
    //        new XElement("account",
    //        new XElement("name", "Linus"),
    //        new XElement("password", sha1.ComputeHash(data))
    //        ));
    //    doc.Save(pathToAccounts);
    //}

    protected void button_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (GrantAccess())
            {
                
            }
        }
    }

    private Boolean GrantAccess()
    {
        XDocument doc = XDocument.Load(pathToAccounts);
        XElement element = doc.Element("accounts").Element("account");
        
        if(txtName.Text == element.Element("name").Value)
        {
            Label1.Text = GetHashString(element.Element("password").Value) ;
            if (txtPass.Text == GetHashString(element.Element("password").Value) )
            {
                return true;
            }
        }
        return false;
    }

    public static byte[] GetHash(string inputString)
    {
        HashAlgorithm algorithm = SHA1.Create();  // SHA1.Create()
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }

    public static string GetHashString(string inputString)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }
}