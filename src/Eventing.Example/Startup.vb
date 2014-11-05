Imports Ninject

Module Startup
    Sub Main()
        Locator.Configure()

        Application.Run(New Main)
    End Sub
End Module
