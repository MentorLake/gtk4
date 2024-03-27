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

public class GApplicationHandle : GObjectHandle
{
	public static GApplicationHandle New(string application_id, GApplicationFlags flags)
	{
		return GApplicationExterns.g_application_new(application_id, flags);
	}
}

public class GApplicationSignal
{
	public string Value { get; set; }
	public GApplicationSignal(string value) => Value = value;
}

public static class GApplicationSignals
{
	public static GApplicationSignal Activate = new("activate");
	public static GApplicationSignal CommandLine = new("command-line");
	public static GApplicationSignal HandleLocalOptions = new("handle-local-options");
	public static GApplicationSignal NameLost = new("name-lost");
	public static GApplicationSignal Open = new("open");
	public static GApplicationSignal Shutdown = new("shutdown");
	public static GApplicationSignal Startup = new("startup");
}

public static class GApplicationHandleExtensions
{
	public static GApplicationHandle Activate(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_activate(application);
		return application;
	}

	public static GApplicationHandle AddMainOption(this GApplicationHandle application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description)
	{
		GApplicationExterns.g_application_add_main_option(application, long_name, short_name, flags, arg, description, arg_description);
		return application;
	}

	public static GApplicationHandle AddMainOptionEntries(this GApplicationHandle application, GOptionEntry[] entries)
	{
		GApplicationExterns.g_application_add_main_option_entries(application, entries);
		return application;
	}

	public static GApplicationHandle AddOptionGroup(this GApplicationHandle application, GOptionGroupHandle group)
	{
		GApplicationExterns.g_application_add_option_group(application, group);
		return application;
	}

	public static GApplicationHandle BindBusyProperty(this GApplicationHandle application, GObjectHandle @object, string property)
	{
		GApplicationExterns.g_application_bind_busy_property(application, @object, property);
		return application;
	}

	public static string GetApplicationId(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_application_id(application);
	}

	public static GDBusConnectionHandle GetDbusConnection(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_connection(application);
	}

	public static string GetDbusObjectPath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_object_path(application);
	}

	public static GApplicationFlags GetFlags(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_flags(application);
	}

	public static uint GetInactivityTimeout(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_inactivity_timeout(application);
	}

	public static bool GetIsBusy(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_busy(application);
	}

	public static bool GetIsRegistered(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_registered(application);
	}

	public static bool GetIsRemote(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_remote(application);
	}

	public static string GetResourceBasePath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_resource_base_path(application);
	}

	public static string GetVersion(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_version(application);
	}

	public static GApplicationHandle Hold(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_hold(application);
		return application;
	}

	public static GApplicationHandle MarkBusy(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_mark_busy(application);
		return application;
	}

	public static GApplicationHandle Open(this GApplicationHandle application, GFileHandle[] files, int n_files, string hint)
	{
		GApplicationExterns.g_application_open(application, files, n_files, hint);
		return application;
	}

	public static GApplicationHandle Quit(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_quit(application);
		return application;
	}

	public static bool Register(this GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GApplicationExterns.g_application_register(application, cancellable, out error);
	}

	public static GApplicationHandle Release(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_release(application);
		return application;
	}

	public static int Run(this GApplicationHandle application, int argc, string[] argv)
	{
		return GApplicationExterns.g_application_run(application, argc, argv);
	}

	public static GApplicationHandle SendNotification(this GApplicationHandle application, string id, GNotificationHandle notification)
	{
		GApplicationExterns.g_application_send_notification(application, id, notification);
		return application;
	}

	public static GApplicationHandle SetActionGroup(this GApplicationHandle application, GActionGroupHandle action_group)
	{
		GApplicationExterns.g_application_set_action_group(application, action_group);
		return application;
	}

	public static GApplicationHandle SetApplicationId(this GApplicationHandle application, string application_id)
	{
		GApplicationExterns.g_application_set_application_id(application, application_id);
		return application;
	}

	public static GApplicationHandle SetDefault(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_set_default(application);
		return application;
	}

	public static GApplicationHandle SetFlags(this GApplicationHandle application, GApplicationFlags flags)
	{
		GApplicationExterns.g_application_set_flags(application, flags);
		return application;
	}

	public static GApplicationHandle SetInactivityTimeout(this GApplicationHandle application, uint inactivity_timeout)
	{
		GApplicationExterns.g_application_set_inactivity_timeout(application, inactivity_timeout);
		return application;
	}

	public static GApplicationHandle SetOptionContextDescription(this GApplicationHandle application, string description)
	{
		GApplicationExterns.g_application_set_option_context_description(application, description);
		return application;
	}

	public static GApplicationHandle SetOptionContextParameterString(this GApplicationHandle application, string parameter_string)
	{
		GApplicationExterns.g_application_set_option_context_parameter_string(application, parameter_string);
		return application;
	}

	public static GApplicationHandle SetOptionContextSummary(this GApplicationHandle application, string summary)
	{
		GApplicationExterns.g_application_set_option_context_summary(application, summary);
		return application;
	}

	public static GApplicationHandle SetResourceBasePath(this GApplicationHandle application, string resource_path)
	{
		GApplicationExterns.g_application_set_resource_base_path(application, resource_path);
		return application;
	}

	public static GApplicationHandle SetVersion(this GApplicationHandle application, string version)
	{
		GApplicationExterns.g_application_set_version(application, version);
		return application;
	}

	public static GApplicationHandle UnbindBusyProperty(this GApplicationHandle application, GObjectHandle @object, string property)
	{
		GApplicationExterns.g_application_unbind_busy_property(application, @object, property);
		return application;
	}

	public static GApplicationHandle UnmarkBusy(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_unmark_busy(application);
		return application;
	}

	public static GApplicationHandle WithdrawNotification(this GApplicationHandle application, string id)
	{
		GApplicationExterns.g_application_withdraw_notification(application, id);
		return application;
	}

	public static GApplicationHandle Connect(this GApplicationHandle instance, GApplicationSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GApplicationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_activate(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_main_option(GApplicationHandle application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_main_option_entries(GApplicationHandle application, GOptionEntry[] entries);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_option_group(GApplicationHandle application, GOptionGroupHandle group);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_bind_busy_property(GApplicationHandle application, GObjectHandle @object, string property);
	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_application_id(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_application_get_dbus_connection(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_dbus_object_path(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern GApplicationFlags g_application_get_flags(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_application_get_inactivity_timeout(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_busy(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_registered(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_remote(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_resource_base_path(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_version(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_hold(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_mark_busy(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_open(GApplicationHandle application, GFileHandle[] files, int n_files, string hint);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_quit(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_register(GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_release(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern int g_application_run(GApplicationHandle application, int argc, string[] argv);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_send_notification(GApplicationHandle application, string id, GNotificationHandle notification);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_action_group(GApplicationHandle application, GActionGroupHandle action_group);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_application_id(GApplicationHandle application, string application_id);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_default(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_flags(GApplicationHandle application, GApplicationFlags flags);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_inactivity_timeout(GApplicationHandle application, uint inactivity_timeout);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_description(GApplicationHandle application, string description);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_parameter_string(GApplicationHandle application, string parameter_string);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_summary(GApplicationHandle application, string summary);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_resource_base_path(GApplicationHandle application, string resource_path);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_version(GApplicationHandle application, string version);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_unbind_busy_property(GApplicationHandle application, GObjectHandle @object, string property);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_unmark_busy(GApplicationHandle application);
	[DllImport(Libraries.Gio)]
	internal static extern void g_application_withdraw_notification(GApplicationHandle application, string id);
	[DllImport(Libraries.Gio)]
	internal static extern GApplicationHandle g_application_new(string application_id, GApplicationFlags flags);
}
