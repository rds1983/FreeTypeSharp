namespace FreeTypeSharp
{
	public unsafe static partial class FreeType
	{
		public const uint FT_ENCODING_NONE = (((uint)(0) << 24) | ((uint)(0) << 16) | ((uint)(0) << 8) | (uint)(0));
		public const uint FT_ENCODING_MS_SYMBOL = (((uint)('s') << 24) | ((uint)('y') << 16) | ((uint)('m') << 8) | (uint)('b'));
		public const uint FT_ENCODING_UNICODE = (((uint)('u') << 24) | ((uint)('n') << 16) | ((uint)('i') << 8) | (uint)('c'));
		public const uint FT_ENCODING_SJIS = (((uint)('s') << 24) | ((uint)('j') << 16) | ((uint)('i') << 8) | (uint)('s'));
		public const uint FT_ENCODING_PRC = (((uint)('g') << 24) | ((uint)('b') << 16) | ((uint)(' ') << 8) | (uint)(' '));
		public const uint FT_ENCODING_BIG5 = (((uint)('b') << 24) | ((uint)('i') << 16) | ((uint)('g') << 8) | (uint)('5'));
		public const uint FT_ENCODING_WANSUNG = (((uint)('w') << 24) | ((uint)('a') << 16) | ((uint)('n') << 8) | (uint)('s'));
		public const uint FT_ENCODING_JOHAB = (((uint)('j') << 24) | ((uint)('o') << 16) | ((uint)('h') << 8) | (uint)('a'));
		public const uint FT_ENCODING_GB2312 = FT_ENCODING_PRC;
		public const uint FT_ENCODING_MS_SJIS = FT_ENCODING_SJIS;
		public const uint FT_ENCODING_MS_GB2312 = FT_ENCODING_PRC;
		public const uint FT_ENCODING_MS_BIG5 = FT_ENCODING_BIG5;
		public const uint FT_ENCODING_MS_WANSUNG = FT_ENCODING_WANSUNG;
		public const uint FT_ENCODING_MS_JOHAB = FT_ENCODING_JOHAB;
		public const uint FT_ENCODING_ADOBE_STANDARD = (((uint)('A') << 24) | ((uint)('D') << 16) | ((uint)('O') << 8) | (uint)('B'));
		public const uint FT_ENCODING_ADOBE_EXPERT = (((uint)('A') << 24) | ((uint)('D') << 16) | ((uint)('B') << 8) | (uint)('E'));
		public const uint FT_ENCODING_ADOBE_CUSTOM = (((uint)('A') << 24) | ((uint)('D') << 16) | ((uint)('B') << 8) | (uint)('C'));
		public const uint FT_ENCODING_ADOBE_LATIN_1 = (((uint)('l') << 24) | ((uint)('a') << 16) | ((uint)('t') << 8) | (uint)('1'));
		public const uint FT_ENCODING_OLD_LATIN_2 = (((uint)('l') << 24) | ((uint)('a') << 16) | ((uint)('t') << 8) | (uint)('2'));
		public const uint FT_ENCODING_APPLE_ROMAN = (((uint)('a') << 24) | ((uint)('r') << 16) | ((uint)('m') << 8) | (uint)('n'));

		public enum FT_Encoding_: uint
		{
			FT_ENCODING_NONE = (((uint)(0) << 24) | ((uint)(0) << 16) | ((uint)(0) << 8) | (uint)(0)),
			FT_ENCODING_MS_SYMBOL = (((uint)('s') << 24) | ((uint)('y') << 16) | ((uint)('m') << 8) | (uint)('b')),
			FT_ENCODING_UNICODE = (((uint)('u') << 24) | ((uint)('n') << 16) | ((uint)('i') << 8) | (uint)('c')),
			FT_ENCODING_SJIS = (((uint)('s') << 24) | ((uint)('j') << 16) | ((uint)('i') << 8) | (uint)('s')),
			FT_ENCODING_PRC = (((uint)('g') << 24) | ((uint)('b') << 16) | ((uint)(' ') << 8) | (uint)(' ')),
			FT_ENCODING_BIG5 = (((uint)('b') << 24) | ((uint)('i') << 16) | ((uint)('g') << 8) | (uint)('5')),
			FT_ENCODING_WANSUNG = (((uint)('w') << 24) | ((uint)('a') << 16) | ((uint)('n') << 8) | (uint)('s')),
			FT_ENCODING_JOHAB = (((uint)('j') << 24) | ((uint)('o') << 16) | ((uint)('h') << 8) | (uint)('a')),
			FT_ENCODING_GB2312 = FT_ENCODING_PRC,
			FT_ENCODING_MS_SJIS = FT_ENCODING_SJIS,
			FT_ENCODING_MS_GB2312 = FT_ENCODING_PRC,
			FT_ENCODING_MS_BIG5 = FT_ENCODING_BIG5,
			FT_ENCODING_MS_WANSUNG = FT_ENCODING_WANSUNG,
			FT_ENCODING_MS_JOHAB = FT_ENCODING_JOHAB,
			FT_ENCODING_ADOBE_STANDARD = (((uint)('A') << 24) | ((uint)('D') << 16) | ((uint)('O') << 8) | (uint)('B')),
			FT_ENCODING_ADOBE_EXPERT = (((uint)('A') << 24) | ((uint)('D') << 16) | ((uint)('B') << 8) | (uint)('E')),
			FT_ENCODING_ADOBE_CUSTOM = (((uint)('A') << 24) | ((uint)('D') << 16) | ((uint)('B') << 8) | (uint)('C')),
			FT_ENCODING_ADOBE_LATIN_1 = (((uint)('l') << 24) | ((uint)('a') << 16) | ((uint)('t') << 8) | (uint)('1')),
			FT_ENCODING_OLD_LATIN_2 = (((uint)('l') << 24) | ((uint)('a') << 16) | ((uint)('t') << 8) | (uint)('2')),
			FT_ENCODING_APPLE_ROMAN = (((uint)('a') << 24) | ((uint)('r') << 16) | ((uint)('m') << 8) | (uint)('n'))
		}

		public const uint FT_GLYPH_FORMAT_NONE = (((uint)(0) << 24) | ((uint)(0) << 16) | ((uint)(0) << 8) | (uint)(0));
		public const uint FT_GLYPH_FORMAT_COMPOSITE = (((uint)('c') << 24) | ((uint)('o') << 16) | ((uint)('m') << 8) | (uint)('p'));
		public const uint FT_GLYPH_FORMAT_BITMAP = (((uint)('b') << 24) | ((uint)('i') << 16) | ((uint)('t') << 8) | (uint)('s'));
		public const uint FT_GLYPH_FORMAT_OUTLINE = (((uint)('o') << 24) | ((uint)('u') << 16) | ((uint)('t') << 8) | (uint)('l'));
		public const uint FT_GLYPH_FORMAT_PLOTTER = (((uint)('p') << 24) | ((uint)('l') << 16) | ((uint)('o') << 8) | (uint)('t'));

		public enum FT_Glyph_Format_: uint
		{
			FT_GLYPH_FORMAT_NONE = (((uint)(0) << 24) | ((uint)(0) << 16) | ((uint)(0) << 8) | (uint)(0)),
			FT_GLYPH_FORMAT_COMPOSITE = (((uint)('c') << 24) | ((uint)('o') << 16) | ((uint)('m') << 8) | (uint)('p')),
			FT_GLYPH_FORMAT_BITMAP = (((uint)('b') << 24) | ((uint)('i') << 16) | ((uint)('t') << 8) | (uint)('s')),
			FT_GLYPH_FORMAT_OUTLINE = (((uint)('o') << 24) | ((uint)('u') << 16) | ((uint)('t') << 8) | (uint)('l')),
			FT_GLYPH_FORMAT_PLOTTER = (((uint)('p') << 24) | ((uint)('l') << 16) | ((uint)('o') << 8) | (uint)('t'))
		}
	}
}
