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

public class GNotificationHandle : GObjectHandle
{
	public static GNotificationHandle New(string title)
	{
		return GNotificationExterns.g_notification_new(title);
	}

}

public static class GNotificationHandleExtensions
{
	public static GNotificationHandle AddButton(this GNotificationHandle notification, string label, string detailed_action)
	{
		GNotificationExterns.g_notification_add_button(notification, label, detailed_action);
		return notification;
	}

	public static GNotificationHandle AddButtonWithTarget(this GNotificationHandle notification, string label, string action, string target_format, IntPtr @__arglist)
	{
		GNotificationExterns.g_notification_add_button_with_target(notification, label, action, target_format, @__arglist);
		return notification;
	}

	public static GNotificationHandle AddButtonWithTargetValue(this GNotificationHandle notification, string label, string action, GVariantHandle target)
	{
		GNotificationExterns.g_notification_add_button_with_target_value(notification, label, action, target);
		return notification;
	}

	public static GNotificationHandle SetBody(this GNotificationHandle notification, string body)
	{
		GNotificationExterns.g_notification_set_body(notification, body);
		return notification;
	}

	public static GNotificationHandle SetCategory(this GNotificationHandle notification, string category)
	{
		GNotificationExterns.g_notification_set_category(notification, category);
		return notification;
	}

	public static GNotificationHandle SetDefaultAction(this GNotificationHandle notification, string detailed_action)
	{
		GNotificationExterns.g_notification_set_default_action(notification, detailed_action);
		return notification;
	}

	public static GNotificationHandle SetDefaultActionAndTarget(this GNotificationHandle notification, string action, string target_format, IntPtr @__arglist)
	{
		GNotificationExterns.g_notification_set_default_action_and_target(notification, action, target_format, @__arglist);
		return notification;
	}

	public static GNotificationHandle SetDefaultActionAndTargetValue(this GNotificationHandle notification, string action, GVariantHandle target)
	{
		GNotificationExterns.g_notification_set_default_action_and_target_value(notification, action, target);
		return notification;
	}

	public static GNotificationHandle SetIcon(this GNotificationHandle notification, GIconHandle icon)
	{
		GNotificationExterns.g_notification_set_icon(notification, icon);
		return notification;
	}

	public static GNotificationHandle SetPriority(this GNotificationHandle notification, GNotificationPriority priority)
	{
		GNotificationExterns.g_notification_set_priority(notification, priority);
		return notification;
	}

	public static GNotificationHandle SetTitle(this GNotificationHandle notification, string title)
	{
		GNotificationExterns.g_notification_set_title(notification, title);
		return notification;
	}

	public static GNotificationHandle SetUrgent(this GNotificationHandle notification, bool urgent)
	{
		GNotificationExterns.g_notification_set_urgent(notification, urgent);
		return notification;
	}

}

internal class GNotificationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GNotificationHandle g_notification_new(string title);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_add_button(GNotificationHandle notification, string label, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_add_button_with_target(GNotificationHandle notification, string label, string action, string target_format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_add_button_with_target_value(GNotificationHandle notification, string label, string action, GVariantHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_body(GNotificationHandle notification, string body);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_category(GNotificationHandle notification, string category);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_default_action(GNotificationHandle notification, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_default_action_and_target(GNotificationHandle notification, string action, string target_format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_default_action_and_target_value(GNotificationHandle notification, string action, GVariantHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_icon(GNotificationHandle notification, GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_priority(GNotificationHandle notification, GNotificationPriority priority);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_title(GNotificationHandle notification, string title);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_urgent(GNotificationHandle notification, bool urgent);

}
