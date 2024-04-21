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

public interface GtkAccessibleHandle
{
}

public static class GtkAccessibleHandleExtensions
{
	public static GtkAccessibleHandle Announce(this GtkAccessibleHandle self, string message, GtkAccessibleAnnouncementPriority priority)
	{
		GtkAccessibleExterns.gtk_accessible_announce(self, message, priority);
		return self;
	}

	public static GtkAccessibleHandle GetAccessibleParent(this GtkAccessibleHandle self)
	{
		return GtkAccessibleExterns.gtk_accessible_get_accessible_parent(self);
	}

	public static GtkAccessibleRole GetAccessibleRole(this GtkAccessibleHandle self)
	{
		return GtkAccessibleExterns.gtk_accessible_get_accessible_role(self);
	}

	public static GtkATContextHandle GetAtContext(this GtkAccessibleHandle self)
	{
		return GtkAccessibleExterns.gtk_accessible_get_at_context(self);
	}

	public static bool GetBounds(this GtkAccessibleHandle self, out int x, out int y, out int width, out int height)
	{
		return GtkAccessibleExterns.gtk_accessible_get_bounds(self, out x, out y, out width, out height);
	}

	public static GtkAccessibleHandle GetFirstAccessibleChild(this GtkAccessibleHandle self)
	{
		return GtkAccessibleExterns.gtk_accessible_get_first_accessible_child(self);
	}

	public static GtkAccessibleHandle GetNextAccessibleSibling(this GtkAccessibleHandle self)
	{
		return GtkAccessibleExterns.gtk_accessible_get_next_accessible_sibling(self);
	}

	public static bool GetPlatformState(this GtkAccessibleHandle self, GtkAccessiblePlatformState state)
	{
		return GtkAccessibleExterns.gtk_accessible_get_platform_state(self, state);
	}

	public static GtkAccessibleHandle ResetProperty(this GtkAccessibleHandle self, GtkAccessibleProperty property)
	{
		GtkAccessibleExterns.gtk_accessible_reset_property(self, property);
		return self;
	}

	public static GtkAccessibleHandle ResetRelation(this GtkAccessibleHandle self, GtkAccessibleRelation relation)
	{
		GtkAccessibleExterns.gtk_accessible_reset_relation(self, relation);
		return self;
	}

	public static GtkAccessibleHandle ResetState(this GtkAccessibleHandle self, GtkAccessibleState state)
	{
		GtkAccessibleExterns.gtk_accessible_reset_state(self, state);
		return self;
	}

	public static GtkAccessibleHandle SetAccessibleParent(this GtkAccessibleHandle self, GtkAccessibleHandle parent, GtkAccessibleHandle next_sibling)
	{
		GtkAccessibleExterns.gtk_accessible_set_accessible_parent(self, parent, next_sibling);
		return self;
	}

	public static GtkAccessibleHandle UpdateNextAccessibleSibling(this GtkAccessibleHandle self, GtkAccessibleHandle new_sibling)
	{
		GtkAccessibleExterns.gtk_accessible_update_next_accessible_sibling(self, new_sibling);
		return self;
	}

	public static GtkAccessibleHandle UpdateProperty(this GtkAccessibleHandle self, GtkAccessibleProperty first_property, IntPtr @__arglist)
	{
		GtkAccessibleExterns.gtk_accessible_update_property(self, first_property, @__arglist);
		return self;
	}

	public static GtkAccessibleHandle UpdatePropertyValue(this GtkAccessibleHandle self, int n_properties, GtkAccessibleProperty[] properties, GValue[] values)
	{
		GtkAccessibleExterns.gtk_accessible_update_property_value(self, n_properties, properties, values);
		return self;
	}

	public static GtkAccessibleHandle UpdateRelation(this GtkAccessibleHandle self, GtkAccessibleRelation first_relation, IntPtr @__arglist)
	{
		GtkAccessibleExterns.gtk_accessible_update_relation(self, first_relation, @__arglist);
		return self;
	}

	public static GtkAccessibleHandle UpdateRelationValue(this GtkAccessibleHandle self, int n_relations, GtkAccessibleRelation[] relations, GValue[] values)
	{
		GtkAccessibleExterns.gtk_accessible_update_relation_value(self, n_relations, relations, values);
		return self;
	}

	public static GtkAccessibleHandle UpdateState(this GtkAccessibleHandle self, GtkAccessibleState first_state, IntPtr @__arglist)
	{
		GtkAccessibleExterns.gtk_accessible_update_state(self, first_state, @__arglist);
		return self;
	}

	public static GtkAccessibleHandle UpdateStateValue(this GtkAccessibleHandle self, int n_states, GtkAccessibleState[] states, GValue[] values)
	{
		GtkAccessibleExterns.gtk_accessible_update_state_value(self, n_states, states, values);
		return self;
	}

}

internal class GtkAccessibleExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_announce(GtkAccessibleHandle self, string message, GtkAccessibleAnnouncementPriority priority);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleHandle gtk_accessible_get_accessible_parent(GtkAccessibleHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleRole gtk_accessible_get_accessible_role(GtkAccessibleHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkATContextHandle gtk_accessible_get_at_context(GtkAccessibleHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_accessible_get_bounds(GtkAccessibleHandle self, out int x, out int y, out int width, out int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleHandle gtk_accessible_get_first_accessible_child(GtkAccessibleHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleHandle gtk_accessible_get_next_accessible_sibling(GtkAccessibleHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_accessible_get_platform_state(GtkAccessibleHandle self, GtkAccessiblePlatformState state);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_reset_property(GtkAccessibleHandle self, GtkAccessibleProperty property);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_reset_relation(GtkAccessibleHandle self, GtkAccessibleRelation relation);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_reset_state(GtkAccessibleHandle self, GtkAccessibleState state);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_set_accessible_parent(GtkAccessibleHandle self, GtkAccessibleHandle parent, GtkAccessibleHandle next_sibling);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_update_next_accessible_sibling(GtkAccessibleHandle self, GtkAccessibleHandle new_sibling);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_update_property(GtkAccessibleHandle self, GtkAccessibleProperty first_property, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_update_property_value(GtkAccessibleHandle self, int n_properties, GtkAccessibleProperty[] properties, GValue[] values);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_update_relation(GtkAccessibleHandle self, GtkAccessibleRelation first_relation, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_update_relation_value(GtkAccessibleHandle self, int n_relations, GtkAccessibleRelation[] relations, GValue[] values);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_update_state(GtkAccessibleHandle self, GtkAccessibleState first_state, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_update_state_value(GtkAccessibleHandle self, int n_states, GtkAccessibleState[] states, GValue[] values);

}
