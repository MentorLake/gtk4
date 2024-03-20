using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GVariantBuilderAdaptors
{
    public static GVariantBuilderHandle Unref(this GVariantBuilderHandle builder)
    {
        GVariantBuilderExterns.g_variant_builder_unref(builder);
        return builder;
    }

    public static GVariantBuilderHandle Ref(this GVariantBuilderHandle builder)
    {
        return GVariantBuilderExterns.g_variant_builder_ref(builder);
    }

    public static GVariantBuilderHandle Init(this GVariantBuilderHandle builder, GVariantTypeHandle type)
    {
        GVariantBuilderExterns.g_variant_builder_init(builder, type);
        return builder;
    }

    public static GVariantHandle End(this GVariantBuilderHandle builder)
    {
        return GVariantBuilderExterns.g_variant_builder_end(builder);
    }

    public static GVariantBuilderHandle Clear(this GVariantBuilderHandle builder)
    {
        GVariantBuilderExterns.g_variant_builder_clear(builder);
        return builder;
    }

    public static GVariantBuilderHandle Open(this GVariantBuilderHandle builder, GVariantTypeHandle type)
    {
        GVariantBuilderExterns.g_variant_builder_open(builder, type);
        return builder;
    }

    public static GVariantBuilderHandle Close(this GVariantBuilderHandle builder)
    {
        GVariantBuilderExterns.g_variant_builder_close(builder);
        return builder;
    }

    public static GVariantBuilderHandle AddValue(this GVariantBuilderHandle builder, GVariantHandle value)
    {
        GVariantBuilderExterns.g_variant_builder_add_value(builder, value);
        return builder;
    }

    public static GVariantBuilderHandle Add(this GVariantBuilderHandle builder, string format_string, IntPtr @__argList)
    {
        GVariantBuilderExterns.g_variant_builder_add(builder, format_string, @__argList);
        return builder;
    }

    public static GVariantBuilderHandle AddParsed(this GVariantBuilderHandle builder, string format, IntPtr @__argList)
    {
        GVariantBuilderExterns.g_variant_builder_add_parsed(builder, format, @__argList);
        return builder;
    }
}
