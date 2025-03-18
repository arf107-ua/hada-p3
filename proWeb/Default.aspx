<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="proWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Adrián Requena Fernández - DNI 24509047V</p>

    <h2 style="text-align: center;background-color: lightblue; padding: 10px; text-align: center;">
        HADA P3 - CURSO 2024/25</h2>
    <div>
        <h3>Products management</h3>
    </div>

    <table style="width: 100%; margin-top: 10px;">
        <tr>
            <td style="width: 120px;"><b>Code</b></td>
            <td><asp:TextBox ID="txtCode" runat="server" Width="200px" MaxLength="16"></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Name</b></td>
            <td><asp:TextBox ID="txtName" runat="server" Width="200px" MaxLength="32"></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Amount</b></td>
            <td><asp:TextBox ID="txtAmount" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Category</b></td>
            <td>
                <asp:DropDownList ID="ddlCategory" runat="server" Width="210px">
                    <asp:ListItem Text="Computing" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Telephony" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Gaming" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Home appliances" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><b>Price</b></td>
            <td><asp:TextBox ID="txtPrice" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Creation Date</b></td>
            <td><asp:TextBox ID="txtCreationDate" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
    </table>

    <div style="margin-top: 15px; text-align: center;">
        <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" CssClass="form-button" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" CssClass="form-button" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="form-button" />
        <asp:Button ID="btnRead" runat="server" Text="Read" OnClick="btnRead_Click" CssClass="form-button" />
        <asp:Button ID="btnReadFirst" runat="server" Text="Read First" CssClass="form-button" />
        <asp:Button ID="btnReadPrev" runat="server" Text="Read Prev" CssClass="form-button" />
        <asp:Button ID="btnReadNext" runat="server" Text="Read Next" CssClass="form-button" />
    </div>

    <div style="margin-top: 10px; text-align: center;">
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
