Imports The_Arcade_VB

Public Class Juego2
    Implements IQueNumero
    Public Sub IQueNumero_Start() Implements IQueNumero.Start
        Console.Clear()
        Dim Min As Integer = 1, Max As Integer = 51
        Console.Title = "QUE NUMERO?"
        Console.WriteLine("Bienvenido a Que numero?! " & vbLf & vbLf & " Voy a pensar un numero del " & Min & " al " & (Max - 1) & " y debes adivinarlo!")
        Console.Write("Escribe un numero: ")
        Dim r As Random = New Random(Guid.NewGuid().GetHashCode())
        Dim numeroElegido As Integer = r.[Next](Min, Max)
        Dim numeroIngresado As Integer = 0

        Do
            numeroIngresado = Convert.ToInt32(Console.ReadLine())

            If numeroIngresado > numeroElegido Then
                Console.WriteLine("Es un numero menor a ese")
            ElseIf numeroIngresado < numeroElegido Then
                Console.WriteLine(" Es un numero mayor a ese")
            Else
                Console.WriteLine("Ganaste")
                Console.ReadKey()
            End If
        Loop While numeroElegido <> numeroIngresado

        Console.ReadLine()
        IQueNumero_Abrir()
    End Sub

    Private Sub IQueNumero_Abrir() Implements IQueNumero.Abrir
        Console.WriteLine("Has clic en enter para ir al menu principal")
        Console.ReadLine()
        Dim open As MenuPrincipal = New MenuPrincipal()
        open.Inicio()
    End Sub
End Class
