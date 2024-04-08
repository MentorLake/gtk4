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

public class PangoItemHandle : BaseSafeHandle
{
	public static PangoItemHandle New()
	{
		return PangoItemExterns.pango_item_new();
	}

}

internal class PangoItemExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoItemHandle pango_item_new();
}

public struct PangoItem
{
	public int offset;
	public int length;
	public int num_chars;
	public PangoAnalysis analysis;
}
