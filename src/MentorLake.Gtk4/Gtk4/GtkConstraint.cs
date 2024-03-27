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

public class GtkConstraintHandle : GObjectHandle
{
	public static GtkConstraintHandle New(GtkConstraintTargetHandle target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, GtkConstraintTargetHandle source, GtkConstraintAttribute source_attribute, double multiplier, double constant, int strength)
	{
		return GtkConstraintExterns.gtk_constraint_new(target, target_attribute, relation, source, source_attribute, multiplier, constant, strength);
	}
	public static GtkConstraintHandle NewConstant(GtkConstraintTargetHandle target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, double constant, int strength)
	{
		return GtkConstraintExterns.gtk_constraint_new_constant(target, target_attribute, relation, constant, strength);
	}
}

public static class GtkConstraintSignals
{
}

public static class GtkConstraintHandleExtensions
{
	public static double GetConstant(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_constant(constraint);
	}

	public static double GetMultiplier(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_multiplier(constraint);
	}

	public static GtkConstraintRelation GetRelation(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_relation(constraint);
	}

	public static GtkConstraintTargetHandle GetSource(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_source(constraint);
	}

	public static GtkConstraintAttribute GetSourceAttribute(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_source_attribute(constraint);
	}

	public static int GetStrength(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_strength(constraint);
	}

	public static GtkConstraintTargetHandle GetTarget(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_target(constraint);
	}

	public static GtkConstraintAttribute GetTargetAttribute(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_get_target_attribute(constraint);
	}

	public static bool IsAttached(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_is_attached(constraint);
	}

	public static bool IsConstant(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_is_constant(constraint);
	}

	public static bool IsRequired(this GtkConstraintHandle constraint)
	{
		return GtkConstraintExterns.gtk_constraint_is_required(constraint);
	}

}

internal class GtkConstraintExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_constraint_get_constant(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_constraint_get_multiplier(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintRelation gtk_constraint_get_relation(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintTargetHandle gtk_constraint_get_source(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintAttribute gtk_constraint_get_source_attribute(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_constraint_get_strength(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintTargetHandle gtk_constraint_get_target(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintAttribute gtk_constraint_get_target_attribute(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_constraint_is_attached(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_constraint_is_constant(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_constraint_is_required(GtkConstraintHandle constraint);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintHandle gtk_constraint_new(GtkConstraintTargetHandle target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, GtkConstraintTargetHandle source, GtkConstraintAttribute source_attribute, double multiplier, double constant, int strength);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintHandle gtk_constraint_new_constant(GtkConstraintTargetHandle target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, double constant, int strength);
}
