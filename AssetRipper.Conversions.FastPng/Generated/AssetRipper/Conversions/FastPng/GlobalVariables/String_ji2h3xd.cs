using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1BE@MMMJACNB@?$AA?$CB?$AAc?$AAo?$AAm?$AAp?$AA_?$AAo?$AAf?$AAs?$AA?$AA@")]
[DemangledName("L\"!comp_ofs\"")]
[CleanName("String")]
internal static partial class String_ji2h3xd
{
	public unsafe static InlineArray_10_oeds4ea* __pointer;

	public unsafe static InlineArray_10_oeds4ea Value
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
		__pointer = unchecked((InlineArray_10_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_10_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_10_oeds4ea, char>("!comp_ofs\0".ToCharacterSpan());
	}
}
