namespace MentorLake.Gtk4.Gdk4;

public class GdkFrameClockHandle : GObjectHandle
{
}

public static class GdkFrameClockSignalExtensions
{

	public static IObservable<GdkFrameClockSignalStructs.AfterPaintSignal> Signal_AfterPaint(this GdkFrameClockHandle instance)
	{
		return Observable.Create((IObserver<GdkFrameClockSignalStructs.AfterPaintSignal> obs) =>
		{
			GdkFrameClockSignalDelegates.after_paint handler = (GdkFrameClockHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockSignalStructs.AfterPaintSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "after_paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkFrameClockSignalStructs.BeforePaintSignal> Signal_BeforePaint(this GdkFrameClockHandle instance)
	{
		return Observable.Create((IObserver<GdkFrameClockSignalStructs.BeforePaintSignal> obs) =>
		{
			GdkFrameClockSignalDelegates.before_paint handler = (GdkFrameClockHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockSignalStructs.BeforePaintSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "before_paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkFrameClockSignalStructs.FlushEventsSignal> Signal_FlushEvents(this GdkFrameClockHandle instance)
	{
		return Observable.Create((IObserver<GdkFrameClockSignalStructs.FlushEventsSignal> obs) =>
		{
			GdkFrameClockSignalDelegates.flush_events handler = (GdkFrameClockHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockSignalStructs.FlushEventsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "flush_events", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkFrameClockSignalStructs.LayoutSignal> Signal_Layout(this GdkFrameClockHandle instance)
	{
		return Observable.Create((IObserver<GdkFrameClockSignalStructs.LayoutSignal> obs) =>
		{
			GdkFrameClockSignalDelegates.layout handler = (GdkFrameClockHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockSignalStructs.LayoutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "layout", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkFrameClockSignalStructs.PaintSignal> Signal_Paint(this GdkFrameClockHandle instance)
	{
		return Observable.Create((IObserver<GdkFrameClockSignalStructs.PaintSignal> obs) =>
		{
			GdkFrameClockSignalDelegates.paint handler = (GdkFrameClockHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockSignalStructs.PaintSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkFrameClockSignalStructs.ResumeEventsSignal> Signal_ResumeEvents(this GdkFrameClockHandle instance)
	{
		return Observable.Create((IObserver<GdkFrameClockSignalStructs.ResumeEventsSignal> obs) =>
		{
			GdkFrameClockSignalDelegates.resume_events handler = (GdkFrameClockHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockSignalStructs.ResumeEventsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "resume_events", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkFrameClockSignalStructs.UpdateSignal> Signal_Update(this GdkFrameClockHandle instance)
	{
		return Observable.Create((IObserver<GdkFrameClockSignalStructs.UpdateSignal> obs) =>
		{
			GdkFrameClockSignalDelegates.update handler = (GdkFrameClockHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockSignalStructs.UpdateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkFrameClockSignalStructs
{

public struct AfterPaintSignal
{
	public GdkFrameClockHandle Self;
	public IntPtr UserData;
}

public struct BeforePaintSignal
{
	public GdkFrameClockHandle Self;
	public IntPtr UserData;
}

public struct FlushEventsSignal
{
	public GdkFrameClockHandle Self;
	public IntPtr UserData;
}

public struct LayoutSignal
{
	public GdkFrameClockHandle Self;
	public IntPtr UserData;
}

public struct PaintSignal
{
	public GdkFrameClockHandle Self;
	public IntPtr UserData;
}

public struct ResumeEventsSignal
{
	public GdkFrameClockHandle Self;
	public IntPtr UserData;
}

public struct UpdateSignal
{
	public GdkFrameClockHandle Self;
	public IntPtr UserData;
}
}

public static class GdkFrameClockSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void after_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void before_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void flush_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resume_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkFrameClockHandle>))] GdkFrameClockHandle self, IntPtr user_data);

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
