using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEntryExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_buffer")]
    internal static extern GtkEntryBufferHandle gtk_entry_get_buffer(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_buffer")]
    internal static extern void gtk_entry_set_buffer(this GtkEntryHandle entry, GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_visibility")]
    internal static extern void gtk_entry_set_visibility(this GtkEntryHandle entry, int visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_visibility")]
    internal static extern int gtk_entry_get_visibility(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_invisible_char")]
    internal static extern void gtk_entry_set_invisible_char(this GtkEntryHandle entry, uint ch);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_invisible_char")]
    internal static extern uint gtk_entry_get_invisible_char(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_unset_invisible_char")]
    internal static extern void gtk_entry_unset_invisible_char(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_has_frame")]
    internal static extern void gtk_entry_set_has_frame(this GtkEntryHandle entry, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_has_frame")]
    internal static extern int gtk_entry_get_has_frame(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_overwrite_mode")]
    internal static extern void gtk_entry_set_overwrite_mode(this GtkEntryHandle entry, int overwrite);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_overwrite_mode")]
    internal static extern int gtk_entry_get_overwrite_mode(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_max_length")]
    internal static extern void gtk_entry_set_max_length(this GtkEntryHandle entry, int max);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_max_length")]
    internal static extern int gtk_entry_get_max_length(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_text_length")]
    internal static extern ushort gtk_entry_get_text_length(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_activates_default")]
    internal static extern void gtk_entry_set_activates_default(this GtkEntryHandle entry, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_activates_default")]
    internal static extern int gtk_entry_get_activates_default(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_alignment")]
    internal static extern void gtk_entry_set_alignment(this GtkEntryHandle entry, float xalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_alignment")]
    internal static extern float gtk_entry_get_alignment(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_completion")]
    internal static extern void gtk_entry_set_completion(this GtkEntryHandle entry, GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_completion")]
    internal static extern GtkEntryCompletionHandle gtk_entry_get_completion(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_progress_fraction")]
    internal static extern void gtk_entry_set_progress_fraction(this GtkEntryHandle entry, double fraction);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_progress_fraction")]
    internal static extern double gtk_entry_get_progress_fraction(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_progress_pulse_step")]
    internal static extern void gtk_entry_set_progress_pulse_step(this GtkEntryHandle entry, double fraction);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_progress_pulse_step")]
    internal static extern double gtk_entry_get_progress_pulse_step(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_progress_pulse")]
    internal static extern void gtk_entry_progress_pulse(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_placeholder_text")]
    internal static extern string gtk_entry_get_placeholder_text(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_placeholder_text")]
    internal static extern void gtk_entry_set_placeholder_text(this GtkEntryHandle entry, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_from_paintable")]
    internal static extern void gtk_entry_set_icon_from_paintable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkPaintableHandle paintable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_from_icon_name")]
    internal static extern void gtk_entry_set_icon_from_icon_name(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string icon_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_from_gicon")]
    internal static extern void gtk_entry_set_icon_from_gicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GIconHandle icon);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_storage_type")]
    internal static extern GtkImageType gtk_entry_get_icon_storage_type(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_paintable")]
    internal static extern GdkPaintableHandle gtk_entry_get_icon_paintable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_name")]
    internal static extern string gtk_entry_get_icon_name(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_gicon")]
    internal static extern GIconHandle gtk_entry_get_icon_gicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_activatable")]
    internal static extern void gtk_entry_set_icon_activatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, int activatable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_activatable")]
    internal static extern int gtk_entry_get_icon_activatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_sensitive")]
    internal static extern void gtk_entry_set_icon_sensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, int sensitive);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_sensitive")]
    internal static extern int gtk_entry_get_icon_sensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_at_pos")]
    internal static extern int gtk_entry_get_icon_at_pos(this GtkEntryHandle entry, int x, int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_tooltip_text")]
    internal static extern void gtk_entry_set_icon_tooltip_text(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_tooltip_text")]
    internal static extern string gtk_entry_get_icon_tooltip_text(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_tooltip_markup")]
    internal static extern void gtk_entry_set_icon_tooltip_markup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_tooltip_markup")]
    internal static extern string gtk_entry_get_icon_tooltip_markup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_icon_drag_source")]
    internal static extern void gtk_entry_set_icon_drag_source(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkContentProviderHandle provider, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_current_icon_drag_source")]
    internal static extern int gtk_entry_get_current_icon_drag_source(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_icon_area")]
    internal static extern void gtk_entry_get_icon_area(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkRectangleHandle icon_area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_reset_im_context")]
    internal static extern void gtk_entry_reset_im_context(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_input_purpose")]
    internal static extern void gtk_entry_set_input_purpose(this GtkEntryHandle entry, GtkInputPurpose purpose);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_input_purpose")]
    internal static extern GtkInputPurpose gtk_entry_get_input_purpose(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_input_hints")]
    internal static extern void gtk_entry_set_input_hints(this GtkEntryHandle entry, GtkInputHints hints);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_input_hints")]
    internal static extern GtkInputHints gtk_entry_get_input_hints(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_attributes")]
    internal static extern void gtk_entry_set_attributes(this GtkEntryHandle entry, PangoAttrListHandle attrs);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_attributes")]
    internal static extern PangoAttrListHandle gtk_entry_get_attributes(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_tabs")]
    internal static extern void gtk_entry_set_tabs(this GtkEntryHandle entry, PangoTabArrayHandle tabs);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_tabs")]
    internal static extern PangoTabArrayHandle gtk_entry_get_tabs(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_grab_focus_without_selecting")]
    internal static extern int gtk_entry_grab_focus_without_selecting(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_set_extra_menu")]
    internal static extern void gtk_entry_set_extra_menu(this GtkEntryHandle entry, GMenuModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_get_extra_menu")]
    internal static extern GMenuModelHandle gtk_entry_get_extra_menu(this GtkEntryHandle entry);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEntryHandle gtk_entry_new();
}
