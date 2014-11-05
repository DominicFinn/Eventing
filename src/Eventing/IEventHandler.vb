Public Interface IEventHandler

End Interface

Public Interface IEventHandler(Of TEvent)
    Inherits IEventHandler

    Sub Handle(ByVal e As TEvent)
End Interface
