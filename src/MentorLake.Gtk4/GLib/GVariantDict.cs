namespace MentorLake.Gtk4.GLib;

public class GVariantDictHandle : BaseSafeHandle
{
	public static GVariantDictHandle New(GVariantHandle from_asv)
	{
		return GVariantDictExterns.g_variant_dict_new(from_asv);
	}

}

internal class GVariantDictExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantDictHandle g_variant_dict_new(GVariantHandle from_asv);

}

public struct GVariantDict
{
}
