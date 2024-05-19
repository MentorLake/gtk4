using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public class GdkAppLaunchContextHandle : GAppLaunchContextHandle
{
}

public static class GdkAppLaunchContextHandleExtensions
{
	public static GdkDisplayHandle GetDisplay(this GdkAppLaunchContextHandle context)
	{
		return GdkAppLaunchContextExterns.gdk_app_launch_context_get_display(context);
	}

	public static GdkAppLaunchContextHandle SetDesktop(this GdkAppLaunchContextHandle context, int desktop)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_desktop(context, desktop);
		return context;
	}

	public static GdkAppLaunchContextHandle SetIcon(this GdkAppLaunchContextHandle context, GIconHandle icon)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_icon(context, icon);
		return context;
	}

	public static GdkAppLaunchContextHandle SetIconName(this GdkAppLaunchContextHandle context, string icon_name)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_icon_name(context, icon_name);
		return context;
	}

	public static GdkAppLaunchContextHandle SetTimestamp(this GdkAppLaunchContextHandle context, uint timestamp)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_timestamp(context, timestamp);
		return context;
	}

}

internal class GdkAppLaunchContextExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_app_launch_context_get_display(GdkAppLaunchContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_app_launch_context_set_desktop(GdkAppLaunchContextHandle context, int desktop);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_app_launch_context_set_icon(GdkAppLaunchContextHandle context, GIconHandle icon);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_app_launch_context_set_icon_name(GdkAppLaunchContextHandle context, string icon_name);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_app_launch_context_set_timestamp(GdkAppLaunchContextHandle context, uint timestamp);

}
