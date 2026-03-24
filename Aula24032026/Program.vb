Imports System

Module Program
    Sub Main(args As String())

        Dim nomesobrenome(2) as String

        Console.writeline("Digite seu nome completo:")

        nomesobrenome(0) = console.readline()
        nomesobrenome(1) = console.readline()

        Console.writeline("Seu nome seria " & nomesobrenome(0) &" "& nomesobrenome(1))

    End Sub
End Module
