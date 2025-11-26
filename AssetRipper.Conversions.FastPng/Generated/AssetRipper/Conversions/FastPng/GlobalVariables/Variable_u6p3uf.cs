using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[CleanName("Variable")]
internal static partial class Variable_u6p3uf
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

	unsafe static Variable_u6p3uf()
	{
		unchecked
		{
			__pointer = (Struct*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(Struct)));
			Value = new Struct
			{
				field_0 = new InlineArrayBuilder<InlineArray3_IntPtr, nint>
				{
					(nint)R4bad_alloc.__pointer,
					(nint)bad_alloc_Delete.__pointer,
					(nint)what.__pointer
				}
			};
		}
	}
}
