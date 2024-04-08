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

public class GtkShortcutControllerHandle : GtkEventControllerHandle, GListModelHandle, GtkBuildableHandle
{
	public static GtkShortcutControllerHandle New()
	{
		return GtkShortcutControllerExterns.gtk_shortcut_controller_new();
	}

	public static GtkShortcutControllerHandle NewForModel(GListModelHandle model)
	{
		return GtkShortcutControllerExterns.gtk_shortcut_controller_new_for_model(model);
	}

}

public static class GtkShortcutControllerHandleExtensions
{
	public static GtkShortcutControllerHandle AddShortcut(this GtkShortcutControllerHandle self, GtkShortcutHandle shortcut)
	{
		GtkShortcutControllerExterns.gtk_shortcut_controller_add_shortcut(self, shortcut);
		return self;
	}

	public static GdkModifierType GetMnemonicsModifiers(this GtkShortcutControllerHandle self)
	{
		return GtkShortcutControllerExterns.gtk_shortcut_controller_get_mnemonics_modifiers(self);
	}

	public static GtkShortcutScope GetScope(this GtkShortcutControllerHandle self)
	{
		return GtkShortcutControllerExterns.gtk_shortcut_controller_get_scope(self);
	}

	public static GtkShortcutControllerHandle RemoveShortcut(this GtkShortcutControllerHandle self, GtkShortcutHandle shortcut)
	{
		GtkShortcutControllerExterns.gtk_shortcut_controller_remove_shortcut(self, shortcut);
		return self;
	}

	public static GtkShortcutControllerHandle SetMnemonicsModifiers(this GtkShortcutControllerHandle self, GdkModifierType modifiers)
	{
		GtkShortcutControllerExterns.gtk_shortcut_controller_set_mnemonics_modifiers(self, modifiers);
		return self;
	}

	public static GtkShortcutControllerHandle SetScope(this GtkShortcutControllerHandle self, GtkShortcutScope scope)
	{
		GtkShortcutControllerExterns.gtk_shortcut_controller_set_scope(self, scope);
		return self;
	}

}

internal class GtkShortcutControllerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutControllerHandle gtk_shortcut_controller_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutControllerHandle gtk_shortcut_controller_new_for_model(GListModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_controller_add_shortcut(GtkShortcutControllerHandle self, GtkShortcutHandle shortcut);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkModifierType gtk_shortcut_controller_get_mnemonics_modifiers(GtkShortcutControllerHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutScope gtk_shortcut_controller_get_scope(GtkShortcutControllerHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_controller_remove_shortcut(GtkShortcutControllerHandle self, GtkShortcutHandle shortcut);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_controller_set_mnemonics_modifiers(GtkShortcutControllerHandle self, GdkModifierType modifiers);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_controller_set_scope(GtkShortcutControllerHandle self, GtkShortcutScope scope);
}
