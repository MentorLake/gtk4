namespace MentorLake.Gtk4.Gtk4;

public class GtkPopoverHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkShortcutManagerHandle
{
	public static GtkPopoverHandle New()
	{
		return GtkPopoverExterns.gtk_popover_new();
	}

}

public static class GtkPopoverSignalExtensions
{

	public static IObservable<GtkPopoverSignalStructs.ActivateDefaultSignal> Signal_ActivateDefault(this GtkPopoverHandle instance)
	{
		return Observable.Create((IObserver<GtkPopoverSignalStructs.ActivateDefaultSignal> obs) =>
		{
			GtkPopoverSignalDelegates.ActivateDefault handler = (GtkPopoverHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPopoverSignalStructs.ActivateDefaultSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_default", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPopoverSignalStructs.ClosedSignal> Signal_Closed(this GtkPopoverHandle instance)
	{
		return Observable.Create((IObserver<GtkPopoverSignalStructs.ClosedSignal> obs) =>
		{
			GtkPopoverSignalDelegates.Closed handler = (GtkPopoverHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPopoverSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPopoverSignalStructs
{

public struct ActivateDefaultSignal
{
	public GtkPopoverHandle Self;
	public IntPtr UserData;
}

public struct ClosedSignal
{
	public GtkPopoverHandle Self;
	public IntPtr UserData;
}
}

public static class GtkPopoverSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ActivateDefault([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPopoverHandle>))] GtkPopoverHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPopoverHandle>))] GtkPopoverHandle self, IntPtr user_data);
}


public static class GtkPopoverHandleExtensions
{
	public static bool GetAutohide(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_autohide(popover);
	}

	public static bool GetCascadePopdown(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_cascade_popdown(popover);
	}

	public static GtkWidgetHandle GetChild(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_child(popover);
	}

	public static bool GetHasArrow(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_has_arrow(popover);
	}

	public static bool GetMnemonicsVisible(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_mnemonics_visible(popover);
	}

	public static GtkPopoverHandle GetOffset(this GtkPopoverHandle popover, out int x_offset, out int y_offset)
	{
		GtkPopoverExterns.gtk_popover_get_offset(popover, out x_offset, out y_offset);
		return popover;
	}

	public static bool GetPointingTo(this GtkPopoverHandle popover, out GdkRectangle rect)
	{
		return GtkPopoverExterns.gtk_popover_get_pointing_to(popover, out rect);
	}

	public static GtkPositionType GetPosition(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_position(popover);
	}

	public static GtkPopoverHandle Popdown(this GtkPopoverHandle popover)
	{
		GtkPopoverExterns.gtk_popover_popdown(popover);
		return popover;
	}

	public static GtkPopoverHandle Popup(this GtkPopoverHandle popover)
	{
		GtkPopoverExterns.gtk_popover_popup(popover);
		return popover;
	}

	public static GtkPopoverHandle Present(this GtkPopoverHandle popover)
	{
		GtkPopoverExterns.gtk_popover_present(popover);
		return popover;
	}

	public static GtkPopoverHandle SetAutohide(this GtkPopoverHandle popover, bool autohide)
	{
		GtkPopoverExterns.gtk_popover_set_autohide(popover, autohide);
		return popover;
	}

	public static GtkPopoverHandle SetCascadePopdown(this GtkPopoverHandle popover, bool cascade_popdown)
	{
		GtkPopoverExterns.gtk_popover_set_cascade_popdown(popover, cascade_popdown);
		return popover;
	}

	public static GtkPopoverHandle SetChild(this GtkPopoverHandle popover, GtkWidgetHandle child)
	{
		GtkPopoverExterns.gtk_popover_set_child(popover, child);
		return popover;
	}

	public static GtkPopoverHandle SetDefaultWidget(this GtkPopoverHandle popover, GtkWidgetHandle widget)
	{
		GtkPopoverExterns.gtk_popover_set_default_widget(popover, widget);
		return popover;
	}

	public static GtkPopoverHandle SetHasArrow(this GtkPopoverHandle popover, bool has_arrow)
	{
		GtkPopoverExterns.gtk_popover_set_has_arrow(popover, has_arrow);
		return popover;
	}

	public static GtkPopoverHandle SetMnemonicsVisible(this GtkPopoverHandle popover, bool mnemonics_visible)
	{
		GtkPopoverExterns.gtk_popover_set_mnemonics_visible(popover, mnemonics_visible);
		return popover;
	}

	public static GtkPopoverHandle SetOffset(this GtkPopoverHandle popover, int x_offset, int y_offset)
	{
		GtkPopoverExterns.gtk_popover_set_offset(popover, x_offset, y_offset);
		return popover;
	}

	public static GtkPopoverHandle SetPointingTo(this GtkPopoverHandle popover, GdkRectangleHandle rect)
	{
		GtkPopoverExterns.gtk_popover_set_pointing_to(popover, rect);
		return popover;
	}

	public static GtkPopoverHandle SetPosition(this GtkPopoverHandle popover, GtkPositionType position)
	{
		GtkPopoverExterns.gtk_popover_set_position(popover, position);
		return popover;
	}

}

internal class GtkPopoverExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPopoverHandle gtk_popover_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_get_autohide(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_get_cascade_popdown(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_popover_get_child(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_get_has_arrow(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_get_mnemonics_visible(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_get_offset(GtkPopoverHandle popover, out int x_offset, out int y_offset);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_get_pointing_to(GtkPopoverHandle popover, out GdkRectangle rect);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPositionType gtk_popover_get_position(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_popdown(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_popup(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_present(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_autohide(GtkPopoverHandle popover, bool autohide);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_cascade_popdown(GtkPopoverHandle popover, bool cascade_popdown);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_child(GtkPopoverHandle popover, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_default_widget(GtkPopoverHandle popover, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_has_arrow(GtkPopoverHandle popover, bool has_arrow);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_mnemonics_visible(GtkPopoverHandle popover, bool mnemonics_visible);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_offset(GtkPopoverHandle popover, int x_offset, int y_offset);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_pointing_to(GtkPopoverHandle popover, GdkRectangleHandle rect);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_set_position(GtkPopoverHandle popover, GtkPositionType position);

}
