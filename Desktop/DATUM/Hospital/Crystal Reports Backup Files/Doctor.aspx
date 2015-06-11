<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doctor.aspx.cs" Inherits="Hospitall.web.Doctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <table>
            <tr>
                <td>
                     Name:
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Salary:
                </td>
                <td>
                    <asp:TextBox ID="txtS" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Designation:
                </td>
                <td>
                    <asp:TextBox ID="txtD" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    DepId:
                </td>
                <td>
                    <asp:TextBox ID="txtDID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    DOB:
                </td>
                <td>
                    <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Join Date:
                </td>
                <td>
                    <asp:TextBox ID="txtJ" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnNew" runat="server" Text="New" onclick="btnNew_Click" 
                        style="width: 39px" />
                    
                    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click"  />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                        onclick="btnDelete_Click" />
                </td>
            </tr>
        </table>

    <asp:GridView ID="Gvam" runat="server" DataSourceID="ObjectDoctor" AllowPaging="True"  PageSize="2">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDoctor" runat="server" TypeName="Hospital.Business.Doctor" SelectMethod="GetALL"></asp:ObjectDataSource>


</asp:Content>
