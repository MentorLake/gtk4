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

public class PangoFontsetHandle : GObjectHandle
{
}

public static class PangoFontsetHandleExtensions
{
	public static PangoFontsetHandle Foreach(this PangoFontsetHandle fontset, PangoFontsetForeachFunc func, IntPtr data)
	{
		PangoFontsetExterns.pango_fontset_foreach(fontset, func, data);
		return fontset;
	}

	public static PangoFontHandle GetFont(this PangoFontsetHandle fontset, uint wc)
	{
		return PangoFontsetExterns.pango_fontset_get_font(fontset, wc);
	}

	public static PangoFontMetricsHandle GetMetrics(this PangoFontsetHandle fontset)
	{
		return PangoFontsetExterns.pango_fontset_get_metrics(fontset);
	}

}

internal class PangoFontsetExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern void pango_fontset_foreach(PangoFontsetHandle fontset, PangoFontsetForeachFunc func, IntPtr data);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontHandle pango_fontset_get_font(PangoFontsetHandle fontset, uint wc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontMetricsHandle pango_fontset_get_metrics(PangoFontsetHandle fontset);

}
