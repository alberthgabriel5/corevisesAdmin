<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="AdminSite.Products.Products" %>
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
            <a class="nav-link" href="#">Game</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#contact">Insert</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#team">Products</a>
          </li>
        <li class="nav-item">
            <a class="nav-link" runat="server"  onclick="logout"  href="../Default.aspx">Logout</a>
               
          </li>
        </ul>
      </div>
    </nav>


     <!-- Header -->
    <header class="masthead">        
        <img src="http://gamefeedz.com/fotos_blog/2_4e5e84477a3b329ed2294247cc9a4ace.jpg" alt="https://i0.wp.com/conectica.com/wp-content/uploads/2016/12/nintendo-juegos-2017.jpg?fit=1010%2C537&ssl=1" />
    </header>

    <!-- Contact -->
    <section id="contact">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading">Insert New Game</h2>
            <h3 class="section-subheading text-muted">Stock Insert</h3>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-12">
            <div class="row">
                <div class="col-md-6">
                  <div class="form-group">
                    <asp:TextBox  CssClass="form-control" ID="tbNameProduct"   data-validation-required-message="Please enter a name." runat="server" ToolTip="Name of Product" OnTextChanged="tbNameProduct_TextChanged"></asp:TextBox>
                    <p class="help-block text-danger"></p>
                  </div>
                  <div class="form-group">
                    <asp:DropDownList ID="typeList" ToolTip="Type" runat="server" CssClass="form-control" >
                        <asp:ListItem Value="0">Select Type </asp:ListItem>
                        <asp:ListItem Value="1">Action</asp:ListItem>
                        <asp:ListItem Value="2">Fight</asp:ListItem>
                        <asp:ListItem Value="3">Kids</asp:ListItem>
                        <asp:ListItem Value="4">Puzzle</asp:ListItem>
                        <asp:ListItem Value="5">Race</asp:ListItem>
                        <asp:ListItem Value="6">Simulation</asp:ListItem>
                        <asp:ListItem Value="7">Sport</asp:ListItem>
                        <asp:ListItem Value="8">Strategy</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                  <div class="form-group">
                     <asp:DropDownList ID="consoleList" ToolTip="Cosole" runat="server" CssClass="form-control" AutoPostBack="True" >
                         <asp:ListItem Value="0">Select Console</asp:ListItem>
                         <asp:ListItem Value="1">XBox 360</asp:ListItem>
                         <asp:ListItem Value="2">PS3</asp:ListItem>
                         <asp:ListItem Value="3">PS4</asp:ListItem>
                         <asp:ListItem Value="4">Nintendo Wi</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                    <div class="form-group">
                    <asp:TextBox  CssClass="form-control" ID="tbPrice"  TextMode="Number"  data-validation-required-message="Please enter a price." runat="server" ToolTip="Price of Product" OnTextChanged="tbNameProduct_TextChanged"></asp:TextBox>
                    <p class="help-block text-danger"></p>
                  </div>
                </div>
                <div class="col-md-6">
                  
                    <div class="form-group">                      
                      <img src="../img/logos/control.png" alt="../img/logos/control.png" class="form-control"  />                    
                  </div>
                </div>

                <asp:Panel ID="frmConfirmation" Visible="False" runat="server">
                    <asp:Label ID="lblUploadResult" runat="server"></asp:Label>
                </asp:Panel>

                <div class="col-lg-12 text-center">
                    <div id="success"></div>
                    <asp:Button ID="Button1" CssClass="btn btn-xl" runat="server" Text="Insert" OnClick="ButtonI_Click" ToolTip="Log- In" ></asp:Button>
                </div>
              </div>            
          </div>
        </div>
      </div>
    </section>
    
    <!-- Team -->
    <section class="bg-light" id="team">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading">Products</h2>
            <h3 class="section-subheading text-muted">Games Available</h3>
          </div>
        </div>

          <asp:panel id="PanelListGame" runat="server" cssclass="col-sm-4" HorizontalAlign="Center">
              
          </asp:panel>

          
        
      </div>
    </section>


</asp:Content>
