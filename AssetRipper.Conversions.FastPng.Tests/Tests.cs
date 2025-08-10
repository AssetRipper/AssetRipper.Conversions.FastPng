namespace AssetRipper.Conversions.FastPng.Tests;

public class Tests
{
	[Test]
	public void EncodingNoPixelsThrows()
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => FPng.EncodeImageToMemory([], 0, 0));
	}

	[Test]
	public void EncodingGradientIsSuccessful()
	{
		int width = 1024;
		int height = 1024;
		byte[] rawPixelData = CreatePixels(width, height);
		byte[] encodedData = FPng.EncodeImageToMemory(rawPixelData, width, height);
		Assert.That(encodedData, Is.Not.Empty);
	}

	static byte[] CreatePixels(int width, int height)
	{
		int index = 0;
		byte[] data = new byte[width * height * 3]; // RGB format
		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
			{
				// Create a simple gradient
				int r = (x * 255) / width;
				int g = (y * 255) / height;
				int b = ((x + y) * 255) / (width + height);

				data[index++] = (byte)r;
				data[index++] = (byte)g;
				data[index++] = (byte)b;
			}
		}
		return data;
	}
}
