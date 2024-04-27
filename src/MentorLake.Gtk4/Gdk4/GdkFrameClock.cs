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

public static class GdkFrameClockSignalExtensions
{
	public static GdkFrameClockHandle Signal_AfterPaint(this GdkFrameClockHandle instance, GdkFrameClockSignalDelegates.AfterPaint handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "after_paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkFrameClockHandle Signal_BeforePaint(this GdkFrameClockHandle instance, GdkFrameClockSignalDelegates.BeforePaint handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "before_paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkFrameClockHandle Signal_FlushEvents(this GdkFrameClockHandle instance, GdkFrameClockSignalDelegates.FlushEvents handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "flush_events", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkFrameClockHandle Signal_Layout(this GdkFrameClockHandle instance, GdkFrameClockSignalDelegates.Layout handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "layout", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkFrameClockHandle Signal_Paint(this GdkFrameClockHandle instance, GdkFrameClockSignalDelegates.Paint handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkFrameClockHandle Signal_ResumeEvents(this GdkFrameClockHandle instance, GdkFrameClockSignalDelegates.ResumeEvents handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "resume_events", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkFrameClockHandle Signal_Update(this GdkFrameClockHandle instance, GdkFrameClockSignalDelegates.Update handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GdkFrameClockSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AfterPaint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void BeforePaint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void FlushEvents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ResumeEvents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);
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
