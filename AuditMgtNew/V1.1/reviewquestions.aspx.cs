﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuditMgtNew
{
    public partial class reviewquestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Examination exam = (Examination)Session["questions"];
            DataList1.DataSource = exam.questions;
            DataList1.DataBind();

        }
    }
}