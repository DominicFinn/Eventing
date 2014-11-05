Public Class SaveProductOnProductSaved
    Implements IEventHandler(Of ProductSaved)

    Private _repository As IRepository

    Public Sub New(ByVal repository As IRepository)
        _repository = repository
    End Sub

    Sub Handle(ByVal e As Sample.Core.ProductSaved) _
        Implements IEventHandler(Of Eventing.Sample.Core.ProductSaved).Handle

        _repository.Save(New Product() With {.Id = e.Id, .Name = e.Name, .UseByDate = e.UseByDate})

    End Sub
End Class
