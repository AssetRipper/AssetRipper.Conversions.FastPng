using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1BE@MMMJACNB@?$AA?$CB?$AAc?$AAo?$AAm?$AAp?$AA_?$AAo?$AAf?$AAs?$AA?$AA@")]
[DemangledName("L\"!comp_ofs\"")]
[CleanName("String")]
internal static partial class String_ji2h3xd
{
	public unsafe static InlineArray10_Int16* __pointer;

	public unsafe static InlineArray10_Int16 Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static String_ji2h3xd()
	{
		__pointer = unchecked((InlineArray10_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray10_Int16))));
		Value = InlineArrayHelper.Create<InlineArray10_Int16, char>("!comp_ofs\0");
	}
}
