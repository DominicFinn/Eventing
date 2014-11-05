Imports Ninject

Public Class NinjectEventHandlerResolver
    Implements IEventHandlerResolver


    Public Function Resolve(ByVal eventType As System.Type) As System.Collections.IEnumerable Implements IEventHandlerResolver.Resolve
        Return Enumerable.Cast(Of Object) _
            (Locator.Kernel.GetAll(GetType(IEventHandler(Of )) _
            .MakeGenericType(New Type() {eventType})))
    End Function
End Class



