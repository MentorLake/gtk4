namespace MentorLake.Gtk4.Gtk4;

public class GtkStackSwitcherHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkStackSwitcherHandle New()
	{
		return GtkStackSwitcherExterns.gtk_stack_switcher_new();
	}

}

public static class GtkStackSwitcherHandleExtensions
{
	public static GtkStackHandle GetStack(this GtkStackSwitcherHandle switcher)
	{
		return GtkStackSwitcherExterns.gtk_stack_switcher_get_stack(switcher);
	}

	public static GtkStackSwitcherHandle SetStack(this GtkStackSwitcherHandle switcher, GtkStackHandle stack)
	{
		GtkStackSwitcherExterns.gtk_stack_switcher_set_stack(switcher, stack);
		return switcher;
	}

}

internal class GtkStackSwitcherExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackSwitcherHandle gtk_stack_switcher_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStackHandle gtk_stack_switcher_get_stack(GtkStackSwitcherHandle switcher);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_switcher_set_stack(GtkStackSwitcherHandle switcher, GtkStackHandle stack);

}
