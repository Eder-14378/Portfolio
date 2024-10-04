<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Bot1 = New System.Windows.Forms.Button()
        Me.Bot0 = New System.Windows.Forms.Button()
        Me.BotCalcular = New System.Windows.Forms.Button()
        Me.Somar = New System.Windows.Forms.Button()
        Me.BotSubtrair = New System.Windows.Forms.Button()
        Me.Bot2 = New System.Windows.Forms.Button()
        Me.BotBackspace = New System.Windows.Forms.Button()
        Me.Bot3 = New System.Windows.Forms.Button()
        Me.Bot6 = New System.Windows.Forms.Button()
        Me.BotMultiplicar = New System.Windows.Forms.Button()
        Me.Bot4 = New System.Windows.Forms.Button()
        Me.Bot8 = New System.Windows.Forms.Button()
        Me.Bot5 = New System.Windows.Forms.Button()
        Me.Bot9 = New System.Windows.Forms.Button()
        Me.BotDividir = New System.Windows.Forms.Button()
        Me.Bot7 = New System.Windows.Forms.Button()
        Me.Txtop = New System.Windows.Forms.TextBox()
        Me.TxtNumero1 = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.BotPonto = New System.Windows.Forms.Button()
        Me.BotClean = New System.Windows.Forms.Button()
        Me.BotInverter = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'Bot1
        '
        Me.Bot1.Location = New System.Drawing.Point(12, 285)
        Me.Bot1.Name = "Bot1"
        Me.Bot1.Size = New System.Drawing.Size(75, 57)
        Me.Bot1.TabIndex = 0
        Me.Bot1.Text = "1"
        Me.Bot1.UseVisualStyleBackColor = True
        '
        'Bot0
        '
        Me.Bot0.Location = New System.Drawing.Point(93, 348)
        Me.Bot0.Name = "Bot0"
        Me.Bot0.Size = New System.Drawing.Size(75, 57)
        Me.Bot0.TabIndex = 0
        Me.Bot0.Text = "0"
        Me.Bot0.UseVisualStyleBackColor = True
        '
        'BotCalcular
        '
        Me.BotCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BotCalcular.Location = New System.Drawing.Point(255, 348)
        Me.BotCalcular.Name = "BotCalcular"
        Me.BotCalcular.Size = New System.Drawing.Size(75, 57)
        Me.BotCalcular.TabIndex = 0
        Me.BotCalcular.Text = "="
        Me.BotCalcular.UseVisualStyleBackColor = False
        '
        'Somar
        '
        Me.Somar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Somar.Location = New System.Drawing.Point(255, 285)
        Me.Somar.Name = "Somar"
        Me.Somar.Size = New System.Drawing.Size(75, 57)
        Me.Somar.TabIndex = 0
        Me.Somar.Text = "+"
        Me.Somar.UseVisualStyleBackColor = False
        '
        'BotSubtrair
        '
        Me.BotSubtrair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BotSubtrair.Location = New System.Drawing.Point(255, 222)
        Me.BotSubtrair.Name = "BotSubtrair"
        Me.BotSubtrair.Size = New System.Drawing.Size(75, 57)
        Me.BotSubtrair.TabIndex = 0
        Me.BotSubtrair.Text = "-"
        Me.BotSubtrair.UseVisualStyleBackColor = False
        '
        'Bot2
        '
        Me.Bot2.Location = New System.Drawing.Point(93, 285)
        Me.Bot2.Name = "Bot2"
        Me.Bot2.Size = New System.Drawing.Size(75, 57)
        Me.Bot2.TabIndex = 0
        Me.Bot2.Text = "2"
        Me.Bot2.UseVisualStyleBackColor = True
        '
        'BotBackspace
        '
        Me.BotBackspace.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BotBackspace.Location = New System.Drawing.Point(12, 348)
        Me.BotBackspace.Name = "BotBackspace"
        Me.BotBackspace.Size = New System.Drawing.Size(75, 57)
        Me.BotBackspace.TabIndex = 0
        Me.BotBackspace.Text = "<-"
        Me.BotBackspace.UseVisualStyleBackColor = False
        '
        'Bot3
        '
        Me.Bot3.Location = New System.Drawing.Point(174, 285)
        Me.Bot3.Name = "Bot3"
        Me.Bot3.Size = New System.Drawing.Size(75, 57)
        Me.Bot3.TabIndex = 0
        Me.Bot3.Text = "3"
        Me.Bot3.UseVisualStyleBackColor = True
        '
        'Bot6
        '
        Me.Bot6.Location = New System.Drawing.Point(174, 222)
        Me.Bot6.Name = "Bot6"
        Me.Bot6.Size = New System.Drawing.Size(75, 57)
        Me.Bot6.TabIndex = 0
        Me.Bot6.Text = "6"
        Me.Bot6.UseVisualStyleBackColor = True
        '
        'BotMultiplicar
        '
        Me.BotMultiplicar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BotMultiplicar.Location = New System.Drawing.Point(255, 159)
        Me.BotMultiplicar.Name = "BotMultiplicar"
        Me.BotMultiplicar.Size = New System.Drawing.Size(75, 57)
        Me.BotMultiplicar.TabIndex = 0
        Me.BotMultiplicar.Text = "x"
        Me.BotMultiplicar.UseVisualStyleBackColor = False
        '
        'Bot4
        '
        Me.Bot4.Location = New System.Drawing.Point(12, 222)
        Me.Bot4.Name = "Bot4"
        Me.Bot4.Size = New System.Drawing.Size(75, 57)
        Me.Bot4.TabIndex = 0
        Me.Bot4.Text = "4"
        Me.Bot4.UseVisualStyleBackColor = True
        '
        'Bot8
        '
        Me.Bot8.Location = New System.Drawing.Point(93, 159)
        Me.Bot8.Name = "Bot8"
        Me.Bot8.Size = New System.Drawing.Size(75, 57)
        Me.Bot8.TabIndex = 0
        Me.Bot8.Text = "8"
        Me.Bot8.UseVisualStyleBackColor = True
        '
        'Bot5
        '
        Me.Bot5.Location = New System.Drawing.Point(93, 222)
        Me.Bot5.Name = "Bot5"
        Me.Bot5.Size = New System.Drawing.Size(75, 57)
        Me.Bot5.TabIndex = 0
        Me.Bot5.Text = "5"
        Me.Bot5.UseVisualStyleBackColor = True
        '
        'Bot9
        '
        Me.Bot9.Location = New System.Drawing.Point(174, 159)
        Me.Bot9.Name = "Bot9"
        Me.Bot9.Size = New System.Drawing.Size(75, 57)
        Me.Bot9.TabIndex = 0
        Me.Bot9.Text = "9"
        Me.Bot9.UseVisualStyleBackColor = True
        '
        'BotDividir
        '
        Me.BotDividir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BotDividir.Location = New System.Drawing.Point(255, 94)
        Me.BotDividir.Name = "BotDividir"
        Me.BotDividir.Size = New System.Drawing.Size(75, 57)
        Me.BotDividir.TabIndex = 0
        Me.BotDividir.Text = "/"
        Me.BotDividir.UseVisualStyleBackColor = False
        '
        'Bot7
        '
        Me.Bot7.Location = New System.Drawing.Point(12, 159)
        Me.Bot7.Name = "Bot7"
        Me.Bot7.Size = New System.Drawing.Size(75, 57)
        Me.Bot7.TabIndex = 0
        Me.Bot7.Text = "7"
        Me.Bot7.UseVisualStyleBackColor = True
        '
        'Txtop
        '
        Me.Txtop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtop.Location = New System.Drawing.Point(304, 12)
        Me.Txtop.Multiline = True
        Me.Txtop.Name = "Txtop"
        Me.Txtop.Size = New System.Drawing.Size(26, 28)
        Me.Txtop.TabIndex = 2
        '
        'TxtNumero1
        '
        Me.TxtNumero1.Location = New System.Drawing.Point(12, 12)
        Me.TxtNumero1.Multiline = True
        Me.TxtNumero1.Name = "TxtNumero1"
        Me.TxtNumero1.Size = New System.Drawing.Size(286, 28)
        Me.TxtNumero1.TabIndex = 3
        '
        'Resultado
        '
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(12, 46)
        Me.Resultado.Multiline = True
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(313, 28)
        Me.Resultado.TabIndex = 4
        Me.Resultado.Text = "0"
        Me.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BotPonto
        '
        Me.BotPonto.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BotPonto.Location = New System.Drawing.Point(174, 346)
        Me.BotPonto.Name = "BotPonto"
        Me.BotPonto.Size = New System.Drawing.Size(75, 61)
        Me.BotPonto.TabIndex = 5
        Me.BotPonto.Text = "."
        Me.BotPonto.UseVisualStyleBackColor = False
        '
        'BotClean
        '
        Me.BotClean.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BotClean.Location = New System.Drawing.Point(174, 92)
        Me.BotClean.Name = "BotClean"
        Me.BotClean.Size = New System.Drawing.Size(75, 61)
        Me.BotClean.TabIndex = 6
        Me.BotClean.Text = "C"
        Me.BotClean.UseVisualStyleBackColor = False
        '
        'BotInverter
        '
        Me.BotInverter.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BotInverter.Location = New System.Drawing.Point(93, 92)
        Me.BotInverter.Name = "BotInverter"
        Me.BotInverter.Size = New System.Drawing.Size(75, 61)
        Me.BotInverter.TabIndex = 7
        Me.BotInverter.Text = "+/-"
        Me.BotInverter.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 462)
        Me.Controls.Add(Me.BotInverter)
        Me.Controls.Add(Me.BotClean)
        Me.Controls.Add(Me.BotPonto)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.TxtNumero1)
        Me.Controls.Add(Me.Txtop)
        Me.Controls.Add(Me.BotBackspace)
        Me.Controls.Add(Me.Bot5)
        Me.Controls.Add(Me.BotDividir)
        Me.Controls.Add(Me.Bot9)
        Me.Controls.Add(Me.Bot7)
        Me.Controls.Add(Me.Bot8)
        Me.Controls.Add(Me.Bot4)
        Me.Controls.Add(Me.BotMultiplicar)
        Me.Controls.Add(Me.Bot6)
        Me.Controls.Add(Me.Bot3)
        Me.Controls.Add(Me.Bot2)
        Me.Controls.Add(Me.BotSubtrair)
        Me.Controls.Add(Me.Somar)
        Me.Controls.Add(Me.BotCalcular)
        Me.Controls.Add(Me.Bot0)
        Me.Controls.Add(Me.Bot1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bot1 As Button
    Friend WithEvents Bot0 As Button
    Friend WithEvents BotCalcular As Button
    Friend WithEvents Somar As Button
    Friend WithEvents BotSubtrair As Button
    Friend WithEvents Bot2 As Button
    Friend WithEvents BotBackspace As Button
    Friend WithEvents Bot3 As Button
    Friend WithEvents Bot6 As Button
    Friend WithEvents BotMultiplicar As Button
    Friend WithEvents Bot4 As Button
    Friend WithEvents Bot8 As Button
    Friend WithEvents Bot5 As Button
    Friend WithEvents Bot9 As Button
    Friend WithEvents BotDividir As Button
    Friend WithEvents Bot7 As Button
    Friend WithEvents Txtop As TextBox
    Friend WithEvents TxtNumero1 As TextBox
    Friend WithEvents Resultado As TextBox
    Friend WithEvents BotPonto As Button
    Friend WithEvents BotClean As Button
    Friend WithEvents BotInverter As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
