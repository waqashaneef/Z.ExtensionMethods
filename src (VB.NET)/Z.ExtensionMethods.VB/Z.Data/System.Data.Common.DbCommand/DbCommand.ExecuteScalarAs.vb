
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data.Common

Public Module Extensions_651

	''' <summary>
	'''     A DbCommand extension method that executes the scalar as operation.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteScalarAs(Of T)(this As DbCommand) As T
		Return DirectCast(this.ExecuteScalar(), T)
	End Function
End Module


