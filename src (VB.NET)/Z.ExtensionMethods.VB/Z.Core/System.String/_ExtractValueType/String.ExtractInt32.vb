
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text

Public Module Extensions_590

	''' <summary>
	'''     A string extension method that extracts the Int32 from the string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The extracted Int32.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExtractInt32(this As String) As Integer
		Dim sb = New StringBuilder()
		For i As Integer = 0 To this.Length - 1
			If [Char].IsDigit(this(i)) Then
				If sb.Length = 0 AndAlso i > 0 AndAlso this(i - 1) = "-"C Then
					sb.Append("-"C)
				End If
				sb.Append(this(i))
			End If
		Next

		Return Convert.ToInt32(sb.ToString())
	End Function
End Module


