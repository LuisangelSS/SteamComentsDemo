<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonCargarComentarios = New System.Windows.Forms.Button()
        Me.ListBoxComentarios = New System.Windows.Forms.ListBox()
        Me.ButtonClasificarComentarios = New System.Windows.Forms.Button()
        Me.ListBoxClasificacion = New System.Windows.Forms.ListBox()
        Me.ButtonExtraerEtiquetas = New System.Windows.Forms.Button()
        Me.ListBoxEtiquetas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCargarComentarios
        '
        Me.ButtonCargarComentarios.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCargarComentarios.Location = New System.Drawing.Point(47, 20)
        Me.ButtonCargarComentarios.Name = "ButtonCargarComentarios"
        Me.ButtonCargarComentarios.Size = New System.Drawing.Size(132, 25)
        Me.ButtonCargarComentarios.TabIndex = 0
        Me.ButtonCargarComentarios.Text = "Cargar Comentarios"
        Me.ButtonCargarComentarios.UseVisualStyleBackColor = False
        '
        'ListBoxComentarios
        '
        Me.ListBoxComentarios.FormattingEnabled = True
        Me.ListBoxComentarios.Location = New System.Drawing.Point(47, 57)
        Me.ListBoxComentarios.Name = "ListBoxComentarios"
        Me.ListBoxComentarios.Size = New System.Drawing.Size(495, 290)
        Me.ListBoxComentarios.TabIndex = 1
        '
        'ButtonClasificarComentarios
        '
        Me.ButtonClasificarComentarios.Location = New System.Drawing.Point(47, 353)
        Me.ButtonClasificarComentarios.Name = "ButtonClasificarComentarios"
        Me.ButtonClasificarComentarios.Size = New System.Drawing.Size(132, 24)
        Me.ButtonClasificarComentarios.TabIndex = 2
        Me.ButtonClasificarComentarios.Text = "Clasificar Comentarios"
        Me.ButtonClasificarComentarios.UseVisualStyleBackColor = True
        '
        'ListBoxClasificacion
        '
        Me.ListBoxClasificacion.FormattingEnabled = True
        Me.ListBoxClasificacion.Location = New System.Drawing.Point(47, 383)
        Me.ListBoxClasificacion.Name = "ListBoxClasificacion"
        Me.ListBoxClasificacion.Size = New System.Drawing.Size(495, 238)
        Me.ListBoxClasificacion.TabIndex = 3
        '
        'ButtonExtraerEtiquetas
        '
        Me.ButtonExtraerEtiquetas.Location = New System.Drawing.Point(696, 62)
        Me.ButtonExtraerEtiquetas.Name = "ButtonExtraerEtiquetas"
        Me.ButtonExtraerEtiquetas.Size = New System.Drawing.Size(132, 24)
        Me.ButtonExtraerEtiquetas.TabIndex = 4
        Me.ButtonExtraerEtiquetas.Text = "Extraer Etiquetas"
        Me.ButtonExtraerEtiquetas.UseVisualStyleBackColor = True
        '
        'ListBoxEtiquetas
        '
        Me.ListBoxEtiquetas.FormattingEnabled = True
        Me.ListBoxEtiquetas.Location = New System.Drawing.Point(572, 92)
        Me.ListBoxEtiquetas.Name = "ListBoxEtiquetas"
        Me.ListBoxEtiquetas.Size = New System.Drawing.Size(382, 485)
        Me.ListBoxEtiquetas.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SteamComments"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(939, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1015, 633)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxEtiquetas)
        Me.Controls.Add(Me.ButtonExtraerEtiquetas)
        Me.Controls.Add(Me.ListBoxClasificacion)
        Me.Controls.Add(Me.ButtonClasificarComentarios)
        Me.Controls.Add(Me.ListBoxComentarios)
        Me.Controls.Add(Me.ButtonCargarComentarios)
        Me.Name = "Form1"
        Me.Text = "SteamComments"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCargarComentarios As Button
    Friend WithEvents ListBoxComentarios As ListBox
    Friend WithEvents ButtonClasificarComentarios As Button
    Friend WithEvents ListBoxClasificacion As ListBox
    Friend WithEvents ButtonExtraerEtiquetas As Button
    Friend WithEvents ListBoxEtiquetas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
