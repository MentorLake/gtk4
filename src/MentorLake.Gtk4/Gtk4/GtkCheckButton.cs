namespace MentorLake.Gtk4.Gtk4;

public class GtkCheckButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkCheckButtonHandle New()
	{
		return GtkCheckButtonExterns.gtk_check_button_new();
	}

	public static GtkCheckButtonHandle NewWithLabel(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_label(label);
	}

	public static GtkCheckButtonHandle NewWithMnemonic(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_mnemonic(label);
	}

}

public static class GtkCheckButtonSignalExtensions
{

	public static IObservable<GtkCheckButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkCheckButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkCheckButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkCheckButtonSignalDelegates.Activate handler = (GtkCheckButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCheckButtonSignalStructs.ActivateSignal()
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

	public static IObservable<GtkCheckButtonSignalStructs.ToggledSignal> Signal_Toggled(this GtkCheckButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkCheckButtonSignalStructs.ToggledSignal> obs) =>
		{
			GtkCheckButtonSignalDelegates.Toggled handler = (GtkCheckButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCheckButtonSignalStructs.ToggledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCheckButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkCheckButtonHandle Self;
	public IntPtr UserData;
}

public struct ToggledSignal
{
	public GtkCheckButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkCheckButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCheckButtonHandle>))] GtkCheckButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCheckButtonHandle>))] GtkCheckButtonHandle self, IntPtr user_data);
}


public static class GtkCheckButtonHandleExtensions
{
	public static bool GetActive(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_active(self);
	}

	public static GtkWidgetHandle GetChild(this GtkCheckButtonHandle button)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_child(button);
	}

	public static bool GetInconsistent(this GtkCheckButtonHandle check_button)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_inconsistent(check_button);
	}

	public static string GetLabel(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_label(self);
	}

	public static bool GetUseUnderline(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_use_underline(self);
	}

	public static GtkCheckButtonHandle SetActive(this GtkCheckButtonHandle self, bool setting)
	{
		GtkCheckButtonExterns.gtk_check_button_set_active(self, setting);
		return self;
	}

	public static GtkCheckButtonHandle SetChild(this GtkCheckButtonHandle button, GtkWidgetHandle child)
	{
		GtkCheckButtonExterns.gtk_check_button_set_child(button, child);
		return button;
	}

	public static GtkCheckButtonHandle SetGroup(this GtkCheckButtonHandle self, GtkCheckButtonHandle group)
	{
		GtkCheckButtonExterns.gtk_check_button_set_group(self, group);
		return self;
	}

	public static GtkCheckButtonHandle SetInconsistent(this GtkCheckButtonHandle check_button, bool inconsistent)
	{
		GtkCheckButtonExterns.gtk_check_button_set_inconsistent(check_button, inconsistent);
		return check_button;
	}

	public static GtkCheckButtonHandle SetLabel(this GtkCheckButtonHandle self, string label)
	{
		GtkCheckButtonExterns.gtk_check_button_set_label(self, label);
		return self;
	}

	public static GtkCheckButtonHandle SetUseUnderline(this GtkCheckButtonHandle self, bool setting)
	{
		GtkCheckButtonExterns.gtk_check_button_set_use_underline(self, setting);
		return self;
	}

}

internal class GtkCheckButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new_with_label(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_check_button_get_active(GtkCheckButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_check_button_get_child(GtkCheckButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_check_button_get_inconsistent(GtkCheckButtonHandle check_button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_check_button_get_label(GtkCheckButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_check_button_get_use_underline(GtkCheckButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_active(GtkCheckButtonHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_child(GtkCheckButtonHandle button, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_group(GtkCheckButtonHandle self, GtkCheckButtonHandle group);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_inconsistent(GtkCheckButtonHandle check_button, bool inconsistent);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_label(GtkCheckButtonHandle self, string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_use_underline(GtkCheckButtonHandle self, bool setting);

}
