using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("_Avx2WmemEnabledWeakValue")]
[DemangledName("_Avx2WmemEnabledWeakValue")]
internal static partial class Avx2WmemEnabledWeakValue
{
	private static int __value;

	public static int Value
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

	static Avx2WmemEnabledWeakValue()
	{
		Value = 0;
	}
}
