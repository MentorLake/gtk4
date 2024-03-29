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

public class GtkShortcutHandle : GObjectHandle
{
	public static GtkShortcutHandle New(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action)
	{
		return GtkShortcutExterns.gtk_shortcut_new(trigger, action);
	}

	public static GtkShortcutHandle NewWithArguments(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action, string format_string, IntPtr @__arglist)
	{
		return GtkShortcutExterns.gtk_shortcut_new_with_arguments(trigger, action, format_string, @__arglist);
	}

}

public static class GtkShortcutHandleExtensions
{
	public static GtkShortcutActionHandle GetAction(this GtkShortcutHandle self)
	{
		return GtkShortcutExterns.gtk_shortcut_get_action(self);
	}

	public static GVariantHandle GetArguments(this GtkShortcutHandle self)
	{
		return GtkShortcutExterns.gtk_shortcut_get_arguments(self);
	}

	public static GtkShortcutTriggerHandle GetTrigger(this GtkShortcutHandle self)
	{
		return GtkShortcutExterns.gtk_shortcut_get_trigger(self);
	}

	public static GtkShortcutHandle SetAction(this GtkShortcutHandle self, GtkShortcutActionHandle action)
	{
		GtkShortcutExterns.gtk_shortcut_set_action(self, action);
		return self;
	}

	public static GtkShortcutHandle SetArguments(this GtkShortcutHandle self, GVariantHandle args)
	{
		GtkShortcutExterns.gtk_shortcut_set_arguments(self, args);
		return self;
	}

	public static GtkShortcutHandle SetTrigger(this GtkShortcutHandle self, GtkShortcutTriggerHandle trigger)
	{
		GtkShortcutExterns.gtk_shortcut_set_trigger(self, trigger);
		return self;
	}

}

internal class GtkShortcutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutHandle gtk_shortcut_new(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutHandle gtk_shortcut_new_with_arguments(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action, string format_string, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutActionHandle gtk_shortcut_get_action(GtkShortcutHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GVariantHandle gtk_shortcut_get_arguments(GtkShortcutHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutTriggerHandle gtk_shortcut_get_trigger(GtkShortcutHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_set_action(GtkShortcutHandle self, GtkShortcutActionHandle action);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_set_arguments(GtkShortcutHandle self, GVariantHandle args);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_set_trigger(GtkShortcutHandle self, GtkShortcutTriggerHandle trigger);
}
