Imports System

Module Program
   
public class Gato

    public cor as String
    public raça as String
    public sexo as String

    public sub miar()
     console.writeline ("Miau-Miau")
End sub

End class
   
   
Sub Main(args As String())

 dim garfield as new Gato()
 dim escolha as String
 
  garfield.cor = "Laranja"
  garfield.raça = "Persa"
  garfield.sexo = "Masculino"

  console.writeline(garfield.cor)
  console.writeline(garfield.raça)
  console.writeline(garfield.sexo)

  garfield.miar()

  console.writeline("Garfield quer lasanha, gostaria de conceder isso a ele?")
  escolha = console.readline()

  if escolha = "Sim" or "sim" then
    console.writeline("Ele gostou muito, obrigado!")

  Else if escolha = "Não" then
    console.writeline("Garfield está irritado!!")

  Else
    console.writeline("Escolha divergente!")


  end if


    End Sub
End Module
