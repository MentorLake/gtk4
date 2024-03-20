using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutTriggerAdaptors
{
	public static string ToString(this GtkShortcutTriggerHandle self)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_to_string(self);
	}

	public static GtkShortcutTriggerHandle Print(this GtkShortcutTriggerHandle self, GStringHandle @string)
	{
		GtkShortcutTriggerExterns.gtk_shortcut_trigger_print(self, @string);
		return self;
	}

	public static string ToLabel(this GtkShortcutTriggerHandle self, GdkDisplayHandle display)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_to_label(self, display);
	}

	public static int PrintLabel(this GtkShortcutTriggerHandle self, GdkDisplayHandle display, GStringHandle @string)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_print_label(self, display, @string);
	}

	public static GdkKeyMatch Trigger(this GtkShortcutTriggerHandle self, GdkEventHandle @event, int enable_mnemonics)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_trigger(self, @event, enable_mnemonics);
	}

	public static GtkShortcutTriggerHandle GtkAlternativeTriggerNew(this GtkShortcutTriggerHandle first, GtkShortcutTriggerHandle second)
	{
		return GtkShortcutTriggerExterns.gtk_alternative_trigger_new(first, second);
	}

	public static GtkShortcutTriggerHandle GtkMnemonicTriggerNew(uint keyval)
	{
		return GtkShortcutTriggerExterns.gtk_mnemonic_trigger_new(keyval);
	}
}
