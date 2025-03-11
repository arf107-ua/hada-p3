<%@ Page Title="Products Management" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="proWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .header {
            background-color: #33cccc;
            text-align: center;
            padding: 15px;
            font-size: 20px;
            font-weight: bold;
        }
        .container {
            width: 50%;
            margin: auto;
            padding: 20px;
        }
        .form-group {
            margin-bottom: 10px;
        }
        label {
            font-weight: bold;
        }
        input, select {
            width: 100%;
            padding: 5px;
            margin-top: 5px;
        }
        .buttons {
            margin-top: 10px;
        }
        .error-message {
            color: red;
            font-weight: bold;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Adrián Requena Fernández - DNI 24509047V
    </p>

    <div class="header">
        HADA P3 - CURSO 2024/25
    </div>

    <div class="container">
        <h2>Products Management</h2>

        <div class="form-group">
            <label for="txtCode">Code</label>
            <asp:TextBox ID="txtCode" runat="server" MaxLength="16" OnTextChanged="txtCode_TextChanged"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtName">Name</label>
            <asp:TextBox ID="txtName" runat="server" MaxLength="32"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtAmount">Amount</label>
            <asp:TextBox ID="txtAmount" runat="server" TextMode="Number"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="ddlCategory">Category</label>
            <asp:DropDownList ID="ddlCategory" runat="server">
                <asp:ListItem Value="0">Computing</asp:ListItem>
                <asp:ListItem Value="1">Telephony</asp:ListItem>
                <asp:ListItem Value="2">Gaming</asp:ListItem>
                <asp:ListItem Value="3">Home appliances</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <label for="txtPrice">Price</label>
            <asp:TextBox ID="txtPrice" runat="server" TextMode="Number"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtCreationDate">Creation Date</label>
            <asp:TextBox ID="txtCreationDate" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
        </div>

        <div class="buttons">
            <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnRead" runat="server" Text="Read" OnClick="btnRead_Click" />
            <asp:Button ID="btnReadFirst" runat="server" Text="Read First" OnClick="btnReadFirst_Click" />
            <asp:Button ID="btnReadPrev" runat="server" Text="Read Prev" OnClick="btnReadPrev_Click" />
            <asp:Button ID="btnReadNext" runat="server" Text="Read Next" OnClick="btnReadNext_Click" />
        </div>

        <br />
        <asp:Label ID="lblMessage" runat="server" CssClass="error-message"></asp:Label>
    </div>
</asp:Content>



