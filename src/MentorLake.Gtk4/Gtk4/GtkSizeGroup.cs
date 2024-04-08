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

public class GtkSizeGroupHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkSizeGroupHandle New(GtkSizeGroupMode mode)
	{
		return GtkSizeGroupExterns.gtk_size_group_new(mode);
	}

}

public static class GtkSizeGroupHandleExtensions
{
	public static GtkSizeGroupHandle AddWidget(this GtkSizeGroupHandle size_group, GtkWidgetHandle widget)
	{
		GtkSizeGroupExterns.gtk_size_group_add_widget(size_group, widget);
		return size_group;
	}

	public static GtkSizeGroupMode GetMode(this GtkSizeGroupHandle size_group)
	{
		return GtkSizeGroupExterns.gtk_size_group_get_mode(size_group);
	}

	public static GSListHandle GetWidgets(this GtkSizeGroupHandle size_group)
	{
		return GtkSizeGroupExterns.gtk_size_group_get_widgets(size_group);
	}

	public static GtkSizeGroupHandle RemoveWidget(this GtkSizeGroupHandle size_group, GtkWidgetHandle widget)
	{
		GtkSizeGroupExterns.gtk_size_group_remove_widget(size_group, widget);
		return size_group;
	}

	public static GtkSizeGroupHandle SetMode(this GtkSizeGroupHandle size_group, GtkSizeGroupMode mode)
	{
		GtkSizeGroupExterns.gtk_size_group_set_mode(size_group, mode);
		return size_group;
	}

}

internal class GtkSizeGroupExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSizeGroupHandle gtk_size_group_new(GtkSizeGroupMode mode);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_size_group_add_widget(GtkSizeGroupHandle size_group, GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSizeGroupMode gtk_size_group_get_mode(GtkSizeGroupHandle size_group);
	[DllImport(Libraries.Gtk4)]
	internal static extern GSListHandle gtk_size_group_get_widgets(GtkSizeGroupHandle size_group);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_size_group_remove_widget(GtkSizeGroupHandle size_group, GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_size_group_set_mode(GtkSizeGroupHandle size_group, GtkSizeGroupMode mode);
}
