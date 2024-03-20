using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLabelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_text")]
    internal static extern void gtk_label_set_text(this GtkLabelHandle self, string str);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_text")]
    internal static extern string gtk_label_get_text(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_attributes")]
    internal static extern void gtk_label_set_attributes(this GtkLabelHandle self, PangoAttrListHandle attrs);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_attributes")]
    internal static extern PangoAttrListHandle gtk_label_get_attributes(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_label")]
    internal static extern void gtk_label_set_label(this GtkLabelHandle self, string str);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_label")]
    internal static extern string gtk_label_get_label(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_markup")]
    internal static extern void gtk_label_set_markup(this GtkLabelHandle self, string str);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_use_markup")]
    internal static extern void gtk_label_set_use_markup(this GtkLabelHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_use_markup")]
    internal static extern int gtk_label_get_use_markup(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_use_underline")]
    internal static extern void gtk_label_set_use_underline(this GtkLabelHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_use_underline")]
    internal static extern int gtk_label_get_use_underline(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_markup_with_mnemonic")]
    internal static extern void gtk_label_set_markup_with_mnemonic(this GtkLabelHandle self, string str);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_mnemonic_keyval")]
    internal static extern uint gtk_label_get_mnemonic_keyval(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_mnemonic_widget")]
    internal static extern void gtk_label_set_mnemonic_widget(this GtkLabelHandle self, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_mnemonic_widget")]
    internal static extern GtkWidgetHandle gtk_label_get_mnemonic_widget(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_text_with_mnemonic")]
    internal static extern void gtk_label_set_text_with_mnemonic(this GtkLabelHandle self, string str);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_justify")]
    internal static extern void gtk_label_set_justify(this GtkLabelHandle self, GtkJustification jtype);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_justify")]
    internal static extern GtkJustification gtk_label_get_justify(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_ellipsize")]
    internal static extern void gtk_label_set_ellipsize(this GtkLabelHandle self, PangoEllipsizeMode mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_ellipsize")]
    internal static extern PangoEllipsizeMode gtk_label_get_ellipsize(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_width_chars")]
    internal static extern void gtk_label_set_width_chars(this GtkLabelHandle self, int n_chars);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_width_chars")]
    internal static extern int gtk_label_get_width_chars(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_max_width_chars")]
    internal static extern void gtk_label_set_max_width_chars(this GtkLabelHandle self, int n_chars);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_max_width_chars")]
    internal static extern int gtk_label_get_max_width_chars(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_lines")]
    internal static extern void gtk_label_set_lines(this GtkLabelHandle self, int lines);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_lines")]
    internal static extern int gtk_label_get_lines(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_wrap")]
    internal static extern void gtk_label_set_wrap(this GtkLabelHandle self, int wrap);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_wrap")]
    internal static extern int gtk_label_get_wrap(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_wrap_mode")]
    internal static extern void gtk_label_set_wrap_mode(this GtkLabelHandle self, PangoWrapMode wrap_mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_wrap_mode")]
    internal static extern PangoWrapMode gtk_label_get_wrap_mode(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_natural_wrap_mode")]
    internal static extern void gtk_label_set_natural_wrap_mode(this GtkLabelHandle self, GtkNaturalWrapMode wrap_mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_natural_wrap_mode")]
    internal static extern GtkNaturalWrapMode gtk_label_get_natural_wrap_mode(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_selectable")]
    internal static extern void gtk_label_set_selectable(this GtkLabelHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_selectable")]
    internal static extern int gtk_label_get_selectable(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_select_region")]
    internal static extern void gtk_label_select_region(this GtkLabelHandle self, int start_offset, int end_offset);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_selection_bounds")]
    internal static extern int gtk_label_get_selection_bounds(this GtkLabelHandle self, out int start, out int end);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_layout")]
    internal static extern PangoLayoutHandle gtk_label_get_layout(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_layout_offsets")]
    internal static extern void gtk_label_get_layout_offsets(this GtkLabelHandle self, out int x, out int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_single_line_mode")]
    internal static extern void gtk_label_set_single_line_mode(this GtkLabelHandle self, int single_line_mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_single_line_mode")]
    internal static extern int gtk_label_get_single_line_mode(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_current_uri")]
    internal static extern string gtk_label_get_current_uri(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_xalign")]
    internal static extern void gtk_label_set_xalign(this GtkLabelHandle self, float xalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_xalign")]
    internal static extern float gtk_label_get_xalign(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_yalign")]
    internal static extern void gtk_label_set_yalign(this GtkLabelHandle self, float yalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_yalign")]
    internal static extern float gtk_label_get_yalign(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_set_extra_menu")]
    internal static extern void gtk_label_set_extra_menu(this GtkLabelHandle self, GMenuModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_label_get_extra_menu")]
    internal static extern GMenuModelHandle gtk_label_get_extra_menu(this GtkLabelHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLabelHandle gtk_label_new(string str);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLabelHandle gtk_label_new_with_mnemonic(string str);
}
