using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWidgetClassAdaptors
{
    public static GtkWidgetClassHandle SetLayoutManagerType(this GtkWidgetClassHandle widget_class, GType type)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_layout_manager_type(widget_class, type);
        return widget_class;
    }

    public static GType GetLayoutManagerType(this GtkWidgetClassHandle widget_class)
    {
        return GtkWidgetClassExterns.gtk_widget_class_get_layout_manager_type(widget_class);
    }

    public static GtkWidgetClassHandle AddBinding(this GtkWidgetClassHandle widget_class, uint keyval, GdkModifierType mods, GtkShortcutFunc callback, string format_string, IntPtr @__argList)
    {
        GtkWidgetClassExterns.gtk_widget_class_add_binding(widget_class, keyval, mods, callback, format_string, @__argList);
        return widget_class;
    }

    public static GtkWidgetClassHandle AddBindingSignal(this GtkWidgetClassHandle widget_class, uint keyval, GdkModifierType mods, string signal, string format_string, IntPtr @__argList)
    {
        GtkWidgetClassExterns.gtk_widget_class_add_binding_signal(widget_class, keyval, mods, signal, format_string, @__argList);
        return widget_class;
    }

    public static GtkWidgetClassHandle AddBindingAction(this GtkWidgetClassHandle widget_class, uint keyval, GdkModifierType mods, string action_name, string format_string, IntPtr @__argList)
    {
        GtkWidgetClassExterns.gtk_widget_class_add_binding_action(widget_class, keyval, mods, action_name, format_string, @__argList);
        return widget_class;
    }

    public static GtkWidgetClassHandle AddShortcut(this GtkWidgetClassHandle widget_class, GtkShortcutHandle shortcut)
    {
        GtkWidgetClassExterns.gtk_widget_class_add_shortcut(widget_class, shortcut);
        return widget_class;
    }

    public static GtkWidgetClassHandle SetActivateSignal(this GtkWidgetClassHandle widget_class, uint signal_id)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_activate_signal(widget_class, signal_id);
        return widget_class;
    }

    public static GtkWidgetClassHandle SetActivateSignalFromName(this GtkWidgetClassHandle widget_class, string signal_name)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_activate_signal_from_name(widget_class, signal_name);
        return widget_class;
    }

    public static uint GetActivateSignal(this GtkWidgetClassHandle widget_class)
    {
        return GtkWidgetClassExterns.gtk_widget_class_get_activate_signal(widget_class);
    }

    public static GtkWidgetClassHandle SetCssName(this GtkWidgetClassHandle widget_class, string name)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_css_name(widget_class, name);
        return widget_class;
    }

    public static string GetCssName(this GtkWidgetClassHandle widget_class)
    {
        return GtkWidgetClassExterns.gtk_widget_class_get_css_name(widget_class);
    }

    public static GtkWidgetClassHandle SetTemplate(this GtkWidgetClassHandle widget_class, GBytesHandle template_bytes)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_template(widget_class, template_bytes);
        return widget_class;
    }

    public static GtkWidgetClassHandle SetTemplateFromResource(this GtkWidgetClassHandle widget_class, string resource_name)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_template_from_resource(widget_class, resource_name);
        return widget_class;
    }

    public static GtkWidgetClassHandle BindTemplateCallbackFull(this GtkWidgetClassHandle widget_class, string callback_name, GCallback callback_symbol)
    {
        GtkWidgetClassExterns.gtk_widget_class_bind_template_callback_full(widget_class, callback_name, callback_symbol);
        return widget_class;
    }

    public static GtkWidgetClassHandle SetTemplateScope(this GtkWidgetClassHandle widget_class, GtkBuilderScopeHandle scope)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_template_scope(widget_class, scope);
        return widget_class;
    }

    public static GtkWidgetClassHandle BindTemplateChildFull(this GtkWidgetClassHandle widget_class, string name, int internal_child, nint struct_offset)
    {
        GtkWidgetClassExterns.gtk_widget_class_bind_template_child_full(widget_class, name, internal_child, struct_offset);
        return widget_class;
    }

    public static GtkWidgetClassHandle InstallAction(this GtkWidgetClassHandle widget_class, string action_name, string parameter_type, GtkWidgetActionActivateFunc activate)
    {
        GtkWidgetClassExterns.gtk_widget_class_install_action(widget_class, action_name, parameter_type, activate);
        return widget_class;
    }

    public static GtkWidgetClassHandle InstallPropertyAction(this GtkWidgetClassHandle widget_class, string action_name, string property_name)
    {
        GtkWidgetClassExterns.gtk_widget_class_install_property_action(widget_class, action_name, property_name);
        return widget_class;
    }

    public static int QueryAction(this GtkWidgetClassHandle widget_class, uint index_, GTypeHandle owner, out string action_name, out GVariantTypeHandle parameter_type, out string property_name)
    {
        return GtkWidgetClassExterns.gtk_widget_class_query_action(widget_class, index_, owner, out action_name, out parameter_type, out property_name);
    }

    public static GtkWidgetClassHandle SetAccessibleRole(this GtkWidgetClassHandle widget_class, GtkAccessibleRole accessible_role)
    {
        GtkWidgetClassExterns.gtk_widget_class_set_accessible_role(widget_class, accessible_role);
        return widget_class;
    }

    public static GtkAccessibleRole GetAccessibleRole(this GtkWidgetClassHandle widget_class)
    {
        return GtkWidgetClassExterns.gtk_widget_class_get_accessible_role(widget_class);
    }
}
