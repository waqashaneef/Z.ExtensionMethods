
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_56

	''' <summary>
	'''     Copies a range of elements from an  starting at the specified source index and pastes them to another
	'''     starting at the specified destination index.  Guarantees that all changes are undone if the copy does not
	'''     succeed completely.
	''' </summary>
	''' <param name="sourceArray">The  that contains the data to copy.</param>
	''' <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
	''' <param name="destinationArray">The  that receives the data.</param>
	''' <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
	''' <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ConstrainedCopy(sourceArray As Array, sourceIndex As Int32, destinationArray As Array, destinationIndex As Int32, length As Int32)
		Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)
	End Sub
End Module


