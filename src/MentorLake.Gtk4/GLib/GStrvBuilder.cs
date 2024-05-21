namespace MentorLake.Gtk4.GLib;

public class GStrvBuilderHandle : BaseSafeHandle
{
	public static GStrvBuilderHandle New()
	{
		return GStrvBuilderExterns.g_strv_builder_new();
	}

}


public static class GStrvBuilderHandleExtensions
{
	public static GStrvBuilderHandle Add(this GStrvBuilderHandle builder, string value)
	{
		GStrvBuilderExterns.g_strv_builder_add(builder, value);
		return builder;
	}

	public static GStrvBuilderHandle AddMany(this GStrvBuilderHandle builder, IntPtr @__arglist)
	{
		GStrvBuilderExterns.g_strv_builder_add_many(builder, @__arglist);
		return builder;
	}

	public static GStrvBuilderHandle Addv(this GStrvBuilderHandle builder, string[] value)
	{
		GStrvBuilderExterns.g_strv_builder_addv(builder, value);
		return builder;
	}

	public static IntPtr End(this GStrvBuilderHandle builder)
	{
		return GStrvBuilderExterns.g_strv_builder_end(builder);
	}

	public static GStrvBuilderHandle Ref(this GStrvBuilderHandle builder)
	{
		return GStrvBuilderExterns.g_strv_builder_ref(builder);
	}

	public static GStrvBuilderHandle Take(this GStrvBuilderHandle builder, string value)
	{
		GStrvBuilderExterns.g_strv_builder_take(builder, value);
		return builder;
	}

	public static GStrvBuilderHandle Unref(this GStrvBuilderHandle builder)
	{
		GStrvBuilderExterns.g_strv_builder_unref(builder);
		return builder;
	}

}
internal class GStrvBuilderExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GStrvBuilderHandle g_strv_builder_new();

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_add(GStrvBuilderHandle builder, string value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_add_many(GStrvBuilderHandle builder, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_addv(GStrvBuilderHandle builder, string[] value);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_strv_builder_end(GStrvBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern GStrvBuilderHandle g_strv_builder_ref(GStrvBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_take(GStrvBuilderHandle builder, string value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_unref(GStrvBuilderHandle builder);

}

public struct GStrvBuilder
{
}
