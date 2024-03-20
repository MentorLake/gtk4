using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMultiSorterAdaptors
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
