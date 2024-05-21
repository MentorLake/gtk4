namespace MentorLake.Gtk4.GLib;

public class GVariantIterHandle : BaseSafeHandle
{
}


public static class GVariantIterHandleExtensions
{
	public static GVariantIterHandle Copy(this GVariantIterHandle iter)
	{
		return GVariantIterExterns.g_variant_iter_copy(iter);
	}

	public static GVariantIterHandle Free(this GVariantIterHandle iter)
	{
		GVariantIterExterns.g_variant_iter_free(iter);
		return iter;
	}

	public static UIntPtr Init(this GVariantIterHandle iter, GVariantHandle value)
	{
		return GVariantIterExterns.g_variant_iter_init(iter, value);
	}

	public static bool Loop(this GVariantIterHandle iter, string format_string, IntPtr @__arglist)
	{
		return GVariantIterExterns.g_variant_iter_loop(iter, format_string, @__arglist);
	}

	public static UIntPtr NChildren(this GVariantIterHandle iter)
	{
		return GVariantIterExterns.g_variant_iter_n_children(iter);
	}

	public static bool Next(this GVariantIterHandle iter, string format_string, IntPtr @__arglist)
	{
		return GVariantIterExterns.g_variant_iter_next(iter, format_string, @__arglist);
	}

	public static GVariantHandle NextValue(this GVariantIterHandle iter)
	{
		return GVariantIterExterns.g_variant_iter_next_value(iter);
	}

}
internal class GVariantIterExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantIterHandle g_variant_iter_copy(GVariantIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_iter_free(GVariantIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_variant_iter_init(GVariantIterHandle iter, GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_iter_loop(GVariantIterHandle iter, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_variant_iter_n_children(GVariantIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_iter_next(GVariantIterHandle iter, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_iter_next_value(GVariantIterHandle iter);

}

public struct GVariantIter
{
}
