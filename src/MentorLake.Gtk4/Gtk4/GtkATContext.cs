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

public class GtkATContextHandle : GObjectHandle
{
	public static GtkATContextHandle GtkAtContextCreate(GtkAccessibleRole accessible_role, GtkAccessibleHandle accessible, GdkDisplayHandle display)
	{
		return GtkATContextExterns.gtk_at_context_create(accessible_role, accessible, display);
	}

}

public static class GtkATContextSignalExtensions
{
	public static GtkATContextHandle Signal_StateChange(this GtkATContextHandle instance, GtkATContextSignalDelegates.StateChange handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "state_change", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkATContextSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void StateChange([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkATContextHandle>))] GtkATContextHandle self, IntPtr user_data);
}


public static class GtkATContextHandleExtensions
{
	public static GtkAccessibleHandle GtkAtContextGetAccessible(this GtkATContextHandle self)
	{
		return GtkATContextExterns.gtk_at_context_get_accessible(self);
	}

	public static GtkAccessibleRole GtkAtContextGetAccessibleRole(this GtkATContextHandle self)
	{
		return GtkATContextExterns.gtk_at_context_get_accessible_role(self);
	}

}

internal class GtkATContextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkATContextHandle gtk_at_context_create(GtkAccessibleRole accessible_role, GtkAccessibleHandle accessible, GdkDisplayHandle display);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleHandle gtk_at_context_get_accessible(GtkATContextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleRole gtk_at_context_get_accessible_role(GtkATContextHandle self);

}
