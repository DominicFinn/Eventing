Imports Ninject
Imports Eventing.Sample.Core

Public Class Main
    Private _bus As IEventBus

    Public Sub New()
        InitializeComponent()

        _bus = Locator.Kernel.Get(Of IEventBus)()
    End Sub

    Private Sub menuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSave.Click
        ' some validation here.

        _bus.PublishEvent(New ProductSaved() With {.Id = Guid.NewGuid, .Name = txtName.Text, .UseByDate = dtpUseByDate.Value})

        MsgBox("Product Saved")

    End Sub

    Private Sub menuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

End Class
