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

public class GAppLaunchContextHandle : GObjectHandle
{
	public static GAppLaunchContextHandle New()
	{
		return GAppLaunchContextExterns.g_app_launch_context_new();
	}
}

public class GAppLaunchContextSignal
{
	public string Value { get; set; }
	public GAppLaunchContextSignal(string value) => Value = value;
}

public static class GAppLaunchContextSignals
{
	public static GAppLaunchContextSignal LaunchFailed = new("launch-failed");
	public static GAppLaunchContextSignal LaunchStarted = new("launch-started");
	public static GAppLaunchContextSignal Launched = new("launched");
}

public static class GAppLaunchContextHandleExtensions
{
	public static string GetDisplay(this GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files)
	{
		return GAppLaunchContextExterns.g_app_launch_context_get_display(context, info, files);
	}

	public static string[] GetEnvironment(this GAppLaunchContextHandle context)
	{
		return GAppLaunchContextExterns.g_app_launch_context_get_environment(context);
	}

	public static string GetStartupNotifyId(this GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files)
	{
		return GAppLaunchContextExterns.g_app_launch_context_get_startup_notify_id(context, info, files);
	}

	public static GAppLaunchContextHandle LaunchFailed(this GAppLaunchContextHandle context, string startup_notify_id)
	{
		GAppLaunchContextExterns.g_app_launch_context_launch_failed(context, startup_notify_id);
		return context;
	}

	public static GAppLaunchContextHandle Setenv(this GAppLaunchContextHandle context, string variable, string value)
	{
		GAppLaunchContextExterns.g_app_launch_context_setenv(context, variable, value);
		return context;
	}

	public static GAppLaunchContextHandle Unsetenv(this GAppLaunchContextHandle context, string variable)
	{
		GAppLaunchContextExterns.g_app_launch_context_unsetenv(context, variable);
		return context;
	}

	public static GAppLaunchContextHandle Connect(this GAppLaunchContextHandle instance, GAppLaunchContextSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GAppLaunchContextExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_launch_context_get_display(GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_app_launch_context_get_environment(GAppLaunchContextHandle context);
	[DllImport(Libraries.Gio)]
	internal static extern string g_app_launch_context_get_startup_notify_id(GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files);
	[DllImport(Libraries.Gio)]
	internal static extern void g_app_launch_context_launch_failed(GAppLaunchContextHandle context, string startup_notify_id);
	[DllImport(Libraries.Gio)]
	internal static extern void g_app_launch_context_setenv(GAppLaunchContextHandle context, string variable, string value);
	[DllImport(Libraries.Gio)]
	internal static extern void g_app_launch_context_unsetenv(GAppLaunchContextHandle context, string variable);
	[DllImport(Libraries.Gio)]
	internal static extern GAppLaunchContextHandle g_app_launch_context_new();
}
