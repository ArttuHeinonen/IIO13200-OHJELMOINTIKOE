using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class H3425_T2a : System.Web.UI.Page
{
    String path = ConfigurationManager.AppSettings["Path"].ToString();
    DataSet ds = new DataSet();
    DataSet filter = new DataSet();
    XDocument doc;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                ds.ReadXml(path);
                gv.DataSource = ds;
                gv.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

    protected void btnVakituiset_Click(object sender, EventArgs e)
    {
        doc = XDocument.Load(path);
        var parser = (from p in doc.Root.Descendants("tyontekijat")
                      where (p.Element("tyosuhde").Value == "asd")
                      select new
                      {
                          etunimi = p.Element("etunimi").Value,
                          sukunimi = p.Element("sukunimi").Value,
                          numero = p.Element("numero").Value,
                          tyosuhde = p.Element("tyosuhde").Value,
                          palkka = p.Element("palkka").Value,
                      }).Distinct();
        DataTable table = new DataTable();
        table.Columns.Add("etunimi", typeof(String));
        table.Columns.Add("sukunimi", typeof(String));
        table.Columns.Add("numero", typeof(String));
        table.Columns.Add("tyosuhde", typeof(String));
        table.Columns.Add("palkka", typeof(String));

        foreach (var p in parser)
        {
            table.Rows.Add(p.etunimi, p.sukunimi, p.numero, p.tyosuhde, p.palkka);
        }
        gv.DataSource = null;
        gv.DataSource = table;

    }
}