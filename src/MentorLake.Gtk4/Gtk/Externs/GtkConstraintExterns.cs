using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkConstraintExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_target")]
    internal static extern GtkConstraintTargetHandle gtk_constraint_get_target(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_target_attribute")]
    internal static extern GtkConstraintAttribute gtk_constraint_get_target_attribute(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_source")]
    internal static extern GtkConstraintTargetHandle gtk_constraint_get_source(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_source_attribute")]
    internal static extern GtkConstraintAttribute gtk_constraint_get_source_attribute(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_relation")]
    internal static extern GtkConstraintRelation gtk_constraint_get_relation(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_multiplier")]
    internal static extern double gtk_constraint_get_multiplier(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_constant")]
    internal static extern double gtk_constraint_get_constant(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_get_strength")]
    internal static extern int gtk_constraint_get_strength(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_is_required")]
    internal static extern int gtk_constraint_is_required(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_is_attached")]
    internal static extern int gtk_constraint_is_attached(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_is_constant")]
    internal static extern int gtk_constraint_is_constant(this GtkConstraintHandle constraint);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkConstraintHandle gtk_constraint_new(IntPtr target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, IntPtr source, GtkConstraintAttribute source_attribute, double multiplier, double constant, int strength);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkConstraintHandle gtk_constraint_new_constant(IntPtr target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, double constant, int strength);
}
