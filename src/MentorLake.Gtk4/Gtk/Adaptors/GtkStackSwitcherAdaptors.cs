using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStackSwitcherAdaptors
{
	public static GtkStackSwitcherHandle SetStack(this GtkStackSwitcherHandle switcher, GtkStackHandle stack)
	{
		GtkStackSwitcherExterns.gtk_stack_switcher_set_stack(switcher, stack);
		return switcher;
	}

	public static GtkStackHandle GetStack(this GtkStackSwitcherHandle switcher)
	{
		return GtkStackSwitcherExterns.gtk_stack_switcher_get_stack(switcher);
	}
}
