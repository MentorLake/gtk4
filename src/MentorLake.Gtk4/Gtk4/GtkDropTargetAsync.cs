namespace MentorLake.Gtk4.Gtk4;

public class GtkDropTargetAsyncHandle : GtkEventControllerHandle
{
	public static GtkDropTargetAsyncHandle New(GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_new(formats, actions);
	}

}

public static class GtkDropTargetAsyncSignalExtensions
{

	public static IObservable<GtkDropTargetAsyncSignalStructs.AcceptSignal> Signal_Accept(this GtkDropTargetAsyncHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetAsyncSignalStructs.AcceptSignal> obs) =>
		{
			GtkDropTargetAsyncSignalDelegates.accept handler = (GtkDropTargetAsyncHandle self, GdkDropHandle drop, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetAsyncSignalStructs.AcceptSignal()
				{
					Self = self, Drop = drop, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accept", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetAsyncSignalStructs.DragEnterSignal> Signal_DragEnter(this GtkDropTargetAsyncHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetAsyncSignalStructs.DragEnterSignal> obs) =>
		{
			GtkDropTargetAsyncSignalDelegates.drag_enter handler = (GtkDropTargetAsyncHandle self, GdkDropHandle drop, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetAsyncSignalStructs.DragEnterSignal()
				{
					Self = self, Drop = drop, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetAsyncSignalStructs.DragLeaveSignal> Signal_DragLeave(this GtkDropTargetAsyncHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetAsyncSignalStructs.DragLeaveSignal> obs) =>
		{
			GtkDropTargetAsyncSignalDelegates.drag_leave handler = (GtkDropTargetAsyncHandle self, GdkDropHandle drop, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetAsyncSignalStructs.DragLeaveSignal()
				{
					Self = self, Drop = drop, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetAsyncSignalStructs.DragMotionSignal> Signal_DragMotion(this GtkDropTargetAsyncHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetAsyncSignalStructs.DragMotionSignal> obs) =>
		{
			GtkDropTargetAsyncSignalDelegates.drag_motion handler = (GtkDropTargetAsyncHandle self, GdkDropHandle drop, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetAsyncSignalStructs.DragMotionSignal()
				{
					Self = self, Drop = drop, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDropTargetAsyncSignalStructs.DropSignal> Signal_Drop(this GtkDropTargetAsyncHandle instance)
	{
		return Observable.Create((IObserver<GtkDropTargetAsyncSignalStructs.DropSignal> obs) =>
		{
			GtkDropTargetAsyncSignalDelegates.drop handler = (GtkDropTargetAsyncHandle self, GdkDropHandle drop, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDropTargetAsyncSignalStructs.DropSignal()
				{
					Self = self, Drop = drop, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkDropTargetAsyncSignalStructs
{

public struct AcceptSignal
{
	public GtkDropTargetAsyncHandle Self;
	public GdkDropHandle Drop;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DragEnterSignal
{
	public GtkDropTargetAsyncHandle Self;
	public GdkDropHandle Drop;
	public double X;
	public double Y;
	public IntPtr UserData;
	public GdkDragAction ReturnValue;
}

public struct DragLeaveSignal
{
	public GtkDropTargetAsyncHandle Self;
	public GdkDropHandle Drop;
	public IntPtr UserData;
}

public struct DragMotionSignal
{
	public GtkDropTargetAsyncHandle Self;
	public GdkDropHandle Drop;
	public double X;
	public double Y;
	public IntPtr UserData;
	public GdkDragAction ReturnValue;
}

public struct DropSignal
{
	public GtkDropTargetAsyncHandle Self;
	public GdkDropHandle Drop;
	public double X;
	public double Y;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkDropTargetAsyncSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accept([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDropHandle>))] GdkDropHandle drop, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GdkDragAction drag_enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDropHandle>))] GdkDropHandle drop, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDropHandle>))] GdkDropHandle drop, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GdkDragAction drag_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDropHandle>))] GdkDropHandle drop, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDropHandle>))] GdkDropHandle drop, double x, double y, IntPtr user_data);

}


public static class GtkDropTargetAsyncHandleExtensions
{
	public static GdkDragAction GetActions(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_actions(self);
	}

	public static GdkContentFormatsHandle GetFormats(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_formats(self);
	}

	public static GtkDropTargetAsyncHandle RejectDrop(this GtkDropTargetAsyncHandle self, GdkDropHandle drop)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_reject_drop(self, drop);
		return self;
	}

	public static GtkDropTargetAsyncHandle SetActions(this GtkDropTargetAsyncHandle self, GdkDragAction actions)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_actions(self, actions);
		return self;
	}

	public static GtkDropTargetAsyncHandle SetFormats(this GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_formats(self, formats);
		return self;
	}

}

internal class GtkDropTargetAsyncExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropTargetAsyncHandle gtk_drop_target_async_new(GdkContentFormatsHandle formats, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragAction gtk_drop_target_async_get_actions(GtkDropTargetAsyncHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentFormatsHandle gtk_drop_target_async_get_formats(GtkDropTargetAsyncHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_reject_drop(GtkDropTargetAsyncHandle self, GdkDropHandle drop);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_set_actions(GtkDropTargetAsyncHandle self, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_set_formats(GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats);

}
