namespace MentorLake.Gtk4.Gtk4;

public class GtkDragSourceHandle : GtkGestureSingleHandle
{
	public static GtkDragSourceHandle New()
	{
		return GtkDragSourceExterns.gtk_drag_source_new();
	}

}

public static class GtkDragSourceSignalExtensions
{

	public static IObservable<GtkDragSourceSignalStructs.DragBeginSignal> Signal_DragBegin(this GtkDragSourceHandle instance)
	{
		return Observable.Create((IObserver<GtkDragSourceSignalStructs.DragBeginSignal> obs) =>
		{
			GtkDragSourceSignalDelegates.DragBegin handler = (GtkDragSourceHandle self, GdkDragHandle drag, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDragSourceSignalStructs.DragBeginSignal()
				{
					Self = self, Drag = drag, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDragSourceSignalStructs.DragCancelSignal> Signal_DragCancel(this GtkDragSourceHandle instance)
	{
		return Observable.Create((IObserver<GtkDragSourceSignalStructs.DragCancelSignal> obs) =>
		{
			GtkDragSourceSignalDelegates.DragCancel handler = (GtkDragSourceHandle self, GdkDragHandle drag, ref GdkDragCancelReason reason, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDragSourceSignalStructs.DragCancelSignal()
				{
					Self = self, Drag = drag, Reason = reason, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDragSourceSignalStructs.DragEndSignal> Signal_DragEnd(this GtkDragSourceHandle instance)
	{
		return Observable.Create((IObserver<GtkDragSourceSignalStructs.DragEndSignal> obs) =>
		{
			GtkDragSourceSignalDelegates.DragEnd handler = (GtkDragSourceHandle self, GdkDragHandle drag, bool delete_data, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDragSourceSignalStructs.DragEndSignal()
				{
					Self = self, Drag = drag, DeleteData = delete_data, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkDragSourceSignalStructs.PrepareSignal> Signal_Prepare(this GtkDragSourceHandle instance)
	{
		return Observable.Create((IObserver<GtkDragSourceSignalStructs.PrepareSignal> obs) =>
		{
			GtkDragSourceSignalDelegates.Prepare handler = (GtkDragSourceHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDragSourceSignalStructs.PrepareSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "prepare", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkDragSourceSignalStructs
{

public struct DragBeginSignal
{
	public GtkDragSourceHandle Self;
	public GdkDragHandle Drag;
	public IntPtr UserData;
}

public struct DragCancelSignal
{
	public GtkDragSourceHandle Self;
	public GdkDragHandle Drag;
	public GdkDragCancelReason Reason;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DragEndSignal
{
	public GtkDragSourceHandle Self;
	public GdkDragHandle Drag;
	public bool DeleteData;
	public IntPtr UserData;
}

public struct PrepareSignal
{
	public GtkDragSourceHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
	public GdkContentProviderHandle ReturnValue;
}
}

public static class GtkDragSourceSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragBegin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDragSourceHandle>))] GtkDragSourceHandle self, GdkDragHandle drag, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool DragCancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDragSourceHandle>))] GtkDragSourceHandle self, GdkDragHandle drag, ref GdkDragCancelReason reason, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragEnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDragSourceHandle>))] GtkDragSourceHandle self, GdkDragHandle drag, bool delete_data, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GdkContentProviderHandle Prepare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDragSourceHandle>))] GtkDragSourceHandle self, double x, double y, IntPtr user_data);
}


public static class GtkDragSourceHandleExtensions
{
	public static GtkDragSourceHandle DragCancel(this GtkDragSourceHandle source)
	{
		GtkDragSourceExterns.gtk_drag_source_drag_cancel(source);
		return source;
	}

	public static GdkDragAction GetActions(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_actions(source);
	}

	public static GdkContentProviderHandle GetContent(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_content(source);
	}

	public static GdkDragHandle GetDrag(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_drag(source);
	}

	public static GtkDragSourceHandle SetActions(this GtkDragSourceHandle source, GdkDragAction actions)
	{
		GtkDragSourceExterns.gtk_drag_source_set_actions(source, actions);
		return source;
	}

	public static GtkDragSourceHandle SetContent(this GtkDragSourceHandle source, GdkContentProviderHandle content)
	{
		GtkDragSourceExterns.gtk_drag_source_set_content(source, content);
		return source;
	}

	public static GtkDragSourceHandle SetIcon(this GtkDragSourceHandle source, GdkPaintableHandle paintable, int hot_x, int hot_y)
	{
		GtkDragSourceExterns.gtk_drag_source_set_icon(source, paintable, hot_x, hot_y);
		return source;
	}

}

internal class GtkDragSourceExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDragSourceHandle gtk_drag_source_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_drag_cancel(GtkDragSourceHandle source);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragAction gtk_drag_source_get_actions(GtkDragSourceHandle source);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentProviderHandle gtk_drag_source_get_content(GtkDragSourceHandle source);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragHandle gtk_drag_source_get_drag(GtkDragSourceHandle source);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_set_actions(GtkDragSourceHandle source, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_set_content(GtkDragSourceHandle source, GdkContentProviderHandle content);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_set_icon(GtkDragSourceHandle source, GdkPaintableHandle paintable, int hot_x, int hot_y);

}
