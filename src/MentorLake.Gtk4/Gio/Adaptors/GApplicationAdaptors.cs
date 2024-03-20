using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gio;
public static class GApplicationAdaptors
{
	public static string GetApplicationId(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_application_id(application);
	}

	public static GApplicationHandle SetApplicationId(this GApplicationHandle application, string application_id)
	{
		GApplicationExterns.g_application_set_application_id(application, application_id);
		return application;
	}

	public static GDBusConnectionHandle GetDbusConnection(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_connection(application);
	}

	public static string GetDbusObjectPath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_object_path(application);
	}

	public static uint GetInactivityTimeout(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_inactivity_timeout(application);
	}

	public static GApplicationHandle SetInactivityTimeout(this GApplicationHandle application, uint inactivity_timeout)
	{
		GApplicationExterns.g_application_set_inactivity_timeout(application, inactivity_timeout);
		return application;
	}

	public static GApplicationFlags GetFlags(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_flags(application);
	}

	public static GApplicationHandle SetFlags(this GApplicationHandle application, GApplicationFlags flags)
	{
		GApplicationExterns.g_application_set_flags(application, flags);
		return application;
	}

	public static string GetResourceBasePath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_resource_base_path(application);
	}

	public static GApplicationHandle SetResourceBasePath(this GApplicationHandle application, string resource_path)
	{
		GApplicationExterns.g_application_set_resource_base_path(application, resource_path);
		return application;
	}

	public static GApplicationHandle SetActionGroup(this GApplicationHandle application, GActionGroupHandle action_group)
	{
		GApplicationExterns.g_application_set_action_group(application, action_group);
		return application;
	}

	public static GApplicationHandle AddMainOptionEntries(this GApplicationHandle application, GOptionEntryHandle entries)
	{
		GApplicationExterns.g_application_add_main_option_entries(application, entries);
		return application;
	}

	public static GApplicationHandle AddMainOption(this GApplicationHandle application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description)
	{
		GApplicationExterns.g_application_add_main_option(application, long_name, short_name, flags, arg, description, arg_description);
		return application;
	}

	public static GApplicationHandle AddOptionGroup(this GApplicationHandle application, GOptionGroupHandle group)
	{
		GApplicationExterns.g_application_add_option_group(application, group);
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

	public static GApplicationHandle SetOptionContextDescription(this GApplicationHandle application, string description)
	{
		GApplicationExterns.g_application_set_option_context_description(application, description);
		return application;
	}

	public static int GetIsRegistered(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_registered(application);
	}

	public static int GetIsRemote(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_remote(application);
	}

	public static int Register(this GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GApplicationExterns.g_application_register(application, cancellable, out error);
	}

	public static GApplicationHandle Hold(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_hold(application);
		return application;
	}

	public static GApplicationHandle Release(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_release(application);
		return application;
	}

	public static GApplicationHandle Activate(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_activate(application);
		return application;
	}

	public static GApplicationHandle Open(this GApplicationHandle application, out GFileHandle files, int n_files, string hint)
	{
		GApplicationExterns.g_application_open(application, out files, n_files, hint);
		return application;
	}

	public static int Run(this GApplicationHandle application, int argc, string[] argv)
	{
		return GApplicationExterns.g_application_run(application, argc, argv);
	}

	public static GApplicationHandle Quit(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_quit(application);
		return application;
	}

	public static GApplicationHandle SetDefault(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_set_default(application);
		return application;
	}

	public static GApplicationHandle MarkBusy(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_mark_busy(application);
		return application;
	}

	public static GApplicationHandle UnmarkBusy(this GApplicationHandle application)
	{
		GApplicationExterns.g_application_unmark_busy(application);
		return application;
	}

	public static int GetIsBusy(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_busy(application);
	}

	public static GApplicationHandle SendNotification(this GApplicationHandle application, string id, GNotificationHandle notification)
	{
		GApplicationExterns.g_application_send_notification(application, id, notification);
		return application;
	}

	public static GApplicationHandle WithdrawNotification(this GApplicationHandle application, string id)
	{
		GApplicationExterns.g_application_withdraw_notification(application, id);
		return application;
	}

	public static GApplicationHandle BindBusyProperty(this GApplicationHandle application, IntPtr @object, string property)
	{
		GApplicationExterns.g_application_bind_busy_property(application, @object, property);
		return application;
	}

	public static GApplicationHandle UnbindBusyProperty(this GApplicationHandle application, IntPtr @object, string property)
	{
		GApplicationExterns.g_application_unbind_busy_property(application, @object, property);
		return application;
	}
}
