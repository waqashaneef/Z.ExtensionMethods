
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_59

	''' <summary>
	'''     Searches for the specified object and returns the index of the last occurrence within the entire one-
	'''     dimensional .
	''' </summary>
	''' <param name="array">The one-dimensional  to search.</param>
	''' <param name="value">The object to locate in .</param>
	''' <returns>
	'''     The index of the last occurrence of  within the entire , if found; otherwise, the lower bound of the array
	'''     minus 1.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function LastIndexOf(array__1 As Array, value As [Object]) As Int32
		Return Array.LastIndexOf(array__1, value)
	End Function

	''' <summary>
	'''     Searches for the specified object and returns the index of the last occurrence within the range of elements
	'''     in the one-dimensional  that extends from the first element to the specified index.
	''' </summary>
	''' <param name="array">The one-dimensional  to search.</param>
	''' <param name="value">The object to locate in .</param>
	''' <param name="startIndex">The starting index of the backward search.</param>
	''' <returns>
	'''     The index of the last occurrence of  within the range of elements in  that extends from the first element to ,
	'''     if found; otherwise, the lower bound of the array minus 1.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function LastIndexOf(array__1 As Array, value As [Object], startIndex As Int32) As Int32
		Return Array.LastIndexOf(array__1, value, startIndex)
	End Function

	''' <summary>
	'''     Searches for the specified object and returns the index of the last occurrence within the range of elements
	'''     in the one-dimensional  that contains the specified number of elements and ends at the specified index.
	''' </summary>
	''' <param name="array">The one-dimensional  to search.</param>
	''' <param name="value">The object to locate in .</param>
	''' <param name="startIndex">The starting index of the backward search.</param>
	''' <param name="count">The number of elements in the section to search.</param>
	''' <returns>
	'''     The index of the last occurrence of  within the range of elements in  that contains the number of elements
	'''     specified in  and ends at , if found; otherwise, the lower bound of the array minus 1.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function LastIndexOf(array__1 As Array, value As [Object], startIndex As Int32, count As Int32) As Int32
		Return Array.LastIndexOf(array__1, value, startIndex, count)
	End Function
End Module


