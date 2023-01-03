<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibraryFunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookBorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookEntryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StudentToolStripMenuItem, Me.LibraryFunctionToolStripMenuItem, Me.BookEntryToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1352, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(49, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentEntryToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'StudentEntryToolStripMenuItem
        '
        Me.StudentEntryToolStripMenuItem.Name = "StudentEntryToolStripMenuItem"
        Me.StudentEntryToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.StudentEntryToolStripMenuItem.Text = "Student Entry"
        '
        'LibraryFunctionToolStripMenuItem
        '
        Me.LibraryFunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookBorrowToolStripMenuItem})
        Me.LibraryFunctionToolStripMenuItem.Name = "LibraryFunctionToolStripMenuItem"
        Me.LibraryFunctionToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.LibraryFunctionToolStripMenuItem.Text = "Library"
        '
        'BookBorrowToolStripMenuItem
        '
        Me.BookBorrowToolStripMenuItem.Name = "BookBorrowToolStripMenuItem"
        Me.BookBorrowToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.BookBorrowToolStripMenuItem.Text = "Book Borrow"
        '
        'BookEntryToolStripMenuItem
        '
        Me.BookEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookEntryToolStripMenuItem1})
        Me.BookEntryToolStripMenuItem.Name = "BookEntryToolStripMenuItem"
        Me.BookEntryToolStripMenuItem.Size = New System.Drawing.Size(63, 25)
        Me.BookEntryToolStripMenuItem.Text = "Book"
        '
        'BookEntryToolStripMenuItem1
        '
        Me.BookEntryToolStripMenuItem1.Name = "BookEntryToolStripMenuItem1"
        Me.BookEntryToolStripMenuItem1.Size = New System.Drawing.Size(166, 26)
        Me.BookEntryToolStripMenuItem1.Text = "Book Entry"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendingReturnToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(74, 25)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'PendingReturnToolStripMenuItem
        '
        Me.PendingReturnToolStripMenuItem.Name = "PendingReturnToolStripMenuItem"
        Me.PendingReturnToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.PendingReturnToolStripMenuItem.Text = "Report"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Libraryvb.My.Resources.Resources._3371_blue_waves_1920x1200_abstract_wallpaper1
        Me.ClientSize = New System.Drawing.Size(1352, 730)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryFunctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookBorrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendingReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookEntryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
