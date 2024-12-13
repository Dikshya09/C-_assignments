
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab3.8.aspx.cs" Inherits="PKMC2078Unit4Web.Lab38" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Registration Form</h2>
        <div>
            <asp:Label Text="Name" ID="lblName" runat="server" /><br />
            <asp:TextBox ID="txtName" runat="server" /><br />
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1" 
                runat="server" 
                ErrorMessage="Please enter your name" 
                ControlToValidate="txtName" 
                ForeColor="Red" 
                Display="Dynamic" /><br />
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator2" 
                runat="server" 
                ErrorMessage="Name must contain only letters and spaces" 
                ControlToValidate="txtName" 
                ForeColor="Red" 
                Display="Dynamic" 
                ValidationExpression="^[a-zA-Z\s]+$" /><br />

            <asp:Label Text="Email" ID="lblEmail" runat="server" /><br />
            <asp:TextBox ID="txtEmail" runat="server" /><br />
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator2" 
                runat="server" 
                ErrorMessage="Please enter your email" 
                ControlToValidate="txtEmail" 
                ForeColor="Red" 
                Display="Dynamic" /><br />
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator1" 
                runat="server" 
                ErrorMessage="Invalid email format" 
                ControlToValidate="txtEmail" 
                ForeColor="Red" 
                Display="Dynamic" 
                ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" /><br />

            <asp:Label Text="Password" ID="lblPassword" runat="server" /><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br />
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator3" 
                runat="server" 
                ErrorMessage="Please enter your password" 
                ControlToValidate="txtPassword" 
                ForeColor="Red" 
                Display="Dynamic" /><br /> 
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" /><br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Visible="false" />
        </div>
    </form>
</body>
</html>
