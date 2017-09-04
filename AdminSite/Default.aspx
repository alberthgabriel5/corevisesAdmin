<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdminSite.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Header -->
    <header class="masthead">        
        <div class="container">            
            <div class="intro-text">                
                <div class="col-lg-12 text-center">
                    <h2 class="intro-lead-in">Bear Gamer</h2> 
                    <br />
                    <br />                   
                    <asp:TextBox ID="tbEmail" TextMode="Email"   runat="server" ToolTip="User Email" OnTextChanged="tbEmail_TextChanged"></asp:TextBox>
                    <br />
                    <br />                    
                    <asp:TextBox ID="tbPassword" TextMode="Password"  runat="server" ToolTip="User Password"></asp:TextBox>
                    <br />                    
                    <br />
                    <asp:Button ID="Button1"   runat="server" Text="Start" OnClick="Button1_Click" ToolTip="Log- In" CssClass="btn-xl" />
                    
                    <br />
                    <br />
                </div>
            </div>
          </div>
    </header>

</asp:Content>
