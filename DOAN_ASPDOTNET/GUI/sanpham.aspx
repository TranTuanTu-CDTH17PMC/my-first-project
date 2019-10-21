<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="GUI.sanpham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>mã sản phẩm</td>
                    <td>
                        <asp:TextBox ID="txtmasp" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>tên sản phẩm</td>
                    <td>
                        <asp:TextBox ID="txttensp" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>giá</td>
                    <td>
                        <asp:TextBox ID="txtgia" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>thông số</td>
                    <td>
                        <asp:TextBox ID="txtthongso" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>số lượng tồn kho</td>
                    <td>
                        <asp:TextBox ID="txtsoluongtonkho" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gói bảo hành</td>
                    <td>
                        <asp:TextBox ID="txtgoibaohanh" runat="server"></asp:TextBox></td>

                </tr>
                  <tr>
                    <td>khuyến mãi</td>
                    <td>
                        <asp:TextBox ID="txtkhuyenmai" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnthemsp" runat="server" Text="THÊM" OnClick="btnthemsp_Click" />
                        <input type="reset" value="Hủy bỏ" />
                    </td>
                </tr>
            </table>
        </div>
   
    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="MaSP" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="MaSP" HeaderText="MaSP" ReadOnly="True" SortExpression="MaSP" />
            <asp:BoundField DataField="TenSP" HeaderText="TenSP" SortExpression="TenSP" />
            <asp:BoundField DataField="ThongTin" HeaderText="ThongTin" SortExpression="ThongTin" />
            <asp:BoundField DataField="GiaTien" HeaderText="GiaTien" SortExpression="GiaTien" />
            <asp:BoundField DataField="SoLuongTonKho" HeaderText="SoLuongTonKho" SortExpression="SoLuongTonKho" />
            <asp:BoundField DataField="MaLoaiSP" HeaderText="MaLoaiSP" SortExpression="MaLoaiSP" />
            <asp:BoundField DataField="AnhMinhHoa" HeaderText="AnhMinhHoa" SortExpression="AnhMinhHoa" />
            <asp:CheckBoxField DataField="TrangThai" HeaderText="TrangThai" SortExpression="TrangThai" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandName="" Text="Chọn" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebBanHangConnectionString %>" SelectCommand="SELECT * FROM [SanPham]"></asp:SqlDataSource>
         </form>
</body>
</html>
