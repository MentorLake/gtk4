namespace MentorLake.Gtk4.Gtk4;

public class GtkAssistantHandle : GtkWindowHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkAssistantHandle New()
	{
		return GtkAssistantExterns.gtk_assistant_new();
	}

}

public static class GtkAssistantSignalExtensions
{

	public static IObservable<GtkAssistantSignalStructs.ApplySignal> Signal_Apply(this GtkAssistantHandle instance)
	{
		return Observable.Create((IObserver<GtkAssistantSignalStructs.ApplySignal> obs) =>
		{
			GtkAssistantSignalDelegates.apply handler = (GtkAssistantHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantSignalStructs.ApplySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkAssistantSignalStructs.CancelSignal> Signal_Cancel(this GtkAssistantHandle instance)
	{
		return Observable.Create((IObserver<GtkAssistantSignalStructs.CancelSignal> obs) =>
		{
			GtkAssistantSignalDelegates.cancel handler = (GtkAssistantHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantSignalStructs.CancelSignal()
				{
					Self = self, UserData = user_data
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

	public static IObservable<GtkAssistantSignalStructs.CloseSignal> Signal_Close(this GtkAssistantHandle instance)
	{
		return Observable.Create((IObserver<GtkAssistantSignalStructs.CloseSignal> obs) =>
		{
			GtkAssistantSignalDelegates.close handler = (GtkAssistantHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkAssistantSignalStructs.EscapeSignal> Signal_Escape(this GtkAssistantHandle instance)
	{
		return Observable.Create((IObserver<GtkAssistantSignalStructs.EscapeSignal> obs) =>
		{
			GtkAssistantSignalDelegates.escape handler = (GtkAssistantHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantSignalStructs.EscapeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "escape", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkAssistantSignalStructs.PrepareSignal> Signal_Prepare(this GtkAssistantHandle instance)
	{
		return Observable.Create((IObserver<GtkAssistantSignalStructs.PrepareSignal> obs) =>
		{
			GtkAssistantSignalDelegates.prepare handler = (GtkAssistantHandle self, GtkWidgetHandle page, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantSignalStructs.PrepareSignal()
				{
					Self = self, Page = page, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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

public static class GtkAssistantSignalStructs
{

public struct ApplySignal
{
	public GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct CancelSignal
{
	public GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct CloseSignal
{
	public GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct EscapeSignal
{
	public GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct PrepareSignal
{
	public GtkAssistantHandle Self;
	public GtkWidgetHandle Page;
	public IntPtr UserData;
}
}

public static class GtkAssistantSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAssistantHandle>))] GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAssistantHandle>))] GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAssistantHandle>))] GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void escape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAssistantHandle>))] GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prepare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAssistantHandle>))] GtkAssistantHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle page, IntPtr user_data);

}


public static class GtkAssistantHandleExtensions
{
	public static GtkAssistantHandle AddActionWidget(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		GtkAssistantExterns.gtk_assistant_add_action_widget(assistant, child);
		return assistant;
	}

	public static int AppendPage(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_append_page(assistant, page);
	}

	public static GtkAssistantHandle Commit(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_commit(assistant);
		return assistant;
	}

	public static int GetCurrentPage(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_current_page(assistant);
	}

	public static int GetNPages(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_n_pages(assistant);
	}

	public static GtkWidgetHandle GetNthPage(this GtkAssistantHandle assistant, int page_num)
	{
		return GtkAssistantExterns.gtk_assistant_get_nth_page(assistant, page_num);
	}

	public static GtkAssistantPageHandle GetPage(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		return GtkAssistantExterns.gtk_assistant_get_page(assistant, child);
	}

	public static bool GetPageComplete(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_complete(assistant, page);
	}

	public static string GetPageTitle(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_title(assistant, page);
	}

	public static GtkAssistantPageType GetPageType(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_get_page_type(assistant, page);
	}

	public static GListModelHandle GetPages(this GtkAssistantHandle assistant)
	{
		return GtkAssistantExterns.gtk_assistant_get_pages(assistant);
	}

	public static int InsertPage(this GtkAssistantHandle assistant, GtkWidgetHandle page, int position)
	{
		return GtkAssistantExterns.gtk_assistant_insert_page(assistant, page, position);
	}

	public static GtkAssistantHandle NextPage(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_next_page(assistant);
		return assistant;
	}

	public static int PrependPage(this GtkAssistantHandle assistant, GtkWidgetHandle page)
	{
		return GtkAssistantExterns.gtk_assistant_prepend_page(assistant, page);
	}

	public static GtkAssistantHandle PreviousPage(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_previous_page(assistant);
		return assistant;
	}

	public static GtkAssistantHandle RemoveActionWidget(this GtkAssistantHandle assistant, GtkWidgetHandle child)
	{
		GtkAssistantExterns.gtk_assistant_remove_action_widget(assistant, child);
		return assistant;
	}

	public static GtkAssistantHandle RemovePage(this GtkAssistantHandle assistant, int page_num)
	{
		GtkAssistantExterns.gtk_assistant_remove_page(assistant, page_num);
		return assistant;
	}

	public static GtkAssistantHandle SetCurrentPage(this GtkAssistantHandle assistant, int page_num)
	{
		GtkAssistantExterns.gtk_assistant_set_current_page(assistant, page_num);
		return assistant;
	}

	public static GtkAssistantHandle SetForwardPageFunc(this GtkAssistantHandle assistant, GtkAssistantPageFunc page_func, IntPtr data, GDestroyNotify destroy)
	{
		GtkAssistantExterns.gtk_assistant_set_forward_page_func(assistant, page_func, data, destroy);
		return assistant;
	}

	public static GtkAssistantHandle SetPageComplete(this GtkAssistantHandle assistant, GtkWidgetHandle page, bool complete)
	{
		GtkAssistantExterns.gtk_assistant_set_page_complete(assistant, page, complete);
		return assistant;
	}

	public static GtkAssistantHandle SetPageTitle(this GtkAssistantHandle assistant, GtkWidgetHandle page, string title)
	{
		GtkAssistantExterns.gtk_assistant_set_page_title(assistant, page, title);
		return assistant;
	}

	public static GtkAssistantHandle SetPageType(this GtkAssistantHandle assistant, GtkWidgetHandle page, GtkAssistantPageType type)
	{
		GtkAssistantExterns.gtk_assistant_set_page_type(assistant, page, type);
		return assistant;
	}

	public static GtkAssistantHandle UpdateButtonsState(this GtkAssistantHandle assistant)
	{
		GtkAssistantExterns.gtk_assistant_update_buttons_state(assistant);
		return assistant;
	}

}

internal class GtkAssistantExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAssistantHandle gtk_assistant_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_add_action_widget(GtkAssistantHandle assistant, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_append_page(GtkAssistantHandle assistant, GtkWidgetHandle page);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_commit(GtkAssistantHandle assistant);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_get_current_page(GtkAssistantHandle assistant);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_get_n_pages(GtkAssistantHandle assistant);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_assistant_get_nth_page(GtkAssistantHandle assistant, int page_num);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAssistantPageHandle gtk_assistant_get_page(GtkAssistantHandle assistant, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_assistant_get_page_complete(GtkAssistantHandle assistant, GtkWidgetHandle page);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_assistant_get_page_title(GtkAssistantHandle assistant, GtkWidgetHandle page);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAssistantPageType gtk_assistant_get_page_type(GtkAssistantHandle assistant, GtkWidgetHandle page);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_assistant_get_pages(GtkAssistantHandle assistant);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_insert_page(GtkAssistantHandle assistant, GtkWidgetHandle page, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_next_page(GtkAssistantHandle assistant);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_assistant_prepend_page(GtkAssistantHandle assistant, GtkWidgetHandle page);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_previous_page(GtkAssistantHandle assistant);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_remove_action_widget(GtkAssistantHandle assistant, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_remove_page(GtkAssistantHandle assistant, int page_num);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_current_page(GtkAssistantHandle assistant, int page_num);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_forward_page_func(GtkAssistantHandle assistant, GtkAssistantPageFunc page_func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_page_complete(GtkAssistantHandle assistant, GtkWidgetHandle page, bool complete);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_page_title(GtkAssistantHandle assistant, GtkWidgetHandle page, string title);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_set_page_type(GtkAssistantHandle assistant, GtkWidgetHandle page, GtkAssistantPageType type);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_assistant_update_buttons_state(GtkAssistantHandle assistant);

}
