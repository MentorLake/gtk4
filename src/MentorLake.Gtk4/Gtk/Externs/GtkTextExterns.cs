using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_buffer")]
    internal static extern GtkEntryBufferHandle gtk_text_get_buffer(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_buffer")]
    internal static extern void gtk_text_set_buffer(this GtkTextHandle self, GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_visibility")]
    internal static extern void gtk_text_set_visibility(this GtkTextHandle self, int visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_visibility")]
    internal static extern int gtk_text_get_visibility(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_invisible_char")]
    internal static extern void gtk_text_set_invisible_char(this GtkTextHandle self, uint ch);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_invisible_char")]
    internal static extern uint gtk_text_get_invisible_char(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_unset_invisible_char")]
    internal static extern void gtk_text_unset_invisible_char(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_overwrite_mode")]
    internal static extern void gtk_text_set_overwrite_mode(this GtkTextHandle self, int overwrite);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_overwrite_mode")]
    internal static extern int gtk_text_get_overwrite_mode(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_max_length")]
    internal static extern void gtk_text_set_max_length(this GtkTextHandle self, int length);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_max_length")]
    internal static extern int gtk_text_get_max_length(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_text_length")]
    internal static extern ushort gtk_text_get_text_length(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_activates_default")]
    internal static extern void gtk_text_set_activates_default(this GtkTextHandle self, int activates);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_activates_default")]
    internal static extern int gtk_text_get_activates_default(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_placeholder_text")]
    internal static extern string gtk_text_get_placeholder_text(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_placeholder_text")]
    internal static extern void gtk_text_set_placeholder_text(this GtkTextHandle self, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_input_purpose")]
    internal static extern void gtk_text_set_input_purpose(this GtkTextHandle self, GtkInputPurpose purpose);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_input_purpose")]
    internal static extern GtkInputPurpose gtk_text_get_input_purpose(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_input_hints")]
    internal static extern void gtk_text_set_input_hints(this GtkTextHandle self, GtkInputHints hints);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_input_hints")]
    internal static extern GtkInputHints gtk_text_get_input_hints(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_attributes")]
    internal static extern void gtk_text_set_attributes(this GtkTextHandle self, PangoAttrListHandle attrs);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_attributes")]
    internal static extern PangoAttrListHandle gtk_text_get_attributes(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_tabs")]
    internal static extern void gtk_text_set_tabs(this GtkTextHandle self, PangoTabArrayHandle tabs);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_tabs")]
    internal static extern PangoTabArrayHandle gtk_text_get_tabs(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_grab_focus_without_selecting")]
    internal static extern int gtk_text_grab_focus_without_selecting(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_extra_menu")]
    internal static extern void gtk_text_set_extra_menu(this GtkTextHandle self, GMenuModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_extra_menu")]
    internal static extern GMenuModelHandle gtk_text_get_extra_menu(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_enable_emoji_completion")]
    internal static extern void gtk_text_set_enable_emoji_completion(this GtkTextHandle self, int enable_emoji_completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_enable_emoji_completion")]
    internal static extern int gtk_text_get_enable_emoji_completion(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_propagate_text_width")]
    internal static extern void gtk_text_set_propagate_text_width(this GtkTextHandle self, int propagate_text_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_propagate_text_width")]
    internal static extern int gtk_text_get_propagate_text_width(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_set_truncate_multiline")]
    internal static extern void gtk_text_set_truncate_multiline(this GtkTextHandle self, int truncate_multiline);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_get_truncate_multiline")]
    internal static extern int gtk_text_get_truncate_multiline(this GtkTextHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_compute_cursor_extents")]
    internal static extern void gtk_text_compute_cursor_extents(this GtkTextHandle self, nuint position, graphene_rect_tHandle strong, graphene_rect_tHandle weak);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTextHandle gtk_text_new();
}
