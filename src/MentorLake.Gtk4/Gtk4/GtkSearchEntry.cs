namespace MentorLake.Gtk4.Gtk4;

public class GtkSearchEntryHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkEditableHandle
{
	public static GtkSearchEntryHandle New()
	{
		return GtkSearchEntryExterns.gtk_search_entry_new();
	}

}

public static class GtkSearchEntrySignalExtensions
{

	public static IObservable<GtkSearchEntrySignalStructs.ActivateSignal> Signal_Activate(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.ActivateSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.activate handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.NextMatchSignal> Signal_NextMatch(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.NextMatchSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.next_match handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.NextMatchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "next_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.PreviousMatchSignal> Signal_PreviousMatch(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.PreviousMatchSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.previous_match handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.PreviousMatchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "previous_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.SearchChangedSignal> Signal_SearchChanged(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.SearchChangedSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.search_changed handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.SearchChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "search_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.SearchStartedSignal> Signal_SearchStarted(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.SearchStartedSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.search_started handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.SearchStartedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "search_started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.StopSearchSignal> Signal_StopSearch(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.StopSearchSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.stop_search handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.StopSearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "stop_search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkSearchEntrySignalStructs
{

public struct ActivateSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct NextMatchSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct PreviousMatchSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct SearchChangedSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct SearchStartedSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct StopSearchSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}
}

public static class GtkSearchEntrySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void previous_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stop_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);

}


public static class GtkSearchEntryHandleExtensions
{
	public static GtkInputHints GetInputHints(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_input_hints(entry);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_input_purpose(entry);
	}

	public static GtkWidgetHandle GetKeyCaptureWidget(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_key_capture_widget(entry);
	}

	public static string GetPlaceholderText(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_placeholder_text(entry);
	}

	public static uint GetSearchDelay(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_search_delay(entry);
	}

	public static GtkSearchEntryHandle SetInputHints(this GtkSearchEntryHandle entry, GtkInputHints hints)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_input_hints(entry, hints);
		return entry;
	}

	public static GtkSearchEntryHandle SetInputPurpose(this GtkSearchEntryHandle entry, GtkInputPurpose purpose)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_input_purpose(entry, purpose);
		return entry;
	}

	public static GtkSearchEntryHandle SetKeyCaptureWidget(this GtkSearchEntryHandle entry, GtkWidgetHandle widget)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_key_capture_widget(entry, widget);
		return entry;
	}

	public static GtkSearchEntryHandle SetPlaceholderText(this GtkSearchEntryHandle entry, string text)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_placeholder_text(entry, text);
		return entry;
	}

	public static GtkSearchEntryHandle SetSearchDelay(this GtkSearchEntryHandle entry, uint delay)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_search_delay(entry, delay);
		return entry;
	}

}

internal class GtkSearchEntryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSearchEntryHandle gtk_search_entry_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputHints gtk_search_entry_get_input_hints(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputPurpose gtk_search_entry_get_input_purpose(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_search_entry_get_key_capture_widget(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_search_entry_get_placeholder_text(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_search_entry_get_search_delay(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_input_hints(GtkSearchEntryHandle entry, GtkInputHints hints);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_input_purpose(GtkSearchEntryHandle entry, GtkInputPurpose purpose);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_key_capture_widget(GtkSearchEntryHandle entry, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_placeholder_text(GtkSearchEntryHandle entry, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_search_delay(GtkSearchEntryHandle entry, uint delay);

}
