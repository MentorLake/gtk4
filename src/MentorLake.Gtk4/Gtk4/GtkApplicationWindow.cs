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

public class GtkApplicationWindowHandle : GtkWindowHandle, GActionGroupHandle, GActionMapHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkApplicationWindowHandle New(GtkApplicationHandle application)
	{
		return GtkApplicationWindowExterns.gtk_application_window_new(application);
	}

}

public static class GtkApplicationWindowHandleExtensions
{
	public static GtkShortcutsWindowHandle GetHelpOverlay(this GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowExterns.gtk_application_window_get_help_overlay(window);
	}

	public static uint GetId(this GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowExterns.gtk_application_window_get_id(window);
	}

	public static bool GetShowMenubar(this GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowExterns.gtk_application_window_get_show_menubar(window);
	}

	public static GtkApplicationWindowHandle SetHelpOverlay(this GtkApplicationWindowHandle window, GtkShortcutsWindowHandle help_overlay)
	{
		GtkApplicationWindowExterns.gtk_application_window_set_help_overlay(window, help_overlay);
		return window;
	}

	public static GtkApplicationWindowHandle SetShowMenubar(this GtkApplicationWindowHandle window, bool show_menubar)
	{
		GtkApplicationWindowExterns.gtk_application_window_set_show_menubar(window, show_menubar);
		return window;
	}

}

internal class GtkApplicationWindowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkApplicationWindowHandle gtk_application_window_new(GtkApplicationHandle application);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutsWindowHandle gtk_application_window_get_help_overlay(GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_application_window_get_id(GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_application_window_get_show_menubar(GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_application_window_set_help_overlay(GtkApplicationWindowHandle window, GtkShortcutsWindowHandle help_overlay);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_application_window_set_show_menubar(GtkApplicationWindowHandle window, bool show_menubar);

}
