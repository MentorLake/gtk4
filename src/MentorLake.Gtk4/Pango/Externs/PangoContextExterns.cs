using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoContextExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_deserialize")]
    internal static extern PangoFontHandle pango_font_deserialize(this PangoContextHandle context, GBytesHandle bytes, out GErrorHandle error);
    [DllImport(Libraries.Pango, EntryPoint = "pango_itemize")]
    internal static extern GListHandle pango_itemize(this PangoContextHandle context, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter);
    [DllImport(Libraries.Pango, EntryPoint = "pango_itemize_with_base_dir")]
    internal static extern GListHandle pango_itemize_with_base_dir(this PangoContextHandle context, PangoDirection base_dir, string text, int start_index, int length, PangoAttrListHandle attrs, PangoAttrIteratorHandle cached_iter);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_changed")]
    internal static extern void pango_context_changed(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_font_map")]
    internal static extern void pango_context_set_font_map(this PangoContextHandle context, PangoFontMapHandle font_map);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_font_map")]
    internal static extern PangoFontMapHandle pango_context_get_font_map(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_serial")]
    internal static extern uint pango_context_get_serial(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_list_families")]
    internal static extern void pango_context_list_families(this PangoContextHandle context, PangoFontFamily[] families, out int n_families);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_load_font")]
    internal static extern PangoFontHandle pango_context_load_font(this PangoContextHandle context, PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_load_fontset")]
    internal static extern PangoFontsetHandle pango_context_load_fontset(this PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_metrics")]
    internal static extern PangoFontMetricsHandle pango_context_get_metrics(this PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_font_description")]
    internal static extern void pango_context_set_font_description(this PangoContextHandle context, PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_font_description")]
    internal static extern PangoFontDescriptionHandle pango_context_get_font_description(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_language")]
    internal static extern PangoLanguageHandle pango_context_get_language(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_language")]
    internal static extern void pango_context_set_language(this PangoContextHandle context, PangoLanguageHandle language);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_base_dir")]
    internal static extern void pango_context_set_base_dir(this PangoContextHandle context, PangoDirection direction);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_base_dir")]
    internal static extern PangoDirection pango_context_get_base_dir(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_base_gravity")]
    internal static extern void pango_context_set_base_gravity(this PangoContextHandle context, PangoGravity gravity);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_base_gravity")]
    internal static extern PangoGravity pango_context_get_base_gravity(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_gravity")]
    internal static extern PangoGravity pango_context_get_gravity(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_gravity_hint")]
    internal static extern void pango_context_set_gravity_hint(this PangoContextHandle context, PangoGravityHint hint);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_gravity_hint")]
    internal static extern PangoGravityHint pango_context_get_gravity_hint(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_matrix")]
    internal static extern void pango_context_set_matrix(this PangoContextHandle context, PangoMatrixHandle matrix);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_matrix")]
    internal static extern PangoMatrixHandle pango_context_get_matrix(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_set_round_glyph_positions")]
    internal static extern void pango_context_set_round_glyph_positions(this PangoContextHandle context, int round_positions);
    [DllImport(Libraries.Pango, EntryPoint = "pango_context_get_round_glyph_positions")]
    internal static extern int pango_context_get_round_glyph_positions(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_layout_new")]
    internal static extern PangoLayoutHandle pango_layout_new(this PangoContextHandle context);
    [DllImport(Libraries.Pango, EntryPoint = "pango_layout_deserialize")]
    internal static extern PangoLayoutHandle pango_layout_deserialize(this PangoContextHandle context, GBytesHandle bytes, PangoLayoutDeserializeFlags flags, out GErrorHandle error);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoContextHandle pango_context_new();
}
