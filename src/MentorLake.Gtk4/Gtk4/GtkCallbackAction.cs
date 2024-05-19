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

namespace MentorLake.Gtk4.Gtk4;

public class GtkCallbackActionHandle : GtkShortcutActionHandle
{
	public static GtkCallbackActionHandle New(GtkShortcutFunc callback, IntPtr data, GDestroyNotify destroy)
	{
		return GtkCallbackActionExterns.gtk_callback_action_new(callback, data, destroy);
	}

}

public static class GtkCallbackActionHandleExtensions
{
}

internal class GtkCallbackActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCallbackActionHandle gtk_callback_action_new(GtkShortcutFunc callback, IntPtr data, GDestroyNotify destroy);

}
