using AssetRipper.Conversions.FastPng.Structures;
using System;

namespace AssetRipper.Conversions.FastPng;

public static class FPng
{
	public static unsafe byte[] EncodeImageToMemory(ReadOnlySpan<byte> imageData, int width, int height)
	{
		int pixelCount = width * height;
		if (imageData.Length % pixelCount != 0)
		{
			throw new ArgumentException("Image data length is not a multiple of pixel count.");
		}
		int channelCount = imageData.Length / pixelCount;
		if (channelCount is not 3 and not 4)
		{
			throw new ArgumentException("Image data must have 3 or 4 channels (RGB or RGBA).");
		}

		byte[] result;
		std_vector vector = default;
		std_vector* vectorPtr = &vector;
		GlobalFunctions.vector_unsigned_char_class_std_allocator_unsigned_char_Constructor(vectorPtr); // Constructor
		try
		{
			fixed (byte* ptr = imageData)
			{
				GlobalFunctions.fpng_encode_image_to_memory(ptr, width, height, channelCount, vectorPtr, default);
			}
			result = vector.AsSpan<byte>().ToArray();
		}
		finally
		{
			GlobalFunctions.vector_unsigned_char_class_std_allocator_unsigned_char_Destructor(vectorPtr); // Destructor
		}
		return result;
	}

	static unsafe ReadOnlySpan<T> AsSpan<T>(this std_vector vector) where T : unmanaged
	{
		T* startPtr = (T*)vector.field_0.field_0.field_0;
		T* endPtr = (T*)vector.field_0.field_0.field_1;
		int length = (int)(endPtr - startPtr);
		return new ReadOnlySpan<T>(startPtr, length);
	}
}
