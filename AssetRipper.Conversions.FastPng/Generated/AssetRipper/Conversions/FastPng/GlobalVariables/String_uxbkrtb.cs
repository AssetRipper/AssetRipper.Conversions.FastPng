using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1DK@OKEJEHAG@?$AA?4?$AA?4?$AA?1?$AA?4?$AA?4?$AA?1?$AA?4?$AA?4?$AA?1?$AA?4?$AA?4?$AA?1?$AAS?$AAa?$AAm?$AAp?$AAl?$AAe?$AAs?$AA?2?$AAf?$AAp?$AAn?$AAg?$AA?4?$AAc?$AAp?$AAp?$AA?$AA@")]
[DemangledName("L\"../../../../Samples\\\\fpng.cpp\"")]
[CleanName("String")]
internal static partial class String_uxbkrtb
{
	public unsafe static InlineArray29_Int16* __pointer;

	public unsafe static InlineArray29_Int16 Value
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

	unsafe static String_uxbkrtb()
	{
		__pointer = unchecked((InlineArray29_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray29_Int16))));
		Value = InlineArrayHelper.Create<InlineArray29_Int16, char>("../../../../Samples\\fpng.cpp\0");
	}
}
