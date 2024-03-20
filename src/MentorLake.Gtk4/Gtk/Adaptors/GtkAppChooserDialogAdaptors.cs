using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAppChooserDialogAdaptors
{
    public static GtkWidgetHandle GetWidget(this GtkAppChooserDialogHandle self)
    {
        return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_get_widget(self);
    }

    public static GtkAppChooserDialogHandle SetHeading(this GtkAppChooserDialogHandle self, string heading)
    {
        GtkAppChooserDialogExterns.gtk_app_chooser_dialog_set_heading(self, heading);
        return self;
    }

    public static string GetHeading(this GtkAppChooserDialogHandle self)
    {
        return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_get_heading(self);
    }
}
