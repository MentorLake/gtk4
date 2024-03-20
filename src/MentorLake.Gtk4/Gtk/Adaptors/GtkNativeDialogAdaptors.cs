using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNativeDialogAdaptors
{
    public static GtkNativeDialogHandle Show(this GtkNativeDialogHandle self)
    {
        GtkNativeDialogExterns.gtk_native_dialog_show(self);
        return self;
    }

    public static GtkNativeDialogHandle Hide(this GtkNativeDialogHandle self)
    {
        GtkNativeDialogExterns.gtk_native_dialog_hide(self);
        return self;
    }

    public static GtkNativeDialogHandle Destroy(this GtkNativeDialogHandle self)
    {
        GtkNativeDialogExterns.gtk_native_dialog_destroy(self);
        return self;
    }

    public static int GetVisible(this GtkNativeDialogHandle self)
    {
        return GtkNativeDialogExterns.gtk_native_dialog_get_visible(self);
    }

    public static GtkNativeDialogHandle SetModal(this GtkNativeDialogHandle self, int modal)
    {
        GtkNativeDialogExterns.gtk_native_dialog_set_modal(self, modal);
        return self;
    }

    public static int GetModal(this GtkNativeDialogHandle self)
    {
        return GtkNativeDialogExterns.gtk_native_dialog_get_modal(self);
    }

    public static GtkNativeDialogHandle SetTitle(this GtkNativeDialogHandle self, string title)
    {
        GtkNativeDialogExterns.gtk_native_dialog_set_title(self, title);
        return self;
    }

    public static string GetTitle(this GtkNativeDialogHandle self)
    {
        return GtkNativeDialogExterns.gtk_native_dialog_get_title(self);
    }

    public static GtkNativeDialogHandle SetTransientFor(this GtkNativeDialogHandle self, GtkWindowHandle parent)
    {
        GtkNativeDialogExterns.gtk_native_dialog_set_transient_for(self, parent);
        return self;
    }

    public static GtkWindowHandle GetTransientFor(this GtkNativeDialogHandle self)
    {
        return GtkNativeDialogExterns.gtk_native_dialog_get_transient_for(self);
    }
}
