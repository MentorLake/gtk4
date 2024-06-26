namespace MentorLake.Gtk4.Gtk4;

public class GtkCellAreaBoxHandle : GtkCellAreaHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkOrientableHandle
{
	public static GtkCellAreaBoxHandle New()
	{
		return GtkCellAreaBoxExterns.gtk_cell_area_box_new();
	}

}

public static class GtkCellAreaBoxHandleExtensions
{
	public static int GetSpacing(this GtkCellAreaBoxHandle box)
	{
		return GtkCellAreaBoxExterns.gtk_cell_area_box_get_spacing(box);
	}

	public static GtkCellAreaBoxHandle PackEnd(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed)
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_pack_end(box, renderer, expand, align, @fixed);
		return box;
	}

	public static GtkCellAreaBoxHandle PackStart(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed)
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_pack_start(box, renderer, expand, align, @fixed);
		return box;
	}

	public static GtkCellAreaBoxHandle SetSpacing(this GtkCellAreaBoxHandle box, int spacing)
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkCellAreaBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellAreaBoxHandle gtk_cell_area_box_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_cell_area_box_get_spacing(GtkCellAreaBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_box_pack_end(GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_box_pack_start(GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_box_set_spacing(GtkCellAreaBoxHandle box, int spacing);

}
