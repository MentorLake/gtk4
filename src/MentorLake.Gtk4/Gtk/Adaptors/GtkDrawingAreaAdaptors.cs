using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDrawingAreaAdaptors
{
	public static GtkDrawingAreaHandle SetContentWidth(this GtkDrawingAreaHandle self, int width)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_content_width(self, width);
		return self;
	}

	public static int GetContentWidth(this GtkDrawingAreaHandle self)
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_get_content_width(self);
	}

	public static GtkDrawingAreaHandle SetContentHeight(this GtkDrawingAreaHandle self, int height)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_content_height(self, height);
		return self;
	}

	public static int GetContentHeight(this GtkDrawingAreaHandle self)
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_get_content_height(self);
	}

	public static GtkDrawingAreaHandle SetDrawFunc(this GtkDrawingAreaHandle self, GtkDrawingAreaDrawFunc draw_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_draw_func(self, draw_func, user_data, destroy);
		return self;
	}
}
