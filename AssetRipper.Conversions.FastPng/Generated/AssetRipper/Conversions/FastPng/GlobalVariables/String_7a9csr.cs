using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CI@EDFEPIBM@?$AA?$CI?$AAb?$AA?$CJ?$AA?5?$AA?$DM?$AA?5?$AA?$CI?$AA1?$AAU?$AAL?$AAL?$AA?5?$AA?$DM?$AA?$DM?$AA?5?$AA?$CI?$AAl?$AA?$CJ?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"(b) < (1ULL << (l))\"")]
[CleanName("String")]
internal static partial class String_7a9csr
{
	public unsafe static InlineArray20_Int16* __pointer;

	public unsafe static InlineArray20_Int16 Value
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

	unsafe static String_7a9csr()
	{
		__pointer = unchecked((InlineArray20_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray20_Int16))));
		Value = InlineArrayHelper.Create<InlineArray20_Int16, char>("(b) < (1ULL << (l))\0");
	}
}
