Imports System

Module Program
    Sub Main(args As String())
        
        Dim base as double
        Dim altura as double
        Dim area as double

        console.writeline("Vamos descobrir o resultado!")
        console.writeline("Me informe a base do triangulo:")
        
        base = console.readline()

        console.writeline("Agora me informe a altura:")

        altura = console.readline()

        area = base * altura

        console.writeline("A area do triangulo e: " & area)


    End Sub
End Module
