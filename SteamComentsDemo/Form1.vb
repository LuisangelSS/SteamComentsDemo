Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class Form1
    ' Evento para cargar los comentarios desde un archivo CSV
    Private Sub ButtonCargarComentarios_Click(sender As Object, e As EventArgs) Handles ButtonCargarComentarios.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            CargarYEnviarComentarios(filePath)
        End If
    End Sub

    ' Función para cargar los comentarios desde el CSV y enviarlos a Azure
    Private Sub CargarYEnviarComentarios(filePath As String)
        Dim comentarios As New List(Of String)

        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                comentarios.Add(reader.ReadLine())
            End While
        End Using

        Dim json As String = "{""data"": " & ConvertComentariosAJson(comentarios) & "}"

        EnviarAClaseAzure(json)
    End Sub

    ' Función para convertir los comentarios en formato JSON
    Private Function ConvertComentariosAJson(comentarios As List(Of String)) As String
        Dim comentariosJson As New StringBuilder("[")
        For Each comentario In comentarios
            comentariosJson.Append("""" & comentario.Replace("""", "\""") & """,")
        Next
        comentariosJson.Length -= 1
        comentariosJson.Append("]")
        Return comentariosJson.ToString()
    End Function

    ' Función para realizar la solicitud HTTP a Azure
    Private Async Sub EnviarAClaseAzure(json As String)
        ' URL del endpoint de Azure
        Dim url As String = "https://steamcoments-phiqx.eastus2.inference.ml.azure.com/score"
        ' Token de autenticación
        Dim token As String = "83MkatY4VGEi0U2JbHcdxTQRVk9YADXp"

        Dim client As New HttpClient()

        Try
            ' Agregar el encabezado de autorización
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & token)

            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            If response.IsSuccessStatusCode Then
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Conexión con Azure exitosa. Respuesta: " & responseBody)
            Else
                MessageBox.Show("Error en la conexión con Azure. Código de respuesta: " & response.StatusCode)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al intentar conectarse a Azure: {ex.Message}")
        End Try
    End Sub

End Class
