Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnCopiaBD_Click(sender As Object, e As EventArgs) Handles btnCopiaBD.Click
        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?
        Dim ssql As String 'que dados trazer? 

        If rdbTodosBD.Checked() Then
            ssql = "Select * From Produtos;"

        Else
            ssql = "Select * From Produtos Where Existências = 0;"
        End If

        dgvDB.DataSource = obj.BuscaDados(sc, ssql)
    End Sub

    Private Sub btnLimpaGrid_Click(sender As Object, e As EventArgs) Handles btnLimpaGrid.Click
        dgvDB.Columns.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim s As String = txtRemove.Text
        Dim p As Integer = -1

        For index = 0 To dgvDB.Rows.Count() - 1
            If dgvDB.Rows(index).Cells(1).Value = s Then
                p = index
            End If
        Next

        If (p <> -1) Then
            dgvDB.Rows.RemoveAt(p)
        End If
    End Sub

    Private Sub btnConta_Click(sender As Object, e As EventArgs) Handles btnConta.Click

        txtConta.Text = (dgvDB.Rows.Count() - 1)


    End Sub

    Private Sub btnNome_Click(sender As Object, e As EventArgs) Handles btnNome.Click

        Dim index As Integer

        For index = 0 To dgvDB.Rows.Count() - 2
            lstNomes.Items.Add(dgvDB.Rows(index).Cells(1).Value)
        Next



    End Sub

    Private Sub btnEliminaLista_Click(sender As Object, e As EventArgs) Handles btnEliminaLista.Click
        lstNomes.Items.Remove(txtRemoveNome.Text)
    End Sub

    Private Sub btnLimpaLista_Click(sender As Object, e As EventArgs) Handles btnLimpaLista.Click
        lstNomes.Items.Clear()
    End Sub

    Private Sub btnContaLista_Click(sender As Object, e As EventArgs) Handles btnContaLista.Click

        Dim contador As Integer = lstNomes.Items.Count()

        MessageBox.Show(contador)
    End Sub

    Private Sub btnContaProdutos_Click(sender As Object, e As EventArgs) Handles btnContaProdutos.Click
        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?
        Dim ssql As String 'que dados trazer? 

        ssql = "Select count(*) From Produtos;"

        txtContarProdutos.Text = obj.BuscaDados(sc, ssql).Rows(0)(0).ToString
    End Sub

    Private Sub btnAtualiza_Click(sender As Object, e As EventArgs) Handles btnAtualiza.Click
        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?
        Dim ssql As String 'que dados trazer? 

        Dim cDP As String = CStr(dgvDB.CurrentRow.Cells(0).Value)
        Dim nDP As String = CStr(dgvDB.CurrentRow.Cells(1).Value)
        Dim PU As String = CStr(dgvDB.CurrentRow.Cells(4).Value)


        ssql = "Update Produtos set NomeDoProduto = '" + nDP + "'" + "," + "PreçoUnitário = '" + PU + "'" + "where CódigoDoProduto = '" + cDP + "';"

        obj.BuscaDados(sc, ssql)
    End Sub

    Private Sub btnInsere_Click(sender As Object, e As EventArgs) Handles btnInsere.Click
        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?
        Dim ssql As String 'que dados trazer?

        Dim nDP As String = txtNome.Text
        Dim cDF As String = CStr(txtCategoria.Text)
        Dim cDC As String = CStr(txtCategoria.Text)
        Dim pU As String = CStr(txtPreco.Text)

        ssql = "Insert into Produtos (NomeDoProduto, CódigoDoFornecedor, CódigoDaCategoria, PreçoUnitário) values (nDP, cDF, cDC, pU)"

        obj.BuscaDados(sc, ssql)
    End Sub
End Class
