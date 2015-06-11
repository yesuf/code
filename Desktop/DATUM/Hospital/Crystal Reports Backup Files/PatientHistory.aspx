<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientHistory.aspx.cs" Inherits="Hospitall.web.PatientHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h1> Welcome to PatientHistory Form  
</h1>
 <table border="1" align="right">
        <tr>
            <td>
              Admission date:
            </td>
            <td>
                <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
            </td>
        
        <tr>
            <td>
                Doctor Name:
            </td>
            <td>
                <asp:TextBox ID="txtDN" runat="server"></asp:TextBox>
            </td>
             <tr>
            <td>
              Doctor ID:
            </td>
            <td>
                <asp:TextBox ID="txtD" runat="server"></asp:TextBox>
            </td>
             <tr>
            <td>
              Patient ID:
            </td>
            <td>
                <asp:TextBox ID="txtP" runat="server"></asp:TextBox>
            </td>
             <tr>
            <td>
           Realase Date:
            </td>
            <td>
                <asp:TextBox ID="txtRD" runat="server"></asp:TextBox>
            </td>
             <tr>
            <td>
             Ward:
            </td>
            <td>
                <asp:TextBox ID="txtward" runat="server"></asp:TextBox>
            </td>
            </tr>
        
    </table>
    <td>
    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />

         </td>
         <td>
             <asp:Button ID="btnNew" runat="server" Text="New" 
        onclick="btnNew_Click" />
         </td>
     

        <asp:GridView ID="Gvam" runat="server" DataSourceID="ObjPatientHistory" 
        AutoGenerateColumns="False" AllowPaging="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
      <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
    <asp:BoundField DataField="AdmissionDate" HeaderText="Admission Date:"/>
     <asp:BoundField DataField="Doctor" HeaderText="Doctor:"/>
     <asp:BoundField DataField="ReleaseDate" HeaderText="ReleaseDate:"/>
      <asp:BoundField DataField="Ward" HeaderText="Ward:"/>


        </Columns>
             </asp:GridView>

    <asp:ObjectDataSource ID="ObjPatientHistory" runat="server" TypeName="Hospital.Business.PatientHistory" SelectMethod="GetAll"></asp:ObjectDataSource>
</asp:Content>
