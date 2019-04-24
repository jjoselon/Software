Module Module1

    Public counter As Integer
    Private _name As Integer

    'Public [Dim] counter As Integer

    Public Sub ExampleSub()
        Static exampleStaticLocalVariable As Integer = 0
        Console.WriteLine(exampleStaticLocalVariable.ToString)
        exampleStaticLocalVariable += 2
    End Sub

    Sub Main()
        ExampleSub()
        ExampleSub()
        ExampleSub()
        Console.ReadKey()

    End Sub

    ' También podemos declarar clases dentro de un Module
    Public Class ExampleClass

    End Class

End Module
