using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.std::exception")]
public partial struct std_exception
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public std_exception_data field_1;
}
