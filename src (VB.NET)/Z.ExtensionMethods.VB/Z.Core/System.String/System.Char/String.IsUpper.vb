
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_558

	''' <summary>
	'''     Indicates whether the character at the specified position in a specified string is categorized as an
	'''     uppercase letter.
	''' </summary>
	''' <param name="s">A string.</param>
	''' <param name="index">The position of the character to evaluate in .</param>
	''' <returns>true if the character at position  in  is an uppercase letter; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsUpper(s As [String], index As Int32) As [Boolean]
		Return [Char].IsUpper(s, index)
	End Function
End Module


