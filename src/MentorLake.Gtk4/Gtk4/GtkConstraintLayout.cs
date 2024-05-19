namespace MentorLake.Gtk4.Gtk4;

public class GtkConstraintLayoutHandle : GtkLayoutManagerHandle, GtkBuildableHandle
{
	public static GtkConstraintLayoutHandle New()
	{
		return GtkConstraintLayoutExterns.gtk_constraint_layout_new();
	}

}

public static class GtkConstraintLayoutHandleExtensions
{
	public static GtkConstraintLayoutHandle AddConstraint(this GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint)
	{
		GtkConstraintLayoutExterns.gtk_constraint_layout_add_constraint(layout, constraint);
		return layout;
	}

	public static GListHandle AddConstraintsFromDescription(this GtkConstraintLayoutHandle layout, string lines, int n_lines, int hspacing, int vspacing, out GErrorHandle error, string first_view, IntPtr @__arglist)
	{
		return GtkConstraintLayoutExterns.gtk_constraint_layout_add_constraints_from_description(layout, lines, n_lines, hspacing, vspacing, out error, first_view, @__arglist);
	}

	public static GListHandle AddConstraintsFromDescriptionv(this GtkConstraintLayoutHandle layout, string lines, int n_lines, int hspacing, int vspacing, GHashTableHandle views, out GErrorHandle error)
	{
		return GtkConstraintLayoutExterns.gtk_constraint_layout_add_constraints_from_descriptionv(layout, lines, n_lines, hspacing, vspacing, views, out error);
	}

	public static GtkConstraintLayoutHandle AddGuide(this GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide)
	{
		GtkConstraintLayoutExterns.gtk_constraint_layout_add_guide(layout, guide);
		return layout;
	}

	public static GListModelHandle ObserveConstraints(this GtkConstraintLayoutHandle layout)
	{
		return GtkConstraintLayoutExterns.gtk_constraint_layout_observe_constraints(layout);
	}

	public static GListModelHandle ObserveGuides(this GtkConstraintLayoutHandle layout)
	{
		return GtkConstraintLayoutExterns.gtk_constraint_layout_observe_guides(layout);
	}

	public static GtkConstraintLayoutHandle RemoveAllConstraints(this GtkConstraintLayoutHandle layout)
	{
		GtkConstraintLayoutExterns.gtk_constraint_layout_remove_all_constraints(layout);
		return layout;
	}

	public static GtkConstraintLayoutHandle RemoveConstraint(this GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint)
	{
		GtkConstraintLayoutExterns.gtk_constraint_layout_remove_constraint(layout, constraint);
		return layout;
	}

	public static GtkConstraintLayoutHandle RemoveGuide(this GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide)
	{
		GtkConstraintLayoutExterns.gtk_constraint_layout_remove_guide(layout, guide);
		return layout;
	}

}

internal class GtkConstraintLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintLayoutHandle gtk_constraint_layout_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_layout_add_constraint(GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_constraint_layout_add_constraints_from_description(GtkConstraintLayoutHandle layout, string lines, int n_lines, int hspacing, int vspacing, out GErrorHandle error, string first_view, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_constraint_layout_add_constraints_from_descriptionv(GtkConstraintLayoutHandle layout, string lines, int n_lines, int hspacing, int vspacing, GHashTableHandle views, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_layout_add_guide(GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_constraint_layout_observe_constraints(GtkConstraintLayoutHandle layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_constraint_layout_observe_guides(GtkConstraintLayoutHandle layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_layout_remove_all_constraints(GtkConstraintLayoutHandle layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_layout_remove_constraint(GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_layout_remove_guide(GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide);

}
