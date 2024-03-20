using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkFrameClockAdaptors
{
    public static nint GetFrameTime(this GdkFrameClockHandle frame_clock)
    {
        return GdkFrameClockExterns.gdk_frame_clock_get_frame_time(frame_clock);
    }

    public static GdkFrameClockHandle RequestPhase(this GdkFrameClockHandle frame_clock, GdkFrameClockPhase phase)
    {
        GdkFrameClockExterns.gdk_frame_clock_request_phase(frame_clock, phase);
        return frame_clock;
    }

    public static GdkFrameClockHandle BeginUpdating(this GdkFrameClockHandle frame_clock)
    {
        GdkFrameClockExterns.gdk_frame_clock_begin_updating(frame_clock);
        return frame_clock;
    }

    public static GdkFrameClockHandle EndUpdating(this GdkFrameClockHandle frame_clock)
    {
        GdkFrameClockExterns.gdk_frame_clock_end_updating(frame_clock);
        return frame_clock;
    }

    public static nint GetFrameCounter(this GdkFrameClockHandle frame_clock)
    {
        return GdkFrameClockExterns.gdk_frame_clock_get_frame_counter(frame_clock);
    }

    public static nint GetHistoryStart(this GdkFrameClockHandle frame_clock)
    {
        return GdkFrameClockExterns.gdk_frame_clock_get_history_start(frame_clock);
    }

    public static GdkFrameTimingsHandle GetTimings(this GdkFrameClockHandle frame_clock, nint frame_counter)
    {
        return GdkFrameClockExterns.gdk_frame_clock_get_timings(frame_clock, frame_counter);
    }

    public static GdkFrameTimingsHandle GetCurrentTimings(this GdkFrameClockHandle frame_clock)
    {
        return GdkFrameClockExterns.gdk_frame_clock_get_current_timings(frame_clock);
    }

    public static GdkFrameClockHandle GetRefreshInfo(this GdkFrameClockHandle frame_clock, nint base_time, out nint refresh_interval_return, out nint presentation_time_return)
    {
        GdkFrameClockExterns.gdk_frame_clock_get_refresh_info(frame_clock, base_time, out refresh_interval_return, out presentation_time_return);
        return frame_clock;
    }

    public static double GetFps(this GdkFrameClockHandle frame_clock)
    {
        return GdkFrameClockExterns.gdk_frame_clock_get_fps(frame_clock);
    }
}
