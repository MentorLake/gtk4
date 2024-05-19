namespace MentorLake.Gtk4.Gtk4;

public class GtkLockButtonHandle : GtkButtonHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkLockButtonHandle New(GPermissionHandle permission)
	{
		return GtkLockButtonExterns.gtk_lock_button_new(permission);
	}

}

public static class GtkLockButtonHandleExtensions
{
	public static GPermissionHandle GetPermission(this GtkLockButtonHandle button)
	{
		return GtkLockButtonExterns.gtk_lock_button_get_permission(button);
	}

	public static GtkLockButtonHandle SetPermission(this GtkLockButtonHandle button, GPermissionHandle permission)
	{
		GtkLockButtonExterns.gtk_lock_button_set_permission(button, permission);
		return button;
	}

}

internal class GtkLockButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLockButtonHandle gtk_lock_button_new(GPermissionHandle permission);

	[DllImport(Libraries.Gtk4)]
	internal static extern GPermissionHandle gtk_lock_button_get_permission(GtkLockButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_lock_button_set_permission(GtkLockButtonHandle button, GPermissionHandle permission);

}
