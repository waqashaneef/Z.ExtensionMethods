
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_241

	''' <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
	''' <param name="this">this.</param>
	''' <returns>The folder path.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetFolderPath(this As Environment.SpecialFolder) As String
		Return Environment.GetFolderPath(this)
	End Function

	''' <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
	''' <param name="this">this.</param>
	''' <param name="option">The option.</param>
	''' <returns>The folder path.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetFolderPath(this As Environment.SpecialFolder, [option] As Environment.SpecialFolderOption) As String
		Return Environment.GetFolderPath(this, [option])
	End Function
End Module


