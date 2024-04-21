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

public interface GtkActionableHandle
{
}

public static class GtkActionableHandleExtensions
{
	public static string GetActionName(this GtkActionableHandle actionable)
	{
		return GtkActionableExterns.gtk_actionable_get_action_name(actionable);
	}

	public static GVariantHandle GetActionTargetValue(this GtkActionableHandle actionable)
	{
		return GtkActionableExterns.gtk_actionable_get_action_target_value(actionable);
	}

	public static GtkActionableHandle SetActionName(this GtkActionableHandle actionable, string action_name)
	{
		GtkActionableExterns.gtk_actionable_set_action_name(actionable, action_name);
		return actionable;
	}

	public static GtkActionableHandle SetActionTarget(this GtkActionableHandle actionable, string format_string, IntPtr @__arglist)
	{
		GtkActionableExterns.gtk_actionable_set_action_target(actionable, format_string, @__arglist);
		return actionable;
	}

	public static GtkActionableHandle SetActionTargetValue(this GtkActionableHandle actionable, GVariantHandle target_value)
	{
		GtkActionableExterns.gtk_actionable_set_action_target_value(actionable, target_value);
		return actionable;
	}

	public static GtkActionableHandle SetDetailedActionName(this GtkActionableHandle actionable, string detailed_action_name)
	{
		GtkActionableExterns.gtk_actionable_set_detailed_action_name(actionable, detailed_action_name);
		return actionable;
	}

}

internal class GtkActionableExterns
{
	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_actionable_get_action_name(GtkActionableHandle actionable);

	[DllImport(Libraries.Gtk4)]
	internal static extern GVariantHandle gtk_actionable_get_action_target_value(GtkActionableHandle actionable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_actionable_set_action_name(GtkActionableHandle actionable, string action_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_actionable_set_action_target(GtkActionableHandle actionable, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_actionable_set_action_target_value(GtkActionableHandle actionable, GVariantHandle target_value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_actionable_set_detailed_action_name(GtkActionableHandle actionable, string detailed_action_name);

}
