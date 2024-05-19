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

public class GSrvTargetHandle : BaseSafeHandle
{
	public static GSrvTargetHandle New(string hostname, ushort port, ushort priority, ushort weight)
	{
		return GSrvTargetExterns.g_srv_target_new(hostname, port, priority, weight);
	}

}

internal class GSrvTargetExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSrvTargetHandle g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);

}

public struct GSrvTarget
{
}
