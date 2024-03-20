using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStrvBuilderAdaptors
{
	public static GStrvBuilderHandle Unref(this GStrvBuilderHandle builder)
	{
		GStrvBuilderExterns.g_strv_builder_unref(builder);
		return builder;
	}

	public static GStrvBuilderHandle Ref(this GStrvBuilderHandle builder)
	{
		return GStrvBuilderExterns.g_strv_builder_ref(builder);
	}

	public static GStrvBuilderHandle Add(this GStrvBuilderHandle builder, string value)
	{
		GStrvBuilderExterns.g_strv_builder_add(builder, value);
		return builder;
	}

	public static GStrvBuilderHandle Addv(this GStrvBuilderHandle builder, string[] value)
	{
		GStrvBuilderExterns.g_strv_builder_addv(builder, value);
		return builder;
	}

	public static GStrvBuilderHandle AddMany(this GStrvBuilderHandle builder, IntPtr @__argList)
	{
		GStrvBuilderExterns.g_strv_builder_add_many(builder, @__argList);
		return builder;
	}

	public static GStrv End(this GStrvBuilderHandle builder)
	{
		return GStrvBuilderExterns.g_strv_builder_end(builder);
	}
}
