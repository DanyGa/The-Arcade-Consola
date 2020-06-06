Public Interface IAhorcado
    Function ElegirPalabra() As String
    Function GenerarEspacios(ByVal palabra As String) As Char()
    Sub ImprimirEspacios(ByVal longitud As Char())
    Function CompruebaUna(ByVal letra As String) As Boolean
    Sub ImprimirFinJuego(ByVal palabra As String, ByVal intentos As Integer, ByVal gano As Boolean)
End Interface
