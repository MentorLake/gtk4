using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gdk;

public static class GdkAppLaunchContextExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_app_launch_context_get_display")]
	internal static extern GdkDisplayHandle gdk_app_launch_context_get_display(this GdkAppLaunchContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_app_launch_context_set_desktop")]
	internal static extern void gdk_app_launch_context_set_desktop(this GdkAppLaunchContextHandle context, int desktop);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_app_launch_context_set_timestamp")]
	internal static extern void gdk_app_launch_context_set_timestamp(this GdkAppLaunchContextHandle context, uint timestamp);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_app_launch_context_set_icon")]
	internal static extern void gdk_app_launch_context_set_icon(this GdkAppLaunchContextHandle context, GIconHandle icon);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_app_launch_context_set_icon_name")]
	internal static extern void gdk_app_launch_context_set_icon_name(this GdkAppLaunchContextHandle context, string icon_name);
}
