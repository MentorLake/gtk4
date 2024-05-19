namespace MentorLake.Gtk4.Gdk4;

public class GdkDeviceHandle : GObjectHandle
{
}

public static class GdkDeviceSignalExtensions
{

	public static IObservable<GdkDeviceSignalStructs.ChangedSignal> Signal_Changed(this GdkDeviceHandle instance)
	{
		return Observable.Create((IObserver<GdkDeviceSignalStructs.ChangedSignal> obs) =>
		{
			GdkDeviceSignalDelegates.Changed handler = (GdkDeviceHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDeviceSignalStructs.ToolChangedSignal> Signal_ToolChanged(this GdkDeviceHandle instance)
	{
		return Observable.Create((IObserver<GdkDeviceSignalStructs.ToolChangedSignal> obs) =>
		{
			GdkDeviceSignalDelegates.ToolChanged handler = (GdkDeviceHandle self, GdkDeviceToolHandle tool, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceSignalStructs.ToolChangedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "tool_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkDeviceSignalStructs
{

public struct ChangedSignal
{
	public GdkDeviceHandle Self;
	public IntPtr UserData;
}

public struct ToolChangedSignal
{
	public GdkDeviceHandle Self;
	public GdkDeviceToolHandle Tool;
	public IntPtr UserData;
}
}

public static class GdkDeviceSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToolChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle self, GdkDeviceToolHandle tool, IntPtr user_data);
}


public static class GdkDeviceHandleExtensions
{
	public static bool GetCapsLockState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_caps_lock_state(device);
	}

	public static GdkDeviceToolHandle GetDeviceTool(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_device_tool(device);
	}

	public static PangoDirection GetDirection(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_direction(device);
	}

	public static GdkDisplayHandle GetDisplay(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_display(device);
	}

	public static bool GetHasCursor(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_has_cursor(device);
	}

	public static GdkModifierType GetModifierState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_modifier_state(device);
	}

	public static string GetName(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_name(device);
	}

	public static bool GetNumLockState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_num_lock_state(device);
	}

	public static uint GetNumTouches(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_num_touches(device);
	}

	public static string GetProductId(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_product_id(device);
	}

	public static bool GetScrollLockState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_scroll_lock_state(device);
	}

	public static GdkSeatHandle GetSeat(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_seat(device);
	}

	public static GdkInputSource GetSource(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_source(device);
	}

	public static GdkSurfaceHandle GetSurfaceAtPosition(this GdkDeviceHandle device, out double win_x, out double win_y)
	{
		return GdkDeviceExterns.gdk_device_get_surface_at_position(device, out win_x, out win_y);
	}

	public static uint GetTimestamp(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_timestamp(device);
	}

	public static string GetVendorId(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_vendor_id(device);
	}

	public static bool HasBidiLayouts(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_has_bidi_layouts(device);
	}

}

internal class GdkDeviceExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_caps_lock_state(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceToolHandle gdk_device_get_device_tool(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern PangoDirection gdk_device_get_direction(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_device_get_display(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_has_cursor(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkModifierType gdk_device_get_modifier_state(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_name(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_num_lock_state(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_device_get_num_touches(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_product_id(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_scroll_lock_state(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSeatHandle gdk_device_get_seat(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkInputSource gdk_device_get_source(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_device_get_surface_at_position(GdkDeviceHandle device, out double win_x, out double win_y);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_device_get_timestamp(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_vendor_id(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_has_bidi_layouts(GdkDeviceHandle device);

}
