
    Imports System
Imports System.Collections.Generic

Module Program
    Sub Main(args As String())
    
       Dim lista As New Collections.Generic.List(Of String) From {
            "Moises", "Hellenna", "Manuella"
        }

        Dim nome As String = ""

        While nome.ToLower() <> "sair"
            Console.WriteLine("Digite um nome ou 'sair':")
            nome = Console.ReadLine()

            If nome.ToLower() <> "sair" Then
                lista.Add(nome)
            End If
        End While

        Console.WriteLine("Lista completa:")
        For Each aluno In lista
            Console.WriteLine(aluno)
        Next

        Console.ReadLine()
    End Sub
End Module
  
