using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMountOperationAdaptors
{
    public static int IsShowing(this GtkMountOperationHandle op)
    {
        return GtkMountOperationExterns.gtk_mount_operation_is_showing(op);
    }

    public static GtkMountOperationHandle SetParent(this GtkMountOperationHandle op, GtkWindowHandle parent)
    {
        GtkMountOperationExterns.gtk_mount_operation_set_parent(op, parent);
        return op;
    }

    public static GtkWindowHandle GetParent(this GtkMountOperationHandle op)
    {
        return GtkMountOperationExterns.gtk_mount_operation_get_parent(op);
    }

    public static GtkMountOperationHandle SetDisplay(this GtkMountOperationHandle op, GdkDisplayHandle display)
    {
        GtkMountOperationExterns.gtk_mount_operation_set_display(op, display);
        return op;
    }

    public static GdkDisplayHandle GetDisplay(this GtkMountOperationHandle op)
    {
        return GtkMountOperationExterns.gtk_mount_operation_get_display(op);
    }
}
