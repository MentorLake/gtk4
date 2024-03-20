using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutControllerAdaptors
{
    public static GtkShortcutControllerHandle SetMnemonicsModifiers(this GtkShortcutControllerHandle self, GdkModifierType modifiers)
    {
        GtkShortcutControllerExterns.gtk_shortcut_controller_set_mnemonics_modifiers(self, modifiers);
        return self;
    }

    public static GdkModifierType GetMnemonicsModifiers(this GtkShortcutControllerHandle self)
    {
        return GtkShortcutControllerExterns.gtk_shortcut_controller_get_mnemonics_modifiers(self);
    }

    public static GtkShortcutControllerHandle SetScope(this GtkShortcutControllerHandle self, GtkShortcutScope scope)
    {
        GtkShortcutControllerExterns.gtk_shortcut_controller_set_scope(self, scope);
        return self;
    }

    public static GtkShortcutScope GetScope(this GtkShortcutControllerHandle self)
    {
        return GtkShortcutControllerExterns.gtk_shortcut_controller_get_scope(self);
    }

    public static GtkShortcutControllerHandle AddShortcut(this GtkShortcutControllerHandle self, GtkShortcutHandle shortcut)
    {
        GtkShortcutControllerExterns.gtk_shortcut_controller_add_shortcut(self, shortcut);
        return self;
    }

    public static GtkShortcutControllerHandle RemoveShortcut(this GtkShortcutControllerHandle self, GtkShortcutHandle shortcut)
    {
        GtkShortcutControllerExterns.gtk_shortcut_controller_remove_shortcut(self, shortcut);
        return self;
    }
}
