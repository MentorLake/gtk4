namespace MentorLake.Gtk4.Gtk4;

public class GtkPopoverMenuHandle : GtkPopoverHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkShortcutManagerHandle
{
	public static GtkPopoverMenuHandle NewFromModel(GMenuModelHandle model)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_new_from_model(model);
	}

	public static GtkPopoverMenuHandle NewFromModelFull(GMenuModelHandle model, GtkPopoverMenuFlags flags)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_new_from_model_full(model, flags);
	}

}

public static class GtkPopoverMenuHandleExtensions
{
	public static bool AddChild(this GtkPopoverMenuHandle popover, GtkWidgetHandle child, string id)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_add_child(popover, child, id);
	}

	public static GtkPopoverMenuFlags GetFlags(this GtkPopoverMenuHandle popover)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_get_flags(popover);
	}

	public static GMenuModelHandle GetMenuModel(this GtkPopoverMenuHandle popover)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_get_menu_model(popover);
	}

	public static bool RemoveChild(this GtkPopoverMenuHandle popover, GtkWidgetHandle child)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_remove_child(popover, child);
	}

	public static GtkPopoverMenuHandle SetFlags(this GtkPopoverMenuHandle popover, GtkPopoverMenuFlags flags)
	{
		GtkPopoverMenuExterns.gtk_popover_menu_set_flags(popover, flags);
		return popover;
	}

	public static GtkPopoverMenuHandle SetMenuModel(this GtkPopoverMenuHandle popover, GMenuModelHandle model)
	{
		GtkPopoverMenuExterns.gtk_popover_menu_set_menu_model(popover, model);
		return popover;
	}

}

internal class GtkPopoverMenuExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPopoverMenuHandle gtk_popover_menu_new_from_model(GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPopoverMenuHandle gtk_popover_menu_new_from_model_full(GMenuModelHandle model, GtkPopoverMenuFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_menu_add_child(GtkPopoverMenuHandle popover, GtkWidgetHandle child, string id);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPopoverMenuFlags gtk_popover_menu_get_flags(GtkPopoverMenuHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_popover_menu_get_menu_model(GtkPopoverMenuHandle popover);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_popover_menu_remove_child(GtkPopoverMenuHandle popover, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_menu_set_flags(GtkPopoverMenuHandle popover, GtkPopoverMenuFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_popover_menu_set_menu_model(GtkPopoverMenuHandle popover, GMenuModelHandle model);

}
