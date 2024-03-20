using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskShaderArgsBuilderAdaptors
{
    public static GBytesHandle ToArgs(this GskShaderArgsBuilderHandle builder)
    {
        return GskShaderArgsBuilderExterns.gsk_shader_args_builder_to_args(builder);
    }

    public static GBytesHandle FreeToArgs(this GskShaderArgsBuilderHandle builder)
    {
        return GskShaderArgsBuilderExterns.gsk_shader_args_builder_free_to_args(builder);
    }

    public static GskShaderArgsBuilderHandle Ref(this GskShaderArgsBuilderHandle builder)
    {
        return GskShaderArgsBuilderExterns.gsk_shader_args_builder_ref(builder);
    }

    public static GskShaderArgsBuilderHandle Unref(this GskShaderArgsBuilderHandle builder)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_unref(builder);
        return builder;
    }

    public static GskShaderArgsBuilderHandle SetFloat(this GskShaderArgsBuilderHandle builder, int idx, float value)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_float(builder, idx, value);
        return builder;
    }

    public static GskShaderArgsBuilderHandle SetInt(this GskShaderArgsBuilderHandle builder, int idx, int value)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_int(builder, idx, value);
        return builder;
    }

    public static GskShaderArgsBuilderHandle SetUint(this GskShaderArgsBuilderHandle builder, int idx, uint value)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_uint(builder, idx, value);
        return builder;
    }

    public static GskShaderArgsBuilderHandle SetBool(this GskShaderArgsBuilderHandle builder, int idx, int value)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_bool(builder, idx, value);
        return builder;
    }

    public static GskShaderArgsBuilderHandle SetVec2(this GskShaderArgsBuilderHandle builder, int idx, graphene_vec2_tHandle value)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_vec2(builder, idx, value);
        return builder;
    }

    public static GskShaderArgsBuilderHandle SetVec3(this GskShaderArgsBuilderHandle builder, int idx, graphene_vec3_tHandle value)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_vec3(builder, idx, value);
        return builder;
    }

    public static GskShaderArgsBuilderHandle SetVec4(this GskShaderArgsBuilderHandle builder, int idx, graphene_vec4_tHandle value)
    {
        GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_vec4(builder, idx, value);
        return builder;
    }
}
