Module Module1

    Sub Main()
        Dim x As String
        Dim y, z As Integer


        'My.Settings.Value3 = 2081
        'My.Settings.LastChanged = Now
        'My.Settings.Save()
        'My.Settings.Upgrade()
        'My.Settings.Reload()

        'My.Settings.Value2 = "Hello"

        x = My.Settings.Value1
        y = My.Settings.Value2
        z = My.Settings.Value3
        My.Settings.LastChanged = Now

        Console.WriteLine(x)
        Console.WriteLine(y)
        Console.WriteLine(z)
        Console.WriteLine(My.Settings.LastChanged.ToString)

        Console.ReadKey()
    End Sub

End Module
