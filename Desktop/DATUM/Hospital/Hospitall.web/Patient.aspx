<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="Hospitall.web.Patient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h1>welcome to Patient form    </h1>
 <table border="1">
        <tr>
            <td>
                Patient Name:
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                   Gender:
            </td>
            <td>
                <asp:TextBox ID="txtG" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                    Age :
            </td>
            <td>
                <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
            </td>
        </tr>
           <tr>
            <td>
               City:
            </td>
            <td>
                <asp:TextBox ID="txtC" runat="server"></asp:TextBox>
            </td>
        </tr>

    </table>
    <td>
        <asp:Button ID="btnSave" runat="server" Text="Save" 
        onclick="btnSave_Click" />
    
    </td>
    <td>
        <asp:Button ID="btnNew" runat="server" Text="New" onclick="btnNew_Click" />
    
    
    </td>

    
        <asp:GridView ID="Gvam" runat="server" DataSourceID="ObjPatient">
             </asp:GridView>

    <asp:ObjectDataSource ID="ObjPatient" runat="server" TypeName="Hospital.Business.Patient" SelectMethod="GetAll"></asp:ObjectDataSource>

</asp:Content>
