using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkActionableAdaptors
{
    public static string GetActionName(this GtkActionableHandle actionable)
    {
        return GtkActionableExterns.gtk_actionable_get_action_name(actionable);
    }

    public static GtkActionableHandle SetActionName(this GtkActionableHandle actionable, string action_name)
    {
        GtkActionableExterns.gtk_actionable_set_action_name(actionable, action_name);
        return actionable;
    }

    public static GVariantHandle GetActionTargetValue(this GtkActionableHandle actionable)
    {
        return GtkActionableExterns.gtk_actionable_get_action_target_value(actionable);
    }

    public static GtkActionableHandle SetActionTargetValue(this GtkActionableHandle actionable, GVariantHandle target_value)
    {
        GtkActionableExterns.gtk_actionable_set_action_target_value(actionable, target_value);
        return actionable;
    }

    public static GtkActionableHandle SetActionTarget(this GtkActionableHandle actionable, string format_string, IntPtr @__argList)
    {
        GtkActionableExterns.gtk_actionable_set_action_target(actionable, format_string, @__argList);
        return actionable;
    }

    public static GtkActionableHandle SetDetailedActionName(this GtkActionableHandle actionable, string detailed_action_name)
    {
        GtkActionableExterns.gtk_actionable_set_detailed_action_name(actionable, detailed_action_name);
        return actionable;
    }
}
