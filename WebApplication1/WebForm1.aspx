<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="cbOnayla" runat="server" Text="Onaylıyorum" />
        </div>
        <p>
            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Ürünlerimiz</asp:ListItem>
                <asp:ListItem>Bilgisayar</asp:ListItem>
                <asp:ListItem>Monitör</asp:ListItem>
                <asp:ListItem>Aksesuar</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Resimler/logo.png" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label ile yazı"></asp:Label>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
        </p>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Onayla" />
        </p>
        <p>
            <asp:TextBox ID="txtGiris" runat="server"></asp:TextBox>
            <asp:Button ID="btnGiris" runat="server" Text="Literale yazdır" OnClick="btnGiris_Click" />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            <input id="Text1" type="text" />
            <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <div>
        </div>
        <img alt="" src="" />

    </form>
</body>
</html>
