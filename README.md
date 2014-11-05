Eventing
========

An eventing library for the Compact Framework that allows logic to be decoupled from the UI in Compact Framework forms projects. Borrowed from the ideas of [@trullock](https://github.com/trullock/). 

Save readmodels / projections by publishing events on the form and subscribe / handle the event in as many ways as you want. 

See the example project for full usage and setup. The implementation of the EventHandlerResolver is in the example project in case you want to implement this using an alternative IoC container.

## Basic Syntax

```vb
public class Main
  private _bus as IEventBus
  
  public sub New(IEventBus bus)
    _bus = bus
  end sub 
  
  private Sub click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSave.Click
    _bus.publish(new SomethingHappened() with { .Id = 1 })
  end sub
end class

public class SomethingHappened
  public readonly Id as integer
  
  public sub New(id as integer)
    me.Id = id
  end sub 
end class 

public class DoSomethingOnSomethingHappened
    Implements IEventHandler(Of SomethingHappened)

    sub handle(ByVal e As SomethingHappened) _
        Implements IEventHandler(Of SomethingHappened).Handle

        ' do something with the something happened event, save an entity, create a project, send an email

    End Sub
end class
```
