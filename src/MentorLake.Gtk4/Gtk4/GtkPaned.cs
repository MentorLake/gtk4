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

public class GtkPanedHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkPanedHandle New(GtkOrientation orientation)
	{
		return GtkPanedExterns.gtk_paned_new(orientation);
	}

}

public static class GtkPanedSignalExtensions
{
	public static GtkPanedHandle Signal_AcceptPosition(this GtkPanedHandle instance, GtkPanedSignalDelegates.AcceptPosition handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "accept_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkPanedHandle Signal_CancelPosition(this GtkPanedHandle instance, GtkPanedSignalDelegates.CancelPosition handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "cancel_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkPanedHandle Signal_CycleChildFocus(this GtkPanedHandle instance, GtkPanedSignalDelegates.CycleChildFocus handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "cycle_child_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkPanedHandle Signal_CycleHandleFocus(this GtkPanedHandle instance, GtkPanedSignalDelegates.CycleHandleFocus handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "cycle_handle_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkPanedHandle Signal_MoveHandle(this GtkPanedHandle instance, GtkPanedSignalDelegates.MoveHandle handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "move_handle", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkPanedHandle Signal_ToggleHandleFocus(this GtkPanedHandle instance, GtkPanedSignalDelegates.ToggleHandleFocus handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "toggle_handle_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkPanedSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool AcceptPosition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool CancelPosition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool CycleChildFocus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, bool reversed, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool CycleHandleFocus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, bool reversed, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool MoveHandle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, ref GtkScrollType scroll_type, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool ToggleHandleFocus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);
}


public static class GtkPanedHandleExtensions
{
	public static GtkWidgetHandle GetEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_end_child(paned);
	}

	public static int GetPosition(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_position(paned);
	}

	public static bool GetResizeEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_end_child(paned);
	}

	public static bool GetResizeStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_start_child(paned);
	}

	public static bool GetShrinkEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_end_child(paned);
	}

	public static bool GetShrinkStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_start_child(paned);
	}

	public static GtkWidgetHandle GetStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_start_child(paned);
	}

	public static bool GetWideHandle(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_wide_handle(paned);
	}

	public static GtkPanedHandle SetEndChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_end_child(paned, child);
		return paned;
	}

	public static GtkPanedHandle SetPosition(this GtkPanedHandle paned, int position)
	{
		GtkPanedExterns.gtk_paned_set_position(paned, position);
		return paned;
	}

	public static GtkPanedHandle SetResizeEndChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_end_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetResizeStartChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_start_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetShrinkEndChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_end_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetShrinkStartChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_start_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetStartChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_start_child(paned, child);
		return paned;
	}

	public static GtkPanedHandle SetWideHandle(this GtkPanedHandle paned, bool wide)
	{
		GtkPanedExterns.gtk_paned_set_wide_handle(paned, wide);
		return paned;
	}

}

internal class GtkPanedExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPanedHandle gtk_paned_new(GtkOrientation orientation);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_paned_get_end_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_paned_get_position(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_resize_end_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_resize_start_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_shrink_end_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_shrink_start_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_paned_get_start_child(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_wide_handle(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_end_child(GtkPanedHandle paned, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_position(GtkPanedHandle paned, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_resize_end_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_resize_start_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_shrink_end_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_shrink_start_child(GtkPanedHandle paned, bool resize);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_start_child(GtkPanedHandle paned, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_wide_handle(GtkPanedHandle paned, bool wide);

}
