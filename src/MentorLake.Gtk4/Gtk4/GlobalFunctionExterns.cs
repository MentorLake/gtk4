using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

internal class GlobalFunctionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_get_binary_age();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_enumerate_printers(GtkPrinterFunc func, IntPtr data, GDestroyNotify destroy, bool wait);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_accelerator_parse(string accelerator, out uint accelerator_key, out GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk4)]
	internal static extern GQuark gtk_css_parser_error_quark();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_test_init(ref int argcp, ref string[] argvp, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_value_get_expression(GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_hsv_to_rgb(float h, float s, float v, out float r, out float g, out float b);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_distribute_natural_allocation(int extra_space, uint n_requested_sizes, GtkRequestedSize[] sizes);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_test_accessible_has_state(GtkAccessibleHandle accessible, GtkAccessibleState state);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_set_debug_flags(GtkDebugFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_init_check();

	[DllImport(Libraries.Gtk4)]
	internal static extern GType[] gtk_test_list_all_types(out uint n_types);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_get_minor_version();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_accelerator_parse_with_keycode(string accelerator, GdkDisplayHandle display, out uint accelerator_key, out uint[] accelerator_codes, out GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_test_accessible_check_property(GtkAccessibleHandle accessible, GtkAccessibleProperty property, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_test_accessible_check_state(GtkAccessibleHandle accessible, GtkAccessibleState state, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_disable_setlocale();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_test_register_all_types();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextDirection gtk_get_locale_direction();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_value_take_expression(GValueHandle value, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_get_row_drag_data(GValueHandle value, out GtkTreeModelHandle tree_model, out GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GQuark gtk_css_parser_warning_quark();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_test_accessible_has_relation(GtkAccessibleHandle accessible, GtkAccessibleRelation relation);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_accelerator_get_label(uint accelerator_key, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_get_micro_version();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_init();

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkModifierType gtk_accelerator_get_default_mod_mask();

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLanguageHandle gtk_get_default_language();

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_test_accessible_check_relation(GtkAccessibleHandle accessible, GtkAccessibleRelation relation, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_accelerator_get_label_with_keycode(GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDebugFlags gtk_get_debug_flags();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_value_dup_expression(GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_accelerator_name(uint accelerator_key, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk4)]
	internal static extern GParamSpecHandle gtk_param_spec_expression(string name, string nick, string blurb, GParamFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_accelerator_name_with_keycode(GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_accelerator_valid(uint keyval, GdkModifierType modifiers);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_test_accessible_has_property(GtkAccessibleHandle accessible, GtkAccessibleProperty property);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_rgb_to_hsv(float r, float g, float b, out float h, out float s, out float v);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentProviderHandle gtk_tree_create_row_drag_content(GtkTreeModelHandle tree_model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_test_accessible_assertion_message_role(string domain, string file, int line, string func, string expr, GtkAccessibleHandle accessible, GtkAccessibleRole expected_role, GtkAccessibleRole actual_role);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_get_major_version();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_is_initialized();

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_get_interface_age();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_value_set_expression(GValueHandle value, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_test_accessible_has_role(GtkAccessibleHandle accessible, GtkAccessibleRole role);

}
