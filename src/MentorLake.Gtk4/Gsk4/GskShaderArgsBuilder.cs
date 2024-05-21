namespace MentorLake.Gtk4.Gsk4;

public class GskShaderArgsBuilderHandle : BaseSafeHandle
{
	public static GskShaderArgsBuilderHandle New(GskGLShaderHandle shader, GBytesHandle initial_values)
	{
		return GskShaderArgsBuilderExterns.gsk_shader_args_builder_new(shader, initial_values);
	}

}


public static class GskShaderArgsBuilderHandleExtensions
{
	public static GBytesHandle FreeToArgs(this GskShaderArgsBuilderHandle builder)
	{
		return GskShaderArgsBuilderExterns.gsk_shader_args_builder_free_to_args(builder);
	}

	public static GskShaderArgsBuilderHandle Ref(this GskShaderArgsBuilderHandle builder)
	{
		return GskShaderArgsBuilderExterns.gsk_shader_args_builder_ref(builder);
	}

	public static GskShaderArgsBuilderHandle SetBool(this GskShaderArgsBuilderHandle builder, int idx, bool value)
	{
		GskShaderArgsBuilderExterns.gsk_shader_args_builder_set_bool(builder, idx, value);
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

	public static GBytesHandle ToArgs(this GskShaderArgsBuilderHandle builder)
	{
		return GskShaderArgsBuilderExterns.gsk_shader_args_builder_to_args(builder);
	}

	public static GskShaderArgsBuilderHandle Unref(this GskShaderArgsBuilderHandle builder)
	{
		GskShaderArgsBuilderExterns.gsk_shader_args_builder_unref(builder);
		return builder;
	}

}
internal class GskShaderArgsBuilderExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskShaderArgsBuilderHandle gsk_shader_args_builder_new(GskGLShaderHandle shader, GBytesHandle initial_values);

	[DllImport(Libraries.Gsk4)]
	internal static extern GBytesHandle gsk_shader_args_builder_free_to_args(GskShaderArgsBuilderHandle builder);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskShaderArgsBuilderHandle gsk_shader_args_builder_ref(GskShaderArgsBuilderHandle builder);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_set_bool(GskShaderArgsBuilderHandle builder, int idx, bool value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_set_float(GskShaderArgsBuilderHandle builder, int idx, float value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_set_int(GskShaderArgsBuilderHandle builder, int idx, int value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_set_uint(GskShaderArgsBuilderHandle builder, int idx, uint value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_set_vec2(GskShaderArgsBuilderHandle builder, int idx, graphene_vec2_tHandle value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_set_vec3(GskShaderArgsBuilderHandle builder, int idx, graphene_vec3_tHandle value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_set_vec4(GskShaderArgsBuilderHandle builder, int idx, graphene_vec4_tHandle value);

	[DllImport(Libraries.Gsk4)]
	internal static extern GBytesHandle gsk_shader_args_builder_to_args(GskShaderArgsBuilderHandle builder);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_shader_args_builder_unref(GskShaderArgsBuilderHandle builder);

}

public struct GskShaderArgsBuilder
{
}
