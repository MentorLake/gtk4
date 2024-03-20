using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoColorExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_color_copy")]
	internal static extern PangoColorHandle pango_color_copy(this PangoColorHandle src);

	[DllImport(Libraries.Pango, EntryPoint = "pango_color_free")]
	internal static extern void pango_color_free(this PangoColorHandle color);

	[DllImport(Libraries.Pango, EntryPoint = "pango_color_parse")]
	internal static extern int pango_color_parse(this PangoColorHandle color, string spec);

	[DllImport(Libraries.Pango, EntryPoint = "pango_color_parse_with_alpha")]
	internal static extern int pango_color_parse_with_alpha(this PangoColorHandle color, out ushort alpha, string spec);

	[DllImport(Libraries.Pango, EntryPoint = "pango_color_to_string")]
	internal static extern string pango_color_to_string(this PangoColorHandle color);
}
