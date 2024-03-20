using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSizeGroupAdaptors
{
	public static GtkSizeGroupHandle SetMode(this GtkSizeGroupHandle size_group, GtkSizeGroupMode mode)
	{
		GtkSizeGroupExterns.gtk_size_group_set_mode(size_group, mode);
		return size_group;
	}

	public static GtkSizeGroupMode GetMode(this GtkSizeGroupHandle size_group)
	{
		return GtkSizeGroupExterns.gtk_size_group_get_mode(size_group);
	}

	public static GtkSizeGroupHandle AddWidget(this GtkSizeGroupHandle size_group, GtkWidgetHandle widget)
	{
		GtkSizeGroupExterns.gtk_size_group_add_widget(size_group, widget);
		return size_group;
	}

	public static GtkSizeGroupHandle RemoveWidget(this GtkSizeGroupHandle size_group, GtkWidgetHandle widget)
	{
		GtkSizeGroupExterns.gtk_size_group_remove_widget(size_group, widget);
		return size_group;
	}

	public static GSListHandle GetWidgets(this GtkSizeGroupHandle size_group)
	{
		return GtkSizeGroupExterns.gtk_size_group_get_widgets(size_group);
	}
}
