Imports System

Module Program
    Sub Main(args As String())
        
        'variáveis'
        Dim unidmb as double
        Dim resultadogb as double
    


        console.writeline("Por gentileza, digite o valor em MB:")

        unidmb = console.readline()
        
        resultadogb = unidmb / 1024

        console.writeline ("O seu valor em Gigabytes é: " & resultadogb)



    End Sub
End Module
