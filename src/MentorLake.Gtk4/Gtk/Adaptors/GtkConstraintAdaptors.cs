using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkConstraintAdaptors
{
	public static GtkConstraintTargetHandle GetTarget(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_target(constraint);
	}

	public static GtkConstraintAttribute GetTargetAttribute(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_target_attribute(constraint);
	}

	public static GtkConstraintTargetHandle GetSource(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_source(constraint);
	}

	public static GtkConstraintAttribute GetSourceAttribute(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_source_attribute(constraint);
	}

	public static GtkConstraintRelation GetRelation(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_relation(constraint);
	}

	public static double GetMultiplier(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_multiplier(constraint);
	}

	public static double GetConstant(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_constant(constraint);
	}

	public static int GetStrength(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_strength(constraint);
	}

	public static int IsRequired(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_is_required(constraint);
	}

	public static int IsAttached(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_is_attached(constraint);
	}

	public static int IsConstant(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_is_constant(constraint);
	}

	public static GtkConstraintHandle NewConstant(IntPtr target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, double constant, int strength)
	{
		return GtkConstraintExterns.gtk_constraint_new_constant(target, target_attribute, relation, constant, strength);
	}
}
