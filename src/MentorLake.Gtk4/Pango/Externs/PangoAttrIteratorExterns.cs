using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;

public static class PangoAttrIteratorExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_iterator_range")]
	internal static extern void pango_attr_iterator_range(this PangoAttrIteratorHandle iterator, out int start, out int end);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_iterator_next")]
	internal static extern int pango_attr_iterator_next(this PangoAttrIteratorHandle iterator);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_iterator_copy")]
	internal static extern PangoAttrIteratorHandle pango_attr_iterator_copy(this PangoAttrIteratorHandle iterator);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_iterator_destroy")]
	internal static extern void pango_attr_iterator_destroy(this PangoAttrIteratorHandle iterator);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_iterator_get")]
	internal static extern PangoAttributeHandle pango_attr_iterator_get(this PangoAttrIteratorHandle iterator, PangoAttrType type);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_iterator_get_font")]
	internal static extern void pango_attr_iterator_get_font(this PangoAttrIteratorHandle iterator, PangoFontDescriptionHandle desc, out PangoLanguageHandle language, out GSListHandle extra_attrs);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_iterator_get_attrs")]
	internal static extern GSListHandle pango_attr_iterator_get_attrs(this PangoAttrIteratorHandle iterator);
}
