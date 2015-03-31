
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_226

	''' <summary>
	'''     Returns the tangent of the specified angle.
	''' </summary>
	''' <param name="a">An angle, measured in radians.</param>
	''' <returns>The tangent of . If  is equal to , , or , this method returns .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Tan(a As [Double]) As [Double]
		Return Math.Tan(a)
	End Function
End Module


