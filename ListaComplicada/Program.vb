Imports System

Module Program
    Sub Main(args As String())

        Dim lista as new list (of String)
        Dim value as integer
        Dim nome as String

    console.writeline("Quantos alunos irão se cadastrar?")
    value = integer.parse(console.readline())

         for i as integer = 1 to value
         console.write("Digite o nome do aluno:")
         nome = console. readline()
         lista.add(nome) 
         next

         For each aluno in lista
         console.writeline(aluno)
         next
        

    End Sub
End Module
