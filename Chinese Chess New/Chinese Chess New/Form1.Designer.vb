<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualBoard
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
        Me.components = New System.ComponentModel.Container()
        Me.ChessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerTurn = New System.Windows.Forms.PictureBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        CType(Me.PlayerTurn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChessTimer
        '
        '
        'PlayerTurn
        '
        Me.PlayerTurn.Location = New System.Drawing.Point(319, 375)
        Me.PlayerTurn.Name = "PlayerTurn"
        Me.PlayerTurn.Size = New System.Drawing.Size(20, 19)
        Me.PlayerTurn.TabIndex = 1
        Me.PlayerTurn.TabStop = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(345, 375)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 13)
        Me.StatusLabel.TabIndex = 2
        '
        'VisualBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chinese_Chess_New.My.Resources.Resources.Board
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 761)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.PlayerTurn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VisualBoard"
        Me.Text = "VisualBoard"
        CType(Me.PlayerTurn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChessTimer As Timer
    Friend WithEvents PlayerTurn As PictureBox
    Friend WithEvents StatusLabel As Label
End Class
