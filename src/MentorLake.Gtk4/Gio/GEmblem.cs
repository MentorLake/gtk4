namespace MentorLake.Gtk4.Gio;

public class GEmblemHandle : GObjectHandle, GIconHandle
{
	public static GEmblemHandle New(GIconHandle icon)
	{
		return GEmblemExterns.g_emblem_new(icon);
	}

	public static GEmblemHandle NewWithOrigin(GIconHandle icon, GEmblemOrigin origin)
	{
		return GEmblemExterns.g_emblem_new_with_origin(icon, origin);
	}

}

public static class GEmblemHandleExtensions
{
	public static GIconHandle GetIcon(this GEmblemHandle emblem)
	{
		return GEmblemExterns.g_emblem_get_icon(emblem);
	}

	public static GEmblemOrigin GetOrigin(this GEmblemHandle emblem)
	{
		return GEmblemExterns.g_emblem_get_origin(emblem);
	}

}

internal class GEmblemExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GEmblemHandle g_emblem_new(GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern GEmblemHandle g_emblem_new_with_origin(GIconHandle icon, GEmblemOrigin origin);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_emblem_get_icon(GEmblemHandle emblem);

	[DllImport(Libraries.Gio)]
	internal static extern GEmblemOrigin g_emblem_get_origin(GEmblemHandle emblem);

}
