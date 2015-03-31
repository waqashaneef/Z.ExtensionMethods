
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_511

	''' <summary>
	'''     A string extension method that return the left part of the string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="length">The length.</param>
	''' <returns>The left part.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Left(this As String, length As Integer) As String
		Return this.Substring(0, length)
	End Function
End Module


