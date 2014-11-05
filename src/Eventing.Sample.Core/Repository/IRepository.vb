Public Interface IRepository
    Sub Save(Of TReadModel As ReadModel)(ByVal entity As TReadModel)
    Function Load(Of TReadModel As ReadModel)(ByVal id As Guid) As TReadModel
End Interface
