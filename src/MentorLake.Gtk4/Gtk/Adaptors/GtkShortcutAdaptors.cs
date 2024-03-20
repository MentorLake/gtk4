using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutAdaptors
{
	public static GtkShortcutTriggerHandle GetTrigger(this GtkShortcutHandle self)
	{
		return GtkShortcutExterns.gtk_shortcut_get_trigger(self);
	}

	public static GtkShortcutHandle SetTrigger(this GtkShortcutHandle self, GtkShortcutTriggerHandle trigger)
	{
		GtkShortcutExterns.gtk_shortcut_set_trigger(self, trigger);
		return self;
	}

	public static GtkShortcutActionHandle GetAction(this GtkShortcutHandle self)
	{
		return GtkShortcutExterns.gtk_shortcut_get_action(self);
	}

	public static GtkShortcutHandle SetAction(this GtkShortcutHandle self, GtkShortcutActionHandle action)
	{
		GtkShortcutExterns.gtk_shortcut_set_action(self, action);
		return self;
	}

	public static GVariantHandle GetArguments(this GtkShortcutHandle self)
	{
		return GtkShortcutExterns.gtk_shortcut_get_arguments(self);
	}

	public static GtkShortcutHandle SetArguments(this GtkShortcutHandle self, GVariantHandle args)
	{
		GtkShortcutExterns.gtk_shortcut_set_arguments(self, args);
		return self;
	}

	public static GtkShortcutHandle NewWithArguments(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action, string format_string, IntPtr @__arglist)
	{
		return GtkShortcutExterns.gtk_shortcut_new_with_arguments(trigger, action, format_string, @__arglist);
	}
}
