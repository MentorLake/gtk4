namespace MentorLake.Gtk4.Gtk4;

public class GtkPopoverMenuBarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkPopoverMenuBarHandle NewFromModel(GMenuModelHandle model)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_new_from_model(model);
	}

}

public static class GtkPopoverMenuBarHandleExtensions
{
	public static bool AddChild(this GtkPopoverMenuBarHandle bar, GtkWidgetHandle child, string id)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_add_child(bar, child, id);
	}

	public static GMenuModelHandle GetMenuModel(this GtkPopoverMenuBarHandle bar)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_get_menu_model(bar);
	}

	public static bool RemoveChild(this GtkPopoverMenuBarHandle bar, GtkWidgetHandle child)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_remove_child(bar, child);
	}

	public static GtkPopoverMenuBarHandle SetMenuModel(this GtkPopoverMenuBarHandle bar, GMenuModelHandle model)
	{
		GtkPopoverMenuBarExterns.gtk_popover_menu_bar_set_menu_model(bar, model);
		return bar;
	}

}

internal class GtkPopoverMenuBarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPopoverMenuBarHandle gtk_popover_menu_bar_new_from_model(GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_menu_bar_add_child(GtkPopoverMenuBarHandle bar, GtkWidgetHandle child, string id);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_popover_menu_bar_get_menu_model(GtkPopoverMenuBarHandle bar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_menu_bar_remove_child(GtkPopoverMenuBarHandle bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_menu_bar_set_menu_model(GtkPopoverMenuBarHandle bar, GMenuModelHandle model);

}
