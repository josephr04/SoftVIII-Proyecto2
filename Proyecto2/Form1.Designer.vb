<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel4 = New Panel()
        Button4 = New Button()
        Panel5 = New Panel()
        Button5 = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        Button2 = New Button()
        ParrotWidgetPanel1 = New ReaLTaiizor.Controls.ParrotWidgetPanel()
        FlowLayoutPanel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        FlowLayoutPanel1.Controls.Add(Panel4)
        FlowLayoutPanel1.Controls.Add(Panel5)
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Dock = DockStyle.Left
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 100, 0, 0)
        FlowLayoutPanel1.Size = New Size(235, 784)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button4)
        Panel4.Cursor = Cursors.Hand
        Panel4.Location = New Point(3, 103)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(0, 30, 0, 0)
        Panel4.Size = New Size(247, 59)
        Panel4.TabIndex = 6
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(-14, -12)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(25, 0, 0, 0)
        Button4.Size = New Size(249, 80)
        Button4.TabIndex = 1
        Button4.Text = "                      Cheques"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Button5)
        Panel5.Cursor = Cursors.Hand
        Panel5.Location = New Point(3, 168)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(0, 30, 0, 0)
        Panel5.Size = New Size(247, 59)
        Panel5.TabIndex = 7
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(-6, -4)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(25, 0, 0, 0)
        Button5.Size = New Size(241, 80)
        Button5.TabIndex = 1
        Button5.Text = "                    Depósitos"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Cursor = Cursors.Hand
        Panel1.Location = New Point(3, 233)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 30, 0, 0)
        Panel1.Size = New Size(247, 59)
        Panel1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(-14, -4)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(25, 0, 0, 0)
        Button1.Size = New Size(249, 80)
        Button1.TabIndex = 1
        Button1.Text = "             Conciliación Bancaria"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button2)
        Panel2.Cursor = Cursors.Hand
        Panel2.Location = New Point(3, 298)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 30, 0, 0)
        Panel2.Size = New Size(247, 59)
        Panel2.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(-14, -4)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(25, 0, 0, 0)
        Button2.Size = New Size(249, 80)
        Button2.TabIndex = 1
        Button2.Text = "                      Salir del " & vbCrLf & "                      Sistema"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ParrotWidgetPanel1
        ' 
        ParrotWidgetPanel1.ControlsAsWidgets = False
        ParrotWidgetPanel1.Location = New Point(234, 0)
        ParrotWidgetPanel1.Name = "ParrotWidgetPanel1"
        ParrotWidgetPanel1.Size = New Size(1096, 784)
        ParrotWidgetPanel1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 784)
        Controls.Add(ParrotWidgetPanel1)
        Controls.Add(FlowLayoutPanel1)
        Name = "Form1"
        Text = "Form1"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ParrotWidgetPanel1 As ReaLTaiizor.Controls.ParrotWidgetPanel

End Class
