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

namespace MentorLake.Gtk4.Gio;

public class GDBusObjectSkeletonHandle : GObjectHandle, GDBusObjectHandle
{
	public static GDBusObjectSkeletonHandle GDbusObjectSkeletonNew(string object_path)
	{
		return GDBusObjectSkeletonExterns.g_dbus_object_skeleton_new(object_path);
	}

}

public static class GDBusObjectSkeletonSignalExtensions
{
	public static GDBusObjectSkeletonHandle Signal_AuthorizeMethod(this GDBusObjectSkeletonHandle instance, GDBusObjectSkeletonSignalDelegates.AuthorizeMethod handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "authorize_method", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GDBusObjectSkeletonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool AuthorizeMethod([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusObjectSkeletonHandle>))] GDBusObjectSkeletonHandle self, GDBusInterfaceSkeletonHandle @interface, GDBusMethodInvocationHandle invocation, IntPtr user_data);
}


public static class GDBusObjectSkeletonHandleExtensions
{
	public static GDBusObjectSkeletonHandle GDbusObjectSkeletonAddInterface(this GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_)
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_add_interface(@object, interface_);
		return @object;
	}

	public static GDBusObjectSkeletonHandle GDbusObjectSkeletonFlush(this GDBusObjectSkeletonHandle @object)
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_flush(@object);
		return @object;
	}

	public static GDBusObjectSkeletonHandle GDbusObjectSkeletonRemoveInterface(this GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_)
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_remove_interface(@object, interface_);
		return @object;
	}

	public static GDBusObjectSkeletonHandle GDbusObjectSkeletonRemoveInterfaceByName(this GDBusObjectSkeletonHandle @object, string interface_name)
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_remove_interface_by_name(@object, interface_name);
		return @object;
	}

	public static GDBusObjectSkeletonHandle GDbusObjectSkeletonSetObjectPath(this GDBusObjectSkeletonHandle @object, string object_path)
	{
		GDBusObjectSkeletonExterns.g_dbus_object_skeleton_set_object_path(@object, object_path);
		return @object;
	}

}

internal class GDBusObjectSkeletonExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectSkeletonHandle g_dbus_object_skeleton_new(string object_path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_add_interface(GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_flush(GDBusObjectSkeletonHandle @object);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_remove_interface(GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_remove_interface_by_name(GDBusObjectSkeletonHandle @object, string interface_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_skeleton_set_object_path(GDBusObjectSkeletonHandle @object, string object_path);

}
