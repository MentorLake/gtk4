using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStackAdaptors
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

	public static GtkStackHandle Remove(this GtkStackHandle stack, GtkWidgetHandle child)
	{
		GtkStackExterns.gtk_stack_remove(stack, child);
		return stack;
	}

	public static GtkStackPageHandle GetPage(this GtkStackHandle stack, GtkWidgetHandle child)
	{
		return GtkStackExterns.gtk_stack_get_page(stack, child);
	}

	public static GtkWidgetHandle GetChildByName(this GtkStackHandle stack, string name)
	{
		return GtkStackExterns.gtk_stack_get_child_by_name(stack, name);
	}

	public static GtkStackHandle SetVisibleChild(this GtkStackHandle stack, GtkWidgetHandle child)
	{
		GtkStackExterns.gtk_stack_set_visible_child(stack, child);
		return stack;
	}

	public static GtkWidgetHandle GetVisibleChild(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_visible_child(stack);
	}

	public static GtkStackHandle SetVisibleChildName(this GtkStackHandle stack, string name)
	{
		GtkStackExterns.gtk_stack_set_visible_child_name(stack, name);
		return stack;
	}

	public static string GetVisibleChildName(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_visible_child_name(stack);
	}

	public static GtkStackHandle SetVisibleChildFull(this GtkStackHandle stack, string name, GtkStackTransitionType transition)
	{
		GtkStackExterns.gtk_stack_set_visible_child_full(stack, name, transition);
		return stack;
	}

	public static GtkStackHandle SetHhomogeneous(this GtkStackHandle stack, int hhomogeneous)
	{
		GtkStackExterns.gtk_stack_set_hhomogeneous(stack, hhomogeneous);
		return stack;
	}

	public static int GetHhomogeneous(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_hhomogeneous(stack);
	}

	public static GtkStackHandle SetVhomogeneous(this GtkStackHandle stack, int vhomogeneous)
	{
		GtkStackExterns.gtk_stack_set_vhomogeneous(stack, vhomogeneous);
		return stack;
	}

	public static int GetVhomogeneous(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_vhomogeneous(stack);
	}

	public static GtkStackHandle SetTransitionDuration(this GtkStackHandle stack, uint duration)
	{
		GtkStackExterns.gtk_stack_set_transition_duration(stack, duration);
		return stack;
	}

	public static uint GetTransitionDuration(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_duration(stack);
	}

	public static GtkStackHandle SetTransitionType(this GtkStackHandle stack, GtkStackTransitionType transition)
	{
		GtkStackExterns.gtk_stack_set_transition_type(stack, transition);
		return stack;
	}

	public static GtkStackTransitionType GetTransitionType(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_type(stack);
	}

	public static int GetTransitionRunning(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_running(stack);
	}

	public static GtkStackHandle SetInterpolateSize(this GtkStackHandle stack, int interpolate_size)
	{
		GtkStackExterns.gtk_stack_set_interpolate_size(stack, interpolate_size);
		return stack;
	}

	public static int GetInterpolateSize(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_interpolate_size(stack);
	}

	public static GtkSelectionModelHandle GetPages(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_pages(stack);
	}
}
