namespace MentorLake.Gtk4.Gdk4;

public class GdkDragHandle : GObjectHandle
{
	public static GdkDragHandle Begin(GdkSurfaceHandle surface, GdkDeviceHandle device, GdkContentProviderHandle content, GdkDragAction actions, double dx, double dy)
	{
		return GdkDragExterns.gdk_drag_begin(surface, device, content, actions, dx, dy);
	}

}

public static class GdkDragSignalExtensions
{

	public static IObservable<GdkDragSignalStructs.CancelSignal> Signal_Cancel(this GdkDragHandle instance)
	{
		return Observable.Create((IObserver<GdkDragSignalStructs.CancelSignal> obs) =>
		{
			GdkDragSignalDelegates.Cancel handler = (GdkDragHandle self, ref GdkDragCancelReason reason, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragSignalStructs.CancelSignal()
				{
					Self = self, Reason = reason, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDragSignalStructs.DndFinishedSignal> Signal_DndFinished(this GdkDragHandle instance)
	{
		return Observable.Create((IObserver<GdkDragSignalStructs.DndFinishedSignal> obs) =>
		{
			GdkDragSignalDelegates.DndFinished handler = (GdkDragHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragSignalStructs.DndFinishedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "dnd_finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDragSignalStructs.DropPerformedSignal> Signal_DropPerformed(this GdkDragHandle instance)
	{
		return Observable.Create((IObserver<GdkDragSignalStructs.DropPerformedSignal> obs) =>
		{
			GdkDragSignalDelegates.DropPerformed handler = (GdkDragHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragSignalStructs.DropPerformedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drop_performed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkDragSignalStructs
{

public struct CancelSignal
{
	public GdkDragHandle Self;
	public GdkDragCancelReason Reason;
	public IntPtr UserData;
}

public struct DndFinishedSignal
{
	public GdkDragHandle Self;
	public IntPtr UserData;
}

public struct DropPerformedSignal
{
	public GdkDragHandle Self;
	public IntPtr UserData;
}
}

public static class GdkDragSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragHandle>))] GdkDragHandle self, ref GdkDragCancelReason reason, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DndFinished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragHandle>))] GdkDragHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DropPerformed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragHandle>))] GdkDragHandle self, IntPtr user_data);
}


public static class GdkDragHandleExtensions
{
	public static GdkDragHandle DropDone(this GdkDragHandle drag, bool success)
	{
		GdkDragExterns.gdk_drag_drop_done(drag, success);
		return drag;
	}

	public static GdkDragAction GetActions(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_actions(drag);
	}

	public static GdkContentProviderHandle GetContent(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_content(drag);
	}

	public static GdkDeviceHandle GetDevice(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_device(drag);
	}

	public static GdkDisplayHandle GetDisplay(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_display(drag);
	}

	public static GdkSurfaceHandle GetDragSurface(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_drag_surface(drag);
	}

	public static GdkContentFormatsHandle GetFormats(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_formats(drag);
	}

	public static GdkDragAction GetSelectedAction(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_selected_action(drag);
	}

	public static GdkSurfaceHandle GetSurface(this GdkDragHandle drag)
	{
		return GdkDragExterns.gdk_drag_get_surface(drag);
	}

	public static GdkDragHandle SetHotspot(this GdkDragHandle drag, int hot_x, int hot_y)
	{
		GdkDragExterns.gdk_drag_set_hotspot(drag, hot_x, hot_y);
		return drag;
	}

}

internal class GdkDragExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_drag_drop_done(GdkDragHandle drag, bool success);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDragAction gdk_drag_get_actions(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentProviderHandle gdk_drag_get_content(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceHandle gdk_drag_get_device(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_drag_get_display(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_drag_get_drag_surface(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_drag_get_formats(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDragAction gdk_drag_get_selected_action(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_drag_get_surface(GdkDragHandle drag);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_drag_set_hotspot(GdkDragHandle drag, int hot_x, int hot_y);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDragHandle gdk_drag_begin(GdkSurfaceHandle surface, GdkDeviceHandle device, GdkContentProviderHandle content, GdkDragAction actions, double dx, double dy);

}
