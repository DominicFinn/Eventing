Public Interface IEventHandlerResolver
    Function Resolve(ByVal eventType As Type) As IEnumerable
End Interface
