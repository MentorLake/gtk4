using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Gsk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;

public static class GtkWidgetExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_unparent")]
	internal static extern void gtk_widget_unparent(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_show")]
	internal static extern void gtk_widget_show(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_hide")]
	internal static extern void gtk_widget_hide(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_map")]
	internal static extern void gtk_widget_map(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_unmap")]
	internal static extern void gtk_widget_unmap(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_realize")]
	internal static extern void gtk_widget_realize(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_unrealize")]
	internal static extern void gtk_widget_unrealize(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_queue_draw")]
	internal static extern void gtk_widget_queue_draw(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_queue_resize")]
	internal static extern void gtk_widget_queue_resize(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_queue_allocate")]
	internal static extern void gtk_widget_queue_allocate(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_frame_clock")]
	internal static extern GdkFrameClockHandle gtk_widget_get_frame_clock(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_size_allocate")]
	internal static extern void gtk_widget_size_allocate(this GtkWidgetHandle widget, GtkAllocationHandle allocation, int baseline);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_allocate")]
	internal static extern void gtk_widget_allocate(this GtkWidgetHandle widget, int width, int height, int baseline, GskTransformHandle transform);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_request_mode")]
	internal static extern GtkSizeRequestMode gtk_widget_get_request_mode(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_measure")]
	internal static extern void gtk_widget_measure(this GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_preferred_size")]
	internal static extern void gtk_widget_get_preferred_size(this GtkWidgetHandle widget, GtkRequisitionHandle minimum_size, GtkRequisitionHandle natural_size);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_layout_manager")]
	internal static extern void gtk_widget_set_layout_manager(this GtkWidgetHandle widget, GtkLayoutManagerHandle layout_manager);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_layout_manager")]
	internal static extern GtkLayoutManagerHandle gtk_widget_get_layout_manager(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_mnemonic_activate")]
	internal static extern int gtk_widget_mnemonic_activate(this GtkWidgetHandle widget, int group_cycling);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_activate")]
	internal static extern int gtk_widget_activate(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_can_focus")]
	internal static extern void gtk_widget_set_can_focus(this GtkWidgetHandle widget, int can_focus);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_can_focus")]
	internal static extern int gtk_widget_get_can_focus(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_focusable")]
	internal static extern void gtk_widget_set_focusable(this GtkWidgetHandle widget, int focusable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_focusable")]
	internal static extern int gtk_widget_get_focusable(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_has_focus")]
	internal static extern int gtk_widget_has_focus(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_is_focus")]
	internal static extern int gtk_widget_is_focus(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_has_visible_focus")]
	internal static extern int gtk_widget_has_visible_focus(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_grab_focus")]
	internal static extern int gtk_widget_grab_focus(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_focus_on_click")]
	internal static extern void gtk_widget_set_focus_on_click(this GtkWidgetHandle widget, int focus_on_click);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_focus_on_click")]
	internal static extern int gtk_widget_get_focus_on_click(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_can_target")]
	internal static extern void gtk_widget_set_can_target(this GtkWidgetHandle widget, int can_target);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_can_target")]
	internal static extern int gtk_widget_get_can_target(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_has_default")]
	internal static extern int gtk_widget_has_default(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_receives_default")]
	internal static extern void gtk_widget_set_receives_default(this GtkWidgetHandle widget, int receives_default);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_receives_default")]
	internal static extern int gtk_widget_get_receives_default(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_name")]
	internal static extern void gtk_widget_set_name(this GtkWidgetHandle widget, string name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_name")]
	internal static extern string gtk_widget_get_name(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_state_flags")]
	internal static extern void gtk_widget_set_state_flags(this GtkWidgetHandle widget, GtkStateFlags flags, int clear);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_unset_state_flags")]
	internal static extern void gtk_widget_unset_state_flags(this GtkWidgetHandle widget, GtkStateFlags flags);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_state_flags")]
	internal static extern GtkStateFlags gtk_widget_get_state_flags(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_sensitive")]
	internal static extern void gtk_widget_set_sensitive(this GtkWidgetHandle widget, int sensitive);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_sensitive")]
	internal static extern int gtk_widget_get_sensitive(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_is_sensitive")]
	internal static extern int gtk_widget_is_sensitive(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_visible")]
	internal static extern void gtk_widget_set_visible(this GtkWidgetHandle widget, int visible);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_visible")]
	internal static extern int gtk_widget_get_visible(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_is_visible")]
	internal static extern int gtk_widget_is_visible(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_is_drawable")]
	internal static extern int gtk_widget_is_drawable(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_realized")]
	internal static extern int gtk_widget_get_realized(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_mapped")]
	internal static extern int gtk_widget_get_mapped(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_parent")]
	internal static extern void gtk_widget_set_parent(this GtkWidgetHandle widget, GtkWidgetHandle parent);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_parent")]
	internal static extern GtkWidgetHandle gtk_widget_get_parent(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_root")]
	internal static extern GtkRootHandle gtk_widget_get_root(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_native")]
	internal static extern GtkNativeHandle gtk_widget_get_native(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_child_visible")]
	internal static extern void gtk_widget_set_child_visible(this GtkWidgetHandle widget, int child_visible);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_child_visible")]
	internal static extern int gtk_widget_get_child_visible(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_allocated_width")]
	internal static extern int gtk_widget_get_allocated_width(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_allocated_height")]
	internal static extern int gtk_widget_get_allocated_height(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_allocated_baseline")]
	internal static extern int gtk_widget_get_allocated_baseline(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_allocation")]
	internal static extern void gtk_widget_get_allocation(this GtkWidgetHandle widget, GtkAllocationHandle allocation);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_compute_transform")]
	internal static extern int gtk_widget_compute_transform(this GtkWidgetHandle widget, GtkWidgetHandle target, graphene_matrix_tHandle out_transform);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_compute_bounds")]
	internal static extern int gtk_widget_compute_bounds(this GtkWidgetHandle widget, GtkWidgetHandle target, graphene_rect_tHandle out_bounds);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_compute_point")]
	internal static extern int gtk_widget_compute_point(this GtkWidgetHandle widget, GtkWidgetHandle target, graphene_point_tHandle point, graphene_point_tHandle out_point);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_width")]
	internal static extern int gtk_widget_get_width(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_height")]
	internal static extern int gtk_widget_get_height(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_size")]
	internal static extern int gtk_widget_get_size(this GtkWidgetHandle widget, GtkOrientation orientation);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_child_focus")]
	internal static extern int gtk_widget_child_focus(this GtkWidgetHandle widget, GtkDirectionType direction);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_keynav_failed")]
	internal static extern int gtk_widget_keynav_failed(this GtkWidgetHandle widget, GtkDirectionType direction);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_error_bell")]
	internal static extern void gtk_widget_error_bell(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_size_request")]
	internal static extern void gtk_widget_set_size_request(this GtkWidgetHandle widget, int width, int height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_size_request")]
	internal static extern void gtk_widget_get_size_request(this GtkWidgetHandle widget, out int width, out int height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_opacity")]
	internal static extern void gtk_widget_set_opacity(this GtkWidgetHandle widget, double opacity);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_opacity")]
	internal static extern double gtk_widget_get_opacity(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_overflow")]
	internal static extern void gtk_widget_set_overflow(this GtkWidgetHandle widget, GtkOverflow overflow);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_overflow")]
	internal static extern GtkOverflow gtk_widget_get_overflow(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_ancestor")]
	internal static extern GtkWidgetHandle gtk_widget_get_ancestor(this GtkWidgetHandle widget, GType widget_type);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_scale_factor")]
	internal static extern int gtk_widget_get_scale_factor(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_display")]
	internal static extern GdkDisplayHandle gtk_widget_get_display(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_settings")]
	internal static extern GtkSettingsHandle gtk_widget_get_settings(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_clipboard")]
	internal static extern GdkClipboardHandle gtk_widget_get_clipboard(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_primary_clipboard")]
	internal static extern GdkClipboardHandle gtk_widget_get_primary_clipboard(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_hexpand")]
	internal static extern int gtk_widget_get_hexpand(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_hexpand")]
	internal static extern void gtk_widget_set_hexpand(this GtkWidgetHandle widget, int expand);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_hexpand_set")]
	internal static extern int gtk_widget_get_hexpand_set(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_hexpand_set")]
	internal static extern void gtk_widget_set_hexpand_set(this GtkWidgetHandle widget, int set);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_vexpand")]
	internal static extern int gtk_widget_get_vexpand(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_vexpand")]
	internal static extern void gtk_widget_set_vexpand(this GtkWidgetHandle widget, int expand);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_vexpand_set")]
	internal static extern int gtk_widget_get_vexpand_set(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_vexpand_set")]
	internal static extern void gtk_widget_set_vexpand_set(this GtkWidgetHandle widget, int set);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_compute_expand")]
	internal static extern int gtk_widget_compute_expand(this GtkWidgetHandle widget, GtkOrientation orientation);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_halign")]
	internal static extern GtkAlign gtk_widget_get_halign(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_halign")]
	internal static extern void gtk_widget_set_halign(this GtkWidgetHandle widget, GtkAlign align);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_valign")]
	internal static extern GtkAlign gtk_widget_get_valign(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_valign")]
	internal static extern void gtk_widget_set_valign(this GtkWidgetHandle widget, GtkAlign align);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_margin_start")]
	internal static extern int gtk_widget_get_margin_start(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_margin_start")]
	internal static extern void gtk_widget_set_margin_start(this GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_margin_end")]
	internal static extern int gtk_widget_get_margin_end(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_margin_end")]
	internal static extern void gtk_widget_set_margin_end(this GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_margin_top")]
	internal static extern int gtk_widget_get_margin_top(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_margin_top")]
	internal static extern void gtk_widget_set_margin_top(this GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_margin_bottom")]
	internal static extern int gtk_widget_get_margin_bottom(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_margin_bottom")]
	internal static extern void gtk_widget_set_margin_bottom(this GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_is_ancestor")]
	internal static extern int gtk_widget_is_ancestor(this GtkWidgetHandle widget, GtkWidgetHandle ancestor);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_translate_coordinates")]
	internal static extern int gtk_widget_translate_coordinates(this GtkWidgetHandle src_widget, GtkWidgetHandle dest_widget, double src_x, double src_y, out double dest_x, out double dest_y);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_contains")]
	internal static extern int gtk_widget_contains(this GtkWidgetHandle widget, double x, double y);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_pick")]
	internal static extern GtkWidgetHandle gtk_widget_pick(this GtkWidgetHandle widget, double x, double y, GtkPickFlags flags);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_add_controller")]
	internal static extern void gtk_widget_add_controller(this GtkWidgetHandle widget, GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_remove_controller")]
	internal static extern void gtk_widget_remove_controller(this GtkWidgetHandle widget, GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_create_pango_context")]
	internal static extern PangoContextHandle gtk_widget_create_pango_context(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_pango_context")]
	internal static extern PangoContextHandle gtk_widget_get_pango_context(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_font_options")]
	internal static extern void gtk_widget_set_font_options(this GtkWidgetHandle widget, cairo_font_optionsHandle options);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_font_options")]
	internal static extern cairo_font_optionsHandle gtk_widget_get_font_options(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_create_pango_layout")]
	internal static extern PangoLayoutHandle gtk_widget_create_pango_layout(this GtkWidgetHandle widget, string text);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_direction")]
	internal static extern void gtk_widget_set_direction(this GtkWidgetHandle widget, GtkTextDirection dir);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_direction")]
	internal static extern GtkTextDirection gtk_widget_get_direction(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_cursor")]
	internal static extern void gtk_widget_set_cursor(this GtkWidgetHandle widget, GdkCursorHandle cursor);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_cursor_from_name")]
	internal static extern void gtk_widget_set_cursor_from_name(this GtkWidgetHandle widget, string name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_cursor")]
	internal static extern GdkCursorHandle gtk_widget_get_cursor(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_list_mnemonic_labels")]
	internal static extern GListHandle gtk_widget_list_mnemonic_labels(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_add_mnemonic_label")]
	internal static extern void gtk_widget_add_mnemonic_label(this GtkWidgetHandle widget, GtkWidgetHandle label);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_remove_mnemonic_label")]
	internal static extern void gtk_widget_remove_mnemonic_label(this GtkWidgetHandle widget, GtkWidgetHandle label);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_trigger_tooltip_query")]
	internal static extern void gtk_widget_trigger_tooltip_query(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_tooltip_text")]
	internal static extern void gtk_widget_set_tooltip_text(this GtkWidgetHandle widget, string text);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_tooltip_text")]
	internal static extern string gtk_widget_get_tooltip_text(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_tooltip_markup")]
	internal static extern void gtk_widget_set_tooltip_markup(this GtkWidgetHandle widget, string markup);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_tooltip_markup")]
	internal static extern string gtk_widget_get_tooltip_markup(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_has_tooltip")]
	internal static extern void gtk_widget_set_has_tooltip(this GtkWidgetHandle widget, int has_tooltip);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_has_tooltip")]
	internal static extern int gtk_widget_get_has_tooltip(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_in_destruction")]
	internal static extern int gtk_widget_in_destruction(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_style_context")]
	internal static extern GtkStyleContextHandle gtk_widget_get_style_context(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_add_tick_callback")]
	internal static extern uint gtk_widget_add_tick_callback(this GtkWidgetHandle widget, GtkTickCallback callback, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_remove_tick_callback")]
	internal static extern void gtk_widget_remove_tick_callback(this GtkWidgetHandle widget, uint id);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_init_template")]
	internal static extern void gtk_widget_init_template(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_template_child")]
	internal static extern GObjectHandle gtk_widget_get_template_child(this GtkWidgetHandle widget, GType widget_type, string name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_insert_action_group")]
	internal static extern void gtk_widget_insert_action_group(this GtkWidgetHandle widget, string name, GActionGroupHandle group);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_activate_action")]
	internal static extern int gtk_widget_activate_action(this GtkWidgetHandle widget, string name, string format_string, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_activate_action_variant")]
	internal static extern int gtk_widget_activate_action_variant(this GtkWidgetHandle widget, string name, GVariantHandle args);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_activate_default")]
	internal static extern void gtk_widget_activate_default(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_font_map")]
	internal static extern void gtk_widget_set_font_map(this GtkWidgetHandle widget, PangoFontMapHandle font_map);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_font_map")]
	internal static extern PangoFontMapHandle gtk_widget_get_font_map(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_first_child")]
	internal static extern GtkWidgetHandle gtk_widget_get_first_child(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_last_child")]
	internal static extern GtkWidgetHandle gtk_widget_get_last_child(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_next_sibling")]
	internal static extern GtkWidgetHandle gtk_widget_get_next_sibling(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_prev_sibling")]
	internal static extern GtkWidgetHandle gtk_widget_get_prev_sibling(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_observe_children")]
	internal static extern GListModelHandle gtk_widget_observe_children(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_observe_controllers")]
	internal static extern GListModelHandle gtk_widget_observe_controllers(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_insert_after")]
	internal static extern void gtk_widget_insert_after(this GtkWidgetHandle widget, GtkWidgetHandle parent, GtkWidgetHandle previous_sibling);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_insert_before")]
	internal static extern void gtk_widget_insert_before(this GtkWidgetHandle widget, GtkWidgetHandle parent, GtkWidgetHandle next_sibling);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_focus_child")]
	internal static extern void gtk_widget_set_focus_child(this GtkWidgetHandle widget, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_focus_child")]
	internal static extern GtkWidgetHandle gtk_widget_get_focus_child(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_snapshot_child")]
	internal static extern void gtk_widget_snapshot_child(this GtkWidgetHandle widget, GtkWidgetHandle child, GtkSnapshotHandle snapshot);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_should_layout")]
	internal static extern int gtk_widget_should_layout(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_css_name")]
	internal static extern string gtk_widget_get_css_name(this GtkWidgetHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_add_css_class")]
	internal static extern void gtk_widget_add_css_class(this GtkWidgetHandle widget, string css_class);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_remove_css_class")]
	internal static extern void gtk_widget_remove_css_class(this GtkWidgetHandle widget, string css_class);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_has_css_class")]
	internal static extern int gtk_widget_has_css_class(this GtkWidgetHandle widget, string css_class);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_get_css_classes")]
	internal static extern string[] gtk_widget_get_css_classes(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_set_css_classes")]
	internal static extern void gtk_widget_set_css_classes(this GtkWidgetHandle widget, string[] classes);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_action_set_enabled")]
	internal static extern void gtk_widget_action_set_enabled(this GtkWidgetHandle widget, string action_name, int enabled);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_check_threshold")]
	internal static extern int gtk_drag_check_threshold(this GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_widget_wait_for_draw")]
	internal static extern void gtk_test_widget_wait_for_draw(this GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_paintable_new")]
	internal static extern GdkPaintableHandle gtk_widget_paintable_new(this GtkWidgetHandle widget);
}
