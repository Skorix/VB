﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Меню
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Меню))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(12, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(625, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Кафе"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(625, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Переменные"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(625, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Решение квадратного уравнения"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(625, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Приветсвие"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(625, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Выбор подарка"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 157)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(625, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Доход по вкладу"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 186)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(625, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "MyForLoop"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 215)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(625, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Делимость чисел"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 244)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(625, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 273)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(625, 23)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Меню
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(649, 326)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Меню"
        Me.Text = "Меню"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
