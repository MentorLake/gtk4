using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkOverlayHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkOverlayHandle New()
	{
		return GtkOverlayExterns.gtk_overlay_new();
	}

}

public class GtkOverlaySignal
{
	public string Value { get; set; }
	public GtkOverlaySignal(string value) => Value = value;
}

public static class GtkOverlaySignals
{
	public static GtkOverlaySignal GetChildPosition = new("BindingTransform.MethodDeclaration");
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

	public static GtkOverlayHandle Signal_GetChildPosition(this GtkOverlayHandle instance, GtkOverlayDelegates.GetChildPosition handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "get_child_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkOverlayDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool GetChildPosition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkOverlayHandle>))] GtkOverlayHandle self, GtkWidgetHandle widget, out GdkRectangle allocation, IntPtr user_data);
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
