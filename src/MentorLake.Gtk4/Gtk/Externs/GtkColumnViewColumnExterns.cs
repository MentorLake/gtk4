using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkColumnViewColumnExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_column_view")]
    internal static extern GtkColumnViewHandle gtk_column_view_column_get_column_view(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_factory")]
    internal static extern void gtk_column_view_column_set_factory(this GtkColumnViewColumnHandle self, GtkListItemFactoryHandle factory);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_factory")]
    internal static extern GtkListItemFactoryHandle gtk_column_view_column_get_factory(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_title")]
    internal static extern void gtk_column_view_column_set_title(this GtkColumnViewColumnHandle self, string title);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_title")]
    internal static extern string gtk_column_view_column_get_title(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_sorter")]
    internal static extern void gtk_column_view_column_set_sorter(this GtkColumnViewColumnHandle self, GtkSorterHandle sorter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_sorter")]
    internal static extern GtkSorterHandle gtk_column_view_column_get_sorter(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_visible")]
    internal static extern void gtk_column_view_column_set_visible(this GtkColumnViewColumnHandle self, int visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_visible")]
    internal static extern int gtk_column_view_column_get_visible(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_header_menu")]
    internal static extern void gtk_column_view_column_set_header_menu(this GtkColumnViewColumnHandle self, GMenuModelHandle menu);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_header_menu")]
    internal static extern GMenuModelHandle gtk_column_view_column_get_header_menu(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_fixed_width")]
    internal static extern void gtk_column_view_column_set_fixed_width(this GtkColumnViewColumnHandle self, int fixed_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_fixed_width")]
    internal static extern int gtk_column_view_column_get_fixed_width(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_resizable")]
    internal static extern void gtk_column_view_column_set_resizable(this GtkColumnViewColumnHandle self, int resizable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_resizable")]
    internal static extern int gtk_column_view_column_get_resizable(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_set_expand")]
    internal static extern void gtk_column_view_column_set_expand(this GtkColumnViewColumnHandle self, int expand);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_column_get_expand")]
    internal static extern int gtk_column_view_column_get_expand(this GtkColumnViewColumnHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkColumnViewColumnHandle gtk_column_view_column_new(string title, GtkListItemFactoryHandle factory);
}
