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
        btnAdd = New Button()
        txtFirstNumber = New TextBox()
        lblFirstNumber = New Label()
        txtSecondNumber = New TextBox()
        lblSecondNumber = New Label()
        txtResultIs = New TextBox()
        lblSumIs = New Label()
        btnDivide = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(218, 324)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtFirstNumber
        ' 
        txtFirstNumber.Location = New Point(447, 95)
        txtFirstNumber.Name = "txtFirstNumber"
        txtFirstNumber.Size = New Size(125, 27)
        txtFirstNumber.TabIndex = 1
        ' 
        ' lblFirstNumber
        ' 
        lblFirstNumber.AutoSize = True
        lblFirstNumber.Location = New Point(218, 102)
        lblFirstNumber.Name = "lblFirstNumber"
        lblFirstNumber.Size = New Size(94, 20)
        lblFirstNumber.TabIndex = 2
        lblFirstNumber.Text = "First Number"
        ' 
        ' txtSecondNumber
        ' 
        txtSecondNumber.Location = New Point(447, 163)
        txtSecondNumber.Name = "txtSecondNumber"
        txtSecondNumber.Size = New Size(125, 27)
        txtSecondNumber.TabIndex = 1
        ' 
        ' lblSecondNumber
        ' 
        lblSecondNumber.AutoSize = True
        lblSecondNumber.Location = New Point(218, 170)
        lblSecondNumber.Name = "lblSecondNumber"
        lblSecondNumber.Size = New Size(116, 20)
        lblSecondNumber.TabIndex = 2
        lblSecondNumber.Text = "Second Number"
        ' 
        ' txtResultIs
        ' 
        txtResultIs.Location = New Point(447, 227)
        txtResultIs.Name = "txtResultIs"
        txtResultIs.Size = New Size(125, 27)
        txtResultIs.TabIndex = 1
        ' 
        ' lblSumIs
        ' 
        lblSumIs.AutoSize = True
        lblSumIs.Location = New Point(218, 234)
        lblSumIs.Name = "lblSumIs"
        lblSumIs.Size = New Size(63, 20)
        lblSumIs.TabIndex = 2
        lblSumIs.Text = "Result Is"
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(462, 324)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(94, 29)
        btnDivide.TabIndex = 0
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(339, 324)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(94, 29)
        btnSubtract.TabIndex = 0
        btnSubtract.Text = "Subtract"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(586, 324)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(94, 29)
        btnMultiply.TabIndex = 0
        btnMultiply.Text = "Multiply"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSumIs)
        Controls.Add(txtResultIs)
        Controls.Add(lblSecondNumber)
        Controls.Add(txtSecondNumber)
        Controls.Add(lblFirstNumber)
        Controls.Add(txtFirstNumber)
        Controls.Add(btnDivide)
        Controls.Add(btnSubtract)
        Controls.Add(btnMultiply)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents lblSecondNumber As Label
    Friend WithEvents txtResultIs As TextBox
    Friend WithEvents lblSumIs As Label
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
End Class
