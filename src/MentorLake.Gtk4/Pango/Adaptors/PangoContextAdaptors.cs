using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoContextAdaptors
{
	public static PangoFontHandle PangoFontDeserialize(this PangoContextHandle context, GBytesHandle bytes, out GErrorHandle error)
	{
		return PangoContextExterns.pango_font_deserialize(context, bytes, out error);
	}

	public static GListHandle PangoItemize(this PangoContextHandle context, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter)
	{
		return PangoContextExterns.pango_itemize(context, text, start_index, length, attrs, cached_iter);
	}

	public static GListHandle PangoItemizeWithBaseDir(this PangoContextHandle context, PangoDirection base_dir, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter)
	{
		return PangoContextExterns.pango_itemize_with_base_dir(context, base_dir, text, start_index, length, attrs, cached_iter);
	}

	public static PangoContextHandle Changed(this PangoContextHandle context)
	{
		PangoContextExterns.pango_context_changed(context);
		return context;
	}

	public static PangoContextHandle SetFontMap(this PangoContextHandle context, PangoFontMapHandle font_map)
	{
		PangoContextExterns.pango_context_set_font_map(context, font_map);
		return context;
	}

	public static PangoFontMapHandle GetFontMap(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_font_map(context);
	}

	public static uint GetSerial(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_serial(context);
	}

	public static PangoContextHandle ListFamilies(this PangoContextHandle context, PangoFontFamily[] families, out int n_families)
	{
		PangoContextExterns.pango_context_list_families(context, families, out n_families);
		return context;
	}

	public static PangoFontHandle LoadFont(this PangoContextHandle context, PangoFontDescriptionHandle desc)
	{
		return PangoContextExterns.pango_context_load_font(context, desc);
	}

	public static PangoFontsetHandle LoadFontset(this PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language)
	{
		return PangoContextExterns.pango_context_load_fontset(context, desc, language);
	}

	public static PangoFontMetricsHandle GetMetrics(this PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language)
	{
		return PangoContextExterns.pango_context_get_metrics(context, desc, language);
	}

	public static PangoContextHandle SetFontDescription(this PangoContextHandle context, PangoFontDescriptionHandle desc)
	{
		PangoContextExterns.pango_context_set_font_description(context, desc);
		return context;
	}

	public static PangoFontDescriptionHandle GetFontDescription(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_font_description(context);
	}

	public static PangoLanguageHandle GetLanguage(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_language(context);
	}

	public static PangoContextHandle SetLanguage(this PangoContextHandle context, PangoLanguageHandle language)
	{
		PangoContextExterns.pango_context_set_language(context, language);
		return context;
	}

	public static PangoContextHandle SetBaseDir(this PangoContextHandle context, PangoDirection direction)
	{
		PangoContextExterns.pango_context_set_base_dir(context, direction);
		return context;
	}

	public static PangoDirection GetBaseDir(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_base_dir(context);
	}

	public static PangoContextHandle SetBaseGravity(this PangoContextHandle context, PangoGravity gravity)
	{
		PangoContextExterns.pango_context_set_base_gravity(context, gravity);
		return context;
	}

	public static PangoGravity GetBaseGravity(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_base_gravity(context);
	}

	public static PangoGravity GetGravity(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_gravity(context);
	}

	public static PangoContextHandle SetGravityHint(this PangoContextHandle context, PangoGravityHint hint)
	{
		PangoContextExterns.pango_context_set_gravity_hint(context, hint);
		return context;
	}

	public static PangoGravityHint GetGravityHint(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_gravity_hint(context);
	}

	public static PangoContextHandle SetMatrix(this PangoContextHandle context, PangoMatrixHandle matrix)
	{
		PangoContextExterns.pango_context_set_matrix(context, matrix);
		return context;
	}

	public static PangoMatrixHandle GetMatrix(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_matrix(context);
	}

	public static PangoContextHandle SetRoundGlyphPositions(this PangoContextHandle context, int round_positions)
	{
		PangoContextExterns.pango_context_set_round_glyph_positions(context, round_positions);
		return context;
	}

	public static int GetRoundGlyphPositions(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_round_glyph_positions(context);
	}

	public static PangoLayoutHandle PangoLayoutNew(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_layout_new(context);
	}

	public static PangoLayoutHandle PangoLayoutDeserialize(this PangoContextHandle context, GBytesHandle bytes, PangoLayoutDeserializeFlags flags, out GErrorHandle error)
	{
		return PangoContextExterns.pango_layout_deserialize(context, bytes, flags, out error);
	}
}
