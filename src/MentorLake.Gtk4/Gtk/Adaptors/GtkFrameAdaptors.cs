using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFrameAdaptors
{
	public static GtkFrameHandle SetLabel(this GtkFrameHandle frame, string label)
	{
		GtkFrameExterns.gtk_frame_set_label(frame, label);
		return frame;
	}

	public static string GetLabel(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label(frame);
	}

	public static GtkFrameHandle SetLabelWidget(this GtkFrameHandle frame, GtkWidgetHandle label_widget)
	{
		GtkFrameExterns.gtk_frame_set_label_widget(frame, label_widget);
		return frame;
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label_widget(frame);
	}

	public static GtkFrameHandle SetLabelAlign(this GtkFrameHandle frame, float xalign)
	{
		GtkFrameExterns.gtk_frame_set_label_align(frame, xalign);
		return frame;
	}

	public static float GetLabelAlign(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label_align(frame);
	}

	public static GtkFrameHandle SetChild(this GtkFrameHandle frame, GtkWidgetHandle child)
	{
		GtkFrameExterns.gtk_frame_set_child(frame, child);
		return frame;
	}

	public static GtkWidgetHandle GetChild(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_child(frame);
	}
}
