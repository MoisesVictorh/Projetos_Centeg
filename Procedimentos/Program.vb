Imports System

Module Program
    Sub DemonstarMensagem()

        Dim nome as String
        Dim nota as Integer

        console.write("Olá caro aluno(a), digite seu nome: ")
        nome = console.readline()
        console.writeline("Ah! Olá " & nome)

        console.writeline("Qual nota você se avalia?")
        nota = console.readline()

        if nota <= "5" then
         console.writeline("Precisa melhorar")

        else if nota <= "7" then

            console.writeline("Em algumas instituições passaria, estude mais")

            else if nota >= "8" then
                 console.writeline("Parabéns")
       

        end if  
        

    End sub

    Function soma (a as Integer, b as Integer) as Integer

    return a + b

    end Function



    Sub Main(args As String())

       Dim result as Integer
       Dim num1, num2 as Integer

       console.write("Digite o número: ")
       num1 = console.readline()

       console.write("Digite o segundo número: ")
       num2 = console.readline()

       Result = soma(num1, num2)
       console.writeline(result)
    


    End Sub
End Module


