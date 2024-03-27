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

namespace MentorLake.Gtk4.Gio;

public class GInitableHandle  : GObjectHandle
{
}

public static class GInitableHandleExtensions
{
	public static bool Init(this GInitableHandle initable, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInitableExterns.g_initable_init(initable, cancellable, out error);
	}

}

internal class GInitableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_initable_init(GInitableHandle initable, GCancellableHandle cancellable, out GErrorHandle error);
}
