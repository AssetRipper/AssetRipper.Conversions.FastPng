using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?vector_append@fpng@@YAXAEAV?$vector@EV?$allocator@E@std@@@std@@PEBX_K@Z")]
[DemangledName("void __cdecl fpng::vector_append(class std::vector<unsigned char, class std::allocator<unsigned char>> &, void const *, unsigned __int64)")]
internal static partial class vector_append
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class std::vector<unsigned char, class std::allocator<unsigned char>> &")] void* buf, [NativeType("void const *")] void* pData, [NativeType("unsigned __int64")] long len)
	{
		unchecked
		{
			if (len != 0L)
			{
				long num = size_4io4p4d.Invoke(buf);
				resize_wwmwtsa.Invoke(buf, num + len);
				if (ExceptionInfo.Current == null)
				{
					llvm_memcpy_p0_p0_i64.Invoke((byte*)data_efhnzgd.Invoke(buf) + num, pData, len, isVolatile: false);
				}
			}
		}
	}
}
