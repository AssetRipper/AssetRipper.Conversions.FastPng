using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0bad_alloc@std@@AEAA@QEBD@Z")]
[DemangledName("private: __cdecl std::bad_alloc::bad_alloc(char const *const)")]
[CleanName("bad_alloc_Constructor")]
internal static partial class bad_alloc_Constructor_72dj2ea
{
	public unsafe static void* Invoke(void* @this, void* Message)
	{
		exception_Constructor_morlzmd.Invoke(@this, Message, 1);
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_zdor9mc.__pointer->field_0) + sizeof(nint);
			return @this;
		}
	}
}
