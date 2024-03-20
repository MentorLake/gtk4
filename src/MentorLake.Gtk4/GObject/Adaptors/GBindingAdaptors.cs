using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;
public static class GBindingAdaptors
{
    public static GBindingFlags GetFlags(this GBindingHandle binding)
    {
        return GBindingExterns.g_binding_get_flags(binding);
    }

    public static GObjectHandle GetSource(this GBindingHandle binding)
    {
        return GBindingExterns.g_binding_get_source(binding);
    }

    public static GObjectHandle DupSource(this GBindingHandle binding)
    {
        return GBindingExterns.g_binding_dup_source(binding);
    }

    public static GObjectHandle GetTarget(this GBindingHandle binding)
    {
        return GBindingExterns.g_binding_get_target(binding);
    }

    public static GObjectHandle DupTarget(this GBindingHandle binding)
    {
        return GBindingExterns.g_binding_dup_target(binding);
    }

    public static string GetSourceProperty(this GBindingHandle binding)
    {
        return GBindingExterns.g_binding_get_source_property(binding);
    }

    public static string GetTargetProperty(this GBindingHandle binding)
    {
        return GBindingExterns.g_binding_get_target_property(binding);
    }

    public static GBindingHandle Unbind(this GBindingHandle binding)
    {
        GBindingExterns.g_binding_unbind(binding);
        return binding;
    }
}
