using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;

public static class Methods
{
	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_css_parser_error_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_css_parser_warning_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_css_parser_error_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_css_parser_warning_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_css_section_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_accelerator_valid(uint keyval, GdkModifierType modifiers);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_accelerator_parse(string accelerator, out uint accelerator_key, out GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_accelerator_parse_with_keycode(string accelerator, GdkDisplayHandle display, out uint accelerator_key, out uint[] accelerator_codes, out GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string gtk_accelerator_name(uint accelerator_key, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string gtk_accelerator_get_label(uint accelerator_key, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GdkModifierType gtk_accelerator_get_default_mod_mask();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_border_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkShortcutActionHandle gtk_shortcut_action_parse_string(string @string);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_nothing_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkShortcutActionHandle gtk_nothing_action_get();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_callback_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_mnemonic_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkShortcutActionHandle gtk_mnemonic_action_get();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_activate_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkShortcutActionHandle gtk_activate_action_get();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_signal_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_named_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_widget_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_widget_set_default_direction(GtkTextDirection dir);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkTextDirection gtk_widget_get_default_direction();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_requisition_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_application_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_window_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_window_set_default_icon_name(string name);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string gtk_window_get_default_icon_name();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_window_set_auto_startup_notification(int setting);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GListModelHandle gtk_window_get_toplevels();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GListHandle gtk_window_list_toplevels();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_window_set_interactive_debugging(int enable);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_about_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_accessible_state_init_value(GtkAccessibleState state, GValueHandle value);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_accessible_property_init_value(GtkAccessibleProperty property, GValueHandle value);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_accessible_relation_init_value(GtkAccessibleRelation relation, GValueHandle value);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_actionable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_action_bar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_adjustment_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_app_chooser_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_app_chooser_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_app_chooser_widget_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_app_chooser_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcuts_window_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_application_window_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_aspect_frame_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_assistant_page_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_assistant_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_at_context_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkATContextHandle gtk_at_context_create(GtkAccessibleRole accessible_role, GtkAccessibleHandle accessible, GdkDisplayHandle display);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_layout_child_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_layout_manager_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_bin_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_bitset_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_bitset_iter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_bookmark_list_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_expression_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_expression_watch_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_property_expression_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constant_expression_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_object_expression_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_closure_expression_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cclosure_expression_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_param_expression_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle gtk_param_spec_expression(string name, string nick, string blurb, GParamFlags flags);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_bool_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_box_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_box_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_builder_scope_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_builder_cscope_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_builder_error_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_builder_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_buildable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_list_item_factory_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_builder_list_item_factory_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_calendar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_editable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_path_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_row_reference_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_iter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_area_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_area_box_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_area_context_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_text_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_accel_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_combo_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_pixbuf_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_progress_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_spin_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_spinner_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_toggle_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_view_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_center_box_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_center_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_toggle_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_check_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_color_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_color_chooser_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_color_chooser_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_color_chooser_widget_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_hsv_to_rgb(float h, float s, float v, out float r, out float g, out float b);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_rgb_to_hsv(float r, float g, float b, out float h, out float s, out float v);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_sorter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_sort_list_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_selection_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_column_view_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_column_view_column_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_sortable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_view_column_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_editable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_im_context_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_entry_buffer_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_list_store_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_model_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_entry_completion_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_image_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_entry_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_view_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_combo_box_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_combo_box_text_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_target_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_license_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_application_inhibit_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_assistant_page_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_builder_error_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_builder_closure_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_state_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_cell_renderer_accel_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_debug_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_dialog_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_response_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_editable_properties_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_entry_icon_position_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_align_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_arrow_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_baseline_position_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_delete_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_direction_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_icon_size_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_sensitivity_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_direction_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_justification_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_message_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_movement_step_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_natural_wrap_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scroll_step_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_orientation_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_overflow_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_pack_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_position_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scroll_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_selection_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_wrap_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_sort_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_pages_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_page_set_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_number_up_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_ordering_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_page_orientation_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_quality_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_duplex_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_unit_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_view_grid_lines_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_size_group_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_size_request_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scrollable_policy_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_state_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_border_style_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_level_bar_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_input_purpose_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_input_hints_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_propagation_phase_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_propagation_limit_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_sequence_state_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_pan_direction_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_scope_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_pick_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_relation_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_strength_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_attribute_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_vfl_parser_error_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_system_setting_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_symbolic_color_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_role_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_state_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_property_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_relation_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_tristate_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_invalid_state_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_autocomplete_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_accessible_sort_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_controller_scroll_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_file_chooser_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_file_chooser_error_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_filter_match_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_filter_change_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_font_chooser_level_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_icon_lookup_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_icon_theme_error_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_icon_view_drop_position_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_image_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_buttons_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_notebook_tab_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_pad_action_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_popover_menu_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_status_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_operation_result_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_operation_action_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_error_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_recent_manager_error_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_revealer_transition_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_corner_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_policy_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_action_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_sorter_order_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_sorter_change_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_spin_button_update_policy_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_spin_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_stack_transition_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_string_filter_match_mode_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_style_context_print_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_search_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_window_type_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_view_layer_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_extend_selection_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_model_flags_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_view_drop_position_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_view_column_sizing_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_guide_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_layout_child_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_constraint_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_constraint_vfl_parser_error_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_css_provider_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_custom_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_custom_sorter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkDebugFlags gtk_get_debug_flags();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_set_debug_flags(GtkDebugFlags flags);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_directory_list_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_drag_icon_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_drag_source_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_drawing_area_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_controller_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_drop_controller_motion_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_drop_target_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_drop_target_async_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_drop_down_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_editable_label_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_emoji_chooser_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_controller_focus_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_controller_key_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_controller_legacy_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_controller_motion_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_event_controller_scroll_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_expander_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_fixed_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_fixed_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_fixed_layout_child_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_file_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_file_chooser_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_file_chooser_error_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_file_chooser_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_native_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_file_chooser_native_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_file_chooser_widget_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_filter_list_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_custom_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_flatten_list_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_flow_box_child_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_flow_box_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_font_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_font_chooser_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_font_chooser_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_font_chooser_widget_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_frame_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_single_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_click_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_drag_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_long_press_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_pan_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_rotate_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_stylus_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_swipe_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gesture_zoom_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_gl_area_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_grid_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_grid_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_grid_layout_child_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_list_base_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_grid_view_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_header_bar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_icon_theme_error_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_icon_theme_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_icon_paintable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tooltip_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_icon_view_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_im_context_simple_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_im_multicontext_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_info_bar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_label_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_level_bar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_link_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_list_box_row_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_list_box_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_list_item_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_list_view_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_lock_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_init();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_init_check();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_is_initialized();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_disable_setlocale();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern PangoLanguageHandle gtk_get_default_language();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkTextDirection gtk_get_locale_direction();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_map_list_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_media_stream_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_media_controls_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_media_file_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_popover_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_menu_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_message_dialog_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_mount_operation_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_multi_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_any_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_every_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_multi_selection_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_multi_sorter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_native_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_no_selection_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_notebook_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_notebook_page_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_numeric_sorter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_orientable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_overlay_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_overlay_layout_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_overlay_layout_child_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_pad_controller_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_paper_size_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GListHandle gtk_paper_size_get_paper_sizes(int include_custom);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string gtk_paper_size_get_default();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_page_setup_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_paned_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_password_entry_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_password_entry_buffer_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_picture_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_popover_menu_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_popover_menu_bar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_context_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_settings_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_operation_preview_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_print_error_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_print_operation_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_progress_bar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_range_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gtk_recent_manager_error_quark();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_recent_manager_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkRecentManagerHandle gtk_recent_manager_get_default();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_recent_info_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void _gtk_recent_manager_sync();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_revealer_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_root_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scale_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scale_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scrollable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scrollbar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_scrolled_window_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_search_bar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_search_entry_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_selection_filter_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_separator_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_settings_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkSettingsHandle gtk_settings_get_default();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_controller_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_label_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_manager_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcuts_group_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcuts_section_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcuts_shortcut_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_shortcut_trigger_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkShortcutTriggerHandle gtk_shortcut_trigger_parse_string(string @string);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gtk_shortcut_trigger_hash(IntPtr trigger);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_shortcut_trigger_equal(IntPtr trigger1, IntPtr trigger2);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_shortcut_trigger_compare(IntPtr trigger1, IntPtr trigger2);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_never_trigger_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GtkShortcutTriggerHandle gtk_never_trigger_get();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_keyval_trigger_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_mnemonic_trigger_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_alternative_trigger_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_signal_list_item_factory_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_single_selection_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_slice_list_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_snapshot_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_stack_page_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_stack_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_stack_sidebar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_size_group_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gtk_distribute_natural_allocation(int extra_space, uint n_requested_sizes, GtkRequestedSizeHandle sizes);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_spin_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_spinner_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_stack_switcher_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_statusbar_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_string_filter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_string_object_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_string_list_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_string_sorter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_style_provider_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_style_context_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_switch_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_symbolic_paintable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_tag_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_tag_table_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_child_anchor_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_iter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_mark_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_buffer_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_text_view_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_test_accessible_assertion_message_role(string domain, string file, int line, string func, string expr, GtkAccessibleHandle accessible, GtkAccessibleRole expected_role, GtkAccessibleRole actual_role);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_test_init(ref int argcp, ref string[] argvp, __arglist);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gtk_test_register_all_types();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType[] gtk_test_list_all_types(out uint n_types);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_row_data_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_drag_source_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_drag_dest_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_list_model_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_list_row_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_expander_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_list_row_sorter_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_model_sort_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_selection_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_tree_store_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gtk_get_major_version();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gtk_get_minor_version();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gtk_get_micro_version();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gtk_get_binary_age();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gtk_get_interface_age();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string gtk_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_video_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_viewport_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_volume_button_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_widget_paintable_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_window_controls_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_window_group_get_type();

	[DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gtk_window_handle_get_type();
}
