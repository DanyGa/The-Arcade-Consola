Public Class MenuPrincipal
    Public Sub Inicio()
        Dim opcion 
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.DarkMagenta
        Console.WriteLine("||========================================================||")
        Console.WriteLine("||--------------------------------------------------------||")
        Console.Write("||----------------- ")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("WELCOME TO THE ARCADE")
        Console.ForegroundColor = ConsoleColor.DarkMagenta
        Console.WriteLine(" ----------------||")
        Console.Write("||------------------- ")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Write("Console VB version")
        Console.ForegroundColor = ConsoleColor.DarkMagenta
        Console.WriteLine(" -----------------||")
        Console.WriteLine("||========================================================||")
        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine()
        Console.WriteLine("                     EL AHORCADO - 1                  ")
        Console.WriteLine("                     QUE NUMERO? - 2                  ")
        Console.WriteLine("                     SALIR - 3                  ")
        Console.ForegroundColor = ConsoleColor.DarkMagenta
        Console.WriteLine("||========================================================||")
        Console.WriteLine("||--------------------------------------------------------||")
        Console.WriteLine("||--------------------------------------------------------||")
        Console.WriteLine("||--------------------------------------------------------||")
        Console.WriteLine("||========================================================||")
        opcion = Convert.ToInt32(Console.ReadLine())
        Console.ReadKey()

        Select Case opcion
            Case 1
                Dim Ahorcado As New Juego1()
                Ahorcado.Empieza()
            Case 2
                Dim Numero As New Juego2()
                Numero.IQueNumero_Start()
            Case 3
                Environment.[Exit](0)
        End Select

        While opcion <> 4
        End While
    End Sub
End Class
