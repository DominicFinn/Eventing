Imports Ninject
Imports Eventing.Sample.Core

''' <summary>
'''  A wrapper around Ninject to give it a service locater type functionality. Perhaps not needed but easy for now. 
''' </summary>
''' <remarks></remarks>
Public Class Locator
    Public Shared Kernel As IKernel = New StandardKernel(New PersistanceModule, New EventHandlersModule)

    Public Shared Sub Configure()
        ' wiring up the event bus
        Kernel.Bind(Of IEventBus).To(Of EventBus)()
        ' writing up our own resolver 
        Kernel.Bind(Of IEventHandlerResolver).To(Of NinjectEventHandlerResolver)()
    End Sub

End Class
