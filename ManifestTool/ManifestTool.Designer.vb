﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManifestTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManifestTool))
        Me.DriverTextBox = New System.Windows.Forms.TextBox()
        Me.DriverBrowseButton = New System.Windows.Forms.Button()
        Me.FileNameText = New System.Windows.Forms.TextBox()
        Me.FileActionBox = New System.Windows.Forms.ListBox()
        Me.ChecksumText = New System.Windows.Forms.TextBox()
        Me.ChecksumButton = New System.Windows.Forms.Button()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputBrowseButton = New System.Windows.Forms.Button()
        Me.InputLineText = New System.Windows.Forms.Label()
        Me.ChecksumDirectoryText = New System.Windows.Forms.TextBox()
        Me.ChecksumDirecoryBrowseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OutputLineText = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.ManualButton = New System.Windows.Forms.Button()
        Me.BatchButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DriverTextBox
        '
        Me.DriverTextBox.Location = New System.Drawing.Point(12, 12)
        Me.DriverTextBox.Name = "DriverTextBox"
        Me.DriverTextBox.Size = New System.Drawing.Size(529, 22)
        Me.DriverTextBox.TabIndex = 0
        '
        'DriverBrowseButton
        '
        Me.DriverBrowseButton.Location = New System.Drawing.Point(550, 12)
        Me.DriverBrowseButton.Name = "DriverBrowseButton"
        Me.DriverBrowseButton.Size = New System.Drawing.Size(110, 25)
        Me.DriverBrowseButton.TabIndex = 1
        Me.DriverBrowseButton.Text = "Browse"
        Me.DriverBrowseButton.UseVisualStyleBackColor = True
        '
        'FileNameText
        '
        Me.FileNameText.Location = New System.Drawing.Point(12, 255)
        Me.FileNameText.Name = "FileNameText"
        Me.FileNameText.Size = New System.Drawing.Size(529, 22)
        Me.FileNameText.TabIndex = 2
        '
        'FileActionBox
        '
        Me.FileActionBox.FormattingEnabled = True
        Me.FileActionBox.ItemHeight = 16
        Me.FileActionBox.Items.AddRange(New Object() {"0 - Delete File Or Directory", "1 - Create Directory", "2 - Required for Legal copy", "3 - SOE files", "4 - Server Specific Files", "5 - Create or Change Registry Entry", "6 - Delete Registry Entry", "7 - End User License Agreement"})
        Me.FileActionBox.Location = New System.Drawing.Point(12, 205)
        Me.FileActionBox.Name = "FileActionBox"
        Me.FileActionBox.Size = New System.Drawing.Size(529, 20)
        Me.FileActionBox.TabIndex = 3
        '
        'ChecksumText
        '
        Me.ChecksumText.Location = New System.Drawing.Point(12, 305)
        Me.ChecksumText.Name = "ChecksumText"
        Me.ChecksumText.Size = New System.Drawing.Size(529, 22)
        Me.ChecksumText.TabIndex = 4
        '
        'ChecksumButton
        '
        Me.ChecksumButton.Location = New System.Drawing.Point(550, 305)
        Me.ChecksumButton.Name = "ChecksumButton"
        Me.ChecksumButton.Size = New System.Drawing.Size(110, 25)
        Me.ChecksumButton.TabIndex = 5
        Me.ChecksumButton.Text = "Do Checksum"
        Me.ChecksumButton.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(12, 112)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(529, 22)
        Me.OutputTextBox.TabIndex = 6
        '
        'OutputBrowseButton
        '
        Me.OutputBrowseButton.Location = New System.Drawing.Point(550, 112)
        Me.OutputBrowseButton.Name = "OutputBrowseButton"
        Me.OutputBrowseButton.Size = New System.Drawing.Size(110, 25)
        Me.OutputBrowseButton.TabIndex = 7
        Me.OutputBrowseButton.Text = "Browse"
        Me.OutputBrowseButton.UseVisualStyleBackColor = True
        '
        'InputLineText
        '
        Me.InputLineText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InputLineText.BackColor = System.Drawing.Color.Transparent
        Me.InputLineText.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLineText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InputLineText.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.InputLineText.Location = New System.Drawing.Point(665, 12)
        Me.InputLineText.Name = "InputLineText"
        Me.InputLineText.Size = New System.Drawing.Size(156, 21)
        Me.InputLineText.TabIndex = 10
        Me.InputLineText.Text = "Processing Entry 0000"
        '
        'ChecksumDirectoryText
        '
        Me.ChecksumDirectoryText.Location = New System.Drawing.Point(12, 62)
        Me.ChecksumDirectoryText.Name = "ChecksumDirectoryText"
        Me.ChecksumDirectoryText.Size = New System.Drawing.Size(529, 22)
        Me.ChecksumDirectoryText.TabIndex = 11
        '
        'ChecksumDirecoryBrowseButton
        '
        Me.ChecksumDirecoryBrowseButton.Location = New System.Drawing.Point(550, 62)
        Me.ChecksumDirecoryBrowseButton.Name = "ChecksumDirecoryBrowseButton"
        Me.ChecksumDirecoryBrowseButton.Size = New System.Drawing.Size(110, 25)
        Me.ChecksumDirecoryBrowseButton.TabIndex = 12
        Me.ChecksumDirecoryBrowseButton.Text = "Browse"
        Me.ChecksumDirecoryBrowseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Input manifest or csv file"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(529, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Directory with files to checksum"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(529, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Output Manifest"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Location = New System.Drawing.Point(12, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(529, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Entry Type"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label5.Location = New System.Drawing.Point(12, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(529, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "File Name"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label6.Location = New System.Drawing.Point(12, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(529, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Checksum"
        '
        'OutputLineText
        '
        Me.OutputLineText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OutputLineText.BackColor = System.Drawing.Color.Transparent
        Me.OutputLineText.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLineText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OutputLineText.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.OutputLineText.Location = New System.Drawing.Point(665, 112)
        Me.OutputLineText.Name = "OutputLineText"
        Me.OutputLineText.Size = New System.Drawing.Size(156, 21)
        Me.OutputLineText.TabIndex = 19
        Me.OutputLineText.Text = "Output Line 0000"
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(420, 360)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(110, 25)
        Me.NextButton.TabIndex = 20
        Me.NextButton.Text = "Next Entry"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'DoneButton
        '
        Me.DoneButton.BackColor = System.Drawing.SystemColors.Control
        Me.DoneButton.Location = New System.Drawing.Point(665, 360)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(110, 25)
        Me.DoneButton.TabIndex = 21
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseMnemonic = False
        Me.DoneButton.UseVisualStyleBackColor = False
        '
        'ManualButton
        '
        Me.ManualButton.Location = New System.Drawing.Point(12, 360)
        Me.ManualButton.Name = "ManualButton"
        Me.ManualButton.Size = New System.Drawing.Size(110, 25)
        Me.ManualButton.TabIndex = 22
        Me.ManualButton.Text = "Start Manual"
        Me.ManualButton.UseVisualStyleBackColor = True
        '
        'BatchButton
        '
        Me.BatchButton.Location = New System.Drawing.Point(205, 360)
        Me.BatchButton.Name = "BatchButton"
        Me.BatchButton.Size = New System.Drawing.Size(110, 25)
        Me.BatchButton.TabIndex = 23
        Me.BatchButton.Text = "Start Batch"
        Me.BatchButton.UseVisualStyleBackColor = True
        '
        'ManifestTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 413)
        Me.Controls.Add(Me.BatchButton)
        Me.Controls.Add(Me.ManualButton)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.OutputLineText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChecksumDirecoryBrowseButton)
        Me.Controls.Add(Me.ChecksumDirectoryText)
        Me.Controls.Add(Me.InputLineText)
        Me.Controls.Add(Me.OutputBrowseButton)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.ChecksumButton)
        Me.Controls.Add(Me.ChecksumText)
        Me.Controls.Add(Me.FileActionBox)
        Me.Controls.Add(Me.FileNameText)
        Me.Controls.Add(Me.DriverBrowseButton)
        Me.Controls.Add(Me.DriverTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManifestTool"
        Me.Text = "Manifest Creation Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DriverTextBox As TextBox
    Friend WithEvents DriverBrowseButton As Button
    Friend WithEvents FileNameText As TextBox
    Friend WithEvents FileActionBox As ListBox
    Friend WithEvents ChecksumText As TextBox
    Friend WithEvents ChecksumButton As Button
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents OutputBrowseButton As Button
    Friend WithEvents InputLineText As Label
    Friend WithEvents ChecksumDirectoryText As TextBox
    Friend WithEvents ChecksumDirecoryBrowseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents OutputLineText As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents DoneButton As Button
    Friend WithEvents ManualButton As Button
    Friend WithEvents BatchButton As Button
End Class
