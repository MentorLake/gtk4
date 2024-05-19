namespace MentorLake.Gtk4.Gtk4;

public class GtkOverlayHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkOverlayHandle New()
	{
		return GtkOverlayExterns.gtk_overlay_new();
	}

}

public static class GtkOverlaySignalExtensions
{

	public static IObservable<GtkOverlaySignalStructs.GetChildPositionSignal> Signal_GetChildPosition(this GtkOverlayHandle instance)
	{
		return Observable.Create((IObserver<GtkOverlaySignalStructs.GetChildPositionSignal> obs) =>
		{
			GtkOverlaySignalDelegates.GetChildPosition handler = (GtkOverlayHandle self, GtkWidgetHandle widget, out GdkRectangle allocation, IntPtr user_data) =>
			{
				allocation = default;

				var signalStruct = new GtkOverlaySignalStructs.GetChildPositionSignal()
				{
					Self = self, Widget = widget, Allocation = allocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "get_child_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkOverlaySignalStructs
{

public struct GetChildPositionSignal
{
	public GtkOverlayHandle Self;
	public GtkWidgetHandle Widget;
	public GdkRectangle Allocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkOverlaySignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool GetChildPosition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkOverlayHandle>))] GtkOverlayHandle self, GtkWidgetHandle widget, out GdkRectangle allocation, IntPtr user_data);
}


public static class GtkOverlayHandleExtensions
{
	public static GtkOverlayHandle AddOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		GtkOverlayExterns.gtk_overlay_add_overlay(overlay, widget);
		return overlay;
	}

	public static GtkWidgetHandle GetChild(this GtkOverlayHandle overlay)
	{
		return GtkOverlayExterns.gtk_overlay_get_child(overlay);
	}

	public static bool GetClipOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		return GtkOverlayExterns.gtk_overlay_get_clip_overlay(overlay, widget);
	}

	public static bool GetMeasureOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		return GtkOverlayExterns.gtk_overlay_get_measure_overlay(overlay, widget);
	}

	public static GtkOverlayHandle RemoveOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		GtkOverlayExterns.gtk_overlay_remove_overlay(overlay, widget);
		return overlay;
	}

	public static GtkOverlayHandle SetChild(this GtkOverlayHandle overlay, GtkWidgetHandle child)
	{
		GtkOverlayExterns.gtk_overlay_set_child(overlay, child);
		return overlay;
	}

	public static GtkOverlayHandle SetClipOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget, bool clip_overlay)
	{
		GtkOverlayExterns.gtk_overlay_set_clip_overlay(overlay, widget, clip_overlay);
		return overlay;
	}

	public static GtkOverlayHandle SetMeasureOverlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget, bool measure)
	{
		GtkOverlayExterns.gtk_overlay_set_measure_overlay(overlay, widget, measure);
		return overlay;
	}

}

internal class GtkOverlayExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkOverlayHandle gtk_overlay_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_overlay_add_overlay(GtkOverlayHandle overlay, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_overlay_get_child(GtkOverlayHandle overlay);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_overlay_get_clip_overlay(GtkOverlayHandle overlay, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_overlay_get_measure_overlay(GtkOverlayHandle overlay, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_overlay_remove_overlay(GtkOverlayHandle overlay, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_overlay_set_child(GtkOverlayHandle overlay, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_overlay_set_clip_overlay(GtkOverlayHandle overlay, GtkWidgetHandle widget, bool clip_overlay);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_overlay_set_measure_overlay(GtkOverlayHandle overlay, GtkWidgetHandle widget, bool measure);

}
