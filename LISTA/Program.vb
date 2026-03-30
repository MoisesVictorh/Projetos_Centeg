Imports System
Imports System.Collections.Generic

Module Program
    Sub Main(args As String())
        

        Dim materia As new list(Of String)
        
        
        materia.add("Português")
        materia.add("Matemática")
        materia.add("História")

        For each dado in materia
        Console.writeline(dado)
        next

        console.writeline("Escolha uma matéria: ")

        Dim escolha As String = Console.ReadLine()

        if 
            escolha = "Português" then
            console.writeline("Então você é de humanas")

        Else if 
            escolha = "Matemática" then
            console.writeline("Então você é de exatas")

        Else if
            escolha = "História" then
            console.writeline("Um grande historiador")
         
        Else
            console.writeline("Informação não reconhecida.")

        end if

        



    End Sub
End Module
