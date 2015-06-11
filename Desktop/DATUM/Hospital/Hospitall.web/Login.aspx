<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hospitall.web.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<center>
<table>
            <tr>
                <td>
                    User Name:
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox ID="txtP" runat="server"></asp:TextBox>
                </td>
            </tr>
              <tr>
                <td >
                    <asp:Button ID="btnNew" runat="server" Text="Login" OnClick="btnNew_Click" />
            
                </td>
                
            </tr>
          
        </table>
        <table>
          <tr>
                <td>
                    User Name:
                </td>
                <td>
                    <asp:TextBox ID="txtNamee" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                   First Nmae:
                </td>
                <td>
                    <asp:TextBox ID="txtF" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Last Name:
                </td>
                <td>
                    <asp:TextBox ID="txtL" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Pasword:
                </td>
                <td>
                    <asp:TextBox ID="txtPP" runat="server"></asp:TextBox>
                </td>
            </tr>

              <tr>
                <td >
                    <asp:Button ID="btnSignUp" runat="server" Text="SignUp" 
                        onclick="btnSignUp_Click"  />
            
                </td>
                
            </tr>
        
        
        </table>

        <%--<table>
        <div>
Username : <asp:TextBox ID="txtUserName" runat="server" onkeyup = "OnKeyUp(this)" /><br />
Password:  <asp:TextBox ID="txtPassWord" TextMode=Password runat="server" onkeyup ="OnKeyUp(this)"/><br />  
 <input id="btnCheck" type="button" value="Login" onclick = "CheckUserLogin()" />
 <br />
 <span id = "message"> </spa
</div>
        
        
        </table>--%>
        </center>
</asp:Content>
