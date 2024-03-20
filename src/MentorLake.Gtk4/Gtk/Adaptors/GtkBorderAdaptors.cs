using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBorderAdaptors
{
	public static GtkBorderHandle Copy(this GtkBorderHandle border_)
	{
		return GtkBorderExterns.gtk_border_copy(border_);
	}

	public static GtkBorderHandle Free(this GtkBorderHandle border_)
	{
		GtkBorderExterns.gtk_border_free(border_);
		return border_;
	}
}
