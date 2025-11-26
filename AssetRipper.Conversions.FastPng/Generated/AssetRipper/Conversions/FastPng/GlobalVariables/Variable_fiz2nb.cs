using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[CleanName("Variable")]
internal static partial class Variable_fiz2nb
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

	unsafe static Variable_fiz2nb()
	{
		unchecked
		{
			__pointer = (Struct*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(Struct)));
			Value = new Struct
			{
				field_0 = new InlineArrayBuilder<InlineArray3_IntPtr, nint>
				{
					(nint)R4bad_array_new_length.__pointer,
					(nint)bad_array_new_length_Delete.__pointer,
					(nint)what.__pointer
				}
			};
		}
	}
}
