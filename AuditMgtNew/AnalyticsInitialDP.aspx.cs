﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace AuditMgtNew
{
    public partial class AnalyticsInitialDP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string query = ("select distinct locationid,location from tbllocation where verticalid =" + 14);
                DataTable dt = GetData(query);
                ddlCountries.DataSource = dt;
                ddlCountries.DataTextField = "location";
                ddlCountries.DataValueField = "locationid";
                ddlCountries.DataBind();
                ddlCountries.Items.Insert(0, new ListItem("Select", ""));
            }

        }
        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chart1.Visible = ddlCountries.SelectedValue != "";
            string query = string.Format("select sname, score from oe_subjects where locationid = '{0}' group by sname,score Order by sname", ddlCountries.SelectedValue);
            DataTable dt = GetData(query);
            string[] x = new string[dt.Rows.Count];
            int[] y = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(dt.Rows[i][1]);
            }
            Chart1.Series[0].Points.DataBindXY(x, y);
            Chart1.Series[0].ChartType = SeriesChartType.Column;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart1.Legends[0].Enabled = true;
        }

        private static DataTable GetData(string query)
        {
            SqlConnection con = new SqlConnection(DBUtil.ConnectionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query);
            //   String constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            //  SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            return dt;
        }

    }
}
