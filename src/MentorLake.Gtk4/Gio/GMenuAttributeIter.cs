namespace MentorLake.Gtk4.Gio;

public class GMenuAttributeIterHandle : GObjectHandle
{
}

public static class GMenuAttributeIterHandleExtensions
{
	public static string GetName(this GMenuAttributeIterHandle iter)
	{
		return GMenuAttributeIterExterns.g_menu_attribute_iter_get_name(iter);
	}

	public static bool GetNext(this GMenuAttributeIterHandle iter, out string out_name, out GVariantHandle value)
	{
		return GMenuAttributeIterExterns.g_menu_attribute_iter_get_next(iter, out out_name, out value);
	}

	public static GVariantHandle GetValue(this GMenuAttributeIterHandle iter)
	{
		return GMenuAttributeIterExterns.g_menu_attribute_iter_get_value(iter);
	}

	public static bool Next(this GMenuAttributeIterHandle iter)
	{
		return GMenuAttributeIterExterns.g_menu_attribute_iter_next(iter);
	}

}

internal class GMenuAttributeIterExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_menu_attribute_iter_get_name(GMenuAttributeIterHandle iter);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_menu_attribute_iter_get_next(GMenuAttributeIterHandle iter, out string out_name, out GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_menu_attribute_iter_get_value(GMenuAttributeIterHandle iter);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_menu_attribute_iter_next(GMenuAttributeIterHandle iter);

}
