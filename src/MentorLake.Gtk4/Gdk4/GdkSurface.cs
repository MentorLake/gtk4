namespace MentorLake.Gtk4.Gdk4;

public class GdkSurfaceHandle : GObjectHandle
{
	public static GdkSurfaceHandle NewPopup(GdkSurfaceHandle parent, bool autohide)
	{
		return GdkSurfaceExterns.gdk_surface_new_popup(parent, autohide);
	}

	public static GdkSurfaceHandle NewToplevel(GdkDisplayHandle display)
	{
		return GdkSurfaceExterns.gdk_surface_new_toplevel(display);
	}

}

public static class GdkSurfaceSignalExtensions
{

	public static IObservable<GdkSurfaceSignalStructs.EnterMonitorSignal> Signal_EnterMonitor(this GdkSurfaceHandle instance)
	{
		return Observable.Create((IObserver<GdkSurfaceSignalStructs.EnterMonitorSignal> obs) =>
		{
			GdkSurfaceSignalDelegates.enter_monitor handler = (GdkSurfaceHandle self, GdkMonitorHandle monitor, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSurfaceSignalStructs.EnterMonitorSignal()
				{
					Self = self, Monitor = monitor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "enter_monitor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkSurfaceSignalStructs.EventSignal> Signal_Event(this GdkSurfaceHandle instance)
	{
		return Observable.Create((IObserver<GdkSurfaceSignalStructs.EventSignal> obs) =>
		{
			GdkSurfaceSignalDelegates.@event handler = (GdkSurfaceHandle self, GdkEventHandle @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSurfaceSignalStructs.EventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkSurfaceSignalStructs.LayoutSignal> Signal_Layout(this GdkSurfaceHandle instance)
	{
		return Observable.Create((IObserver<GdkSurfaceSignalStructs.LayoutSignal> obs) =>
		{
			GdkSurfaceSignalDelegates.layout handler = (GdkSurfaceHandle self, int width, int height, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSurfaceSignalStructs.LayoutSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
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

	public static IObservable<GdkSurfaceSignalStructs.LeaveMonitorSignal> Signal_LeaveMonitor(this GdkSurfaceHandle instance)
	{
		return Observable.Create((IObserver<GdkSurfaceSignalStructs.LeaveMonitorSignal> obs) =>
		{
			GdkSurfaceSignalDelegates.leave_monitor handler = (GdkSurfaceHandle self, GdkMonitorHandle monitor, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSurfaceSignalStructs.LeaveMonitorSignal()
				{
					Self = self, Monitor = monitor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "leave_monitor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkSurfaceSignalStructs.RenderSignal> Signal_Render(this GdkSurfaceHandle instance)
	{
		return Observable.Create((IObserver<GdkSurfaceSignalStructs.RenderSignal> obs) =>
		{
			GdkSurfaceSignalDelegates.render handler = (GdkSurfaceHandle self, cairo_region_tHandle region, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSurfaceSignalStructs.RenderSignal()
				{
					Self = self, Region = region, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "render", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkSurfaceSignalStructs
{

public struct EnterMonitorSignal
{
	public GdkSurfaceHandle Self;
	public GdkMonitorHandle Monitor;
	public IntPtr UserData;
}

public struct EventSignal
{
	public GdkSurfaceHandle Self;
	public GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct LayoutSignal
{
	public GdkSurfaceHandle Self;
	public int Width;
	public int Height;
	public IntPtr UserData;
}

public struct LeaveMonitorSignal
{
	public GdkSurfaceHandle Self;
	public GdkMonitorHandle Monitor;
	public IntPtr UserData;
}

public struct RenderSignal
{
	public GdkSurfaceHandle Self;
	public cairo_region_tHandle Region;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GdkSurfaceSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkMonitorHandle>))] GdkMonitorHandle monitor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, int width, int height, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkMonitorHandle>))] GdkMonitorHandle monitor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<cairo_region_tHandle>))] cairo_region_tHandle region, IntPtr user_data);

}


public static class GdkSurfaceHandleExtensions
{
	public static GdkSurfaceHandle Beep(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_beep(surface);
		return surface;
	}

	public static GdkCairoContextHandle CreateCairoContext(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_create_cairo_context(surface);
	}

	public static GdkGLContextHandle CreateGlContext(this GdkSurfaceHandle surface, out GErrorHandle error)
	{
		return GdkSurfaceExterns.gdk_surface_create_gl_context(surface, out error);
	}

	public static cairo_surface_tHandle CreateSimilarSurface(this GdkSurfaceHandle surface, cairo_content_t content, int width, int height)
	{
		return GdkSurfaceExterns.gdk_surface_create_similar_surface(surface, content, width, height);
	}

	public static GdkVulkanContextHandle CreateVulkanContext(this GdkSurfaceHandle surface, out GErrorHandle error)
	{
		return GdkSurfaceExterns.gdk_surface_create_vulkan_context(surface, out error);
	}

	public static GdkSurfaceHandle Destroy(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_destroy(surface);
		return surface;
	}

	public static GdkCursorHandle GetCursor(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_cursor(surface);
	}

	public static GdkCursorHandle GetDeviceCursor(this GdkSurfaceHandle surface, GdkDeviceHandle device)
	{
		return GdkSurfaceExterns.gdk_surface_get_device_cursor(surface, device);
	}

	public static bool GetDevicePosition(this GdkSurfaceHandle surface, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask)
	{
		return GdkSurfaceExterns.gdk_surface_get_device_position(surface, device, out x, out y, out mask);
	}

	public static GdkDisplayHandle GetDisplay(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_display(surface);
	}

	public static GdkFrameClockHandle GetFrameClock(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_frame_clock(surface);
	}

	public static int GetHeight(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_height(surface);
	}

	public static bool GetMapped(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_mapped(surface);
	}

	public static double GetScale(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_scale(surface);
	}

	public static int GetScaleFactor(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_scale_factor(surface);
	}

	public static int GetWidth(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_width(surface);
	}

	public static GdkSurfaceHandle Hide(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_hide(surface);
		return surface;
	}

	public static bool IsDestroyed(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_is_destroyed(surface);
	}

	public static GdkSurfaceHandle QueueRender(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_queue_render(surface);
		return surface;
	}

	public static GdkSurfaceHandle RequestLayout(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_request_layout(surface);
		return surface;
	}

	public static GdkSurfaceHandle SetCursor(this GdkSurfaceHandle surface, GdkCursorHandle cursor)
	{
		GdkSurfaceExterns.gdk_surface_set_cursor(surface, cursor);
		return surface;
	}

	public static GdkSurfaceHandle SetDeviceCursor(this GdkSurfaceHandle surface, GdkDeviceHandle device, GdkCursorHandle cursor)
	{
		GdkSurfaceExterns.gdk_surface_set_device_cursor(surface, device, cursor);
		return surface;
	}

	public static GdkSurfaceHandle SetInputRegion(this GdkSurfaceHandle surface, cairo_region_tHandle region)
	{
		GdkSurfaceExterns.gdk_surface_set_input_region(surface, region);
		return surface;
	}

	public static GdkSurfaceHandle SetOpaqueRegion(this GdkSurfaceHandle surface, cairo_region_tHandle region)
	{
		GdkSurfaceExterns.gdk_surface_set_opaque_region(surface, region);
		return surface;
	}

	public static bool TranslateCoordinates(this GdkSurfaceHandle from, GdkSurfaceHandle to, ref double x, ref double y)
	{
		return GdkSurfaceExterns.gdk_surface_translate_coordinates(from, to, ref x, ref y);
	}

}

internal class GdkSurfaceExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_surface_new_popup(GdkSurfaceHandle parent, bool autohide);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_surface_new_toplevel(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_beep(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCairoContextHandle gdk_surface_create_cairo_context(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLContextHandle gdk_surface_create_gl_context(GdkSurfaceHandle surface, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_surface_tHandle gdk_surface_create_similar_surface(GdkSurfaceHandle surface, cairo_content_t content, int width, int height);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkVulkanContextHandle gdk_surface_create_vulkan_context(GdkSurfaceHandle surface, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_destroy(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCursorHandle gdk_surface_get_cursor(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCursorHandle gdk_surface_get_device_cursor(GdkSurfaceHandle surface, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_get_device_position(GdkSurfaceHandle surface, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_surface_get_display(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFrameClockHandle gdk_surface_get_frame_clock(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_surface_get_height(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_get_mapped(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern double gdk_surface_get_scale(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_surface_get_scale_factor(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_surface_get_width(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_hide(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_is_destroyed(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_queue_render(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_request_layout(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_cursor(GdkSurfaceHandle surface, GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_device_cursor(GdkSurfaceHandle surface, GdkDeviceHandle device, GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_input_region(GdkSurfaceHandle surface, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_opaque_region(GdkSurfaceHandle surface, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_translate_coordinates(GdkSurfaceHandle from, GdkSurfaceHandle to, ref double x, ref double y);

}
