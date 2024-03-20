using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkConstraintGuideExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_set_min_size")]
    internal static extern void gtk_constraint_guide_set_min_size(this GtkConstraintGuideHandle guide, int width, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_get_min_size")]
    internal static extern void gtk_constraint_guide_get_min_size(this GtkConstraintGuideHandle guide, out int width, out int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_set_nat_size")]
    internal static extern void gtk_constraint_guide_set_nat_size(this GtkConstraintGuideHandle guide, int width, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_get_nat_size")]
    internal static extern void gtk_constraint_guide_get_nat_size(this GtkConstraintGuideHandle guide, out int width, out int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_set_max_size")]
    internal static extern void gtk_constraint_guide_set_max_size(this GtkConstraintGuideHandle guide, int width, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_get_max_size")]
    internal static extern void gtk_constraint_guide_get_max_size(this GtkConstraintGuideHandle guide, out int width, out int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_get_strength")]
    internal static extern GtkConstraintStrength gtk_constraint_guide_get_strength(this GtkConstraintGuideHandle guide);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_set_strength")]
    internal static extern void gtk_constraint_guide_set_strength(this GtkConstraintGuideHandle guide, GtkConstraintStrength strength);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_set_name")]
    internal static extern void gtk_constraint_guide_set_name(this GtkConstraintGuideHandle guide, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_guide_get_name")]
    internal static extern string gtk_constraint_guide_get_name(this GtkConstraintGuideHandle guide);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkConstraintGuideHandle gtk_constraint_guide_new();
}
