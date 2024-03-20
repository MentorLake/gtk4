using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gdk;
public static class GdkAppLaunchContextAdaptors
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

    public static GdkAppLaunchContextHandle SetTimestamp(this GdkAppLaunchContextHandle context, uint timestamp)
    {
        GdkAppLaunchContextExterns.gdk_app_launch_context_set_timestamp(context, timestamp);
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
}
