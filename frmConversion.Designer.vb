<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversion
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
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblConverterTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtUnitInput = New System.Windows.Forms.TextBox()
        Me.grpConvert = New System.Windows.Forms.GroupBox()
        Me.radMToIn = New System.Windows.Forms.RadioButton()
        Me.radInToM = New System.Windows.Forms.RadioButton()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConvert.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.BackgroundImage = Global.BuildingPlansConversion.My.Resources.Resources.building
        Me.picBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBuilding.Location = New System.Drawing.Point(1, 12)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(250, 150)
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblConverterTitle
        '
        Me.lblConverterTitle.AutoSize = True
        Me.lblConverterTitle.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverterTitle.Location = New System.Drawing.Point(315, 47)
        Me.lblConverterTitle.Name = "lblConverterTitle"
        Me.lblConverterTitle.Size = New System.Drawing.Size(259, 38)
        Me.lblConverterTitle.TabIndex = 1
        Me.lblConverterTitle.Text = "Converter App"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(318, 105)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(164, 46)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        '
        'txtUnitInput
        '
        Me.txtUnitInput.BackColor = System.Drawing.Color.Black
        Me.txtUnitInput.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitInput.ForeColor = System.Drawing.Color.White
        Me.txtUnitInput.Location = New System.Drawing.Point(581, 119)
        Me.txtUnitInput.Name = "txtUnitInput"
        Me.txtUnitInput.Size = New System.Drawing.Size(100, 32)
        Me.txtUnitInput.TabIndex = 3
        Me.txtUnitInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConvert
        '
        Me.grpConvert.BackColor = System.Drawing.Color.Chartreuse
        Me.grpConvert.Controls.Add(Me.radMToIn)
        Me.grpConvert.Controls.Add(Me.radInToM)
        Me.grpConvert.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvert.Location = New System.Drawing.Point(365, 176)
        Me.grpConvert.Name = "grpConvert"
        Me.grpConvert.Size = New System.Drawing.Size(278, 91)
        Me.grpConvert.TabIndex = 4
        Me.grpConvert.TabStop = False
        Me.grpConvert.Text = "Convert Measurement"
        '
        'radMToIn
        '
        Me.radMToIn.AutoSize = True
        Me.radMToIn.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMToIn.Location = New System.Drawing.Point(7, 61)
        Me.radMToIn.Name = "radMToIn"
        Me.radMToIn.Size = New System.Drawing.Size(183, 25)
        Me.radMToIn.TabIndex = 1
        Me.radMToIn.TabStop = True
        Me.radMToIn.Text = "Meters to Inches"
        Me.radMToIn.UseVisualStyleBackColor = True
        '
        'radInToM
        '
        Me.radInToM.AutoSize = True
        Me.radInToM.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInToM.Location = New System.Drawing.Point(7, 30)
        Me.radInToM.Name = "radInToM"
        Me.radInToM.Size = New System.Drawing.Size(183, 25)
        Me.radInToM.TabIndex = 0
        Me.radInToM.TabStop = True
        Me.radInToM.Text = "Inches to Meters"
        Me.radInToM.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(361, 302)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(186, 24)
        Me.lblResults.TabIndex = 5
        Me.lblResults.Text = "Results Go Here"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.OliveDrab
        Me.btnConvert.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(87, 365)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(150, 40)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OliveDrab
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(334, 365)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 40)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OliveDrab
        Me.btnExit.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(581, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.grpConvert)
        Me.Controls.Add(Me.txtUnitInput)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblConverterTitle)
        Me.Controls.Add(Me.picBuilding)
        Me.Name = "frmConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Building Plans Conversion"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConvert.ResumeLayout(False)
        Me.grpConvert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblConverterTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtUnitInput As TextBox
    Friend WithEvents grpConvert As GroupBox
    Friend WithEvents radMToIn As RadioButton
    Friend WithEvents radInToM As RadioButton
    Friend WithEvents lblResults As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
