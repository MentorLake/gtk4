using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkConstraintLayoutAdaptors
{
    public static GtkConstraintLayoutHandle AddConstraint(this GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint)
    {
        GtkConstraintLayoutExterns.gtk_constraint_layout_add_constraint(layout, constraint);
        return layout;
    }

    public static GtkConstraintLayoutHandle RemoveConstraint(this GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint)
    {
        GtkConstraintLayoutExterns.gtk_constraint_layout_remove_constraint(layout, constraint);
        return layout;
    }

    public static GtkConstraintLayoutHandle AddGuide(this GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide)
    {
        GtkConstraintLayoutExterns.gtk_constraint_layout_add_guide(layout, guide);
        return layout;
    }

    public static GtkConstraintLayoutHandle RemoveGuide(this GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide)
    {
        GtkConstraintLayoutExterns.gtk_constraint_layout_remove_guide(layout, guide);
        return layout;
    }

    public static GtkConstraintLayoutHandle RemoveAllConstraints(this GtkConstraintLayoutHandle layout)
    {
        GtkConstraintLayoutExterns.gtk_constraint_layout_remove_all_constraints(layout);
        return layout;
    }

    public static GListHandle AddConstraintsFromDescription(this GtkConstraintLayoutHandle layout, string[] lines, nuint n_lines, int hspacing, int vspacing, out GErrorHandle error, string first_view, IntPtr @__argList)
    {
        return GtkConstraintLayoutExterns.gtk_constraint_layout_add_constraints_from_description(layout, lines, n_lines, hspacing, vspacing, out error, first_view, @__argList);
    }

    public static GListHandle AddConstraintsFromDescriptionv(this GtkConstraintLayoutHandle layout, string[] lines, nuint n_lines, int hspacing, int vspacing, GHashTableHandle views, out GErrorHandle error)
    {
        return GtkConstraintLayoutExterns.gtk_constraint_layout_add_constraints_from_descriptionv(layout, lines, n_lines, hspacing, vspacing, views, out error);
    }

    public static GListModelHandle ObserveConstraints(this GtkConstraintLayoutHandle layout)
    {
        return GtkConstraintLayoutExterns.gtk_constraint_layout_observe_constraints(layout);
    }

    public static GListModelHandle ObserveGuides(this GtkConstraintLayoutHandle layout)
    {
        return GtkConstraintLayoutExterns.gtk_constraint_layout_observe_guides(layout);
    }
}
