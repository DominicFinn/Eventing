Public Class EventBus
    Implements IEventBus

    Private ReadOnly _eventHandlerResolver As IEventHandlerResolver

    Public Sub New(ByVal eventHandlerResolver As IEventHandlerResolver)
        Me._eventHandlerResolver = eventHandlerResolver
    End Sub

    Public Sub PublishEvent(ByVal [event] As Object) Implements IEventBus.PublishEvent
        Dim eventType = [event].GetType

        Dim handlers = Me._eventHandlerResolver.Resolve(eventType)

        For Each handler In handlers
            GetType(IEventHandler(Of )) _
                .MakeGenericType(New Type() {eventType}) _
                .GetMethod("Handle", New Type() {eventType}) _
                .Invoke(handler, New Object() {[event]})
        Next
    End Sub
End Class