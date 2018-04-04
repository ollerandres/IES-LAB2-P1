Public Class Consulta

    Private idConsulta As Integer
    Private idMascota As Integer
    Private fecha As Date
    Private nombreCliente As String
    Private nombreMascota As String
    Private telefono As String

    Public Sub New(idConsulta As TipoConsulta, idMascota As TipoMascota, fecha As Date, nombreCliente As String, nombreMascota As String, telefono As String)
        Me.idConsulta = idConsulta
        Me.idMascota = idMascota
        Me.fecha = fecha
        Me.nombreCliente = nombreCliente
        Me.nombreMascota = nombreMascota
        Me.telefono = telefono
    End Sub


    Public Property TipoConsulta() As TipoConsulta
        Get
            Return idConsulta
        End Get
        Set(ByVal Value As TipoConsulta)
            idConsulta = Value
        End Set    End Property

    Public Property TipoMascota() As TipoMascota
        Get
            Return idMascota
        End Get
        Set(ByVal Value As TipoMascota)
            idMascota = Value
        End Set    End Property

    Public Property fechaConsulta() As Date
        Get
            Return fecha
        End Get
        Set(ByVal Value As Date)
            fecha = Value
        End Set    End Property

    Public Property NombreDelCliente() As String
        Get
            Return nombreCliente
        End Get
        Set(ByVal Value As String)
            nombreCliente = Value
        End Set    End Property

    Public Property NombreDeMascota() As String
        Get
            Return nombreMascota
        End Get
        Set(ByVal Value As String)
            nombreMascota = Value
        End Set    End Property

    Public Property TelefonoDeContacto() As String
        Get
            Return telefono
        End Get
        Set(ByVal Value As String)
            telefono = Value
        End Set    End Property

End Class
