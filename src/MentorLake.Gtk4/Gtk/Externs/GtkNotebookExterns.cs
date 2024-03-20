using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNotebookExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_append_page")]
    internal static extern int gtk_notebook_append_page(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_append_page_menu")]
    internal static extern int gtk_notebook_append_page_menu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_prepend_page")]
    internal static extern int gtk_notebook_prepend_page(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_prepend_page_menu")]
    internal static extern int gtk_notebook_prepend_page_menu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_insert_page")]
    internal static extern int gtk_notebook_insert_page(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_insert_page_menu")]
    internal static extern int gtk_notebook_insert_page_menu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_remove_page")]
    internal static extern void gtk_notebook_remove_page(this GtkNotebookHandle notebook, int page_num);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_group_name")]
    internal static extern void gtk_notebook_set_group_name(this GtkNotebookHandle notebook, string group_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_group_name")]
    internal static extern string gtk_notebook_get_group_name(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_current_page")]
    internal static extern int gtk_notebook_get_current_page(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_nth_page")]
    internal static extern GtkWidgetHandle gtk_notebook_get_nth_page(this GtkNotebookHandle notebook, int page_num);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_n_pages")]
    internal static extern int gtk_notebook_get_n_pages(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_page_num")]
    internal static extern int gtk_notebook_page_num(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_current_page")]
    internal static extern void gtk_notebook_set_current_page(this GtkNotebookHandle notebook, int page_num);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_next_page")]
    internal static extern void gtk_notebook_next_page(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_prev_page")]
    internal static extern void gtk_notebook_prev_page(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_show_border")]
    internal static extern void gtk_notebook_set_show_border(this GtkNotebookHandle notebook, int show_border);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_show_border")]
    internal static extern int gtk_notebook_get_show_border(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_show_tabs")]
    internal static extern void gtk_notebook_set_show_tabs(this GtkNotebookHandle notebook, int show_tabs);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_show_tabs")]
    internal static extern int gtk_notebook_get_show_tabs(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_tab_pos")]
    internal static extern void gtk_notebook_set_tab_pos(this GtkNotebookHandle notebook, GtkPositionType pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_tab_pos")]
    internal static extern GtkPositionType gtk_notebook_get_tab_pos(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_scrollable")]
    internal static extern void gtk_notebook_set_scrollable(this GtkNotebookHandle notebook, int scrollable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_scrollable")]
    internal static extern int gtk_notebook_get_scrollable(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_popup_enable")]
    internal static extern void gtk_notebook_popup_enable(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_popup_disable")]
    internal static extern void gtk_notebook_popup_disable(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_tab_label")]
    internal static extern GtkWidgetHandle gtk_notebook_get_tab_label(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_tab_label")]
    internal static extern void gtk_notebook_set_tab_label(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_tab_label_text")]
    internal static extern void gtk_notebook_set_tab_label_text(this GtkNotebookHandle notebook, GtkWidgetHandle child, string tab_text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_tab_label_text")]
    internal static extern string gtk_notebook_get_tab_label_text(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_menu_label")]
    internal static extern GtkWidgetHandle gtk_notebook_get_menu_label(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_menu_label")]
    internal static extern void gtk_notebook_set_menu_label(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle menu_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_menu_label_text")]
    internal static extern void gtk_notebook_set_menu_label_text(this GtkNotebookHandle notebook, GtkWidgetHandle child, string menu_text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_menu_label_text")]
    internal static extern string gtk_notebook_get_menu_label_text(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_reorder_child")]
    internal static extern void gtk_notebook_reorder_child(this GtkNotebookHandle notebook, GtkWidgetHandle child, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_tab_reorderable")]
    internal static extern int gtk_notebook_get_tab_reorderable(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_tab_reorderable")]
    internal static extern void gtk_notebook_set_tab_reorderable(this GtkNotebookHandle notebook, GtkWidgetHandle child, int reorderable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_tab_detachable")]
    internal static extern int gtk_notebook_get_tab_detachable(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_tab_detachable")]
    internal static extern void gtk_notebook_set_tab_detachable(this GtkNotebookHandle notebook, GtkWidgetHandle child, int detachable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_detach_tab")]
    internal static extern void gtk_notebook_detach_tab(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_action_widget")]
    internal static extern GtkWidgetHandle gtk_notebook_get_action_widget(this GtkNotebookHandle notebook, GtkPackType pack_type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_set_action_widget")]
    internal static extern void gtk_notebook_set_action_widget(this GtkNotebookHandle notebook, GtkWidgetHandle widget, GtkPackType pack_type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_page")]
    internal static extern GtkNotebookPageHandle gtk_notebook_get_page(this GtkNotebookHandle notebook, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_notebook_get_pages")]
    internal static extern GListModelHandle gtk_notebook_get_pages(this GtkNotebookHandle notebook);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkNotebookHandle gtk_notebook_new();
}
