using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStackSidebarAdaptors
{
	public static GtkStackSidebarHandle SetStack(this GtkStackSidebarHandle self, GtkStackHandle stack)
	{
		GtkStackSidebarExterns.gtk_stack_sidebar_set_stack(self, stack);
		return self;
	}

	public static GtkStackHandle GetStack(this GtkStackSidebarHandle self)
	{
		return GtkStackSidebarExterns.gtk_stack_sidebar_get_stack(self);
	}
}
