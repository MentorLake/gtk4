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

public class GtkSeparatorHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkSeparatorHandle New(GtkOrientation orientation)
	{
		return GtkSeparatorExterns.gtk_separator_new(orientation);
	}

}

public static class GtkSeparatorHandleExtensions
{
}

internal class GtkSeparatorExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSeparatorHandle gtk_separator_new(GtkOrientation orientation);
}
