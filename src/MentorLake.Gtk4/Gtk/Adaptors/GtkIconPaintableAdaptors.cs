using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIconPaintableAdaptors
{
	public static GFileHandle GetFile(this GtkIconPaintableHandle self)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_get_file(self);
	}

	public static string GetIconName(this GtkIconPaintableHandle self)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_get_icon_name(self);
	}

	public static int IsSymbolic(this GtkIconPaintableHandle self)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_is_symbolic(self);
	}
}
