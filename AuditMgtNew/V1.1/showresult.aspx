﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="showresult.aspx.cs" Inherits="AuditMgtNew.showresult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <br />
    <h2>
    Examination Result</h2>
    &nbsp;
    <br />
    <table bgcolor="#eeeeee" border=1>
        <tr>
            <td>
                Subject:
            </td>
            <td>
                <asp:Label ID="lblSubject" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>
                Starting Time :
            </td>
            <td>
                <asp:Label ID="lblStime" runat="server" Text="Label"></asp:Label></td>
        </tr>
        
        <tr>
            <td>
                Time Taken In Minutes : 
            </td>
            <td>
                <asp:Label ID="lblMin" runat="server" Text="Label"></asp:Label></td>
        </tr>
        
                <tr>
            <td>
               No. of Questions :
            </td>
            <td>
                <asp:Label ID="lblNquestions" runat="server"></asp:Label></td>
        </tr>
        
                <tr>
            <td>
                No. of correct answers :
            </td>
            <td>
                <asp:Label ID="lblNcans" runat="server" Text="Label"></asp:Label></td>
        </tr>

        <tr>
            <td>
                Grade : 
            </td>
            <td>
                <asp:Label ID="lblGrade" runat="server" Text="Label"></asp:Label></td>
        </tr>


    </table>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <a  href="reviewquestions.aspx">Review Questions</a>
    <asp:LinkButton ID="lbRank" runat="server" OnClick="lbRank_Click">Rank The Result</asp:LinkButton><br />
    <br />
    <asp:Label ID="lblRank" runat="server"></asp:Label><br />
    
</asp:Content>




