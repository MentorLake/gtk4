namespace MentorLake.Gtk4.Gtk4;

public class GtkPanedHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkPanedHandle New(GtkOrientation orientation)
	{
		return GtkPanedExterns.gtk_paned_new(orientation);
	}

}

public static class GtkPanedSignalExtensions
{

	public static IObservable<GtkPanedSignalStructs.AcceptPositionSignal> Signal_AcceptPosition(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.AcceptPositionSignal> obs) =>
		{
			GtkPanedSignalDelegates.accept_position handler = (GtkPanedHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.AcceptPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accept_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.CancelPositionSignal> Signal_CancelPosition(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.CancelPositionSignal> obs) =>
		{
			GtkPanedSignalDelegates.cancel_position handler = (GtkPanedHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.CancelPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancel_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.CycleChildFocusSignal> Signal_CycleChildFocus(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.CycleChildFocusSignal> obs) =>
		{
			GtkPanedSignalDelegates.cycle_child_focus handler = (GtkPanedHandle self, bool reversed, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.CycleChildFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cycle_child_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.CycleHandleFocusSignal> Signal_CycleHandleFocus(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.CycleHandleFocusSignal> obs) =>
		{
			GtkPanedSignalDelegates.cycle_handle_focus handler = (GtkPanedHandle self, bool reversed, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.CycleHandleFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cycle_handle_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.MoveHandleSignal> Signal_MoveHandle(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.MoveHandleSignal> obs) =>
		{
			GtkPanedSignalDelegates.move_handle handler = (GtkPanedHandle self, ref GtkScrollType scroll_type, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.MoveHandleSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_handle", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.ToggleHandleFocusSignal> Signal_ToggleHandleFocus(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.ToggleHandleFocusSignal> obs) =>
		{
			GtkPanedSignalDelegates.toggle_handle_focus handler = (GtkPanedHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.ToggleHandleFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_handle_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPanedSignalStructs
{

public struct AcceptPositionSignal
{
	public GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CancelPositionSignal
{
	public GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CycleChildFocusSignal
{
	public GtkPanedHandle Self;
	public bool Reversed;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CycleHandleFocusSignal
{
	public GtkPanedHandle Self;
	public bool Reversed;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveHandleSignal
{
	public GtkPanedHandle Self;
	public GtkScrollType ScrollType;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ToggleHandleFocusSignal
{
	public GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkPanedSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accept_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cancel_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_child_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, bool reversed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, bool reversed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, ref GtkScrollType scroll_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool toggle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);

}


public static class GtkPanedHandleExtensions
{
	public static GtkWidgetHandle GetEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_end_child(paned);
	}

	public static int GetPosition(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_position(paned);
	}

	public static bool GetResizeEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_end_child(paned);
	}

	public static bool GetResizeStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_start_child(paned);
	}

	public static bool GetShrinkEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_end_child(paned);
	}

	public static bool GetShrinkStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_start_child(paned);
	}

	public static GtkWidgetHandle GetStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_start_child(paned);
	}

	public static bool GetWideHandle(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_wide_handle(paned);
	}

	public static GtkPanedHandle SetEndChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_end_child(paned, child);
		return paned;
	}

	public static GtkPanedHandle SetPosition(this GtkPanedHandle paned, int position)
	{
		GtkPanedExterns.gtk_paned_set_position(paned, position);
		return paned;
	}

	public static GtkPanedHandle SetResizeEndChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_end_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetResizeStartChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_start_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetShrinkEndChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_end_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetShrinkStartChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_start_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetStartChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_start_child(paned, child);
		return paned;
	}

	public static GtkPanedHandle SetWideHandle(this GtkPanedHandle paned, bool wide)
	{
		GtkPanedExterns.gtk_paned_set_wide_handle(paned, wide);
		return paned;
	}

}

internal class GtkPanedExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPanedHandle gtk_paned_new(GtkOrientation orientation);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_paned_get_end_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_paned_get_position(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_resize_end_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_resize_start_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_shrink_end_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_shrink_start_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_paned_get_start_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_wide_handle(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_end_child(GtkPanedHandle paned, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_position(GtkPanedHandle paned, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_resize_end_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_resize_start_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_shrink_end_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_shrink_start_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_start_child(GtkPanedHandle paned, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_wide_handle(GtkPanedHandle paned, bool wide);

}
