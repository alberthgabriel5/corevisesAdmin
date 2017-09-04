<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sales.aspx.cs" Inherits="AdminSite.Sales.Sales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Header -->
    <header class="masthead">
        <%--<div class="container">
            <div class="intro-text">
                <div class="intro-lead-in">Welcome to paradise for players!</div>
                <div class="intro-heading">It's a admin site</div>
                <a href="#services" class="btn btn-xl">&nbsp;More</a>
            </div>
        </div>--%>
        <img src="http://gamefeedz.com/fotos_blog/2_4e5e84477a3b329ed2294247cc9a4ace.jpg" alt="https://i0.wp.com/conectica.com/wp-content/uploads/2016/12/nintendo-juegos-2017.jpg?fit=1010%2C537&ssl=1" />
    </header>

    <!-- Services -->
    <section id="services">
        <div class="container">
            <div class="row">
<h2 class="intro-lead-in">Insert Product</h2>

                <div class="col-lg-12 text-center">
                    
                    <br />
                    <br />
                    <asp:TextBox ID="tbNameProduct"   AutoCompleteType="None"  runat="server" ToolTip="Name of Product"></asp:TextBox>
                    <br />
                    <br />
                    <asp:DropDownList ID="DropDownList1"  runat="server"></asp:DropDownList>
                    <br />


                    <br />
                    <asp:DropDownList ID="DropDownList2"  runat="server"></asp:DropDownList>


                    <br />
                    <br />

                    <br />

                    <br />
                    <asp:Button ID="Button1" class="btn btn-xl" runat="server" Text="Insert" OnClick="Button1_Click" ToolTip="Log- In" />
                    <br />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
