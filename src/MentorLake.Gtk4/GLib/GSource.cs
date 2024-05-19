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

namespace MentorLake.Gtk4.GLib;

public class GSourceHandle : BaseSafeHandle
{
	public static GSourceHandle New(GSourceFuncsHandle source_funcs, uint struct_size)
	{
		return GSourceExterns.g_source_new(source_funcs, struct_size);
	}

}

internal class GSourceExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_source_new(GSourceFuncsHandle source_funcs, uint struct_size);

}

public struct GSource
{
}
