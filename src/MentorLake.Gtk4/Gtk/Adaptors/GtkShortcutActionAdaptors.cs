using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutActionAdaptors
{
	public static string ToString(this GtkShortcutActionHandle self)
	{
		return GtkShortcutActionExterns.gtk_shortcut_action_to_string(self);
	}

	public static GtkShortcutActionHandle Print(this GtkShortcutActionHandle self, GStringHandle @string)
	{
		GtkShortcutActionExterns.gtk_shortcut_action_print(self, @string);
		return self;
	}

	public static int Activate(this GtkShortcutActionHandle self, GtkShortcutActionFlags flags, GtkWidgetHandle widget, GVariantHandle args)
	{
		return GtkShortcutActionExterns.gtk_shortcut_action_activate(self, flags, widget, args);
	}

	public static GtkShortcutActionHandle GtkSignalActionNew(string signal_name)
	{
		return GtkShortcutActionExterns.gtk_signal_action_new(signal_name);
	}

	public static GtkShortcutActionHandle GtkNamedActionNew(string name)
	{
		return GtkShortcutActionExterns.gtk_named_action_new(name);
	}
}
