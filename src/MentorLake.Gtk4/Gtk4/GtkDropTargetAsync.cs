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

public class GtkDropTargetAsyncHandle : GtkEventControllerHandle
{
	public static GtkDropTargetAsyncHandle New(GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_new(formats, actions);
	}

}

public class GtkDropTargetAsyncSignal
{
	public string Value { get; set; }
	public GtkDropTargetAsyncSignal(string value) => Value = value;
}

public static class GtkDropTargetAsyncSignals
{
	public static GtkDropTargetAsyncSignal Accept = new("BindingTransform.MethodDeclaration");
	public static GtkDropTargetAsyncSignal DragEnter = new("BindingTransform.MethodDeclaration");
	public static GtkDropTargetAsyncSignal DragLeave = new("BindingTransform.MethodDeclaration");
	public static GtkDropTargetAsyncSignal DragMotion = new("BindingTransform.MethodDeclaration");
	public static GtkDropTargetAsyncSignal Drop = new("BindingTransform.MethodDeclaration");
}

public static class GtkDropTargetAsyncHandleExtensions
{
	public static GdkDragAction GetActions(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_actions(self);
	}

	public static GdkContentFormatsHandle GetFormats(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_formats(self);
	}

	public static GtkDropTargetAsyncHandle RejectDrop(this GtkDropTargetAsyncHandle self, GdkDropHandle drop)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_reject_drop(self, drop);
		return self;
	}

	public static GtkDropTargetAsyncHandle SetActions(this GtkDropTargetAsyncHandle self, GdkDragAction actions)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_actions(self, actions);
		return self;
	}

	public static GtkDropTargetAsyncHandle SetFormats(this GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_formats(self, formats);
		return self;
	}

	public static GtkDropTargetAsyncHandle Signal_Accept(this GtkDropTargetAsyncHandle instance, GtkDropTargetAsyncDelegates.Accept handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "accept", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkDropTargetAsyncHandle Signal_DragEnter(this GtkDropTargetAsyncHandle instance, GtkDropTargetAsyncDelegates.DragEnter handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drag_enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkDropTargetAsyncHandle Signal_DragLeave(this GtkDropTargetAsyncHandle instance, GtkDropTargetAsyncDelegates.DragLeave handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drag_leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkDropTargetAsyncHandle Signal_DragMotion(this GtkDropTargetAsyncHandle instance, GtkDropTargetAsyncDelegates.DragMotion handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drag_motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkDropTargetAsyncHandle Signal_Drop(this GtkDropTargetAsyncHandle instance, GtkDropTargetAsyncDelegates.Drop handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkDropTargetAsyncDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Accept([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, GdkDropHandle drop, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GdkDragAction DragEnter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, GdkDropHandle drop, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragLeave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, GdkDropHandle drop, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GdkDragAction DragMotion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, GdkDropHandle drop, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropTargetAsyncHandle>))] GtkDropTargetAsyncHandle self, GdkDropHandle drop, double x, double y, IntPtr user_data);
}

internal class GtkDropTargetAsyncExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropTargetAsyncHandle gtk_drop_target_async_new(GdkContentFormatsHandle formats, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragAction gtk_drop_target_async_get_actions(GtkDropTargetAsyncHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentFormatsHandle gtk_drop_target_async_get_formats(GtkDropTargetAsyncHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_reject_drop(GtkDropTargetAsyncHandle self, GdkDropHandle drop);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_set_actions(GtkDropTargetAsyncHandle self, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_set_formats(GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats);

}
