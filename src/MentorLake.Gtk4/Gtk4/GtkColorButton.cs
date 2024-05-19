namespace MentorLake.Gtk4.Gtk4;

public class GtkColorButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkConstraintTargetHandle
{
	public static GtkColorButtonHandle New()
	{
		return GtkColorButtonExterns.gtk_color_button_new();
	}

	public static GtkColorButtonHandle NewWithRgba(GdkRGBAHandle rgba)
	{
		return GtkColorButtonExterns.gtk_color_button_new_with_rgba(rgba);
	}

}

public static class GtkColorButtonSignalExtensions
{

	public static IObservable<GtkColorButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkColorButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkColorButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkColorButtonSignalDelegates.Activate handler = (GtkColorButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorButtonSignalStructs.ActivateSignal()
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

	public static IObservable<GtkColorButtonSignalStructs.ColorSetSignal> Signal_ColorSet(this GtkColorButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkColorButtonSignalStructs.ColorSetSignal> obs) =>
		{
			GtkColorButtonSignalDelegates.ColorSet handler = (GtkColorButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorButtonSignalStructs.ColorSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "color_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkColorButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkColorButtonHandle Self;
	public IntPtr UserData;
}

public struct ColorSetSignal
{
	public GtkColorButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkColorButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColorButtonHandle>))] GtkColorButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ColorSet([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColorButtonHandle>))] GtkColorButtonHandle self, IntPtr user_data);
}


public static class GtkColorButtonHandleExtensions
{
	public static bool GetModal(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_modal(button);
	}

	public static string GetTitle(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_title(button);
	}

	public static GtkColorButtonHandle SetModal(this GtkColorButtonHandle button, bool modal)
	{
		GtkColorButtonExterns.gtk_color_button_set_modal(button, modal);
		return button;
	}

	public static GtkColorButtonHandle SetTitle(this GtkColorButtonHandle button, string title)
	{
		GtkColorButtonExterns.gtk_color_button_set_title(button, title);
		return button;
	}

}

internal class GtkColorButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorButtonHandle gtk_color_button_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorButtonHandle gtk_color_button_new_with_rgba(GdkRGBAHandle rgba);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_color_button_get_modal(GtkColorButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_color_button_get_title(GtkColorButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_button_set_modal(GtkColorButtonHandle button, bool modal);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_button_set_title(GtkColorButtonHandle button, string title);

}
