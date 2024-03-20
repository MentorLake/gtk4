using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Pango;

public struct PangoRendererClass
{
	public GObjectClass parent_class;

	public IntPtr draw_glyphs;

	public IntPtr draw_rectangle;

	public IntPtr draw_error_underline;

	public IntPtr draw_shape;

	public IntPtr draw_trapezoid;

	public IntPtr draw_glyph;

	public IntPtr part_changed;

	public IntPtr begin;

	public IntPtr end;

	public IntPtr prepare_run;

	public IntPtr draw_glyph_item;

	public IntPtr _pango_reserved2;

	public IntPtr _pango_reserved3;

	public IntPtr _pango_reserved4;
}

public struct PangoRectangle
{
	public int x;

	public int y;

	public int width;

	public int height;
}

public struct PangoEngineShape
{
	public PangoEngine parent_instance;
}

public struct PangoTabArray { }

public struct PangoEngine
{
	public GObject.GObject parent_instance;
}

public struct PangoFontClass
{
	public GObjectClass parent_class;

	public IntPtr describe;

	public IntPtr get_coverage;

	public IntPtr get_glyph_extents;

	public IntPtr get_metrics;

	public IntPtr get_font_map;

	public IntPtr describe_absolute;

	public IntPtr get_features;

	public IntPtr create_hb_font;
}

public struct PangoAttrInt
{
	public PangoAttribute attr;

	public int value;
}

public struct PangoScriptIter { }

public struct PangoEngineClass
{
	public GObjectClass parent_class;
}

public struct PangoGlyphItemIter
{
	public PangoGlyphItemHandle glyph_item;

	public string text;

	public int start_glyph;

	public int start_index;

	public int start_char;

	public int end_glyph;

	public int end_index;

	public int end_char;
}

public struct PangoAttrShape
{
	public PangoAttribute attr;

	public PangoRectangle ink_rect;

	public PangoRectangle logical_rect;

	public IntPtr data;

	public PangoAttrDataCopyFunc copy_func;

	public GDestroyNotify destroy_func;
}

public struct PangoFontsetClass
{
	public GObjectClass parent_class;

	public IntPtr get_font;

	public IntPtr get_metrics;

	public IntPtr get_language;

	public IntPtr @foreach;

	public IntPtr _pango_reserved1;

	public IntPtr _pango_reserved2;

	public IntPtr _pango_reserved3;

	public IntPtr _pango_reserved4;
}

public struct PangoLanguage { }
public struct PangoRendererPrivate { }
public struct PangoLayoutIter { }

public struct PangoAttrClass
{
	public PangoAttrType type;

	public IntPtr copy;

	public IntPtr destroy;

	public IntPtr equal;
}

public struct PangoEngineLangClass
{
	public PangoEngineClass parent_class;

	public IntPtr script_break;
}

public struct PangoEngineInfo
{
	public string id;

	public string engine_type;

	public string render_type;

	public PangoEngineScriptInfoHandle scripts;

	public int n_scripts;
}

public struct PangoFont
{
	public GObject.GObject parent_instance;
}

public struct PangoFontMap
{
	public GObject.GObject parent_instance;
}

public struct PangoRenderer
{
	public GObject.GObject parent_instance;

	public PangoUnderline underline;

	public int strikethrough;

	public int active_count;

	public PangoMatrixHandle matrix;

	public PangoRendererPrivateHandle priv;
}

public struct PangoAttribute
{
	public PangoAttrClassHandle klass;

	public uint start_index;

	public uint end_index;
}

public struct PangoGlyphItem
{
	public PangoItemHandle item;

	public PangoGlyphStringHandle glyphs;

	public int y_offset;

	public int start_x_offset;

	public int end_x_offset;
}

public struct PangoGlyph
{
	public uint Value;
}

public struct PangoGlyphInfo
{
	public PangoGlyph glyph;

	public PangoGlyphGeometry geometry;

	public PangoGlyphVisAttr attr;
}

public struct PangoFontFamily
{
	public GObject.GObject parent_instance;
}

public struct PangoAttrSize
{
	public PangoAttribute attr;

	public int size;

	public uint _bitfield;

	public uint absolute
	{
		readonly get => _bitfield & 0x1u;

		set => _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
	}
}

public struct PangoAttrFontFeatures
{
	public PangoAttribute attr;

	public string features;
}

public struct PangoLayoutClass { }

public struct PangoAttrColor
{
	public PangoAttribute attr;

	public PangoColor color;
}

public struct PangoLayoutLine
{
	public PangoLayoutHandle layout;

	public int start_index;

	public int length;

	public GSListHandle runs;

	public uint _bitfield;

	public uint is_paragraph_start
	{
		readonly get => _bitfield & 0x1u;

		set => _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
	}

	public uint resolved_dir
	{
		readonly get => (_bitfield >> 1) & 0x7u;

		set => _bitfield = (_bitfield & ~(0x7u << 1)) | ((value & 0x7u) << 1);
	}
}

public struct PangoColor
{
	public ushort red;

	public ushort green;

	public ushort blue;
}

public struct PangoFontFace
{
	public GObject.GObject parent_instance;
}

public struct PangoEngineLang
{
	public PangoEngine parent_instance;
}

public struct PangoEngineScriptInfo
{
	public PangoScript script;

	public string langs;
}

public struct PangoMatrix
{
	public double xx;

	public double xy;

	public double yx;

	public double yy;

	public double x0;

	public double y0;
}

public struct PangoAttrFloat
{
	public PangoAttribute attr;

	public double value;
}

public struct PangoFontset
{
	public GObject.GObject parent_instance;
}

public struct PangoGlyphVisAttr
{
	public uint _bitfield;

	public uint is_cluster_start
	{
		readonly get => _bitfield & 0x1u;

		set => _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
	}

	public uint is_color
	{
		readonly get => (_bitfield >> 1) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
	}
}

public struct PangoFontMapClass
{
	public GObjectClass parent_class;

	public IntPtr load_font;

	public IntPtr list_families;

	public IntPtr load_fontset;

	public string shape_engine_type;

	public IntPtr get_serial;

	public IntPtr changed;

	public IntPtr get_family;

	public IntPtr get_face;
}

public struct PangoFontFaceClass
{
	public GObjectClass parent_class;

	public IntPtr get_face_name;

	public IntPtr describe;

	public IntPtr list_sizes;

	public IntPtr is_synthesized;

	public IntPtr get_family;

	public IntPtr _pango_reserved3;

	public IntPtr _pango_reserved4;
}

public struct PangoGlyphString
{
	public int num_glyphs;

	public PangoGlyphInfoHandle glyphs;

	public IntPtr log_clusters;

	public int space;
}

public struct PangoFontsetSimpleClass { }

public struct PangoAttrFontDesc
{
	public PangoAttribute attr;

	public PangoFontDescriptionHandle desc;
}

public struct PangoFontFamilyClass
{
	public GObjectClass parent_class;

	public IntPtr list_faces;

	public IntPtr get_name;

	public IntPtr is_monospace;

	public IntPtr is_variable;

	public IntPtr get_face;

	public IntPtr _pango_reserved2;
}

public struct PangoFontMetrics
{
	public uint ref_count;

	public int ascent;

	public int descent;

	public int height;

	public int approximate_char_width;

	public int approximate_digit_width;

	public int underline_position;

	public int underline_thickness;

	public int strikethrough_position;

	public int strikethrough_thickness;
}

public struct PangoFontDescription { }
public struct PangoAttrList { }
public struct PangoAttrIterator { }

public struct PangoLogAttr
{
	public uint _bitfield;

	public uint is_line_break
	{
		readonly get => _bitfield & 0x1u;

		set => _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
	}

	public uint is_mandatory_break
	{
		readonly get => (_bitfield >> 1) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
	}

	public uint is_char_break
	{
		readonly get => (_bitfield >> 2) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
	}

	public uint is_white
	{
		readonly get => (_bitfield >> 3) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
	}

	public uint is_cursor_position
	{
		readonly get => (_bitfield >> 4) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
	}

	public uint is_word_start
	{
		readonly get => (_bitfield >> 5) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
	}

	public uint is_word_end
	{
		readonly get => (_bitfield >> 6) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
	}

	public uint is_sentence_boundary
	{
		readonly get => (_bitfield >> 7) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
	}

	public uint is_sentence_start
	{
		readonly get => (_bitfield >> 8) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
	}

	public uint is_sentence_end
	{
		readonly get => (_bitfield >> 9) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
	}

	public uint backspace_deletes_character
	{
		readonly get => (_bitfield >> 10) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
	}

	public uint is_expandable_space
	{
		readonly get => (_bitfield >> 11) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
	}

	public uint is_word_boundary
	{
		readonly get => (_bitfield >> 12) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
	}

	public uint break_inserts_hyphen
	{
		readonly get => (_bitfield >> 13) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13);
	}

	public uint break_removes_preceding
	{
		readonly get => (_bitfield >> 14) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14);
	}

	public uint reserved
	{
		readonly get => (_bitfield >> 15) & 0x1FFFFu;

		set => _bitfield = (_bitfield & ~(0x1FFFFu << 15)) | ((value & 0x1FFFFu) << 15);
	}
}

public struct PangoLayout { }
public struct PangoContext { }

public struct PangoGlyphUnit
{
	public int Value;
}

public struct PangoGlyphGeometry
{
	public PangoGlyphUnit width;

	public PangoGlyphUnit x_offset;

	public PangoGlyphUnit y_offset;
}

public struct PangoContextClass { }

public struct PangoItem
{
	public int offset;

	public int length;

	public int num_chars;

	public PangoAnalysis analysis;
}

public struct PangoAttrString
{
	public PangoAttribute attr;

	public string value;
}

public struct PangoEngineShapeClass
{
	public PangoEngineClass parent_class;

	public IntPtr script_shape;

	public IntPtr covers;
}

public struct PangoAnalysis
{
	public PangoEngineShapeHandle shape_engine;

	public PangoEngineLangHandle lang_engine;

	public PangoFontHandle font;

	public byte level;

	public byte gravity;

	public byte flags;

	public byte script;

	public PangoLanguageHandle language;

	public GSListHandle extra_attrs;
}

public struct PangoAttrLanguage
{
	public PangoAttribute attr;

	public PangoLanguageHandle value;
}

public struct PangoCoverage { }
public struct PangoFontsetSimple { }
