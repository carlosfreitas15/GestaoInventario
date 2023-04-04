<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCopiaBD = New System.Windows.Forms.Button()
        Me.dgvDB = New System.Windows.Forms.DataGridView()
        Me.btnLimpaGrid = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnConta = New System.Windows.Forms.Button()
        Me.txtRemove = New System.Windows.Forms.TextBox()
        Me.txtConta = New System.Windows.Forms.TextBox()
        Me.rdbTodosBD = New System.Windows.Forms.RadioButton()
        Me.rdbQuantidadeZero = New System.Windows.Forms.RadioButton()
        Me.btnInsere = New System.Windows.Forms.Button()
        Me.btnContaProdutos = New System.Windows.Forms.Button()
        Me.btnAtualiza = New System.Windows.Forms.Button()
        Me.btnEliminaLista = New System.Windows.Forms.Button()
        Me.lstNomes = New System.Windows.Forms.ListBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtContarProdutos = New System.Windows.Forms.TextBox()
        Me.txtRemoveNome = New System.Windows.Forms.TextBox()
        Me.btnContaLista = New System.Windows.Forms.Button()
        Me.btnLimpaLista = New System.Windows.Forms.Button()
        Me.btnNome = New System.Windows.Forms.Button()
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCopiaBD
        '
        Me.btnCopiaBD.Location = New System.Drawing.Point(16, 15)
        Me.btnCopiaBD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCopiaBD.Name = "btnCopiaBD"
        Me.btnCopiaBD.Size = New System.Drawing.Size(253, 28)
        Me.btnCopiaBD.TabIndex = 0
        Me.btnCopiaBD.Text = "Copia da BD os produtos para a grid"
        Me.btnCopiaBD.UseVisualStyleBackColor = True
        '
        'dgvDB
        '
        Me.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDB.Location = New System.Drawing.Point(16, 50)
        Me.dgvDB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDB.Name = "dgvDB"
        Me.dgvDB.RowHeadersWidth = 82
        Me.dgvDB.Size = New System.Drawing.Size(1005, 446)
        Me.dgvDB.TabIndex = 1
        '
        'btnLimpaGrid
        '
        Me.btnLimpaGrid.Location = New System.Drawing.Point(275, 15)
        Me.btnLimpaGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLimpaGrid.Name = "btnLimpaGrid"
        Me.btnLimpaGrid.Size = New System.Drawing.Size(97, 28)
        Me.btnLimpaGrid.TabIndex = 2
        Me.btnLimpaGrid.Text = "Limpa a Grid"
        Me.btnLimpaGrid.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(376, 15)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(213, 28)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove este da Grid"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnConta
        '
        Me.btnConta.Location = New System.Drawing.Point(669, 15)
        Me.btnConta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConta.Name = "btnConta"
        Me.btnConta.Size = New System.Drawing.Size(150, 28)
        Me.btnConta.TabIndex = 4
        Me.btnConta.Text = "Conta na Grid"
        Me.btnConta.UseVisualStyleBackColor = True
        '
        'txtRemove
        '
        Me.txtRemove.Location = New System.Drawing.Point(595, 19)
        Me.txtRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRemove.Name = "txtRemove"
        Me.txtRemove.Size = New System.Drawing.Size(68, 22)
        Me.txtRemove.TabIndex = 5
        '
        'txtConta
        '
        Me.txtConta.Location = New System.Drawing.Point(825, 18)
        Me.txtConta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(68, 22)
        Me.txtConta.TabIndex = 6
        '
        'rdbTodosBD
        '
        Me.rdbTodosBD.AutoSize = True
        Me.rdbTodosBD.Location = New System.Drawing.Point(563, 510)
        Me.rdbTodosBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbTodosBD.Name = "rdbTodosBD"
        Me.rdbTodosBD.Size = New System.Drawing.Size(177, 20)
        Me.rdbTodosBD.TabIndex = 7
        Me.rdbTodosBD.TabStop = True
        Me.rdbTodosBD.Text = "Todos da BD para a grid"
        Me.rdbTodosBD.UseVisualStyleBackColor = True
        '
        'rdbQuantidadeZero
        '
        Me.rdbQuantidadeZero.AutoSize = True
        Me.rdbQuantidadeZero.Location = New System.Drawing.Point(751, 510)
        Me.rdbQuantidadeZero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbQuantidadeZero.Name = "rdbQuantidadeZero"
        Me.rdbQuantidadeZero.Size = New System.Drawing.Size(288, 20)
        Me.rdbQuantidadeZero.TabIndex = 8
        Me.rdbQuantidadeZero.TabStop = True
        Me.rdbQuantidadeZero.Text = "Da BD para a grid, apenas quantidade zero"
        Me.rdbQuantidadeZero.UseVisualStyleBackColor = True
        '
        'btnInsere
        '
        Me.btnInsere.Location = New System.Drawing.Point(16, 668)
        Me.btnInsere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInsere.Name = "btnInsere"
        Me.btnInsere.Size = New System.Drawing.Size(504, 41)
        Me.btnInsere.TabIndex = 9
        Me.btnInsere.Text = "Insere das texts para a tabela (nome, fornecedor, categoria, preço) (NOTA1: o ide" &
    "ntify está ativo?) (NOTA2: o campo descontinuado permite NULL?)"
        Me.btnInsere.UseVisualStyleBackColor = True
        '
        'btnContaProdutos
        '
        Me.btnContaProdutos.Location = New System.Drawing.Point(16, 636)
        Me.btnContaProdutos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnContaProdutos.Name = "btnContaProdutos"
        Me.btnContaProdutos.Size = New System.Drawing.Size(188, 28)
        Me.btnContaProdutos.TabIndex = 10
        Me.btnContaProdutos.Text = "Conta produtos na tabela"
        Me.btnContaProdutos.UseVisualStyleBackColor = True
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Location = New System.Drawing.Point(16, 606)
        Me.btnAtualiza.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(307, 26)
        Me.btnAtualiza.TabIndex = 11
        Me.btnAtualiza.Text = "Atualiza linha corrente da Grid, para a tabela"
        Me.btnAtualiza.UseVisualStyleBackColor = True
        '
        'btnEliminaLista
        '
        Me.btnEliminaLista.Location = New System.Drawing.Point(296, 502)
        Me.btnEliminaLista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminaLista.Name = "btnEliminaLista"
        Me.btnEliminaLista.Size = New System.Drawing.Size(167, 26)
        Me.btnEliminaLista.TabIndex = 12
        Me.btnEliminaLista.Text = "Elimina este da lista"
        Me.btnEliminaLista.UseVisualStyleBackColor = True
        '
        'lstNomes
        '
        Me.lstNomes.FormattingEnabled = True
        Me.lstNomes.ItemHeight = 16
        Me.lstNomes.Location = New System.Drawing.Point(208, 502)
        Me.lstNomes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstNomes.Name = "lstNomes"
        Me.lstNomes.Size = New System.Drawing.Size(81, 52)
        Me.lstNomes.TabIndex = 13
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(736, 679)
        Me.txtPreco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(68, 22)
        Me.txtPreco.TabIndex = 14
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(664, 679)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(68, 22)
        Me.txtCategoria.TabIndex = 15
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Location = New System.Drawing.Point(595, 679)
        Me.txtFornecedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(68, 22)
        Me.txtFornecedor.TabIndex = 16
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(523, 679)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(68, 22)
        Me.txtNome.TabIndex = 17
        '
        'txtContarProdutos
        '
        Me.txtContarProdutos.Location = New System.Drawing.Point(208, 641)
        Me.txtContarProdutos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContarProdutos.Name = "txtContarProdutos"
        Me.txtContarProdutos.Size = New System.Drawing.Size(68, 22)
        Me.txtContarProdutos.TabIndex = 18
        '
        'txtRemoveNome
        '
        Me.txtRemoveNome.Location = New System.Drawing.Point(296, 533)
        Me.txtRemoveNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRemoveNome.Name = "txtRemoveNome"
        Me.txtRemoveNome.Size = New System.Drawing.Size(168, 22)
        Me.txtRemoveNome.TabIndex = 19
        '
        'btnContaLista
        '
        Me.btnContaLista.Location = New System.Drawing.Point(16, 554)
        Me.btnContaLista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnContaLista.Name = "btnContaLista"
        Me.btnContaLista.Size = New System.Drawing.Size(188, 23)
        Me.btnContaLista.TabIndex = 20
        Me.btnContaLista.Text = "Conta elementos na lista"
        Me.btnContaLista.UseVisualStyleBackColor = True
        '
        'btnLimpaLista
        '
        Me.btnLimpaLista.Location = New System.Drawing.Point(16, 530)
        Me.btnLimpaLista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLimpaLista.Name = "btnLimpaLista"
        Me.btnLimpaLista.Size = New System.Drawing.Size(188, 25)
        Me.btnLimpaLista.TabIndex = 21
        Me.btnLimpaLista.Text = "Limpa a Lista"
        Me.btnLimpaLista.UseVisualStyleBackColor = True
        '
        'btnNome
        '
        Me.btnNome.Location = New System.Drawing.Point(16, 502)
        Me.btnNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNome.Name = "btnNome"
        Me.btnNome.Size = New System.Drawing.Size(188, 27)
        Me.btnNome.TabIndex = 22
        Me.btnNome.Text = "Nome da grid para a Lista"
        Me.btnNome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 779)
        Me.Controls.Add(Me.btnNome)
        Me.Controls.Add(Me.btnLimpaLista)
        Me.Controls.Add(Me.btnContaLista)
        Me.Controls.Add(Me.txtRemoveNome)
        Me.Controls.Add(Me.txtContarProdutos)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.lstNomes)
        Me.Controls.Add(Me.btnEliminaLista)
        Me.Controls.Add(Me.btnAtualiza)
        Me.Controls.Add(Me.btnContaProdutos)
        Me.Controls.Add(Me.btnInsere)
        Me.Controls.Add(Me.rdbQuantidadeZero)
        Me.Controls.Add(Me.rdbTodosBD)
        Me.Controls.Add(Me.txtConta)
        Me.Controls.Add(Me.txtRemove)
        Me.Controls.Add(Me.btnConta)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnLimpaGrid)
        Me.Controls.Add(Me.dgvDB)
        Me.Controls.Add(Me.btnCopiaBD)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCopiaBD As Button
    Friend WithEvents dgvDB As DataGridView
    Friend WithEvents btnLimpaGrid As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnConta As Button
    Friend WithEvents txtRemove As TextBox
    Friend WithEvents txtConta As TextBox
    Friend WithEvents rdbTodosBD As RadioButton
    Friend WithEvents rdbQuantidadeZero As RadioButton
    Friend WithEvents btnInsere As Button
    Friend WithEvents btnContaProdutos As Button
    Friend WithEvents btnAtualiza As Button
    Friend WithEvents btnEliminaLista As Button
    Friend WithEvents lstNomes As ListBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtFornecedor As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtContarProdutos As TextBox
    Friend WithEvents txtRemoveNome As TextBox
    Friend WithEvents btnContaLista As Button
    Friend WithEvents btnLimpaLista As Button
    Friend WithEvents btnNome As Button
End Class
