<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private menuMain As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuMain = New System.Windows.Forms.MainMenu
        Me.lblAddNewProduct = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblUseByDate = New System.Windows.Forms.Label
        Me.menuExit = New System.Windows.Forms.MenuItem
        Me.menuSave = New System.Windows.Forms.MenuItem
        Me.dtpUseByDate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.MenuItems.Add(Me.menuExit)
        Me.menuMain.MenuItems.Add(Me.menuSave)
        '
        'lblAddNewProduct
        '
        Me.lblAddNewProduct.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddNewProduct.Location = New System.Drawing.Point(4, 4)
        Me.lblAddNewProduct.Name = "lblAddNewProduct"
        Me.lblAddNewProduct.Size = New System.Drawing.Size(214, 34)
        Me.lblAddNewProduct.Text = "Add New Product"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(4, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 21)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(4, 49)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 20)
        Me.lblName.Text = "Name"
        '
        'lblUseByDate
        '
        Me.lblUseByDate.Location = New System.Drawing.Point(4, 113)
        Me.lblUseByDate.Name = "lblUseByDate"
        Me.lblUseByDate.Size = New System.Drawing.Size(100, 20)
        Me.lblUseByDate.Text = "Use by Date"
        '
        'menuExit
        '
        Me.menuExit.Text = "Exit"
        '
        'menuSave
        '
        Me.menuSave.Text = "Save"
        '
        'dtpUseByDate
        '
        Me.dtpUseByDate.Location = New System.Drawing.Point(4, 136)
        Me.dtpUseByDate.Name = "dtpUseByDate"
        Me.dtpUseByDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpUseByDate.TabIndex = 7
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.dtpUseByDate)
        Me.Controls.Add(Me.lblUseByDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblAddNewProduct)
        Me.Menu = Me.menuMain
        Me.Name = "Main"
        Me.Text = "Products"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAddNewProduct As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents menuExit As System.Windows.Forms.MenuItem
    Friend WithEvents menuSave As System.Windows.Forms.MenuItem
    Friend WithEvents lblUseByDate As System.Windows.Forms.Label
    Friend WithEvents dtpUseByDate As System.Windows.Forms.DateTimePicker

End Class
