namespace MentorLake.Gtk4.Gdk4;

public class GdkFrameTimingsHandle : BaseSafeHandle
{
}


public static class GdkFrameTimingsHandleExtensions
{
	public static bool GetComplete(this GdkFrameTimingsHandle timings)
	{
		return GdkFrameTimingsExterns.gdk_frame_timings_get_complete(timings);
	}

	public static long GetFrameCounter(this GdkFrameTimingsHandle timings)
	{
		return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_counter(timings);
	}

	public static long GetFrameTime(this GdkFrameTimingsHandle timings)
	{
		return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_time(timings);
	}

	public static long GetPredictedPresentationTime(this GdkFrameTimingsHandle timings)
	{
		return GdkFrameTimingsExterns.gdk_frame_timings_get_predicted_presentation_time(timings);
	}

	public static long GetPresentationTime(this GdkFrameTimingsHandle timings)
	{
		return GdkFrameTimingsExterns.gdk_frame_timings_get_presentation_time(timings);
	}

	public static long GetRefreshInterval(this GdkFrameTimingsHandle timings)
	{
		return GdkFrameTimingsExterns.gdk_frame_timings_get_refresh_interval(timings);
	}

	public static GdkFrameTimingsHandle Ref(this GdkFrameTimingsHandle timings)
	{
		return GdkFrameTimingsExterns.gdk_frame_timings_ref(timings);
	}

	public static GdkFrameTimingsHandle Unref(this GdkFrameTimingsHandle timings)
	{
		GdkFrameTimingsExterns.gdk_frame_timings_unref(timings);
		return timings;
	}

}
internal class GdkFrameTimingsExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_frame_timings_get_complete(GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_timings_get_frame_counter(GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_timings_get_frame_time(GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_timings_get_predicted_presentation_time(GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_timings_get_presentation_time(GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_timings_get_refresh_interval(GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFrameTimingsHandle gdk_frame_timings_ref(GdkFrameTimingsHandle timings);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_frame_timings_unref(GdkFrameTimingsHandle timings);

}

public struct GdkFrameTimings
{
}
