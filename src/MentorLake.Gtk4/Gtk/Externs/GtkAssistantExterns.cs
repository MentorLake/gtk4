using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAssistantExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_next_page")]
    internal static extern void gtk_assistant_next_page(this GtkAssistantHandle assistant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_previous_page")]
    internal static extern void gtk_assistant_previous_page(this GtkAssistantHandle assistant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_current_page")]
    internal static extern int gtk_assistant_get_current_page(this GtkAssistantHandle assistant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_set_current_page")]
    internal static extern void gtk_assistant_set_current_page(this GtkAssistantHandle assistant, int page_num);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_n_pages")]
    internal static extern int gtk_assistant_get_n_pages(this GtkAssistantHandle assistant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_nth_page")]
    internal static extern GtkWidgetHandle gtk_assistant_get_nth_page(this GtkAssistantHandle assistant, int page_num);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_prepend_page")]
    internal static extern int gtk_assistant_prepend_page(this GtkAssistantHandle assistant, GtkWidgetHandle page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_append_page")]
    internal static extern int gtk_assistant_append_page(this GtkAssistantHandle assistant, GtkWidgetHandle page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_insert_page")]
    internal static extern int gtk_assistant_insert_page(this GtkAssistantHandle assistant, GtkWidgetHandle page, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_remove_page")]
    internal static extern void gtk_assistant_remove_page(this GtkAssistantHandle assistant, int page_num);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_set_forward_page_func")]
    internal static extern void gtk_assistant_set_forward_page_func(this GtkAssistantHandle assistant, GtkAssistantPageFunc page_func, IntPtr data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_set_page_type")]
    internal static extern void gtk_assistant_set_page_type(this GtkAssistantHandle assistant, GtkWidgetHandle page, GtkAssistantPageType type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_page_type")]
    internal static extern GtkAssistantPageType gtk_assistant_get_page_type(this GtkAssistantHandle assistant, GtkWidgetHandle page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_set_page_title")]
    internal static extern void gtk_assistant_set_page_title(this GtkAssistantHandle assistant, GtkWidgetHandle page, string title);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_page_title")]
    internal static extern string gtk_assistant_get_page_title(this GtkAssistantHandle assistant, GtkWidgetHandle page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_set_page_complete")]
    internal static extern void gtk_assistant_set_page_complete(this GtkAssistantHandle assistant, GtkWidgetHandle page, int complete);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_page_complete")]
    internal static extern int gtk_assistant_get_page_complete(this GtkAssistantHandle assistant, GtkWidgetHandle page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_add_action_widget")]
    internal static extern void gtk_assistant_add_action_widget(this GtkAssistantHandle assistant, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_remove_action_widget")]
    internal static extern void gtk_assistant_remove_action_widget(this GtkAssistantHandle assistant, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_update_buttons_state")]
    internal static extern void gtk_assistant_update_buttons_state(this GtkAssistantHandle assistant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_commit")]
    internal static extern void gtk_assistant_commit(this GtkAssistantHandle assistant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_page")]
    internal static extern GtkAssistantPageHandle gtk_assistant_get_page(this GtkAssistantHandle assistant, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_get_pages")]
    internal static extern GListModelHandle gtk_assistant_get_pages(this GtkAssistantHandle assistant);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkAssistantHandle gtk_assistant_new();
}
