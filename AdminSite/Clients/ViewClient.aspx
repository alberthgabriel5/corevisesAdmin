<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewClient.aspx.cs" Inherits="AdminSite.Products.ViewClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
      <a class="navbar-brand" href="../index.aspx">Bear Gamer</a>
      <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        
          
        <i class="fa fa-bars"></i>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav ml-auto">
          
          <li class="nav-item">
            <a class="nav-link" href="InsertClient.aspx">Insert</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="ViewClient.aspx">Clients</a>
          </li>          
            <li class="nav-item">
            <a class="nav-link" runat="server"  onclick="logout"  href="../Default.aspx">Logout</a>
               
          </li>
        </ul>
      </div>
    </nav>

    
    <!-- Team -->
    <section class="bg-light" id="team">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading">Clients</h2>
            <h3 class="section-subheading text-muted">Users Available</h3>
          </div>
        </div>

          <asp:panel id="PanelList" runat="server" cssclass="col-sm-4" HorizontalAlign="Center">
              
          </asp:panel>         
        
      </div>
    </section>
</asp:Content>
