namespace MentorLake.Gtk4.Gio;

public class GEmblemedIconHandle : GObjectHandle, GIconHandle
{
	public static GEmblemedIconHandle New(GIconHandle icon, GEmblemHandle emblem)
	{
		return GEmblemedIconExterns.g_emblemed_icon_new(icon, emblem);
	}

}

public static class GEmblemedIconHandleExtensions
{
	public static GEmblemedIconHandle AddEmblem(this GEmblemedIconHandle emblemed, GEmblemHandle emblem)
	{
		GEmblemedIconExterns.g_emblemed_icon_add_emblem(emblemed, emblem);
		return emblemed;
	}

	public static GEmblemedIconHandle ClearEmblems(this GEmblemedIconHandle emblemed)
	{
		GEmblemedIconExterns.g_emblemed_icon_clear_emblems(emblemed);
		return emblemed;
	}

	public static GListHandle GetEmblems(this GEmblemedIconHandle emblemed)
	{
		return GEmblemedIconExterns.g_emblemed_icon_get_emblems(emblemed);
	}

	public static GIconHandle GetIcon(this GEmblemedIconHandle emblemed)
	{
		return GEmblemedIconExterns.g_emblemed_icon_get_icon(emblemed);
	}

}

internal class GEmblemedIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GEmblemedIconHandle g_emblemed_icon_new(GIconHandle icon, GEmblemHandle emblem);

	[DllImport(Libraries.Gio)]
	internal static extern void g_emblemed_icon_add_emblem(GEmblemedIconHandle emblemed, GEmblemHandle emblem);

	[DllImport(Libraries.Gio)]
	internal static extern void g_emblemed_icon_clear_emblems(GEmblemedIconHandle emblemed);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_emblemed_icon_get_emblems(GEmblemedIconHandle emblemed);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_emblemed_icon_get_icon(GEmblemedIconHandle emblemed);

}
