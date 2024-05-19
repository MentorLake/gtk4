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

public class GMainLoopHandle : BaseSafeHandle
{
	public static GMainLoopHandle New(GMainContextHandle context, bool is_running)
	{
		return GMainLoopExterns.g_main_loop_new(context, is_running);
	}

}

internal class GMainLoopExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMainLoopHandle g_main_loop_new(GMainContextHandle context, bool is_running);

}

public struct GMainLoop
{
}
