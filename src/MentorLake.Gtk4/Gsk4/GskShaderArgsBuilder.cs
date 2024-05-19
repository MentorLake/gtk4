namespace MentorLake.Gtk4.Gsk4;

public class GskShaderArgsBuilderHandle : BaseSafeHandle
{
	public static GskShaderArgsBuilderHandle New(GskGLShaderHandle shader, GBytesHandle initial_values)
	{
		return GskShaderArgsBuilderExterns.gsk_shader_args_builder_new(shader, initial_values);
	}

}

internal class GskShaderArgsBuilderExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskShaderArgsBuilderHandle gsk_shader_args_builder_new(GskGLShaderHandle shader, GBytesHandle initial_values);

}

public struct GskShaderArgsBuilder
{
}
