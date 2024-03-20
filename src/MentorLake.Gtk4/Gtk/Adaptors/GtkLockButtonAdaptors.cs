using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLockButtonAdaptors
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
