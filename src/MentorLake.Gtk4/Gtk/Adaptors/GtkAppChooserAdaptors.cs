using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAppChooserAdaptors
{
    public static GAppInfoHandle GetAppInfo(this GtkAppChooserHandle self)
    {
        return GtkAppChooserExterns.gtk_app_chooser_get_app_info(self);
    }

    public static string GetContentType(this GtkAppChooserHandle self)
    {
        return GtkAppChooserExterns.gtk_app_chooser_get_content_type(self);
    }

    public static GtkAppChooserHandle Refresh(this GtkAppChooserHandle self)
    {
        GtkAppChooserExterns.gtk_app_chooser_refresh(self);
        return self;
    }
}
