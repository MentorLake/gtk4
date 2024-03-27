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

public class GtkAspectFrameHandle : GtkWidgetHandle
{
	public static GtkAspectFrameHandle New(float xalign, float yalign, float ratio, bool obey_child)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_new(xalign, yalign, ratio, obey_child);
	}
}

public static class GtkAspectFrameSignals
{
}

public static class GtkAspectFrameHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_child(self);
	}

	public static bool GetObeyChild(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_obey_child(self);
	}

	public static float GetRatio(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_ratio(self);
	}

	public static float GetXalign(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_xalign(self);
	}

	public static float GetYalign(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_yalign(self);
	}

	public static GtkAspectFrameHandle SetChild(this GtkAspectFrameHandle self, GtkWidgetHandle child)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_child(self, child);
		return self;
	}

	public static GtkAspectFrameHandle SetObeyChild(this GtkAspectFrameHandle self, bool obey_child)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_obey_child(self, obey_child);
		return self;
	}

	public static GtkAspectFrameHandle SetRatio(this GtkAspectFrameHandle self, float ratio)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_ratio(self, ratio);
		return self;
	}

	public static GtkAspectFrameHandle SetXalign(this GtkAspectFrameHandle self, float xalign)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_xalign(self, xalign);
		return self;
	}

	public static GtkAspectFrameHandle SetYalign(this GtkAspectFrameHandle self, float yalign)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_yalign(self, yalign);
		return self;
	}

}

internal class GtkAspectFrameExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_aspect_frame_get_child(GtkAspectFrameHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_aspect_frame_get_obey_child(GtkAspectFrameHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_aspect_frame_get_ratio(GtkAspectFrameHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_aspect_frame_get_xalign(GtkAspectFrameHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_aspect_frame_get_yalign(GtkAspectFrameHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_aspect_frame_set_child(GtkAspectFrameHandle self, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_aspect_frame_set_obey_child(GtkAspectFrameHandle self, bool obey_child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_aspect_frame_set_ratio(GtkAspectFrameHandle self, float ratio);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_aspect_frame_set_xalign(GtkAspectFrameHandle self, float xalign);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_aspect_frame_set_yalign(GtkAspectFrameHandle self, float yalign);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAspectFrameHandle gtk_aspect_frame_new(float xalign, float yalign, float ratio, bool obey_child);
}
