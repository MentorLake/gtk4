using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Pango;

public class PangoContextHandle : GObjectHandle
{
	public static PangoContextHandle New()
	{
		return PangoContextExterns.pango_context_new();
	}

}

public static class PangoContextHandleExtensions
{
	public static PangoContextHandle Changed(this PangoContextHandle context)
	{
		PangoContextExterns.pango_context_changed(context);
		return context;
	}

	public static PangoDirection GetBaseDir(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_base_dir(context);
	}

	public static PangoGravity GetBaseGravity(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_base_gravity(context);
	}

	public static PangoFontDescriptionHandle GetFontDescription(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_font_description(context);
	}

	public static PangoFontMapHandle GetFontMap(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_font_map(context);
	}

	public static PangoGravity GetGravity(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_gravity(context);
	}

	public static PangoGravityHint GetGravityHint(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_gravity_hint(context);
	}

	public static PangoLanguageHandle GetLanguage(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_language(context);
	}

	public static PangoMatrixHandle GetMatrix(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_matrix(context);
	}

	public static PangoFontMetricsHandle GetMetrics(this PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language)
	{
		return PangoContextExterns.pango_context_get_metrics(context, desc, language);
	}

	public static bool GetRoundGlyphPositions(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_round_glyph_positions(context);
	}

	public static uint GetSerial(this PangoContextHandle context)
	{
		return PangoContextExterns.pango_context_get_serial(context);
	}

	public static PangoContextHandle ListFamilies(this PangoContextHandle context, out PangoFontFamilyHandle[] families, out int n_families)
	{
		PangoContextExterns.pango_context_list_families(context, out families, out n_families);
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

	public static PangoContextHandle SetBaseDir(this PangoContextHandle context, PangoDirection direction)
	{
		PangoContextExterns.pango_context_set_base_dir(context, direction);
		return context;
	}

	public static PangoContextHandle SetBaseGravity(this PangoContextHandle context, PangoGravity gravity)
	{
		PangoContextExterns.pango_context_set_base_gravity(context, gravity);
		return context;
	}

	public static PangoContextHandle SetFontDescription(this PangoContextHandle context, PangoFontDescriptionHandle desc)
	{
		PangoContextExterns.pango_context_set_font_description(context, desc);
		return context;
	}

	public static PangoContextHandle SetFontMap(this PangoContextHandle context, PangoFontMapHandle font_map)
	{
		PangoContextExterns.pango_context_set_font_map(context, font_map);
		return context;
	}

	public static PangoContextHandle SetGravityHint(this PangoContextHandle context, PangoGravityHint hint)
	{
		PangoContextExterns.pango_context_set_gravity_hint(context, hint);
		return context;
	}

	public static PangoContextHandle SetLanguage(this PangoContextHandle context, PangoLanguageHandle language)
	{
		PangoContextExterns.pango_context_set_language(context, language);
		return context;
	}

	public static PangoContextHandle SetMatrix(this PangoContextHandle context, PangoMatrixHandle matrix)
	{
		PangoContextExterns.pango_context_set_matrix(context, matrix);
		return context;
	}

	public static PangoContextHandle SetRoundGlyphPositions(this PangoContextHandle context, bool round_positions)
	{
		PangoContextExterns.pango_context_set_round_glyph_positions(context, round_positions);
		return context;
	}

	public static GListHandle PangoItemize(this PangoContextHandle context, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter)
	{
		return PangoContextExterns.pango_itemize(context, text, start_index, length, attrs, cached_iter);
	}

	public static GListHandle PangoItemizeWithBaseDir(this PangoContextHandle context, PangoDirection base_dir, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter)
	{
		return PangoContextExterns.pango_itemize_with_base_dir(context, base_dir, text, start_index, length, attrs, cached_iter);
	}

}

internal class PangoContextExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoContextHandle pango_context_new();

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_changed(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoDirection pango_context_get_base_dir(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoGravity pango_context_get_base_gravity(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_context_get_font_description(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontMapHandle pango_context_get_font_map(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoGravity pango_context_get_gravity(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoGravityHint pango_context_get_gravity_hint(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLanguageHandle pango_context_get_language(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoMatrixHandle pango_context_get_matrix(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontMetricsHandle pango_context_get_metrics(PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_context_get_round_glyph_positions(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern uint pango_context_get_serial(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_list_families(PangoContextHandle context, out PangoFontFamilyHandle[] families, out int n_families);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontHandle pango_context_load_font(PangoContextHandle context, PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontsetHandle pango_context_load_fontset(PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_base_dir(PangoContextHandle context, PangoDirection direction);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_base_gravity(PangoContextHandle context, PangoGravity gravity);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_font_description(PangoContextHandle context, PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_font_map(PangoContextHandle context, PangoFontMapHandle font_map);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_gravity_hint(PangoContextHandle context, PangoGravityHint hint);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_language(PangoContextHandle context, PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_matrix(PangoContextHandle context, PangoMatrixHandle matrix);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_context_set_round_glyph_positions(PangoContextHandle context, bool round_positions);

	[DllImport(Libraries.Pango)]
	internal static extern GListHandle pango_itemize(PangoContextHandle context, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter);

	[DllImport(Libraries.Pango)]
	internal static extern GListHandle pango_itemize_with_base_dir(PangoContextHandle context, PangoDirection base_dir, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter);

}
