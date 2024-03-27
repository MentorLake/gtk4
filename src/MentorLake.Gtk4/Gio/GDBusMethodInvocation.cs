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

public class GDBusMethodInvocationHandle : GObjectHandle
{
}

public static class GDBusMethodInvocationSignals
{
}

public static class GDBusMethodInvocationHandleExtensions
{
	public static GDBusConnectionHandle GDbusMethodInvocationGetConnection(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_connection(invocation);
	}

	public static string GDbusMethodInvocationGetInterfaceName(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_interface_name(invocation);
	}

	public static GDBusMessageHandle GDbusMethodInvocationGetMessage(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_message(invocation);
	}

	public static GDBusMethodInfoHandle GDbusMethodInvocationGetMethodInfo(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_method_info(invocation);
	}

	public static string GDbusMethodInvocationGetMethodName(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_method_name(invocation);
	}

	public static string GDbusMethodInvocationGetObjectPath(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_object_path(invocation);
	}

	public static GVariantHandle GDbusMethodInvocationGetParameters(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_parameters(invocation);
	}

	public static GDBusPropertyInfoHandle GDbusMethodInvocationGetPropertyInfo(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_property_info(invocation);
	}

	public static string GDbusMethodInvocationGetSender(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_sender(invocation);
	}

	public static IntPtr GDbusMethodInvocationGetUserData(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_user_data(invocation);
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationReturnDbusError(this GDBusMethodInvocationHandle invocation, string error_name, string error_message)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_dbus_error(invocation, error_name, error_message);
		return invocation;
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationReturnError(this GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_error(invocation, domain, code, format, @__arglist);
		return invocation;
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationReturnErrorLiteral(this GDBusMethodInvocationHandle invocation, GQuark domain, int code, string message)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_error_literal(invocation, domain, code, message);
		return invocation;
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationReturnErrorValist(this GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, IntPtr var_args)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_error_valist(invocation, domain, code, format, var_args);
		return invocation;
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationReturnGerror(this GDBusMethodInvocationHandle invocation, GErrorHandle error)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_gerror(invocation, error);
		return invocation;
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationReturnValue(this GDBusMethodInvocationHandle invocation, GVariantHandle parameters)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_value(invocation, parameters);
		return invocation;
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationReturnValueWithUnixFdList(this GDBusMethodInvocationHandle invocation, GVariantHandle parameters, GUnixFDListHandle fd_list)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_value_with_unix_fd_list(invocation, parameters, fd_list);
		return invocation;
	}

	public static GDBusMethodInvocationHandle GDbusMethodInvocationTakeError(this GDBusMethodInvocationHandle invocation, GErrorHandle error)
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_take_error(invocation, error);
		return invocation;
	}

}

internal class GDBusMethodInvocationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_method_invocation_get_connection(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_interface_name(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_method_invocation_get_message(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMethodInfoHandle g_dbus_method_invocation_get_method_info(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_method_name(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_object_path(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_method_invocation_get_parameters(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusPropertyInfoHandle g_dbus_method_invocation_get_property_info(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_sender(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_dbus_method_invocation_get_user_data(GDBusMethodInvocationHandle invocation);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_dbus_error(GDBusMethodInvocationHandle invocation, string error_name, string error_message);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_error(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, IntPtr @__arglist);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_error_literal(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string message);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_error_valist(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, IntPtr var_args);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_gerror(GDBusMethodInvocationHandle invocation, GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_value(GDBusMethodInvocationHandle invocation, GVariantHandle parameters);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_value_with_unix_fd_list(GDBusMethodInvocationHandle invocation, GVariantHandle parameters, GUnixFDListHandle fd_list);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_take_error(GDBusMethodInvocationHandle invocation, GErrorHandle error);
}
