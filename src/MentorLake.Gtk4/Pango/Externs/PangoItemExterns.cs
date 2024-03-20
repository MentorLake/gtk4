using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoItemExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_item_copy")]
    internal static extern PangoItemHandle pango_item_copy(this PangoItemHandle item);
    [DllImport(Libraries.Pango, EntryPoint = "pango_item_free")]
    internal static extern void pango_item_free(this PangoItemHandle item);
    [DllImport(Libraries.Pango, EntryPoint = "pango_item_split")]
    internal static extern PangoItemHandle pango_item_split(this PangoItemHandle orig, int split_index, int split_offset);
    [DllImport(Libraries.Pango, EntryPoint = "pango_item_apply_attrs")]
    internal static extern void pango_item_apply_attrs(this PangoItemHandle item, PangoAttrIteratorHandle iter);
    [DllImport(Libraries.Pango, EntryPoint = "pango_shape_item")]
    internal static extern void pango_shape_item(this PangoItemHandle item, string paragraph_text, int paragraph_length, PangoLogAttrHandle log_attrs, PangoGlyphStringHandle glyphs, PangoShapeFlags flags);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoItemHandle pango_item_new();
}
