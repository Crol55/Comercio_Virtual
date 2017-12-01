<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="paginainicio.aspx.cs" Inherits="paginainicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label7" runat="server" ForeColor="White" Text="Registro de Usuarios"></asp:Label>
            </td>
        </tr>
        <tr>
            <td rowspan="9">
                &nbsp;</td>
            <td style="width: 115px">
                <asp:Label ID="Label8" runat="server" ForeColor="White" Text="Usuario"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtuser" runat="server" MaxLength="5" Width="215px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                <asp:Label ID="Label1" runat="server" Text="Nombre" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server" Width="219px" MaxLength="20"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                <asp:Label ID="Label2" runat="server" Text="Apellido" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtapellido" runat="server" Width="219px" MaxLength="35"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                <asp:Label ID="Label3" runat="server" Text="Correo" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcorreo" runat="server" Width="221px" MaxLength="30"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                <asp:Label ID="Label4" runat="server" Text="contraseña" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcontrasena" runat="server" Width="219px" MaxLength="25"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                <asp:Label ID="Label5" runat="server" Text="tipo" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" ForeColor="White">
                    <asp:ListItem>Usuario</asp:ListItem>
                    <asp:ListItem>socio</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                <asp:Label ID="Label6" runat="server" Text="Telefono" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server" Width="219px" MaxLength="8"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                <asp:Label ID="Label9" runat="server" ForeColor="White" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

