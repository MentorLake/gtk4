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

public class GtkActionBarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkActionBarHandle New()
	{
		return GtkActionBarExterns.gtk_action_bar_new();
	}

}

public static class GtkActionBarHandleExtensions
{
	public static GtkWidgetHandle GetCenterWidget(this GtkActionBarHandle action_bar)
	{
		return GtkActionBarExterns.gtk_action_bar_get_center_widget(action_bar);
	}

	public static bool GetRevealed(this GtkActionBarHandle action_bar)
	{
		return GtkActionBarExterns.gtk_action_bar_get_revealed(action_bar);
	}

	public static GtkActionBarHandle PackEnd(this GtkActionBarHandle action_bar, GtkWidgetHandle child)
	{
		GtkActionBarExterns.gtk_action_bar_pack_end(action_bar, child);
		return action_bar;
	}

	public static GtkActionBarHandle PackStart(this GtkActionBarHandle action_bar, GtkWidgetHandle child)
	{
		GtkActionBarExterns.gtk_action_bar_pack_start(action_bar, child);
		return action_bar;
	}

	public static GtkActionBarHandle Remove(this GtkActionBarHandle action_bar, GtkWidgetHandle child)
	{
		GtkActionBarExterns.gtk_action_bar_remove(action_bar, child);
		return action_bar;
	}

	public static GtkActionBarHandle SetCenterWidget(this GtkActionBarHandle action_bar, GtkWidgetHandle center_widget)
	{
		GtkActionBarExterns.gtk_action_bar_set_center_widget(action_bar, center_widget);
		return action_bar;
	}

	public static GtkActionBarHandle SetRevealed(this GtkActionBarHandle action_bar, bool revealed)
	{
		GtkActionBarExterns.gtk_action_bar_set_revealed(action_bar, revealed);
		return action_bar;
	}

}

internal class GtkActionBarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkActionBarHandle gtk_action_bar_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_action_bar_get_center_widget(GtkActionBarHandle action_bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_action_bar_get_revealed(GtkActionBarHandle action_bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_action_bar_pack_end(GtkActionBarHandle action_bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_action_bar_pack_start(GtkActionBarHandle action_bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_action_bar_remove(GtkActionBarHandle action_bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_action_bar_set_center_widget(GtkActionBarHandle action_bar, GtkWidgetHandle center_widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_action_bar_set_revealed(GtkActionBarHandle action_bar, bool revealed);

}
