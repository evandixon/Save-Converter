Imports SkyEditor.Core.IO

Public Interface ISaveFormat
    ''' <summary>
    ''' Converts a raw file into the current type.
    ''' </summary>
    ''' <param name="rawFile">The raw file to convert.</param>
    ''' <returns>A new <see cref="GenericFile"/> representing the same data as <paramref name="rawFile"/>, but in the format of the current <see cref="ISaveFormat"/></returns>
    Function ToType(rawFile As GenericFile) As GenericFile

    ''' <summary>
    ''' Converts a file of the current type into a raw file.
    ''' </summary>
    ''' <param name="typeFile">The file to convert into raw.</param>
    ''' <returns>A new <see cref="GenericFile"/> representing the same data as <paramref name="typeFile"/>, but in the raw format.</returns>
    Function ToRaw(typeFile As GenericFile) As GenericFile

    ''' <summary>
    ''' Extension of the file format.  Do not include the "*" or ".".
    ''' </summary>
    ReadOnly Property FileExtension As String

    ''' <summary>
    ''' User-friendly name of the save format.
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property Name As String

    ''' <summary>
    ''' Whether or not the current save format can be the source of a conversion.
    ''' </summary>
    ReadOnly Property CanBeSource As Boolean

    ''' <summary>
    ''' Whether or not the current save format can be the target of a conversion.
    ''' </summary>
    ReadOnly Property CanBeTarget As Boolean

    ''' <summary>
    ''' <see cref="IEnumerable(Of Long)"/> containing all valid sizes, in bytes, for this format.  If empty, all sizes are supported.  First item is the default.
    ''' </summary>
    Function GetSupportedFileSizes() As IEnumerable(Of Long)

End Interface