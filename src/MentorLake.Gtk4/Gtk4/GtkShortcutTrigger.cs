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

public class GtkShortcutTriggerHandle : GObjectHandle
{
	public static GtkShortcutTriggerHandle ParseString(string @string)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_parse_string(@string);
	}

}

public static class GtkShortcutTriggerHandleExtensions
{
	public static int Compare(this IntPtr trigger1, IntPtr trigger2)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_compare(trigger1, trigger2);
	}

	public static bool Equal(this IntPtr trigger1, IntPtr trigger2)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_equal(trigger1, trigger2);
	}

	public static uint Hash(this IntPtr trigger)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_hash(trigger);
	}

	public static GtkShortcutTriggerHandle Print(this GtkShortcutTriggerHandle self, GStringHandle @string)
	{
		GtkShortcutTriggerExterns.gtk_shortcut_trigger_print(self, @string);
		return self;
	}

	public static bool PrintLabel(this GtkShortcutTriggerHandle self, GdkDisplayHandle display, GStringHandle @string)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_print_label(self, display, @string);
	}

	public static string ToLabel(this GtkShortcutTriggerHandle self, GdkDisplayHandle display)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_to_label(self, display);
	}

	public static string ToString(this GtkShortcutTriggerHandle self)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_to_string(self);
	}

	public static GdkKeyMatch Trigger(this GtkShortcutTriggerHandle self, GdkEventHandle @event, bool enable_mnemonics)
	{
		return GtkShortcutTriggerExterns.gtk_shortcut_trigger_trigger(self, @event, enable_mnemonics);
	}

}

internal class GtkShortcutTriggerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutTriggerHandle gtk_shortcut_trigger_parse_string(string @string);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_shortcut_trigger_compare(IntPtr trigger1, IntPtr trigger2);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_shortcut_trigger_equal(IntPtr trigger1, IntPtr trigger2);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_shortcut_trigger_hash(IntPtr trigger);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_trigger_print(GtkShortcutTriggerHandle self, GStringHandle @string);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_shortcut_trigger_print_label(GtkShortcutTriggerHandle self, GdkDisplayHandle display, GStringHandle @string);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_shortcut_trigger_to_label(GtkShortcutTriggerHandle self, GdkDisplayHandle display);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_shortcut_trigger_to_string(GtkShortcutTriggerHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkKeyMatch gtk_shortcut_trigger_trigger(GtkShortcutTriggerHandle self, GdkEventHandle @event, bool enable_mnemonics);

}
