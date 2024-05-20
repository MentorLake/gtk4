namespace MentorLake.Gtk4.Gtk4;

public class GtkInfoBarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkInfoBarHandle New()
	{
		return GtkInfoBarExterns.gtk_info_bar_new();
	}

	public static GtkInfoBarHandle NewWithButtons(string first_button_text, IntPtr @__arglist)
	{
		return GtkInfoBarExterns.gtk_info_bar_new_with_buttons(first_button_text, @__arglist);
	}

}

public static class GtkInfoBarSignalExtensions
{

	public static IObservable<GtkInfoBarSignalStructs.CloseSignal> Signal_Close(this GtkInfoBarHandle instance)
	{
		return Observable.Create((IObserver<GtkInfoBarSignalStructs.CloseSignal> obs) =>
		{
			GtkInfoBarSignalDelegates.close handler = (GtkInfoBarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkInfoBarSignalStructs.CloseSignal()
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

	public static IObservable<GtkInfoBarSignalStructs.ResponseSignal> Signal_Response(this GtkInfoBarHandle instance)
	{
		return Observable.Create((IObserver<GtkInfoBarSignalStructs.ResponseSignal> obs) =>
		{
			GtkInfoBarSignalDelegates.response handler = (GtkInfoBarHandle self, int response_id, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkInfoBarSignalStructs.ResponseSignal()
				{
					Self = self, ResponseId = response_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "response", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkInfoBarSignalStructs
{

public struct CloseSignal
{
	public GtkInfoBarHandle Self;
	public IntPtr UserData;
}

public struct ResponseSignal
{
	public GtkInfoBarHandle Self;
	public int ResponseId;
	public IntPtr UserData;
}
}

public static class GtkInfoBarSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkInfoBarHandle>))] GtkInfoBarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkInfoBarHandle>))] GtkInfoBarHandle self, int response_id, IntPtr user_data);

}


public static class GtkInfoBarHandleExtensions
{
	public static GtkInfoBarHandle AddActionWidget(this GtkInfoBarHandle info_bar, GtkWidgetHandle child, int response_id)
	{
		GtkInfoBarExterns.gtk_info_bar_add_action_widget(info_bar, child, response_id);
		return info_bar;
	}

	public static GtkWidgetHandle AddButton(this GtkInfoBarHandle info_bar, string button_text, int response_id)
	{
		return GtkInfoBarExterns.gtk_info_bar_add_button(info_bar, button_text, response_id);
	}

	public static GtkInfoBarHandle AddButtons(this GtkInfoBarHandle info_bar, string first_button_text, IntPtr @__arglist)
	{
		GtkInfoBarExterns.gtk_info_bar_add_buttons(info_bar, first_button_text, @__arglist);
		return info_bar;
	}

	public static GtkInfoBarHandle AddChild(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget)
	{
		GtkInfoBarExterns.gtk_info_bar_add_child(info_bar, widget);
		return info_bar;
	}

	public static GtkMessageType GetMessageType(this GtkInfoBarHandle info_bar)
	{
		return GtkInfoBarExterns.gtk_info_bar_get_message_type(info_bar);
	}

	public static bool GetRevealed(this GtkInfoBarHandle info_bar)
	{
		return GtkInfoBarExterns.gtk_info_bar_get_revealed(info_bar);
	}

	public static bool GetShowCloseButton(this GtkInfoBarHandle info_bar)
	{
		return GtkInfoBarExterns.gtk_info_bar_get_show_close_button(info_bar);
	}

	public static GtkInfoBarHandle RemoveActionWidget(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget)
	{
		GtkInfoBarExterns.gtk_info_bar_remove_action_widget(info_bar, widget);
		return info_bar;
	}

	public static GtkInfoBarHandle RemoveChild(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget)
	{
		GtkInfoBarExterns.gtk_info_bar_remove_child(info_bar, widget);
		return info_bar;
	}

	public static GtkInfoBarHandle Response(this GtkInfoBarHandle info_bar, int response_id)
	{
		GtkInfoBarExterns.gtk_info_bar_response(info_bar, response_id);
		return info_bar;
	}

	public static GtkInfoBarHandle SetDefaultResponse(this GtkInfoBarHandle info_bar, int response_id)
	{
		GtkInfoBarExterns.gtk_info_bar_set_default_response(info_bar, response_id);
		return info_bar;
	}

	public static GtkInfoBarHandle SetMessageType(this GtkInfoBarHandle info_bar, GtkMessageType message_type)
	{
		GtkInfoBarExterns.gtk_info_bar_set_message_type(info_bar, message_type);
		return info_bar;
	}

	public static GtkInfoBarHandle SetResponseSensitive(this GtkInfoBarHandle info_bar, int response_id, bool setting)
	{
		GtkInfoBarExterns.gtk_info_bar_set_response_sensitive(info_bar, response_id, setting);
		return info_bar;
	}

	public static GtkInfoBarHandle SetRevealed(this GtkInfoBarHandle info_bar, bool revealed)
	{
		GtkInfoBarExterns.gtk_info_bar_set_revealed(info_bar, revealed);
		return info_bar;
	}

	public static GtkInfoBarHandle SetShowCloseButton(this GtkInfoBarHandle info_bar, bool setting)
	{
		GtkInfoBarExterns.gtk_info_bar_set_show_close_button(info_bar, setting);
		return info_bar;
	}

}

internal class GtkInfoBarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInfoBarHandle gtk_info_bar_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInfoBarHandle gtk_info_bar_new_with_buttons(string first_button_text, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_add_action_widget(GtkInfoBarHandle info_bar, GtkWidgetHandle child, int response_id);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_info_bar_add_button(GtkInfoBarHandle info_bar, string button_text, int response_id);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_add_buttons(GtkInfoBarHandle info_bar, string first_button_text, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_add_child(GtkInfoBarHandle info_bar, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMessageType gtk_info_bar_get_message_type(GtkInfoBarHandle info_bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_info_bar_get_revealed(GtkInfoBarHandle info_bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_info_bar_get_show_close_button(GtkInfoBarHandle info_bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_remove_action_widget(GtkInfoBarHandle info_bar, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_remove_child(GtkInfoBarHandle info_bar, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_response(GtkInfoBarHandle info_bar, int response_id);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_set_default_response(GtkInfoBarHandle info_bar, int response_id);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_set_message_type(GtkInfoBarHandle info_bar, GtkMessageType message_type);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_set_response_sensitive(GtkInfoBarHandle info_bar, int response_id, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_set_revealed(GtkInfoBarHandle info_bar, bool revealed);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_info_bar_set_show_close_button(GtkInfoBarHandle info_bar, bool setting);

}
