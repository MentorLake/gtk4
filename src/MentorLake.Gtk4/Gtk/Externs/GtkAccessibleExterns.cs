using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GtkAccessibleExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_get_accessible_role")]
	internal static extern GtkAccessibleRole gtk_accessible_get_accessible_role(this GtkAccessibleHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_update_state")]
	internal static extern void gtk_accessible_update_state(this GtkAccessibleHandle self, GtkAccessibleState first_state, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_update_property")]
	internal static extern void gtk_accessible_update_property(this GtkAccessibleHandle self, GtkAccessibleProperty first_property, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_update_relation")]
	internal static extern void gtk_accessible_update_relation(this GtkAccessibleHandle self, GtkAccessibleRelation first_relation, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_update_state_value")]
	internal static extern void gtk_accessible_update_state_value(this GtkAccessibleHandle self, int n_states, GtkAccessibleState[] states, GValue[] values);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_update_property_value")]
	internal static extern void gtk_accessible_update_property_value(this GtkAccessibleHandle self, int n_properties, GtkAccessibleProperty[] properties, GValue[] values);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_update_relation_value")]
	internal static extern void gtk_accessible_update_relation_value(this GtkAccessibleHandle self, int n_relations, GtkAccessibleRelation[] relations, GValue[] values);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_reset_state")]
	internal static extern void gtk_accessible_reset_state(this GtkAccessibleHandle self, GtkAccessibleState state);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_reset_property")]
	internal static extern void gtk_accessible_reset_property(this GtkAccessibleHandle self, GtkAccessibleProperty property);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accessible_reset_relation")]
	internal static extern void gtk_accessible_reset_relation(this GtkAccessibleHandle self, GtkAccessibleRelation relation);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_accessible_has_role")]
	internal static extern int gtk_test_accessible_has_role(this GtkAccessibleHandle accessible, GtkAccessibleRole role);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_accessible_has_property")]
	internal static extern int gtk_test_accessible_has_property(this GtkAccessibleHandle accessible, GtkAccessibleProperty property);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_accessible_has_relation")]
	internal static extern int gtk_test_accessible_has_relation(this GtkAccessibleHandle accessible, GtkAccessibleRelation relation);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_accessible_has_state")]
	internal static extern int gtk_test_accessible_has_state(this GtkAccessibleHandle accessible, GtkAccessibleState state);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_accessible_check_property")]
	internal static extern string gtk_test_accessible_check_property(this GtkAccessibleHandle accessible, GtkAccessibleProperty property, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_accessible_check_relation")]
	internal static extern string gtk_test_accessible_check_relation(this GtkAccessibleHandle accessible, GtkAccessibleRelation relation, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_test_accessible_check_state")]
	internal static extern string gtk_test_accessible_check_state(this GtkAccessibleHandle accessible, GtkAccessibleState state, IntPtr @__argList);
}
