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

namespace MentorLake.Gtk4.Gdk4;

public class GdkFrameClockHandle : GObjectHandle
{
}

public class GdkFrameClockSignal
{
	public string Value { get; set; }
	public GdkFrameClockSignal(string value) => Value = value;
}

public static class GdkFrameClockSignals
{
	public static GdkFrameClockSignal AfterPaint = new("after-paint");
	public static GdkFrameClockSignal BeforePaint = new("before-paint");
	public static GdkFrameClockSignal FlushEvents = new("flush-events");
	public static GdkFrameClockSignal Layout = new("layout");
	public static GdkFrameClockSignal Paint = new("paint");
	public static GdkFrameClockSignal ResumeEvents = new("resume-events");
	public static GdkFrameClockSignal Update = new("update");
}

public static class GdkFrameClockHandleExtensions
{
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

	public static GdkFrameTimingsHandle GetCurrentTimings(this GdkFrameClockHandle frame_clock)
	{
		return GdkFrameClockExterns.gdk_frame_clock_get_current_timings(frame_clock);
	}

	public static double GetFps(this GdkFrameClockHandle frame_clock)
	{
		return GdkFrameClockExterns.gdk_frame_clock_get_fps(frame_clock);
	}

	public static long GetFrameCounter(this GdkFrameClockHandle frame_clock)
	{
		return GdkFrameClockExterns.gdk_frame_clock_get_frame_counter(frame_clock);
	}

	public static long GetFrameTime(this GdkFrameClockHandle frame_clock)
	{
		return GdkFrameClockExterns.gdk_frame_clock_get_frame_time(frame_clock);
	}

	public static long GetHistoryStart(this GdkFrameClockHandle frame_clock)
	{
		return GdkFrameClockExterns.gdk_frame_clock_get_history_start(frame_clock);
	}

	public static GdkFrameClockHandle GetRefreshInfo(this GdkFrameClockHandle frame_clock, long base_time, out long refresh_interval_return, out long presentation_time_return)
	{
		GdkFrameClockExterns.gdk_frame_clock_get_refresh_info(frame_clock, base_time, out refresh_interval_return, out presentation_time_return);
		return frame_clock;
	}

	public static GdkFrameTimingsHandle GetTimings(this GdkFrameClockHandle frame_clock, long frame_counter)
	{
		return GdkFrameClockExterns.gdk_frame_clock_get_timings(frame_clock, frame_counter);
	}

	public static GdkFrameClockHandle RequestPhase(this GdkFrameClockHandle frame_clock, GdkFrameClockPhase phase)
	{
		GdkFrameClockExterns.gdk_frame_clock_request_phase(frame_clock, phase);
		return frame_clock;
	}

	public static GdkFrameClockHandle Connect(this GdkFrameClockHandle instance, GdkFrameClockSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GdkFrameClockExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_frame_clock_begin_updating(GdkFrameClockHandle frame_clock);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_frame_clock_end_updating(GdkFrameClockHandle frame_clock);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFrameTimingsHandle gdk_frame_clock_get_current_timings(GdkFrameClockHandle frame_clock);
	[DllImport(Libraries.Gdk4)]
	internal static extern double gdk_frame_clock_get_fps(GdkFrameClockHandle frame_clock);
	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_clock_get_frame_counter(GdkFrameClockHandle frame_clock);
	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_clock_get_frame_time(GdkFrameClockHandle frame_clock);
	[DllImport(Libraries.Gdk4)]
	internal static extern long gdk_frame_clock_get_history_start(GdkFrameClockHandle frame_clock);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_frame_clock_get_refresh_info(GdkFrameClockHandle frame_clock, long base_time, out long refresh_interval_return, out long presentation_time_return);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFrameTimingsHandle gdk_frame_clock_get_timings(GdkFrameClockHandle frame_clock, long frame_counter);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_frame_clock_request_phase(GdkFrameClockHandle frame_clock, GdkFrameClockPhase phase);
}
