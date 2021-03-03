Public Class clsRetornoConsultaDefault
    Private _codigo As Long
    Private _nome As String

    Public Property Codigo As Long
        Get
            Return _codigo
        End Get
        Set(value As Long)
            _codigo = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set

    End Property

    Public Sub Clear()
        Me.Codigo = 0
        Me.Nome = ""
    End Sub
End Class
