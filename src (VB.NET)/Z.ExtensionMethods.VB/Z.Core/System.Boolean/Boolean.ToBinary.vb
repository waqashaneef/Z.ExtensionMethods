
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_68

	''' <summary>
	'''     A bool extension method that convert this object into a binary representation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A binary represenation of this object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToBinary(this As Boolean) As Byte
		Return Convert.ToByte(this)
	End Function
End Module


