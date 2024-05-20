namespace MentorLake.Gtk4.Gtk4;

public class GtkMenuButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkMenuButtonHandle New()
	{
		return GtkMenuButtonExterns.gtk_menu_button_new();
	}

}

public static class GtkMenuButtonSignalExtensions
{

	public static IObservable<GtkMenuButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkMenuButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkMenuButtonSignalDelegates.activate handler = (GtkMenuButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuButtonSignalStructs.ActivateSignal()
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
}

public static class GtkMenuButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkMenuButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkMenuButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuButtonHandle>))] GtkMenuButtonHandle self, IntPtr user_data);

}


public static class GtkMenuButtonHandleExtensions
{
	public static bool GetActive(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_active(menu_button);
	}

	public static bool GetAlwaysShowArrow(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_always_show_arrow(menu_button);
	}

	public static bool GetCanShrink(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_can_shrink(menu_button);
	}

	public static GtkWidgetHandle GetChild(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_child(menu_button);
	}

	public static GtkArrowType GetDirection(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_direction(menu_button);
	}

	public static bool GetHasFrame(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_has_frame(menu_button);
	}

	public static string GetIconName(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_icon_name(menu_button);
	}

	public static string GetLabel(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_label(menu_button);
	}

	public static GMenuModelHandle GetMenuModel(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_menu_model(menu_button);
	}

	public static GtkPopoverHandle GetPopover(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_popover(menu_button);
	}

	public static bool GetPrimary(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_primary(menu_button);
	}

	public static bool GetUseUnderline(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_use_underline(menu_button);
	}

	public static GtkMenuButtonHandle Popdown(this GtkMenuButtonHandle menu_button)
	{
		GtkMenuButtonExterns.gtk_menu_button_popdown(menu_button);
		return menu_button;
	}

	public static GtkMenuButtonHandle Popup(this GtkMenuButtonHandle menu_button)
	{
		GtkMenuButtonExterns.gtk_menu_button_popup(menu_button);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetActive(this GtkMenuButtonHandle menu_button, bool active)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_active(menu_button, active);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetAlwaysShowArrow(this GtkMenuButtonHandle menu_button, bool always_show_arrow)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_always_show_arrow(menu_button, always_show_arrow);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetCanShrink(this GtkMenuButtonHandle menu_button, bool can_shrink)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_can_shrink(menu_button, can_shrink);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetChild(this GtkMenuButtonHandle menu_button, GtkWidgetHandle child)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_child(menu_button, child);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetCreatePopupFunc(this GtkMenuButtonHandle menu_button, GtkMenuButtonCreatePopupFunc func, IntPtr user_data, GDestroyNotify destroy_notify)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_create_popup_func(menu_button, func, user_data, destroy_notify);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetDirection(this GtkMenuButtonHandle menu_button, GtkArrowType direction)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_direction(menu_button, direction);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetHasFrame(this GtkMenuButtonHandle menu_button, bool has_frame)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_has_frame(menu_button, has_frame);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetIconName(this GtkMenuButtonHandle menu_button, string icon_name)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_icon_name(menu_button, icon_name);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetLabel(this GtkMenuButtonHandle menu_button, string label)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_label(menu_button, label);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetMenuModel(this GtkMenuButtonHandle menu_button, GMenuModelHandle menu_model)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_menu_model(menu_button, menu_model);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetPopover(this GtkMenuButtonHandle menu_button, GtkWidgetHandle popover)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_popover(menu_button, popover);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetPrimary(this GtkMenuButtonHandle menu_button, bool primary)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_primary(menu_button, primary);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetUseUnderline(this GtkMenuButtonHandle menu_button, bool use_underline)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_use_underline(menu_button, use_underline);
		return menu_button;
	}

}

internal class GtkMenuButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMenuButtonHandle gtk_menu_button_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_menu_button_get_active(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_menu_button_get_always_show_arrow(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_menu_button_get_can_shrink(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_menu_button_get_child(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkArrowType gtk_menu_button_get_direction(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_menu_button_get_has_frame(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_button_get_icon_name(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_button_get_label(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_menu_button_get_menu_model(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPopoverHandle gtk_menu_button_get_popover(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_menu_button_get_primary(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_menu_button_get_use_underline(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_popdown(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_popup(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_active(GtkMenuButtonHandle menu_button, bool active);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_always_show_arrow(GtkMenuButtonHandle menu_button, bool always_show_arrow);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_can_shrink(GtkMenuButtonHandle menu_button, bool can_shrink);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_child(GtkMenuButtonHandle menu_button, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_create_popup_func(GtkMenuButtonHandle menu_button, GtkMenuButtonCreatePopupFunc func, IntPtr user_data, GDestroyNotify destroy_notify);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_direction(GtkMenuButtonHandle menu_button, GtkArrowType direction);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_has_frame(GtkMenuButtonHandle menu_button, bool has_frame);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_icon_name(GtkMenuButtonHandle menu_button, string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_label(GtkMenuButtonHandle menu_button, string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_menu_model(GtkMenuButtonHandle menu_button, GMenuModelHandle menu_model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_popover(GtkMenuButtonHandle menu_button, GtkWidgetHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_primary(GtkMenuButtonHandle menu_button, bool primary);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_menu_button_set_use_underline(GtkMenuButtonHandle menu_button, bool use_underline);

}
