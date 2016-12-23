Imports SaveConverter
Imports SkyEditor.Core.IO

Public Class RawFile
    Implements ISaveFormat

    Public Sub New(name As String, fileExtension As String, fileSizes As IEnumerable(Of Long))
        Me.Name = name
        Me.FileExtension = fileExtension
        Me._supportedFileSizes = fileSizes
    End Sub

    Public ReadOnly Property CanBeSource As Boolean Implements ISaveFormat.CanBeSource
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property CanBeTarget As Boolean Implements ISaveFormat.CanBeTarget
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property FileExtension As String Implements ISaveFormat.FileExtension

    Public ReadOnly Property Name As String Implements ISaveFormat.Name

    Public Function GetSupportedFileSizes() As IEnumerable(Of Long) Implements ISaveFormat.GetSupportedFileSizes
        Throw New NotImplementedException()
    End Function
    Dim _supportedFileSizes As IEnumerable(Of Long)

    Public Function ToRaw(typeFile As GenericFile) As GenericFile Implements ISaveFormat.ToRaw
        Throw New NotImplementedException()
    End Function

    Public Function ToType(rawFile As GenericFile) As GenericFile Implements ISaveFormat.ToType
        Throw New NotImplementedException()
    End Function


End Class
