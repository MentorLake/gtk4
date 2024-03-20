using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkFrameTimingsAdaptors
{
    public static GdkFrameTimingsHandle Ref(this GdkFrameTimingsHandle timings)
    {
        return GdkFrameTimingsExterns.gdk_frame_timings_ref(timings);
    }

    public static GdkFrameTimingsHandle Unref(this GdkFrameTimingsHandle timings)
    {
        GdkFrameTimingsExterns.gdk_frame_timings_unref(timings);
        return timings;
    }

    public static nint GetFrameCounter(this GdkFrameTimingsHandle timings)
    {
        return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_counter(timings);
    }

    public static int GetComplete(this GdkFrameTimingsHandle timings)
    {
        return GdkFrameTimingsExterns.gdk_frame_timings_get_complete(timings);
    }

    public static nint GetFrameTime(this GdkFrameTimingsHandle timings)
    {
        return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_time(timings);
    }

    public static nint GetPresentationTime(this GdkFrameTimingsHandle timings)
    {
        return GdkFrameTimingsExterns.gdk_frame_timings_get_presentation_time(timings);
    }

    public static nint GetRefreshInterval(this GdkFrameTimingsHandle timings)
    {
        return GdkFrameTimingsExterns.gdk_frame_timings_get_refresh_interval(timings);
    }

    public static nint GetPredictedPresentationTime(this GdkFrameTimingsHandle timings)
    {
        return GdkFrameTimingsExterns.gdk_frame_timings_get_predicted_presentation_time(timings);
    }
}
