using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkMountOperationExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_mount_operation_is_showing")]
	internal static extern int gtk_mount_operation_is_showing(this GtkMountOperationHandle op);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_mount_operation_set_parent")]
	internal static extern void gtk_mount_operation_set_parent(this GtkMountOperationHandle op, GtkWindowHandle parent);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_mount_operation_get_parent")]
	internal static extern GtkWindowHandle gtk_mount_operation_get_parent(this GtkMountOperationHandle op);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_mount_operation_set_display")]
	internal static extern void gtk_mount_operation_set_display(this GtkMountOperationHandle op, GdkDisplayHandle display);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_mount_operation_get_display")]
	internal static extern GdkDisplayHandle gtk_mount_operation_get_display(this GtkMountOperationHandle op);
}
