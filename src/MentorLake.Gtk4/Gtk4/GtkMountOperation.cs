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

public class GtkMountOperationHandle : GMountOperationHandle
{
	public static GtkMountOperationHandle New(GtkWindowHandle parent)
	{
		return GtkMountOperationExterns.gtk_mount_operation_new(parent);
	}

}

public static class GtkMountOperationHandleExtensions
{
	public static GdkDisplayHandle GetDisplay(this GtkMountOperationHandle op)
	{
		return GtkMountOperationExterns.gtk_mount_operation_get_display(op);
	}

	public static GtkWindowHandle GetParent(this GtkMountOperationHandle op)
	{
		return GtkMountOperationExterns.gtk_mount_operation_get_parent(op);
	}

	public static bool IsShowing(this GtkMountOperationHandle op)
	{
		return GtkMountOperationExterns.gtk_mount_operation_is_showing(op);
	}

	public static GtkMountOperationHandle SetDisplay(this GtkMountOperationHandle op, GdkDisplayHandle display)
	{
		GtkMountOperationExterns.gtk_mount_operation_set_display(op, display);
		return op;
	}

	public static GtkMountOperationHandle SetParent(this GtkMountOperationHandle op, GtkWindowHandle parent)
	{
		GtkMountOperationExterns.gtk_mount_operation_set_parent(op, parent);
		return op;
	}

}

internal class GtkMountOperationExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMountOperationHandle gtk_mount_operation_new(GtkWindowHandle parent);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDisplayHandle gtk_mount_operation_get_display(GtkMountOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowHandle gtk_mount_operation_get_parent(GtkMountOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_mount_operation_is_showing(GtkMountOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_mount_operation_set_display(GtkMountOperationHandle op, GdkDisplayHandle display);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_mount_operation_set_parent(GtkMountOperationHandle op, GtkWindowHandle parent);
}
