Imports Ninject.Modules

Public Class PersistanceModule
    Inherits NinjectModule

    Public Overrides Sub Load()
        '' you shouldn't have to do this. 
        '' There will be a Ninject equivalent of StructureMaps ConnectImplementationsToTypesClosing method on config

        Bind(Of IRepository)().To(Of Repository)()
    End Sub
End Class
