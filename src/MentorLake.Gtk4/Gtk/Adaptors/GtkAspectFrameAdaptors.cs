using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAspectFrameAdaptors
{
	public static GtkAspectFrameHandle SetXalign(this GtkAspectFrameHandle self, float xalign)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_xalign(self, xalign);
		return self;
	}

	public static float GetXalign(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_xalign(self);
	}

	public static GtkAspectFrameHandle SetYalign(this GtkAspectFrameHandle self, float yalign)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_yalign(self, yalign);
		return self;
	}

	public static float GetYalign(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_yalign(self);
	}

	public static GtkAspectFrameHandle SetRatio(this GtkAspectFrameHandle self, float ratio)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_ratio(self, ratio);
		return self;
	}

	public static float GetRatio(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_ratio(self);
	}

	public static GtkAspectFrameHandle SetObeyChild(this GtkAspectFrameHandle self, int obey_child)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_obey_child(self, obey_child);
		return self;
	}

	public static int GetObeyChild(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_obey_child(self);
	}

	public static GtkAspectFrameHandle SetChild(this GtkAspectFrameHandle self, GtkWidgetHandle child)
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set_child(self, child);
		return self;
	}

	public static GtkWidgetHandle GetChild(this GtkAspectFrameHandle self)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_get_child(self);
	}
}
