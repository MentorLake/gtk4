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

public class GtkKeyvalTriggerHandle : GtkShortcutTriggerHandle
{
	public static GtkKeyvalTriggerHandle New(uint keyval, GdkModifierType modifiers)
	{
		return GtkKeyvalTriggerExterns.gtk_keyval_trigger_new(keyval, modifiers);
	}
}

public static class GtkKeyvalTriggerSignals
{
}

public static class GtkKeyvalTriggerHandleExtensions
{
	public static uint GetKeyval(this GtkKeyvalTriggerHandle self)
	{
		return GtkKeyvalTriggerExterns.gtk_keyval_trigger_get_keyval(self);
	}

	public static GdkModifierType GetModifiers(this GtkKeyvalTriggerHandle self)
	{
		return GtkKeyvalTriggerExterns.gtk_keyval_trigger_get_modifiers(self);
	}

}

internal class GtkKeyvalTriggerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_keyval_trigger_get_keyval(GtkKeyvalTriggerHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkModifierType gtk_keyval_trigger_get_modifiers(GtkKeyvalTriggerHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkKeyvalTriggerHandle gtk_keyval_trigger_new(uint keyval, GdkModifierType modifiers);
}
