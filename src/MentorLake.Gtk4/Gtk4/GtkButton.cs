namespace MentorLake.Gtk4.Gtk4;

public class GtkButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkButtonHandle New()
	{
		return GtkButtonExterns.gtk_button_new();
	}

	public static GtkButtonHandle NewFromIconName(string icon_name)
	{
		return GtkButtonExterns.gtk_button_new_from_icon_name(icon_name);
	}

	public static GtkButtonHandle NewWithLabel(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_label(label);
	}

	public static GtkButtonHandle NewWithMnemonic(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_mnemonic(label);
	}

}

public static class GtkButtonSignalExtensions
{

	public static IObservable<GtkButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkButtonSignalDelegates.activate handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.ActivateSignal()
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

	public static IObservable<GtkButtonSignalStructs.ClickedSignal> Signal_Clicked(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.ClickedSignal> obs) =>
		{
			GtkButtonSignalDelegates.clicked handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}

public struct ClickedSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);

}


public static class GtkButtonHandleExtensions
{
	public static bool GetCanShrink(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_can_shrink(button);
	}

	public static GtkWidgetHandle GetChild(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_child(button);
	}

	public static bool GetHasFrame(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_has_frame(button);
	}

	public static string GetIconName(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_icon_name(button);
	}

	public static string GetLabel(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_label(button);
	}

	public static bool GetUseUnderline(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_use_underline(button);
	}

	public static GtkButtonHandle SetCanShrink(this GtkButtonHandle button, bool can_shrink)
	{
		GtkButtonExterns.gtk_button_set_can_shrink(button, can_shrink);
		return button;
	}

	public static GtkButtonHandle SetChild(this GtkButtonHandle button, GtkWidgetHandle child)
	{
		GtkButtonExterns.gtk_button_set_child(button, child);
		return button;
	}

	public static GtkButtonHandle SetHasFrame(this GtkButtonHandle button, bool has_frame)
	{
		GtkButtonExterns.gtk_button_set_has_frame(button, has_frame);
		return button;
	}

	public static GtkButtonHandle SetIconName(this GtkButtonHandle button, string icon_name)
	{
		GtkButtonExterns.gtk_button_set_icon_name(button, icon_name);
		return button;
	}

	public static GtkButtonHandle SetLabel(this GtkButtonHandle button, string label)
	{
		GtkButtonExterns.gtk_button_set_label(button, label);
		return button;
	}

	public static GtkButtonHandle SetUseUnderline(this GtkButtonHandle button, bool use_underline)
	{
		GtkButtonExterns.gtk_button_set_use_underline(button, use_underline);
		return button;
	}

}

internal class GtkButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new_from_icon_name(string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new_with_label(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_button_get_can_shrink(GtkButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_button_get_child(GtkButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_button_get_has_frame(GtkButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_button_get_icon_name(GtkButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_button_get_label(GtkButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_button_get_use_underline(GtkButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_can_shrink(GtkButtonHandle button, bool can_shrink);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_child(GtkButtonHandle button, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_has_frame(GtkButtonHandle button, bool has_frame);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_icon_name(GtkButtonHandle button, string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_label(GtkButtonHandle button, string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_use_underline(GtkButtonHandle button, bool use_underline);

}
