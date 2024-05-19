namespace MentorLake.Gtk4.Gtk4;

public class GtkAppChooserWidgetHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkAppChooserWidgetHandle New(string content_type)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_new(content_type);
	}

}

public static class GtkAppChooserWidgetSignalExtensions
{

	public static IObservable<GtkAppChooserWidgetSignalStructs.ApplicationActivatedSignal> Signal_ApplicationActivated(this GtkAppChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkAppChooserWidgetSignalStructs.ApplicationActivatedSignal> obs) =>
		{
			GtkAppChooserWidgetSignalDelegates.ApplicationActivated handler = (GtkAppChooserWidgetHandle self, GAppInfoHandle application, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserWidgetSignalStructs.ApplicationActivatedSignal()
				{
					Self = self, Application = application, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "application_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkAppChooserWidgetSignalStructs.ApplicationSelectedSignal> Signal_ApplicationSelected(this GtkAppChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkAppChooserWidgetSignalStructs.ApplicationSelectedSignal> obs) =>
		{
			GtkAppChooserWidgetSignalDelegates.ApplicationSelected handler = (GtkAppChooserWidgetHandle self, GAppInfoHandle application, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserWidgetSignalStructs.ApplicationSelectedSignal()
				{
					Self = self, Application = application, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "application_selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkAppChooserWidgetSignalStructs
{

public struct ApplicationActivatedSignal
{
	public GtkAppChooserWidgetHandle Self;
	public GAppInfoHandle Application;
	public IntPtr UserData;
}

public struct ApplicationSelectedSignal
{
	public GtkAppChooserWidgetHandle Self;
	public GAppInfoHandle Application;
	public IntPtr UserData;
}
}

public static class GtkAppChooserWidgetSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ApplicationActivated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAppChooserWidgetHandle>))] GtkAppChooserWidgetHandle self, GAppInfoHandle application, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ApplicationSelected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAppChooserWidgetHandle>))] GtkAppChooserWidgetHandle self, GAppInfoHandle application, IntPtr user_data);
}


public static class GtkAppChooserWidgetHandleExtensions
{
	public static string GetDefaultText(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_default_text(self);
	}

	public static bool GetShowAll(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_all(self);
	}

	public static bool GetShowDefault(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_default(self);
	}

	public static bool GetShowFallback(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_fallback(self);
	}

	public static bool GetShowOther(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_other(self);
	}

	public static bool GetShowRecommended(this GtkAppChooserWidgetHandle self)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_get_show_recommended(self);
	}

	public static GtkAppChooserWidgetHandle SetDefaultText(this GtkAppChooserWidgetHandle self, string text)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_default_text(self, text);
		return self;
	}

	public static GtkAppChooserWidgetHandle SetShowAll(this GtkAppChooserWidgetHandle self, bool setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_all(self, setting);
		return self;
	}

	public static GtkAppChooserWidgetHandle SetShowDefault(this GtkAppChooserWidgetHandle self, bool setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_default(self, setting);
		return self;
	}

	public static GtkAppChooserWidgetHandle SetShowFallback(this GtkAppChooserWidgetHandle self, bool setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_fallback(self, setting);
		return self;
	}

	public static GtkAppChooserWidgetHandle SetShowOther(this GtkAppChooserWidgetHandle self, bool setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_other(self, setting);
		return self;
	}

	public static GtkAppChooserWidgetHandle SetShowRecommended(this GtkAppChooserWidgetHandle self, bool setting)
	{
		GtkAppChooserWidgetExterns.gtk_app_chooser_widget_set_show_recommended(self, setting);
		return self;
	}

}

internal class GtkAppChooserWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAppChooserWidgetHandle gtk_app_chooser_widget_new(string content_type);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_widget_get_default_text(GtkAppChooserWidgetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_widget_get_show_all(GtkAppChooserWidgetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_widget_get_show_default(GtkAppChooserWidgetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_widget_get_show_fallback(GtkAppChooserWidgetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_widget_get_show_other(GtkAppChooserWidgetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_widget_get_show_recommended(GtkAppChooserWidgetHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_widget_set_default_text(GtkAppChooserWidgetHandle self, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_widget_set_show_all(GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_widget_set_show_default(GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_widget_set_show_fallback(GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_widget_set_show_other(GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_widget_set_show_recommended(GtkAppChooserWidgetHandle self, bool setting);

}
