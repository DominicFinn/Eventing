Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Eventing.Example
Imports Ninject
Imports Eventing.Sample.Core

Namespace GivenAnEventIsPublished

    <TestClass()> _
    Public Class ThenTheEventHandlerShouldBeCalled
        Private _eventBus As IEventBus
        Private _event As ProductSaved

        <TestInitialize()> _
        Public Sub Setup()
            Locator.Configure()

            _eventBus = Locator.Kernel.GetAll(Of IEventBus)()

            _event = New ProductSaved() With { _
                                    .Id = Guid.NewGuid, _
                                    .Name = "New Product", _
                                    .UseByDate = New DateTime(2014, 10, 10) _
                                   }

            _eventBus.PublishEvent(_event)

        End Sub

        Public Sub TheEventHandlerShouldBeCalled()
            Dim repository As Repository = Locator.Kernel.Get(Of IRepository)()

            Dim product = repository.Load(Of Product)(_event.Id)

            Assert.AreEqual(_event.Name, product.Name)
            Assert.AreEqual(_event.UseByDate, product.UseByDate)
        End Sub

    End Class
End Namespace
