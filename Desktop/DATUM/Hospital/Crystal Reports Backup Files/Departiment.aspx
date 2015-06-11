<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Departiment.aspx.cs" Inherits="Hospitall.web.Departiment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h1>
            Welcome departiment Registeration Form
        </h1>
        <asp:TextBox ID="txtId" runat="server" Visible="false"></asp:TextBox>

        <table>
            <tr>
                <td>
                    Departiment Name:
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Departiment Code:
                </td>
                <td>
                    <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnNew" runat="server" Text="New" OnClick="btnNew_Click" />
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    <asp:Button ID="btnExportToExcel" runat="server" Text="ExportToExcel" onclick="btnExportToExcel_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="Gvam" runat="server" DataSourceID="ObjDepartiments" AllowPaging="True"
            DataKeyNames="ID" OnSelectedIndexChanged="Gvam_SelectedIndexChanged" PageSize="5">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjDepartiments" runat="server" TypeName="Hospital.Business.Departiment"
            SelectMethod="GetAll"></asp:ObjectDataSource>
    </center>
</asp:Content>
