<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Lab7.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Student</title>
    <link rel="stylesheet" href="App_Themes/SiteStyles.css" />
</head>

<body>
    <form id="form1" runat="server">
        <h1>Students</h1>
        <table>
            <tr>
                <th>Student Name:</th>
                <th>
                    <asp:TextBox runat="server" ID="txtStudentName" CssClass="input"></asp:TextBox>
                </th>
            </tr>
            <tr>
                <th>Student Type:</th>
                <th>
                    <asp:DropDownList ID="drpStudentType" runat="server" CssClass="input" >
                        <asp:ListItem Value="-1" Text="Select ..."></asp:ListItem>
                        <asp:ListItem Value="0" Text="Full Time"></asp:ListItem>
                        <asp:ListItem Value="1" Text="Part Time"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Co-Op"></asp:ListItem>
                    </asp:DropDownList>
                </th>
            </tr>
        </table>
        <br /><br />
        <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="btnAdd_Click" CssClass="button" />
        <asp:Panel runat="server" ID="pnlResult" Visible="false">
            <asp:Table ID="tblStudents" runat="server" CssClass="table">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
        <div>
        </div>
    </form>
</body>
</html>
