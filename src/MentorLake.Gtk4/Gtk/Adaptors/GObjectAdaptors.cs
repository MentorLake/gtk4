using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GObjectAdaptors
{
    public static GObjectHandle GtkTreeRowReferenceInserted(this GObjectHandle proxy, GtkTreePathHandle path)
    {
        GObjectExterns.gtk_tree_row_reference_inserted(proxy, path);
        return proxy;
    }

    public static GObjectHandle GtkTreeRowReferenceDeleted(this GObjectHandle proxy, GtkTreePathHandle path)
    {
        GObjectExterns.gtk_tree_row_reference_deleted(proxy, path);
        return proxy;
    }

    public static GObjectHandle GtkTreeRowReferenceReordered(this GObjectHandle proxy, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order)
    {
        GObjectExterns.gtk_tree_row_reference_reordered(proxy, path, iter, new_order);
        return proxy;
    }

    public static int GtkEditableDelegateSetProperty(this GObjectHandle @object, uint prop_id, GValueHandle value, GParamSpecHandle pspec)
    {
        return GObjectExterns.gtk_editable_delegate_set_property(@object, prop_id, value, pspec);
    }

    public static int GtkEditableDelegateGetProperty(this GObjectHandle @object, uint prop_id, GValueHandle value, GParamSpecHandle pspec)
    {
        return GObjectExterns.gtk_editable_delegate_get_property(@object, prop_id, value, pspec);
    }
}
