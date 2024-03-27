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

public class GtkStackHandle : GtkWidgetHandle
{
	public static GtkStackHandle New()
	{
		return GtkStackExterns.gtk_stack_new();
	}
}

public static class GtkStackSignals
{
}

public static class GtkStackHandleExtensions
{
	public static GtkStackPageHandle AddChild(this GtkStackHandle stack, GtkWidgetHandle child)
	{
		return GtkStackExterns.gtk_stack_add_child(stack, child);
	}

	public static GtkStackPageHandle AddNamed(this GtkStackHandle stack, GtkWidgetHandle child, string name)
	{
		return GtkStackExterns.gtk_stack_add_named(stack, child, name);
	}

	public static GtkStackPageHandle AddTitled(this GtkStackHandle stack, GtkWidgetHandle child, string name, string title)
	{
		return GtkStackExterns.gtk_stack_add_titled(stack, child, name, title);
	}

	public static GtkWidgetHandle GetChildByName(this GtkStackHandle stack, string name)
	{
		return GtkStackExterns.gtk_stack_get_child_by_name(stack, name);
	}

	public static bool GetHhomogeneous(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_hhomogeneous(stack);
	}

	public static bool GetInterpolateSize(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_interpolate_size(stack);
	}

	public static GtkStackPageHandle GetPage(this GtkStackHandle stack, GtkWidgetHandle child)
	{
		return GtkStackExterns.gtk_stack_get_page(stack, child);
	}

	public static GtkSelectionModelHandle GetPages(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_pages(stack);
	}

	public static uint GetTransitionDuration(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_duration(stack);
	}

	public static bool GetTransitionRunning(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_running(stack);
	}

	public static GtkStackTransitionType GetTransitionType(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_type(stack);
	}

	public static bool GetVhomogeneous(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_vhomogeneous(stack);
	}

	public static GtkWidgetHandle GetVisibleChild(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_visible_child(stack);
	}

	public static string GetVisibleChildName(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_visible_child_name(stack);
	}

	public static GtkStackHandle Remove(this GtkStackHandle stack, GtkWidgetHandle child)
	{
		GtkStackExterns.gtk_stack_remove(stack, child);
		return stack;
	}

	public static GtkStackHandle SetHhomogeneous(this GtkStackHandle stack, bool hhomogeneous)
	{
		GtkStackExterns.gtk_stack_set_hhomogeneous(stack, hhomogeneous);
		return stack;
	}

	public static GtkStackHandle SetInterpolateSize(this GtkStackHandle stack, bool interpolate_size)
	{
		GtkStackExterns.gtk_stack_set_interpolate_size(stack, interpolate_size);
		return stack;
	}

	public static GtkStackHandle SetTransitionDuration(this GtkStackHandle stack, uint duration)
	{
		GtkStackExterns.gtk_stack_set_transition_duration(stack, duration);
		return stack;
	}

	public static GtkStackHandle SetTransitionType(this GtkStackHandle stack, GtkStackTransitionType transition)
	{
		GtkStackExterns.gtk_stack_set_transition_type(stack, transition);
		return stack;
	}

	public static GtkStackHandle SetVhomogeneous(this GtkStackHandle stack, bool vhomogeneous)
	{
		GtkStackExterns.gtk_stack_set_vhomogeneous(stack, vhomogeneous);
		return stack;
	}

	public static GtkStackHandle SetVisibleChild(this GtkStackHandle stack, GtkWidgetHandle child)
	{
		GtkStackExterns.gtk_stack_set_visible_child(stack, child);
		return stack;
	}

	public static GtkStackHandle SetVisibleChildFull(this GtkStackHandle stack, string name, GtkStackTransitionType transition)
	{
		GtkStackExterns.gtk_stack_set_visible_child_full(stack, name, transition);
		return stack;
	}

	public static GtkStackHandle SetVisibleChildName(this GtkStackHandle stack, string name)
	{
		GtkStackExterns.gtk_stack_set_visible_child_name(stack, name);
		return stack;
	}

}

internal class GtkStackExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackPageHandle gtk_stack_add_child(GtkStackHandle stack, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackPageHandle gtk_stack_add_named(GtkStackHandle stack, GtkWidgetHandle child, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackPageHandle gtk_stack_add_titled(GtkStackHandle stack, GtkWidgetHandle child, string name, string title);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_stack_get_child_by_name(GtkStackHandle stack, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_stack_get_hhomogeneous(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_stack_get_interpolate_size(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackPageHandle gtk_stack_get_page(GtkStackHandle stack, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionModelHandle gtk_stack_get_pages(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_stack_get_transition_duration(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_stack_get_transition_running(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackTransitionType gtk_stack_get_transition_type(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_stack_get_vhomogeneous(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_stack_get_visible_child(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_stack_get_visible_child_name(GtkStackHandle stack);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_remove(GtkStackHandle stack, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_hhomogeneous(GtkStackHandle stack, bool hhomogeneous);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_interpolate_size(GtkStackHandle stack, bool interpolate_size);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_transition_duration(GtkStackHandle stack, uint duration);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_transition_type(GtkStackHandle stack, GtkStackTransitionType transition);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_vhomogeneous(GtkStackHandle stack, bool vhomogeneous);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_visible_child(GtkStackHandle stack, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_visible_child_full(GtkStackHandle stack, string name, GtkStackTransitionType transition);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_set_visible_child_name(GtkStackHandle stack, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackHandle gtk_stack_new();
}
