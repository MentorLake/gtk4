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

public class GtkDrawingAreaHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkDrawingAreaHandle New()
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_new();
	}

}

public static class GtkDrawingAreaSignalExtensions
{
	public static GtkDrawingAreaHandle Signal_Resize(this GtkDrawingAreaHandle instance, GtkDrawingAreaSignalDelegates.Resize handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkDrawingAreaSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDrawingAreaHandle>))] GtkDrawingAreaHandle self, int width, int height, IntPtr user_data);
}


public static class GtkDrawingAreaHandleExtensions
{
	public static int GetContentHeight(this GtkDrawingAreaHandle self)
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_get_content_height(self);
	}

	public static int GetContentWidth(this GtkDrawingAreaHandle self)
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_get_content_width(self);
	}

	public static GtkDrawingAreaHandle SetContentHeight(this GtkDrawingAreaHandle self, int height)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_content_height(self, height);
		return self;
	}

	public static GtkDrawingAreaHandle SetContentWidth(this GtkDrawingAreaHandle self, int width)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_content_width(self, width);
		return self;
	}

	public static GtkDrawingAreaHandle SetDrawFunc(this GtkDrawingAreaHandle self, GtkDrawingAreaDrawFunc draw_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_draw_func(self, draw_func, user_data, destroy);
		return self;
	}

}

internal class GtkDrawingAreaExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDrawingAreaHandle gtk_drawing_area_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_drawing_area_get_content_height(GtkDrawingAreaHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_drawing_area_get_content_width(GtkDrawingAreaHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drawing_area_set_content_height(GtkDrawingAreaHandle self, int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drawing_area_set_content_width(GtkDrawingAreaHandle self, int width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drawing_area_set_draw_func(GtkDrawingAreaHandle self, GtkDrawingAreaDrawFunc draw_func, IntPtr user_data, GDestroyNotify destroy);

}
