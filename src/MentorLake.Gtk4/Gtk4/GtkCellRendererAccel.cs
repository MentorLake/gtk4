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

public class GtkCellRendererAccelHandle : GtkCellRendererTextHandle
{
	public static GtkCellRendererAccelHandle New()
	{
		return GtkCellRendererAccelExterns.gtk_cell_renderer_accel_new();
	}

}

public class GtkCellRendererAccelSignal
{
	public string Value { get; set; }
	public GtkCellRendererAccelSignal(string value) => Value = value;
}

public static class GtkCellRendererAccelSignals
{
	public static GtkCellRendererAccelSignal AccelCleared = new("BindingTransform.MethodDeclaration");
	public static GtkCellRendererAccelSignal AccelEdited = new("BindingTransform.MethodDeclaration");
}

public static class GtkCellRendererAccelHandleExtensions
{
	public static GtkCellRendererAccelHandle Signal_AccelCleared(this GtkCellRendererAccelHandle instance, GtkCellRendererAccelDelegates.AccelCleared handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "accel_cleared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCellRendererAccelHandle Signal_AccelEdited(this GtkCellRendererAccelHandle instance, GtkCellRendererAccelDelegates.AccelEdited handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "accel_edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkCellRendererAccelDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AccelCleared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererAccelHandle>))] GtkCellRendererAccelHandle self, string path_string, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AccelEdited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererAccelHandle>))] GtkCellRendererAccelHandle self, string path_string, uint accel_key, GdkModifierType accel_mods, uint hardware_keycode, IntPtr user_data);
}

internal class GtkCellRendererAccelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererAccelHandle gtk_cell_renderer_accel_new();

}
