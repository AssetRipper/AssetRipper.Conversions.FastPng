using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[CleanName("Variable")]
internal static partial class Variable_unhbb7
{
	public unsafe static Struct* __pointer;

	public unsafe static Struct Value
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

	unsafe static Variable_unhbb7()
	{
		unchecked
		{
			__pointer = (Struct*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(Struct)));
			Value = new Struct
			{
				field_0 = new InlineArrayBuilder<InlineArray3_IntPtr, nint>
				{
					(nint)R4exception.__pointer,
					(nint)exception_Delete.__pointer,
					(nint)what.__pointer
				}
			};
		}
	}
}
