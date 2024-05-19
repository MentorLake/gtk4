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

public class GSimplePermissionHandle : GPermissionHandle
{
	public static GSimplePermissionHandle New(bool allowed)
	{
		return GSimplePermissionExterns.g_simple_permission_new(allowed);
	}

}

public static class GSimplePermissionHandleExtensions
{
}

internal class GSimplePermissionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimplePermissionHandle g_simple_permission_new(bool allowed);

}
