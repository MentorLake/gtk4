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

public class GtkFixedLayoutChildHandle : GtkLayoutChildHandle
{
}

public static class GtkFixedLayoutChildSignals
{
}

public static class GtkFixedLayoutChildHandleExtensions
{
	public static GskTransformHandle GetTransform(this GtkFixedLayoutChildHandle child)
	{
		return GtkFixedLayoutChildExterns.gtk_fixed_layout_child_get_transform(child);
	}

	public static GtkFixedLayoutChildHandle SetTransform(this GtkFixedLayoutChildHandle child, GskTransformHandle transform)
	{
		GtkFixedLayoutChildExterns.gtk_fixed_layout_child_set_transform(child, transform);
		return child;
	}

}

internal class GtkFixedLayoutChildExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GskTransformHandle gtk_fixed_layout_child_get_transform(GtkFixedLayoutChildHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_fixed_layout_child_set_transform(GtkFixedLayoutChildHandle child, GskTransformHandle transform);
}
