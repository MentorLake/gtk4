using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkApplicationAdaptors
{
	public static GtkApplicationHandle AddWindow(this GtkApplicationHandle application, GtkWindowHandle window)
	{
		GtkApplicationExterns.gtk_application_add_window(application, window);
		return application;
	}

	public static GtkApplicationHandle RemoveWindow(this GtkApplicationHandle application, GtkWindowHandle window)
	{
		GtkApplicationExterns.gtk_application_remove_window(application, window);
		return application;
	}

	public static GListHandle GetWindows(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_get_windows(application);
	}

	public static GMenuModelHandle GetMenubar(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_get_menubar(application);
	}

	public static GtkApplicationHandle SetMenubar(this GtkApplicationHandle application, GMenuModelHandle menubar)
	{
		GtkApplicationExterns.gtk_application_set_menubar(application, menubar);
		return application;
	}

	public static uint Inhibit(this GtkApplicationHandle application, GtkWindowHandle window, GtkApplicationInhibitFlags flags, string reason)
	{
		return GtkApplicationExterns.gtk_application_inhibit(application, window, flags, reason);
	}

	public static GtkApplicationHandle Uninhibit(this GtkApplicationHandle application, uint cookie)
	{
		GtkApplicationExterns.gtk_application_uninhibit(application, cookie);
		return application;
	}

	public static GtkWindowHandle GetWindowById(this GtkApplicationHandle application, uint id)
	{
		return GtkApplicationExterns.gtk_application_get_window_by_id(application, id);
	}

	public static GtkWindowHandle GetActiveWindow(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_get_active_window(application);
	}

	public static string[] ListActionDescriptions(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_list_action_descriptions(application);
	}

	public static string[] GetAccelsForAction(this GtkApplicationHandle application, string detailed_action_name)
	{
		return GtkApplicationExterns.gtk_application_get_accels_for_action(application, detailed_action_name);
	}

	public static string[] GetActionsForAccel(this GtkApplicationHandle application, string accel)
	{
		return GtkApplicationExterns.gtk_application_get_actions_for_accel(application, accel);
	}

	public static GtkApplicationHandle SetAccelsForAction(this GtkApplicationHandle application, string detailed_action_name, string accels)
	{
		GtkApplicationExterns.gtk_application_set_accels_for_action(application, detailed_action_name, accels);
		return application;
	}

	public static GMenuHandle GetMenuById(this GtkApplicationHandle application, string id)
	{
		return GtkApplicationExterns.gtk_application_get_menu_by_id(application, id);
	}

	public static GtkWindowHandle WindowNew(this GtkApplicationHandle application)
	{
		return GtkApplicationExterns.gtk_application_window_new(application);
	}
}
