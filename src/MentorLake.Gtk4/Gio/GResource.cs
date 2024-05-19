using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GResourceHandle : BaseSafeHandle
{
	public static GResourceHandle NewFromData(GBytesHandle data, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_new_from_data(data, out error);
	}

}

internal class GResourceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GResourceHandle g_resource_new_from_data(GBytesHandle data, out GErrorHandle error);

}

public struct GResource
{
}
