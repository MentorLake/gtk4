using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoFontsetExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_fontset_get_font")]
	internal static extern PangoFontHandle pango_fontset_get_font(this PangoFontsetHandle fontset, uint wc);

	[DllImport(Libraries.Pango, EntryPoint = "pango_fontset_get_metrics")]
	internal static extern PangoFontMetricsHandle pango_fontset_get_metrics(this PangoFontsetHandle fontset);

	[DllImport(Libraries.Pango, EntryPoint = "pango_fontset_foreach")]
	internal static extern void pango_fontset_foreach(this PangoFontsetHandle fontset, PangoFontsetForeachFunc func, IntPtr data);
}
