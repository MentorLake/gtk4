namespace MentorLake.Gtk4.Gtk4;

public class GtkMultiSorterHandle : GtkSorterHandle, GListModelHandle, GtkBuildableHandle
{
	public static GtkMultiSorterHandle New()
	{
		return GtkMultiSorterExterns.gtk_multi_sorter_new();
	}

}

public static class GtkMultiSorterHandleExtensions
{
	public static GtkMultiSorterHandle Append(this GtkMultiSorterHandle self, GtkSorterHandle sorter)
	{
		GtkMultiSorterExterns.gtk_multi_sorter_append(self, sorter);
		return self;
	}

	public static GtkMultiSorterHandle Remove(this GtkMultiSorterHandle self, uint position)
	{
		GtkMultiSorterExterns.gtk_multi_sorter_remove(self, position);
		return self;
	}

}

internal class GtkMultiSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMultiSorterHandle gtk_multi_sorter_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_sorter_append(GtkMultiSorterHandle self, GtkSorterHandle sorter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_sorter_remove(GtkMultiSorterHandle self, uint position);

}
