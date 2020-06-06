Imports The_Arcade_VB

Public Class Juego1
    Implements IAhorcado
    Public Sub Empieza()
        Console.Clear()
        Dim obj As IAhorcado = New Juego1()
        Dim intentos As Integer = 0, Ganar As Integer = 0
        Dim palabra As String = obj.ElegirPalabra()
        Dim palabraChar As Char() = palabra.ToCharArray()
        Dim longitud As Char() = obj.GenerarEspacios(palabra)
        Dim letraingresa As String = String.Empty
        Dim letraingresachar As Char = " "c
        Dim gano As Boolean = False

        While gano = False
            Dim SoloUna As Integer = 0, contador As Integer = 0, repite As Integer = 0

            While SoloUna = 0
                ImprimirHorca(intentos)
                obj.ImprimirEspacios(longitud)
                Console.WriteLine(vbLf & "Has Fallado: {0}", intentos)
                Console.Write(vbLf & "Introduce una letra: ")
                letraingresa = Console.ReadLine()

                If obj.CompruebaUna(letraingresa) Then
                    letraingresachar = Convert.ToChar(letraingresa)
                    SoloUna += 1
                Else
                    Console.Clear()
                    Console.Write("Oye, Ingresa solo una letra.")
                    Console.ReadKey()
                    Console.Clear()
                End If
            End While

            For k As Integer = 0 To longitud.Length - 1

                If longitud(k) = letraingresachar Then

                    If repite = 0 Then
                        Console.Clear()
                        Console.WriteLine("Oye, Letra ya encontrada, escribe otra.")
                        Console.ReadKey()
                        repite += 1
                    End If

                    contador += 1
                Else

                    If letraingresachar = palabraChar(k) Then
                        longitud(k) = letraingresachar
                        contador += 1
                        Ganar += 1
                    End If
                End If
            Next

            If contador = 0 Then
                intentos += 1
            End If

            If intentos = 10 Then
                Console.Clear()
                ImprimirHorca(intentos)
                Console.WriteLine(vbLf & "Ya no hay intentos" & vbLf & "Perdiste...")
                Console.ReadKey()
                Exit While
            End If

            If Ganar = palabraChar.Length Then
                gano = True
            End If

            Console.Clear()
        End While

        obj.ImprimirFinJuego(palabra, intentos, gano)
        Console.ReadLine()
        AbrirMenu()
    End Sub

    Private Sub ImprimirHorca(ByVal intentos As Integer)
        Console.WriteLine("_ _ _")

        If intentos >= 1 Then
            Console.SetCursorPosition(0, 0)
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("_____")
            Console.ForegroundColor = ConsoleColor.White
        End If

        If intentos >= 4 Then
            Console.SetCursorPosition(3, 1)
            Console.WriteLine("|")
        End If

        If intentos >= 5 Then
            Console.SetCursorPosition(3, 2)
            Console.WriteLine("O")
        End If

        If intentos >= 6 Then
            Console.SetCursorPosition(2, 3)
            Console.WriteLine("/")
        End If

        If intentos >= 7 Then
            Console.SetCursorPosition(2, 3)
            Console.WriteLine("/T")
        End If

        If intentos >= 8 Then
            Console.SetCursorPosition(2, 3)
            Console.WriteLine("/T\")
        End If

        If intentos >= 9 Then
            Console.SetCursorPosition(2, 4)
            Console.WriteLine("/")
        End If

        If intentos >= 10 Then
            Console.SetCursorPosition(2, 4)
            Console.WriteLine("/ \")
        End If

        For i As Integer = 1 To 6 - 1
            If intentos > 1 Then Console.ForegroundColor = ConsoleColor.Yellow
            Console.SetCursorPosition(0, i)
            Console.WriteLine("|")
        Next

        Console.ForegroundColor = ConsoleColor.White
        If intentos >= 3 Then Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("_____")
        Console.ForegroundColor = ConsoleColor.White
    End Sub

    Private Sub AbrirMenu()
        Console.WriteLine("Has clic en enter para ir al menu principal")
        Console.ReadLine()
        Dim open As MenuPrincipal = New MenuPrincipal()
        open.Inicio()
    End Sub

    Private Function IAhorcado_ElegirPalabra() As String Implements IAhorcado.ElegirPalabra
        Dim rdn As Random = New Random()
        Dim n As Integer = rdn.[Next](0, 4)
        Dim palabras As String() = {"bts", "paseme", "staneabts", "hola", "kiwideharry", "Hola Mundo", "Ramen"}
        Dim encontrada As String
        encontrada = palabras(n)
        Return encontrada
    End Function

    Private Function IAhorcado_GenerarEspacios(palabra As String) As Char() Implements IAhorcado.GenerarEspacios
        Dim longitud As Char() = palabra.ToCharArray()

        For a As Integer = 0 To palabra.Length - 1
            longitud(a) = "_"c
        Next

        Return longitud
    End Function

    Private Sub IAhorcado_ImprimirEspacios(longitud() As Char) Implements IAhorcado.ImprimirEspacios
        Console.WriteLine()

        For i As Integer = 0 To longitud.Length - 1
            Console.Write(longitud(i) & " ")
        Next

        Console.WriteLine()
    End Sub

    Private Function IAhorcado_CompruebaUna(letra As String) As Boolean Implements IAhorcado.CompruebaUna
        Dim UnaLetra As Boolean = False
        If letra.Length = 1 Then UnaLetra = True
        Return UnaLetra
    End Function

    Private Sub IAhorcado_ImprimirFinJuego(palabra As String, intentos As Integer, gano As Boolean) Implements IAhorcado.ImprimirFinJuego
        If gano = True Then
            ImprimirHorca(intentos)
            Console.WriteLine()
            Console.WriteLine("Felicidades lo lograste...!")
            Console.WriteLine()
            Console.WriteLine("La palabra era: {0}", palabra.ToUpper())
            Console.ReadKey()
        Else
            Console.Clear()
            Console.WriteLine("La palabra era: {0}", palabra.ToUpper())
            Console.ReadKey()
        End If
    End Sub
End Class
