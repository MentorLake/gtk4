namespace MentorLake.Gtk4.GLib;

public class GVariantBuilderHandle : BaseSafeHandle
{
	public static GVariantBuilderHandle New(GVariantTypeHandle type)
	{
		return GVariantBuilderExterns.g_variant_builder_new(type);
	}

}

internal class GVariantBuilderExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantBuilderHandle g_variant_builder_new(GVariantTypeHandle type);

}

public struct GVariantBuilder
{
}
