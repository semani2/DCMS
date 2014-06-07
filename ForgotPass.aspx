<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.master" AutoEventWireup="true" CodeFile="ForgotPass.aspx.cs" Inherits="ForgotPass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    FORGOT PASSWORD !</p>
    <p>
        Please enter ur username :&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="215px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Please enter username" 
            SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
<p>
    Please select Your Security Questions :
    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="SecurityQuestion" 
        DataValueField="SecurityQuestion" Width="80px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" 
        SelectCommand="SELECT [SecurityQuestion] FROM [stuDemoTB]">
    </asp:SqlDataSource>
</p>
    <p>
        Please enter the security answer :
        <asp:TextBox ID="TextBox1" runat="server" Width="175px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Answer Required"></asp:RequiredFieldValidator>
</p>
    <p style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Get Password !" Width="109px" />
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
</p>
    <p style="margin-left: 40px">
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Stu_login.aspx" 
            Visible="False">Proceed to login</asp:HyperLink>
</p>
    <p>
        &nbsp;</p>
</asp:Content>

