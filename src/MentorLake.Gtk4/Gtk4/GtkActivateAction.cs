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

public class GtkActivateActionHandle : GtkShortcutActionHandle
{
	public static GtkShortcutActionHandle Get()
	{
		return GtkActivateActionExterns.gtk_activate_action_get();
	}

}

public static class GtkActivateActionHandleExtensions
{
}

internal class GtkActivateActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutActionHandle gtk_activate_action_get();

}
