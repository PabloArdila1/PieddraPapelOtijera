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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Inicio = New System.Windows.Forms.Panel()
        Me.Juego = New System.Windows.Forms.Panel()
        Me.eleccion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tijera = New System.Windows.Forms.Button()
        Me.Papel = New System.Windows.Forms.Button()
        Me.Piedra = New System.Windows.Forms.Button()
        Me.resultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inicio.SuspendLayout()
        Me.Juego.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Light", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(251, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CheeseBumPapas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(251, 100)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(241, 153)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(324, 291)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.Inicio.Controls.Add(Me.btnIniciar)
        Me.Inicio.Controls.Add(Me.Label1)
        Me.Inicio.Controls.Add(Me.PictureBox2)
        Me.Inicio.Location = New System.Drawing.Point(12, 12)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(744, 415)
        Me.Inicio.TabIndex = 5
        '
        'Juego
        '
        Me.Juego.Controls.Add(Me.eleccion)
        Me.Juego.Controls.Add(Me.Label4)
        Me.Juego.Controls.Add(Me.Tijera)
        Me.Juego.Controls.Add(Me.Papel)
        Me.Juego.Controls.Add(Me.Piedra)
        Me.Juego.Controls.Add(Me.resultado)
        Me.Juego.Controls.Add(Me.Button1)
        Me.Juego.Controls.Add(Me.Label5)
        Me.Juego.Controls.Add(Me.Label3)
        Me.Juego.Controls.Add(Me.Label2)
        Me.Juego.Location = New System.Drawing.Point(780, 241)
        Me.Juego.Name = "Juego"
        Me.Juego.Size = New System.Drawing.Size(744, 415)
        Me.Juego.TabIndex = 6
        '
        'eleccion
        '
        Me.eleccion.AutoSize = True
        Me.eleccion.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.eleccion.Location = New System.Drawing.Point(125, 36)
        Me.eleccion.Name = "eleccion"
        Me.eleccion.Size = New System.Drawing.Size(0, 25)
        Me.eleccion.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(30, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Jugador: "
        '
        'Tijera
        '
        Me.Tijera.Location = New System.Drawing.Point(544, 137)
        Me.Tijera.Name = "Tijera"
        Me.Tijera.Size = New System.Drawing.Size(89, 92)
        Me.Tijera.TabIndex = 11
        Me.Tijera.Text = "Tijera"
        Me.Tijera.UseVisualStyleBackColor = True
        '
        'Papel
        '
        Me.Papel.Location = New System.Drawing.Point(352, 137)
        Me.Papel.Name = "Papel"
        Me.Papel.Size = New System.Drawing.Size(89, 92)
        Me.Papel.TabIndex = 10
        Me.Papel.Text = "Papel"
        Me.Papel.UseVisualStyleBackColor = True
        '
        'Piedra
        '
        Me.Piedra.Location = New System.Drawing.Point(176, 137)
        Me.Piedra.Name = "Piedra"
        Me.Piedra.Size = New System.Drawing.Size(89, 92)
        Me.Piedra.TabIndex = 9
        Me.Piedra.Text = "Piedra"
        Me.Piedra.UseVisualStyleBackColor = True
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultado.Location = New System.Drawing.Point(532, 324)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(0, 41)
        Me.resultado.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Comprueba"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(51, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "El pc elije: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(291, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jugador vs Pc"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Juego)
        Me.Controls.Add(Me.Inicio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inicio.ResumeLayout(False)
        Me.Inicio.PerformLayout()
        Me.Juego.ResumeLayout(False)
        Me.Juego.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Inicio As Panel
    Friend WithEvents Juego As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents resultado As Label
    Friend WithEvents Piedra As Button
    Friend WithEvents Tijera As Button
    Friend WithEvents Papel As Button
    Friend WithEvents eleccion As Label
    Friend WithEvents Label4 As Label
End Class
