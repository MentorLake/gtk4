using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GVariantIterAdaptors
{
    public static nuint Init(this GVariantIterHandle iter, GVariantHandle value)
    {
        return GVariantIterExterns.g_variant_iter_init(iter, value);
    }

    public static GVariantIterHandle Copy(this GVariantIterHandle iter)
    {
        return GVariantIterExterns.g_variant_iter_copy(iter);
    }

    public static nuint NChildren(this GVariantIterHandle iter)
    {
        return GVariantIterExterns.g_variant_iter_n_children(iter);
    }

    public static GVariantIterHandle Free(this GVariantIterHandle iter)
    {
        GVariantIterExterns.g_variant_iter_free(iter);
        return iter;
    }

    public static GVariantHandle NextValue(this GVariantIterHandle iter)
    {
        return GVariantIterExterns.g_variant_iter_next_value(iter);
    }

    public static int Next(this GVariantIterHandle iter, string format_string, IntPtr @__argList)
    {
        return GVariantIterExterns.g_variant_iter_next(iter, format_string, @__argList);
    }

    public static int Loop(this GVariantIterHandle iter, string format_string, IntPtr @__argList)
    {
        return GVariantIterExterns.g_variant_iter_loop(iter, format_string, @__argList);
    }
}
