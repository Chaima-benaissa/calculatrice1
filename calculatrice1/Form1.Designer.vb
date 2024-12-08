<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_a = New TextBox()
        bt_plus = New Button()
        bt_moin = New Button()
        bt_fois = New Button()
        bt_div = New Button()
        rest = New Button()
        txt_b = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        equal = New Button()
        resultat = New Label()
        SuspendLayout()
        ' 
        ' txt_a
        ' 
        txt_a.BackColor = SystemColors.ScrollBar
        txt_a.Font = New Font("Viner Hand ITC", 16.2F, FontStyle.Bold)
        txt_a.Location = New Point(153, 43)
        txt_a.Multiline = True
        txt_a.Name = "txt_a"
        txt_a.Size = New Size(412, 67)
        txt_a.TabIndex = 0
        ' 
        ' bt_plus
        ' 
        bt_plus.BackColor = SystemColors.ScrollBar
        bt_plus.Font = New Font("Viner Hand ITC", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        bt_plus.ForeColor = Color.DarkOrange
        bt_plus.Location = New Point(484, 283)
        bt_plus.Name = "bt_plus"
        bt_plus.Size = New Size(72, 45)
        bt_plus.TabIndex = 10
        bt_plus.Text = "+"
        bt_plus.UseVisualStyleBackColor = False
        ' 
        ' bt_moin
        ' 
        bt_moin.BackColor = SystemColors.ScrollBar
        bt_moin.Font = New Font("Viner Hand ITC", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        bt_moin.ForeColor = Color.DarkOrange
        bt_moin.Location = New Point(106, 283)
        bt_moin.Name = "bt_moin"
        bt_moin.Size = New Size(72, 45)
        bt_moin.TabIndex = 11
        bt_moin.Text = "-"
        bt_moin.UseVisualStyleBackColor = False
        ' 
        ' bt_fois
        ' 
        bt_fois.BackColor = SystemColors.ScrollBar
        bt_fois.Font = New Font("Viner Hand ITC", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        bt_fois.ForeColor = Color.DarkOrange
        bt_fois.Location = New Point(305, 283)
        bt_fois.Name = "bt_fois"
        bt_fois.Size = New Size(72, 45)
        bt_fois.TabIndex = 12
        bt_fois.Text = "*"
        bt_fois.UseVisualStyleBackColor = False
        ' 
        ' bt_div
        ' 
        bt_div.BackColor = SystemColors.ScrollBar
        bt_div.Font = New Font("Viner Hand ITC", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        bt_div.ForeColor = Color.DarkOrange
        bt_div.Location = New Point(669, 283)
        bt_div.Name = "bt_div"
        bt_div.Size = New Size(72, 45)
        bt_div.TabIndex = 13
        bt_div.Text = "/"
        bt_div.UseVisualStyleBackColor = False
        ' 
        ' rest
        ' 
        rest.BackColor = SystemColors.ScrollBar
        rest.Font = New Font("Viner Hand ITC", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        rest.ForeColor = Color.DarkOrange
        rest.Location = New Point(484, 366)
        rest.Name = "rest"
        rest.Size = New Size(184, 45)
        rest.TabIndex = 14
        rest.Text = "reset"
        rest.UseVisualStyleBackColor = False
        ' 
        ' txt_b
        ' 
        txt_b.BackColor = SystemColors.ScrollBar
        txt_b.Font = New Font("Viner Hand ITC", 16.2F, FontStyle.Bold)
        txt_b.Location = New Point(153, 160)
        txt_b.Multiline = True
        txt_b.Name = "txt_b"
        txt_b.Size = New Size(412, 67)
        txt_b.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Viner Hand ITC", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label1.Location = New Point(64, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 48)
        Label1.TabIndex = 16
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Viner Hand ITC", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label2.Location = New Point(64, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 48)
        Label2.TabIndex = 17
        Label2.Text = "B"
        ' 
        ' equal
        ' 
        equal.BackColor = SystemColors.ScrollBar
        equal.Font = New Font("Viner Hand ITC", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        equal.ForeColor = Color.DarkOrange
        equal.Location = New Point(153, 366)
        equal.Name = "equal"
        equal.Size = New Size(184, 45)
        equal.TabIndex = 18
        equal.Text = "="
        equal.UseVisualStyleBackColor = False
        ' 
        ' resultat
        ' 
        resultat.AutoSize = True
        resultat.Font = New Font("Viner Hand ITC", 18F, FontStyle.Bold Or FontStyle.Italic)
        resultat.Location = New Point(332, 456)
        resultat.Name = "resultat"
        resultat.Size = New Size(152, 48)
        resultat.TabIndex = 19
        resultat.Text = "Resultat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGoldenrod
        ClientSize = New Size(800, 513)
        Controls.Add(resultat)
        Controls.Add(equal)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_b)
        Controls.Add(rest)
        Controls.Add(bt_div)
        Controls.Add(bt_fois)
        Controls.Add(bt_moin)
        Controls.Add(bt_plus)
        Controls.Add(txt_a)
        Name = "Form1"
        Text = "calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_a As TextBox
    Friend WithEvents bt_plus As Button
    Friend WithEvents bt_moin As Button
    Friend WithEvents bt_fois As Button
    Friend WithEvents bt_div As Button
    Friend WithEvents rest As Button
    Friend WithEvents txt_b As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents equal As Button
    Friend WithEvents resultat As Label

End Class
