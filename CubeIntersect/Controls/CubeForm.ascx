<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CubeForm.ascx.cs" Inherits="CubeIntersect.Controls.CubeForm" %>
<div>
    <h2>
        <asp:Label ID="lblTitle" runat="server" /></h2>
    <p>
        <label>
            X:
        </label>
        <asp:TextBox ID="txtXCoord" runat="server" OnTextChanged="ValueChanged" ClientIDMode="Static"></asp:TextBox>
        <asp:CustomValidator ID="cvXCoord" runat="server" ErrorMessage="X needs to be a valid decimal."
            ControlToValidate="txtXCoord" OnServerValidate="cvCoord_Validate"></asp:CustomValidator><asp:RequiredFieldValidator
                ID="rfvX" runat="server" ErrorMessage="X is obligatory." ControlToValidate="txtXCoord"></asp:RequiredFieldValidator>
    </p>
    <p>
        <label>
            Y:
        </label>
        <asp:TextBox ID="txtYCoord" runat="server" OnTextChanged="ValueChanged" ClientIDMode="Static"></asp:TextBox>
        <asp:CustomValidator ID="cvYCoord" runat="server" ErrorMessage="Y needs to be a valid decimal."
            ControlToValidate="txtYCoord" OnServerValidate="cvCoord_Validate"></asp:CustomValidator><asp:RequiredFieldValidator
                ID="rfvY" runat="server" ErrorMessage="Y is obligatory." ControlToValidate="txtYCoord"></asp:RequiredFieldValidator>
    </p>
    <p>
        <label>
            Z:
        </label>
        <asp:TextBox ID="txtZCoord" runat="server" OnTextChanged="ValueChanged" ClientIDMode="Static"></asp:TextBox>
        <asp:CustomValidator ID="cvZCoord" runat="server" ErrorMessage="Z needs to be a valid decimal."
            ControlToValidate="txtZCoord" OnServerValidate="cvCoord_Validate"></asp:CustomValidator><asp:RequiredFieldValidator
                ID="rfvZ" runat="server" ErrorMessage="Z is obligatory." ControlToValidate="txtZCoord"></asp:RequiredFieldValidator>
    </p>
    <p>
        <label>
            Size:
        </label>
        <asp:TextBox ID="txtSize" runat="server" OnTextChanged="ValueChanged" ClientIDMode="Static"></asp:TextBox>
        <asp:CustomValidator ID="cvSize" runat="server" ErrorMessage="Size needs to be a valid positive decimal."
            ControlToValidate="txtSize" OnServerValidate="cvSize_Validate"></asp:CustomValidator><asp:RequiredFieldValidator
                ID="RequiredFieldValidator1" runat="server" ErrorMessage="Size is obligatory."
                ControlToValidate="txtSize"></asp:RequiredFieldValidator>
    </p>
</div>
