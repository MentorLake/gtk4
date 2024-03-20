using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWindowControlsAdaptors
{
	public static GtkPackType GetSide(this GtkWindowControlsHandle self)
	{
		return GtkWindowControlsExterns.gtk_window_controls_get_side(self);
	}

	public static GtkWindowControlsHandle SetSide(this GtkWindowControlsHandle self, GtkPackType side)
	{
		GtkWindowControlsExterns.gtk_window_controls_set_side(self, side);
		return self;
	}

	public static string GetDecorationLayout(this GtkWindowControlsHandle self)
	{
		return GtkWindowControlsExterns.gtk_window_controls_get_decoration_layout(self);
	}

	public static GtkWindowControlsHandle SetDecorationLayout(this GtkWindowControlsHandle self, string layout)
	{
		GtkWindowControlsExterns.gtk_window_controls_set_decoration_layout(self, layout);
		return self;
	}

	public static int GetEmpty(this GtkWindowControlsHandle self)
	{
		return GtkWindowControlsExterns.gtk_window_controls_get_empty(self);
	}
}
