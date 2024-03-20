using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GtkWidgetClassExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_layout_manager_type")]
	internal static extern void gtk_widget_class_set_layout_manager_type(this GtkWidgetClassHandle widget_class, GType type);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_get_layout_manager_type")]
	internal static extern GType gtk_widget_class_get_layout_manager_type(this GtkWidgetClassHandle widget_class);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_add_binding")]
	internal static extern void gtk_widget_class_add_binding(this GtkWidgetClassHandle widget_class, uint keyval, GdkModifierType mods, GtkShortcutFunc callback, string format_string, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_add_binding_signal")]
	internal static extern void gtk_widget_class_add_binding_signal(this GtkWidgetClassHandle widget_class, uint keyval, GdkModifierType mods, string signal, string format_string, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_add_binding_action")]
	internal static extern void gtk_widget_class_add_binding_action(this GtkWidgetClassHandle widget_class, uint keyval, GdkModifierType mods, string action_name, string format_string, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_add_shortcut")]
	internal static extern void gtk_widget_class_add_shortcut(this GtkWidgetClassHandle widget_class, GtkShortcutHandle shortcut);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_activate_signal")]
	internal static extern void gtk_widget_class_set_activate_signal(this GtkWidgetClassHandle widget_class, uint signal_id);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_activate_signal_from_name")]
	internal static extern void gtk_widget_class_set_activate_signal_from_name(this GtkWidgetClassHandle widget_class, string signal_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_get_activate_signal")]
	internal static extern uint gtk_widget_class_get_activate_signal(this GtkWidgetClassHandle widget_class);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_css_name")]
	internal static extern void gtk_widget_class_set_css_name(this GtkWidgetClassHandle widget_class, string name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_get_css_name")]
	internal static extern string gtk_widget_class_get_css_name(this GtkWidgetClassHandle widget_class);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_template")]
	internal static extern void gtk_widget_class_set_template(this GtkWidgetClassHandle widget_class, GBytesHandle template_bytes);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_template_from_resource")]
	internal static extern void gtk_widget_class_set_template_from_resource(this GtkWidgetClassHandle widget_class, string resource_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_bind_template_callback_full")]
	internal static extern void gtk_widget_class_bind_template_callback_full(this GtkWidgetClassHandle widget_class, string callback_name, GCallback callback_symbol);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_template_scope")]
	internal static extern void gtk_widget_class_set_template_scope(this GtkWidgetClassHandle widget_class, GtkBuilderScopeHandle scope);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_bind_template_child_full")]
	internal static extern void gtk_widget_class_bind_template_child_full(this GtkWidgetClassHandle widget_class, string name, int internal_child, nint struct_offset);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_install_action")]
	internal static extern void gtk_widget_class_install_action(this GtkWidgetClassHandle widget_class, string action_name, string parameter_type, GtkWidgetActionActivateFunc activate);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_install_property_action")]
	internal static extern void gtk_widget_class_install_property_action(this GtkWidgetClassHandle widget_class, string action_name, string property_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_query_action")]
	internal static extern int gtk_widget_class_query_action(this GtkWidgetClassHandle widget_class, uint index_, GTypeHandle owner, out string action_name, out GVariantTypeHandle parameter_type, out string property_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_set_accessible_role")]
	internal static extern void gtk_widget_class_set_accessible_role(this GtkWidgetClassHandle widget_class, GtkAccessibleRole accessible_role);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_widget_class_get_accessible_role")]
	internal static extern GtkAccessibleRole gtk_widget_class_get_accessible_role(this GtkWidgetClassHandle widget_class);
}
