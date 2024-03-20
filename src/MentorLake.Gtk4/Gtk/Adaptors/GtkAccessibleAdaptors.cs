using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAccessibleAdaptors
{
    public static GtkAccessibleRole GetAccessibleRole(this GtkAccessibleHandle self)
    {
        return GtkAccessibleExterns.gtk_accessible_get_accessible_role(self);
    }

    public static GtkAccessibleHandle UpdateState(this GtkAccessibleHandle self, GtkAccessibleState first_state, IntPtr @__argList)
    {
        GtkAccessibleExterns.gtk_accessible_update_state(self, first_state, @__argList);
        return self;
    }

    public static GtkAccessibleHandle UpdateProperty(this GtkAccessibleHandle self, GtkAccessibleProperty first_property, IntPtr @__argList)
    {
        GtkAccessibleExterns.gtk_accessible_update_property(self, first_property, @__argList);
        return self;
    }

    public static GtkAccessibleHandle UpdateRelation(this GtkAccessibleHandle self, GtkAccessibleRelation first_relation, IntPtr @__argList)
    {
        GtkAccessibleExterns.gtk_accessible_update_relation(self, first_relation, @__argList);
        return self;
    }

    public static GtkAccessibleHandle UpdateStateValue(this GtkAccessibleHandle self, int n_states, GtkAccessibleState[] states, GValue[] values)
    {
        GtkAccessibleExterns.gtk_accessible_update_state_value(self, n_states, states, values);
        return self;
    }

    public static GtkAccessibleHandle UpdatePropertyValue(this GtkAccessibleHandle self, int n_properties, GtkAccessibleProperty[] properties, GValue[] values)
    {
        GtkAccessibleExterns.gtk_accessible_update_property_value(self, n_properties, properties, values);
        return self;
    }

    public static GtkAccessibleHandle UpdateRelationValue(this GtkAccessibleHandle self, int n_relations, GtkAccessibleRelation[] relations, GValue[] values)
    {
        GtkAccessibleExterns.gtk_accessible_update_relation_value(self, n_relations, relations, values);
        return self;
    }

    public static GtkAccessibleHandle ResetState(this GtkAccessibleHandle self, GtkAccessibleState state)
    {
        GtkAccessibleExterns.gtk_accessible_reset_state(self, state);
        return self;
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

    public static int GtkTestAccessibleHasRole(this GtkAccessibleHandle accessible, GtkAccessibleRole role)
    {
        return GtkAccessibleExterns.gtk_test_accessible_has_role(accessible, role);
    }

    public static int GtkTestAccessibleHasProperty(this GtkAccessibleHandle accessible, GtkAccessibleProperty property)
    {
        return GtkAccessibleExterns.gtk_test_accessible_has_property(accessible, property);
    }

    public static int GtkTestAccessibleHasRelation(this GtkAccessibleHandle accessible, GtkAccessibleRelation relation)
    {
        return GtkAccessibleExterns.gtk_test_accessible_has_relation(accessible, relation);
    }

    public static int GtkTestAccessibleHasState(this GtkAccessibleHandle accessible, GtkAccessibleState state)
    {
        return GtkAccessibleExterns.gtk_test_accessible_has_state(accessible, state);
    }

    public static string GtkTestAccessibleCheckProperty(this GtkAccessibleHandle accessible, GtkAccessibleProperty property, IntPtr @__argList)
    {
        return GtkAccessibleExterns.gtk_test_accessible_check_property(accessible, property, @__argList);
    }

    public static string GtkTestAccessibleCheckRelation(this GtkAccessibleHandle accessible, GtkAccessibleRelation relation, IntPtr @__argList)
    {
        return GtkAccessibleExterns.gtk_test_accessible_check_relation(accessible, relation, @__argList);
    }

    public static string GtkTestAccessibleCheckState(this GtkAccessibleHandle accessible, GtkAccessibleState state, IntPtr @__argList)
    {
        return GtkAccessibleExterns.gtk_test_accessible_check_state(accessible, state, @__argList);
    }
}
