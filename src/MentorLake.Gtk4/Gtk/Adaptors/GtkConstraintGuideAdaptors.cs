using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkConstraintGuideAdaptors
{
	public static GtkConstraintGuideHandle SetMinSize(this GtkConstraintGuideHandle guide, int width, int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_min_size(guide, width, height);
		return guide;
	}

	public static GtkConstraintGuideHandle GetMinSize(this GtkConstraintGuideHandle guide, out int width, out int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_get_min_size(guide, out width, out height);
		return guide;
	}

	public static GtkConstraintGuideHandle SetNatSize(this GtkConstraintGuideHandle guide, int width, int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_nat_size(guide, width, height);
		return guide;
	}

	public static GtkConstraintGuideHandle GetNatSize(this GtkConstraintGuideHandle guide, out int width, out int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_get_nat_size(guide, out width, out height);
		return guide;
	}

	public static GtkConstraintGuideHandle SetMaxSize(this GtkConstraintGuideHandle guide, int width, int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_max_size(guide, width, height);
		return guide;
	}

	public static GtkConstraintGuideHandle GetMaxSize(this GtkConstraintGuideHandle guide, out int width, out int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_get_max_size(guide, out width, out height);
		return guide;
	}

	public static GtkConstraintStrength GetStrength(this GtkConstraintGuideHandle guide)
	{
		return GtkConstraintGuideExterns.gtk_constraint_guide_get_strength(guide);
	}

	public static GtkConstraintGuideHandle SetStrength(this GtkConstraintGuideHandle guide, GtkConstraintStrength strength)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_strength(guide, strength);
		return guide;
	}

	public static GtkConstraintGuideHandle SetName(this GtkConstraintGuideHandle guide, string name)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_name(guide, name);
		return guide;
	}

	public static string GetName(this GtkConstraintGuideHandle guide)
	{
		return GtkConstraintGuideExterns.gtk_constraint_guide_get_name(guide);
	}
}
