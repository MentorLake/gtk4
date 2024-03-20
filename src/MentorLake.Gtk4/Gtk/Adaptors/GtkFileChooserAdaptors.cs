using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFileChooserAdaptors
{
    public static GtkFileChooserHandle SetAction(this GtkFileChooserHandle chooser, GtkFileChooserAction action)
    {
        GtkFileChooserExterns.gtk_file_chooser_set_action(chooser, action);
        return chooser;
    }

    public static GtkFileChooserAction GetAction(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_action(chooser);
    }

    public static GtkFileChooserHandle SetSelectMultiple(this GtkFileChooserHandle chooser, int select_multiple)
    {
        GtkFileChooserExterns.gtk_file_chooser_set_select_multiple(chooser, select_multiple);
        return chooser;
    }

    public static int GetSelectMultiple(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_select_multiple(chooser);
    }

    public static GtkFileChooserHandle SetCreateFolders(this GtkFileChooserHandle chooser, int create_folders)
    {
        GtkFileChooserExterns.gtk_file_chooser_set_create_folders(chooser, create_folders);
        return chooser;
    }

    public static int GetCreateFolders(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_create_folders(chooser);
    }

    public static GtkFileChooserHandle SetCurrentName(this GtkFileChooserHandle chooser, string name)
    {
        GtkFileChooserExterns.gtk_file_chooser_set_current_name(chooser, name);
        return chooser;
    }

    public static string GetCurrentName(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_current_name(chooser);
    }

    public static GFileHandle GetFile(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_file(chooser);
    }

    public static int SetFile(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error)
    {
        return GtkFileChooserExterns.gtk_file_chooser_set_file(chooser, file, out error);
    }

    public static GListModelHandle GetFiles(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_files(chooser);
    }

    public static int SetCurrentFolder(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error)
    {
        return GtkFileChooserExterns.gtk_file_chooser_set_current_folder(chooser, file, out error);
    }

    public static GFileHandle GetCurrentFolder(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_current_folder(chooser);
    }

    public static GtkFileChooserHandle AddFilter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter)
    {
        GtkFileChooserExterns.gtk_file_chooser_add_filter(chooser, filter);
        return chooser;
    }

    public static GtkFileChooserHandle RemoveFilter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter)
    {
        GtkFileChooserExterns.gtk_file_chooser_remove_filter(chooser, filter);
        return chooser;
    }

    public static GListModelHandle GetFilters(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_filters(chooser);
    }

    public static GtkFileChooserHandle SetFilter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter)
    {
        GtkFileChooserExterns.gtk_file_chooser_set_filter(chooser, filter);
        return chooser;
    }

    public static GtkFileFilterHandle GetFilter(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_filter(chooser);
    }

    public static int AddShortcutFolder(this GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error)
    {
        return GtkFileChooserExterns.gtk_file_chooser_add_shortcut_folder(chooser, folder, out error);
    }

    public static int RemoveShortcutFolder(this GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error)
    {
        return GtkFileChooserExterns.gtk_file_chooser_remove_shortcut_folder(chooser, folder, out error);
    }

    public static GListModelHandle GetShortcutFolders(this GtkFileChooserHandle chooser)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_shortcut_folders(chooser);
    }

    public static GtkFileChooserHandle AddChoice(this GtkFileChooserHandle chooser, string id, string label, string[] options, string[] option_labels)
    {
        GtkFileChooserExterns.gtk_file_chooser_add_choice(chooser, id, label, options, option_labels);
        return chooser;
    }

    public static GtkFileChooserHandle RemoveChoice(this GtkFileChooserHandle chooser, string id)
    {
        GtkFileChooserExterns.gtk_file_chooser_remove_choice(chooser, id);
        return chooser;
    }

    public static GtkFileChooserHandle SetChoice(this GtkFileChooserHandle chooser, string id, string option)
    {
        GtkFileChooserExterns.gtk_file_chooser_set_choice(chooser, id, option);
        return chooser;
    }

    public static string GetChoice(this GtkFileChooserHandle chooser, string id)
    {
        return GtkFileChooserExterns.gtk_file_chooser_get_choice(chooser, id);
    }
}
