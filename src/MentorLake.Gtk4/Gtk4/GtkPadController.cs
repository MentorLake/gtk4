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

public class GtkPadControllerHandle : GtkEventControllerHandle
{
	public static GtkPadControllerHandle New(GActionGroupHandle group, GdkDeviceHandle pad)
	{
		return GtkPadControllerExterns.gtk_pad_controller_new(group, pad);
	}

}

public static class GtkPadControllerHandleExtensions
{
	public static GtkPadControllerHandle SetAction(this GtkPadControllerHandle controller, GtkPadActionType type, int index, int mode, string label, string action_name)
	{
		GtkPadControllerExterns.gtk_pad_controller_set_action(controller, type, index, mode, label, action_name);
		return controller;
	}

	public static GtkPadControllerHandle SetActionEntries(this GtkPadControllerHandle controller, GtkPadActionEntry[] entries, int n_entries)
	{
		GtkPadControllerExterns.gtk_pad_controller_set_action_entries(controller, entries, n_entries);
		return controller;
	}

}

internal class GtkPadControllerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPadControllerHandle gtk_pad_controller_new(GActionGroupHandle group, GdkDeviceHandle pad);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_pad_controller_set_action(GtkPadControllerHandle controller, GtkPadActionType type, int index, int mode, string label, string action_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_pad_controller_set_action_entries(GtkPadControllerHandle controller, GtkPadActionEntry[] entries, int n_entries);

}
