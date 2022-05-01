<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CronometroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpezarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PararToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaAtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btEmpezar = New System.Windows.Forms.Button()
        Me.btCuentaAtras = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btParar = New System.Windows.Forms.Button()
        Me.nudContador = New System.Windows.Forms.NumericUpDown()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nudContador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.CronometroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(251, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalizarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'FinalizarToolStripMenuItem
        '
        Me.FinalizarToolStripMenuItem.Name = "FinalizarToolStripMenuItem"
        Me.FinalizarToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.FinalizarToolStripMenuItem.Text = "Finalizar"
        '
        'CronometroToolStripMenuItem
        '
        Me.CronometroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpezarToolStripMenuItem, Me.PararToolStripMenuItem, Me.CuentaAtrasToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.CronometroToolStripMenuItem.Name = "CronometroToolStripMenuItem"
        Me.CronometroToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.CronometroToolStripMenuItem.Text = "Cronometro"
        '
        'EmpezarToolStripMenuItem
        '
        Me.EmpezarToolStripMenuItem.Name = "EmpezarToolStripMenuItem"
        Me.EmpezarToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.EmpezarToolStripMenuItem.Text = "Empezar"
        '
        'PararToolStripMenuItem
        '
        Me.PararToolStripMenuItem.Name = "PararToolStripMenuItem"
        Me.PararToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.PararToolStripMenuItem.Text = "Parar"
        '
        'CuentaAtrasToolStripMenuItem
        '
        Me.CuentaAtrasToolStripMenuItem.Name = "CuentaAtrasToolStripMenuItem"
        Me.CuentaAtrasToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.CuentaAtrasToolStripMenuItem.Text = "Cuenta atras"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'Timer1
        '
        '
        'btEmpezar
        '
        Me.btEmpezar.Location = New System.Drawing.Point(32, 123)
        Me.btEmpezar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btEmpezar.Name = "btEmpezar"
        Me.btEmpezar.Size = New System.Drawing.Size(188, 33)
        Me.btEmpezar.TabIndex = 2
        Me.btEmpezar.Text = "Empezar"
        Me.btEmpezar.UseVisualStyleBackColor = True
        '
        'btCuentaAtras
        '
        Me.btCuentaAtras.Location = New System.Drawing.Point(32, 222)
        Me.btCuentaAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btCuentaAtras.Name = "btCuentaAtras"
        Me.btCuentaAtras.Size = New System.Drawing.Size(188, 33)
        Me.btCuentaAtras.TabIndex = 3
        Me.btCuentaAtras.Text = "Cuenta atras"
        Me.btCuentaAtras.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(32, 270)
        Me.btReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(188, 33)
        Me.btReset.TabIndex = 4
        Me.btReset.Text = "Reset"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btParar
        '
        Me.btParar.Location = New System.Drawing.Point(32, 174)
        Me.btParar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btParar.Name = "btParar"
        Me.btParar.Size = New System.Drawing.Size(188, 33)
        Me.btParar.TabIndex = 5
        Me.btParar.Text = "Parar"
        Me.btParar.UseVisualStyleBackColor = True
        '
        'nudContador
        '
        Me.nudContador.BackColor = System.Drawing.Color.Black
        Me.nudContador.CausesValidation = False
        Me.nudContador.DecimalPlaces = 2
        Me.nudContador.Font = New System.Drawing.Font("Courier New", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudContador.ForeColor = System.Drawing.Color.White
        Me.nudContador.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudContador.Location = New System.Drawing.Point(32, 44)
        Me.nudContador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudContador.Maximum = New Decimal(New Integer() {5959, 0, 0, 131072})
        Me.nudContador.Name = "nudContador"
        Me.nudContador.Size = New System.Drawing.Size(188, 61)
        Me.nudContador.TabIndex = 1
        Me.nudContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer2
        '
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 326)
        Me.Controls.Add(Me.btParar)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.btCuentaAtras)
        Me.Controls.Add(Me.btEmpezar)
        Me.Controls.Add(Me.nudContador)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nudContador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CronometroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpezarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PararToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentaAtrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btEmpezar As Button
    Friend WithEvents btCuentaAtras As Button
    Friend WithEvents btReset As Button
    Friend WithEvents btParar As Button
    Friend WithEvents nudContador As NumericUpDown
    Friend WithEvents Timer2 As Timer
End Class
