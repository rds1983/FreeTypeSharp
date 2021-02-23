using System.Runtime.InteropServices;

namespace FreeTypeSharp
{
	unsafe partial class FreeType
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct FT_StreamDesc_
		{
			[FieldOffset(0)]
			public int value;
			[FieldOffset(0)]
			public void* pointer;
		}

		public class FT_StreamRec_
		{
			public byte* _base_;
			public int size = 0;
			public int pos = 0;
			public FT_StreamDesc_ descriptor;
			public FT_StreamDesc_ pathname;
			public delegate ulong read_func(FT_StreamRec_ a, ulong b, byte* c, ulong d); public read_func read;
			public delegate void close_func(FT_StreamRec_ a); public close_func close;
			public FT_MemoryRec_ memory;
			public byte* cursor;
			public byte* limit;
		}
	}
}
