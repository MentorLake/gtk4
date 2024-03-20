using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkFrameClockExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_get_frame_time")]
	internal static extern nint gdk_frame_clock_get_frame_time(this GdkFrameClockHandle frame_clock);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_request_phase")]
	internal static extern void gdk_frame_clock_request_phase(this GdkFrameClockHandle frame_clock, GdkFrameClockPhase phase);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_begin_updating")]
	internal static extern void gdk_frame_clock_begin_updating(this GdkFrameClockHandle frame_clock);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_end_updating")]
	internal static extern void gdk_frame_clock_end_updating(this GdkFrameClockHandle frame_clock);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_get_frame_counter")]
	internal static extern nint gdk_frame_clock_get_frame_counter(this GdkFrameClockHandle frame_clock);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_get_history_start")]
	internal static extern nint gdk_frame_clock_get_history_start(this GdkFrameClockHandle frame_clock);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_get_timings")]
	internal static extern GdkFrameTimingsHandle gdk_frame_clock_get_timings(this GdkFrameClockHandle frame_clock, nint frame_counter);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_get_current_timings")]
	internal static extern GdkFrameTimingsHandle gdk_frame_clock_get_current_timings(this GdkFrameClockHandle frame_clock);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_get_refresh_info")]
	internal static extern void gdk_frame_clock_get_refresh_info(this GdkFrameClockHandle frame_clock, nint base_time, out nint refresh_interval_return, out nint presentation_time_return);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_frame_clock_get_fps")]
	internal static extern double gdk_frame_clock_get_fps(this GdkFrameClockHandle frame_clock);
}
