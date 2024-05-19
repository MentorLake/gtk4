namespace MentorLake.Gtk4.Gtk4;

public class GtkAppChooserButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkAppChooserButtonHandle New(string content_type)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_new(content_type);
	}

}

public static class GtkAppChooserButtonSignalExtensions
{

	public static IObservable<GtkAppChooserButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkAppChooserButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkAppChooserButtonSignalDelegates.Activate handler = (GtkAppChooserButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonSignalStructs.ActivateSignal()
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

	public static IObservable<GtkAppChooserButtonSignalStructs.ChangedSignal> Signal_Changed(this GtkAppChooserButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonSignalStructs.ChangedSignal> obs) =>
		{
			GtkAppChooserButtonSignalDelegates.Changed handler = (GtkAppChooserButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonSignalStructs.ChangedSignal()
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

	public static IObservable<GtkAppChooserButtonSignalStructs.CustomItemActivatedSignal> Signal_CustomItemActivated(this GtkAppChooserButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonSignalStructs.CustomItemActivatedSignal> obs) =>
		{
			GtkAppChooserButtonSignalDelegates.CustomItemActivated handler = (GtkAppChooserButtonHandle self, string item_name, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonSignalStructs.CustomItemActivatedSignal()
				{
					Self = self, ItemName = item_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "custom_item_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkAppChooserButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkAppChooserButtonHandle Self;
	public IntPtr UserData;
}

public struct ChangedSignal
{
	public GtkAppChooserButtonHandle Self;
	public IntPtr UserData;
}

public struct CustomItemActivatedSignal
{
	public GtkAppChooserButtonHandle Self;
	public string ItemName;
	public IntPtr UserData;
}
}

public static class GtkAppChooserButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAppChooserButtonHandle>))] GtkAppChooserButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAppChooserButtonHandle>))] GtkAppChooserButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CustomItemActivated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAppChooserButtonHandle>))] GtkAppChooserButtonHandle self, string item_name, IntPtr user_data);
}


public static class GtkAppChooserButtonHandleExtensions
{
	public static GtkAppChooserButtonHandle AppendCustomItem(this GtkAppChooserButtonHandle self, string name, string label, GIconHandle icon)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_custom_item(self, name, label, icon);
		return self;
	}

	public static GtkAppChooserButtonHandle AppendSeparator(this GtkAppChooserButtonHandle self)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_separator(self);
		return self;
	}

	public static string GetHeading(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_heading(self);
	}

	public static bool GetModal(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_modal(self);
	}

	public static bool GetShowDefaultItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_default_item(self);
	}

	public static bool GetShowDialogItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_dialog_item(self);
	}

	public static GtkAppChooserButtonHandle SetActiveCustomItem(this GtkAppChooserButtonHandle self, string name)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_active_custom_item(self, name);
		return self;
	}

	public static GtkAppChooserButtonHandle SetHeading(this GtkAppChooserButtonHandle self, string heading)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_heading(self, heading);
		return self;
	}

	public static GtkAppChooserButtonHandle SetModal(this GtkAppChooserButtonHandle self, bool modal)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_modal(self, modal);
		return self;
	}

	public static GtkAppChooserButtonHandle SetShowDefaultItem(this GtkAppChooserButtonHandle self, bool setting)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_default_item(self, setting);
		return self;
	}

	public static GtkAppChooserButtonHandle SetShowDialogItem(this GtkAppChooserButtonHandle self, bool setting)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_dialog_item(self, setting);
		return self;
	}

}

internal class GtkAppChooserButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAppChooserButtonHandle gtk_app_chooser_button_new(string content_type);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_append_custom_item(GtkAppChooserButtonHandle self, string name, string label, GIconHandle icon);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_append_separator(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_button_get_heading(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_button_get_modal(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_button_get_show_default_item(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_button_get_show_dialog_item(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_active_custom_item(GtkAppChooserButtonHandle self, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_heading(GtkAppChooserButtonHandle self, string heading);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_modal(GtkAppChooserButtonHandle self, bool modal);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_show_default_item(GtkAppChooserButtonHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_show_dialog_item(GtkAppChooserButtonHandle self, bool setting);

}
