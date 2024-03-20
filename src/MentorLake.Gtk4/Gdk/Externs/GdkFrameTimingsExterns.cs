using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkFrameTimingsExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_ref")]
	internal static extern GdkFrameTimingsHandle gdk_frame_timings_ref(this GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_unref")]
	internal static extern void gdk_frame_timings_unref(this GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_get_frame_counter")]
	internal static extern nint gdk_frame_timings_get_frame_counter(this GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_get_complete")]
	internal static extern int gdk_frame_timings_get_complete(this GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_get_frame_time")]
	internal static extern nint gdk_frame_timings_get_frame_time(this GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_get_presentation_time")]
	internal static extern nint gdk_frame_timings_get_presentation_time(this GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_get_refresh_interval")]
	internal static extern nint gdk_frame_timings_get_refresh_interval(this GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_timings_get_predicted_presentation_time")]
	internal static extern nint gdk_frame_timings_get_predicted_presentation_time(this GdkFrameTimingsHandle timings);
}
