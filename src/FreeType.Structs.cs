using System;
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

		[StructLayout(LayoutKind.Explicit)]
		public struct TT_Post_NamesRec_names
		{
			[FieldOffset(0)]
			public TT_Post_20Rec_ format_20;

			[FieldOffset(0)]
			public TT_Post_25_ format_25;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct TT_Post_NamesRec_
		{
			public byte loaded;
			public TT_Post_NamesRec_names names;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct FT_HashnodeRec_
		{
			[FieldOffset(0)]
			public FT_Hashkey_ key;

			[FieldOffset(0)]
			public ulong data;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class FT_HashRec_
		{
			public uint limit;
			public uint size;
			public uint used;
			public delegate ulong lookup_func(FT_Hashkey_* a); public lookup_func lookup;
			public delegate byte compare_func(FT_Hashkey_* a, FT_Hashkey_* b); public compare_func compare;
			public FT_HashnodeRec_** table;
		}

		public class FT_Service_PsCMapsRec_
		{

			public delegate uint unicode_value_func(char* a); public unicode_value_func unicode_value;
			public delegate char* PS_GetGlyphNameFunc(void* data, uint string_index);
			public delegate void PS_FreeGlyphNameFunc(void* data, char* name);
			public delegate int unicodes_init_func(FT_MemoryRec_ memory,
						   PS_UnicodesRec_ unicodes,
						   uint num_glyphs,
						   PS_GetGlyphNameFunc get_glyph_name,
						   PS_FreeGlyphNameFunc free_glyph_name,
						   void* glyph_data);

			public unicodes_init_func unicodes_init;
			public delegate uint unicodes_char_index_func(PS_UnicodesRec_ a, uint b); public unicodes_char_index_func unicodes_char_index;
			public delegate uint unicodes_char_next_func(PS_UnicodesRec_ a, uint* b); public unicodes_char_next_func unicodes_char_next;
			public delegate char* macintosh_name_func(uint a); public macintosh_name_func macintosh_name;
			public delegate char* adobe_std_strings_func(uint a); public adobe_std_strings_func adobe_std_strings;
			public ushort* adobe_std_encoding;
			public ushort* adobe_expert_encoding;
		}

		public class T1_Decoder_FuncsRec_
		{
			public delegate int T1_Decoder_Callback(T1_DecoderRec_ decoder, uint glyph_index);
			public delegate int init_func(T1_DecoderRec_ a, FT_FaceRec_ b, FT_SizeRec_ c, FT_GlyphSlotRec_ d, byte** e, PS_BlendRec_ f, byte g, int h, T1_Decoder_Callback i);

			public init_func init;
			public delegate void done_func(T1_DecoderRec_ a); public done_func done;
			public delegate int parse_metrics_func(T1_DecoderRec_ a, byte* b, uint c); public parse_metrics_func parse_metrics;
			public delegate int parse_charstrings_func(PS_Decoder_ a, byte* b, ulong c); public parse_charstrings_func parse_charstrings;
		}

		public class PS_BlendRec_
		{
			public uint num_designs = 0;
			public uint num_axis = 0;
			public sbyte*[] axis_names = new sbyte*[4];
			public int*[] design_pos = new int*[16];
			public PS_DesignMap_[] design_map = new PS_DesignMap_[4];
			public int* weight_vector;
			public int* default_weight_vector;
			public PS_FontInfoRec_*[] font_infos = new PS_FontInfoRec_*[16 + 1];
			public PS_PrivateRec_*[] privates = new PS_PrivateRec_*[16 + 1];
			public int blend_bitflags = 0;
			public FT_BBox_*[] bboxes = new FT_BBox_*[16 + 1];
			public uint[] default_design_vector = new uint[16];
			public uint num_default_design_vector = 0;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct CFF_InternalRec_
		{
			public void* topfont;
			public fixed long subfonts[256];
		}

		public class CFF_Decoder_FuncsRec_
		{
			public delegate int CFF_Decoder_Get_Glyph_Callback(TT_FaceRec_ face, uint glyph_index, byte** pointer, uint* length);
			public delegate void CFF_Decoder_Free_Glyph_Callback(TT_FaceRec_ face, byte** pointer, uint length);
			public delegate void init_func(CFF_Decoder_ a, TT_FaceRec_ b, CFF_SizeRec_ c, CFF_GlyphSlotRec_ d, byte e, int f, CFF_Decoder_Get_Glyph_Callback g, CFF_Decoder_Free_Glyph_Callback h);
			public init_func init;
			public delegate int prepare_func(CFF_Decoder_ a, CFF_SizeRec_ b, uint c); public prepare_func prepare;
			public delegate int parse_charstrings_func(PS_Decoder_ a, byte* b, uint c); public parse_charstrings_func parse_charstrings;
		}
	}
}
