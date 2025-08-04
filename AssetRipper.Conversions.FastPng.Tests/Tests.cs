namespace AssetRipper.Conversions.FastPng.Tests;

public class Tests
{
	[Test]
	public void EncodingNoPixelsThrows()
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => FPng.EncodeImageToMemory([], 0, 0));
	}
}
