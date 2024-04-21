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

namespace MentorLake.Gtk4.Gtk4;

public class GtkBorderHandle : BaseSafeHandle
{
	public static GtkBorderHandle New()
	{
		return GtkBorderExterns.gtk_border_new();
	}

}

internal class GtkBorderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBorderHandle gtk_border_new();

}

public struct GtkBorder
{
	public short left;
	public short right;
	public short top;
	public short bottom;
}
