using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("__ImageBase")]
[DemangledName("__ImageBase")]
internal static partial class ImageBase
{
	private static sbyte __value;

	public static sbyte Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	static ImageBase()
	{
	}
}
