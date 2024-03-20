using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoFontsetSimpleExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_fontset_simple_append")]
	internal static extern void pango_fontset_simple_append(this PangoFontsetSimpleHandle fontset, PangoFontHandle font);

	[DllImport(Libraries.Pango, EntryPoint = "pango_fontset_simple_size")]
	internal static extern int pango_fontset_simple_size(this PangoFontsetSimpleHandle fontset);
}
