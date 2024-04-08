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

public class GtkConstraintGuideHandle : GObjectHandle, GtkConstraintTargetHandle
{
	public static GtkConstraintGuideHandle New()
	{
		return GtkConstraintGuideExterns.gtk_constraint_guide_new();
	}

}

public static class GtkConstraintGuideHandleExtensions
{
	public static GtkConstraintGuideHandle GetMaxSize(this GtkConstraintGuideHandle guide, out int width, out int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_get_max_size(guide, out width, out height);
		return guide;
	}

	public static GtkConstraintGuideHandle GetMinSize(this GtkConstraintGuideHandle guide, out int width, out int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_get_min_size(guide, out width, out height);
		return guide;
	}

	public static string GetName(this GtkConstraintGuideHandle guide)
	{
		return GtkConstraintGuideExterns.gtk_constraint_guide_get_name(guide);
	}

	public static GtkConstraintGuideHandle GetNatSize(this GtkConstraintGuideHandle guide, out int width, out int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_get_nat_size(guide, out width, out height);
		return guide;
	}

	public static GtkConstraintStrength GetStrength(this GtkConstraintGuideHandle guide)
	{
		return GtkConstraintGuideExterns.gtk_constraint_guide_get_strength(guide);
	}

	public static GtkConstraintGuideHandle SetMaxSize(this GtkConstraintGuideHandle guide, int width, int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_max_size(guide, width, height);
		return guide;
	}

	public static GtkConstraintGuideHandle SetMinSize(this GtkConstraintGuideHandle guide, int width, int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_min_size(guide, width, height);
		return guide;
	}

	public static GtkConstraintGuideHandle SetName(this GtkConstraintGuideHandle guide, string name)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_name(guide, name);
		return guide;
	}

	public static GtkConstraintGuideHandle SetNatSize(this GtkConstraintGuideHandle guide, int width, int height)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_nat_size(guide, width, height);
		return guide;
	}

	public static GtkConstraintGuideHandle SetStrength(this GtkConstraintGuideHandle guide, GtkConstraintStrength strength)
	{
		GtkConstraintGuideExterns.gtk_constraint_guide_set_strength(guide, strength);
		return guide;
	}

}

internal class GtkConstraintGuideExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintGuideHandle gtk_constraint_guide_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_get_max_size(GtkConstraintGuideHandle guide, out int width, out int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_get_min_size(GtkConstraintGuideHandle guide, out int width, out int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_constraint_guide_get_name(GtkConstraintGuideHandle guide);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_get_nat_size(GtkConstraintGuideHandle guide, out int width, out int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstraintStrength gtk_constraint_guide_get_strength(GtkConstraintGuideHandle guide);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_set_max_size(GtkConstraintGuideHandle guide, int width, int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_set_min_size(GtkConstraintGuideHandle guide, int width, int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_set_name(GtkConstraintGuideHandle guide, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_set_nat_size(GtkConstraintGuideHandle guide, int width, int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_constraint_guide_set_strength(GtkConstraintGuideHandle guide, GtkConstraintStrength strength);
}
