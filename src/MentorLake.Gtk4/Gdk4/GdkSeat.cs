namespace MentorLake.Gtk4.Gdk4;

public class GdkSeatHandle : GObjectHandle
{
}

public static class GdkSeatSignalExtensions
{

	public static IObservable<GdkSeatSignalStructs.DeviceAddedSignal> Signal_DeviceAdded(this GdkSeatHandle instance)
	{
		return Observable.Create((IObserver<GdkSeatSignalStructs.DeviceAddedSignal> obs) =>
		{
			GdkSeatSignalDelegates.device_added handler = (GdkSeatHandle self, GdkDeviceHandle device, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatSignalStructs.DeviceAddedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "device_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkSeatSignalStructs.DeviceRemovedSignal> Signal_DeviceRemoved(this GdkSeatHandle instance)
	{
		return Observable.Create((IObserver<GdkSeatSignalStructs.DeviceRemovedSignal> obs) =>
		{
			GdkSeatSignalDelegates.device_removed handler = (GdkSeatHandle self, GdkDeviceHandle device, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatSignalStructs.DeviceRemovedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "device_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkSeatSignalStructs.ToolAddedSignal> Signal_ToolAdded(this GdkSeatHandle instance)
	{
		return Observable.Create((IObserver<GdkSeatSignalStructs.ToolAddedSignal> obs) =>
		{
			GdkSeatSignalDelegates.tool_added handler = (GdkSeatHandle self, GdkDeviceToolHandle tool, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatSignalStructs.ToolAddedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "tool_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkSeatSignalStructs.ToolRemovedSignal> Signal_ToolRemoved(this GdkSeatHandle instance)
	{
		return Observable.Create((IObserver<GdkSeatSignalStructs.ToolRemovedSignal> obs) =>
		{
			GdkSeatSignalDelegates.tool_removed handler = (GdkSeatHandle self, GdkDeviceToolHandle tool, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatSignalStructs.ToolRemovedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "tool_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkSeatSignalStructs
{

public struct DeviceAddedSignal
{
	public GdkSeatHandle Self;
	public GdkDeviceHandle Device;
	public IntPtr UserData;
}

public struct DeviceRemovedSignal
{
	public GdkSeatHandle Self;
	public GdkDeviceHandle Device;
	public IntPtr UserData;
}

public struct ToolAddedSignal
{
	public GdkSeatHandle Self;
	public GdkDeviceToolHandle Tool;
	public IntPtr UserData;
}

public struct ToolRemovedSignal
{
	public GdkSeatHandle Self;
	public GdkDeviceToolHandle Tool;
	public IntPtr UserData;
}
}

public static class GdkSeatSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceToolHandle>))] GdkDeviceToolHandle tool, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceToolHandle>))] GdkDeviceToolHandle tool, IntPtr user_data);

}


public static class GdkSeatHandleExtensions
{
	public static GdkSeatCapabilities GetCapabilities(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_capabilities(seat);
	}

	public static GListHandle GetDevices(this GdkSeatHandle seat, GdkSeatCapabilities capabilities)
	{
		return GdkSeatExterns.gdk_seat_get_devices(seat, capabilities);
	}

	public static GdkDisplayHandle GetDisplay(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_display(seat);
	}

	public static GdkDeviceHandle GetKeyboard(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_keyboard(seat);
	}

	public static GdkDeviceHandle GetPointer(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_pointer(seat);
	}

	public static GListHandle GetTools(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_tools(seat);
	}

}

internal class GdkSeatExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSeatCapabilities gdk_seat_get_capabilities(GdkSeatHandle seat);

	[DllImport(Libraries.Gdk4)]
	internal static extern GListHandle gdk_seat_get_devices(GdkSeatHandle seat, GdkSeatCapabilities capabilities);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_seat_get_display(GdkSeatHandle seat);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceHandle gdk_seat_get_keyboard(GdkSeatHandle seat);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceHandle gdk_seat_get_pointer(GdkSeatHandle seat);

	[DllImport(Libraries.Gdk4)]
	internal static extern GListHandle gdk_seat_get_tools(GdkSeatHandle seat);

}
