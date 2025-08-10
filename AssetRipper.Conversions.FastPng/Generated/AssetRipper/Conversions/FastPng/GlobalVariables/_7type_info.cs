using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_7type_info@@6B@")]
[DemangledName("const type_info::`vftable'")]
internal static partial class _7type_info
{
	public unsafe static void** __pointer;

	public unsafe static void* Value
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

	unsafe static _7type_info()
	{
		__pointer = unchecked((void**)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(void*))));
		Value = null;
	}
}
