Imports Ninject.Modules

Public Class EventHandlersModule
    Inherits NinjectModule

    Public Overrides Sub Load()
        '' you shouldn't have to do this. 
        '' There will be a Ninject equivalent of StructureMaps ConnectImplementationsToTypesClosing method on config

        Bind(Of IEventHandler(Of ProductSaved))().To(Of SaveProductOnProductSaved)()
    End Sub
End Class
