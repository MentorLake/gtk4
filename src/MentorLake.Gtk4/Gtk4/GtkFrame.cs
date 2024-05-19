namespace MentorLake.Gtk4.Gtk4;

public class GtkFrameHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkFrameHandle New(string label)
	{
		return GtkFrameExterns.gtk_frame_new(label);
	}

}

public static class GtkFrameHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_child(frame);
	}

	public static string GetLabel(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label(frame);
	}

	public static float GetLabelAlign(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label_align(frame);
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label_widget(frame);
	}

	public static GtkFrameHandle SetChild(this GtkFrameHandle frame, GtkWidgetHandle child)
	{
		GtkFrameExterns.gtk_frame_set_child(frame, child);
		return frame;
	}

	public static GtkFrameHandle SetLabel(this GtkFrameHandle frame, string label)
	{
		GtkFrameExterns.gtk_frame_set_label(frame, label);
		return frame;
	}

	public static GtkFrameHandle SetLabelAlign(this GtkFrameHandle frame, float xalign)
	{
		GtkFrameExterns.gtk_frame_set_label_align(frame, xalign);
		return frame;
	}

	public static GtkFrameHandle SetLabelWidget(this GtkFrameHandle frame, GtkWidgetHandle label_widget)
	{
		GtkFrameExterns.gtk_frame_set_label_widget(frame, label_widget);
		return frame;
	}

}

internal class GtkFrameExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFrameHandle gtk_frame_new(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_frame_get_child(GtkFrameHandle frame);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_frame_get_label(GtkFrameHandle frame);

	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_frame_get_label_align(GtkFrameHandle frame);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_frame_get_label_widget(GtkFrameHandle frame);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_frame_set_child(GtkFrameHandle frame, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_frame_set_label(GtkFrameHandle frame, string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_frame_set_label_align(GtkFrameHandle frame, float xalign);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_frame_set_label_widget(GtkFrameHandle frame, GtkWidgetHandle label_widget);

}
