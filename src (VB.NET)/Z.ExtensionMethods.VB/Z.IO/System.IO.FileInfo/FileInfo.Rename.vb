
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_791

	''' <summary>
	'''     A FileInfo extension method that renames.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="newName">Name of the new.</param>
	''' ###
	''' <returns>.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Rename(this As FileInfo, newName As String)
		Dim filePath As String = Path.Combine(this.Directory.FullName, newName)
		this.MoveTo(filePath)
	End Sub
End Module


