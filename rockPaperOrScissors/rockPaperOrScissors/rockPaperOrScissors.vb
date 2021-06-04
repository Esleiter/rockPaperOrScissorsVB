'Elaborado por: Esleiter Jose Fajardo Laya.
'04-06-2021
'esleiter.com

'Juego de consola, piedra, papel o tijera!

Module rockPaperOrScissors

    Sub Main()
        Dim moveComputer, moveUser As Integer
        Dim rand As Random = New Random()
        'Se declaran las variables, la segunda sirve para generar un numero aleatorio correspondiente a la jugada del ordenador.
        Do
            'Este primer bucle nos permite solo finalizar el programa cuando el usuario gane.
            'Entonces se utiliza (Until) ya que si se cumple la condición de ganar (true) finaliza el programa.
            Console.WriteLine("Ingrese un número correspondiente a las siguientes opciones:")
            Console.WriteLine(vbTab & "1- Piedra")
            Console.WriteLine(vbTab & "2- Papel")
            Console.WriteLine(vbTab & "3- Tijera")
            Console.WriteLine()
            Console.Write("Jugada: ")
            Do
                'Este bucle se utiliza para el manejo de errores en la inserción de la jugada por parte del usuario.
                'Utilizo (While) en este caso, la condición del error deberá se (false) para continuar.
                moveUser = Integer.Parse(Console.ReadLine())
                If moveUser < 1 Or moveUser > 3 Then
                    Console.Write("Valor incorrecto. Intente nuevamente: ")
                End If
            Loop While moveUser < 1 Or moveUser > 3
            'A partir de acá tenemos la lógica del juego, desarrollada con condicionales que se ejecutaran segun sea el caso.
            moveComputer = 1 + rand.Next(3)
            If moveComputer = 1 Then
                Console.WriteLine("La jugada del ordenador es Piedra")
            End If
            If moveComputer = 2 Then
                Console.WriteLine("La jugada del ordenador es Papel")
            End If
            If moveComputer = 3 Then
                Console.WriteLine("La jugada del ordenador es Tijera")
            End If

            If moveUser = moveComputer Then
                Console.WriteLine("Empate")
                Console.WriteLine()
            End If
            If (moveUser = 1 And moveComputer = 3) Or (moveUser = 2 And moveComputer = 1) Or (moveUser = 3 And moveComputer = 2) Then
                Console.WriteLine("Gana usuario")
                Console.WriteLine()
                Shell("cmd /c pause", AppWinStyle.NormalFocus, True)
            End If
            If (moveUser = 3 And moveComputer = 1) Or (moveUser = 1 And moveComputer = 2) Or (moveUser = 2 And moveComputer = 3) Then
                Console.WriteLine("Gana ordenador")
                Console.WriteLine()
            End If
        Loop Until (moveUser = 1 And moveComputer = 3) Or (moveUser = 2 And moveComputer = 1) Or (moveUser = 3 And moveComputer = 2)
        'En la línea anterior observamos como la única condición válida para finalizar el bucle, será la de ganar la partida
        'Se evita un bucle infinito, ya que en algún momento el jugador, en base a probabilidad deberá ganar.
    End Sub

End Module