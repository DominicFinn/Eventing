Public Class Repository
    Implements IRepository

    Shared database As New Dictionary(Of Type, Dictionary(Of Guid, ReadModel))

    Public Sub Save(Of TReadModel As ReadModel)(ByVal entity As TReadModel) Implements IRepository.Save
        If Not database.ContainsKey(GetType(TReadModel)) Then
            database.Add(GetType(TReadModel), New Dictionary(Of Guid, ReadModel)())
        End If

        database(GetType(TReadModel)).Add(entity.Id, entity)
    End Sub

    Public Function Load(Of TReadModel As ReadModel)(ByVal id As Guid) As TReadModel Implements IRepository.Load
        If Not database.ContainsKey(GetType(TReadModel)) Then
            Return Nothing
        End If

        Return database(GetType(TReadModel))(id)
    End Function
End Class
