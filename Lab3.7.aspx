
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab3DikshyaShahi.Default" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>Simple Interest Calculator</title>
</head>
<body>
    <h2>Simple Interest Calculator</h2>
    <form id="form1" runat="server">
        <div>
            <label for="txtPrincipal">Principal (P): </label>
            <asp:TextBox ID="txtPrincipal" runat="server" Width="200px" />
        </div>
        <div>
            <label for="txtRate">Rate of Interest (R): </label>
            <asp:TextBox ID="txtRate" runat="server" Width="200px" />
        </div>
        <div>
            <label for="txtTime">Time (T) in years: </label>
            <asp:TextBox ID="txtTime" runat="server" Width="200px" />
        </div>
        <br />
        <div>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
        </div>
        <br />
        <div>
            <label for="lblResult">Simple Interest: </label>
            <asp:Label ID="lblResult" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>

