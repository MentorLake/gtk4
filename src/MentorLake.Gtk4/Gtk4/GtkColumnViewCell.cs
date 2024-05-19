namespace MentorLake.Gtk4.Gtk4;

public class GtkColumnViewCellHandle : GtkListItemHandle
{
}

public static class GtkColumnViewCellHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkColumnViewCellHandle self)
	{
		return GtkColumnViewCellExterns.gtk_column_view_cell_get_child(self);
	}

	public static bool GetFocusable(this GtkColumnViewCellHandle self)
	{
		return GtkColumnViewCellExterns.gtk_column_view_cell_get_focusable(self);
	}

	public static GObjectHandle GetItem(this GtkColumnViewCellHandle self)
	{
		return GtkColumnViewCellExterns.gtk_column_view_cell_get_item(self);
	}

	public static uint GetPosition(this GtkColumnViewCellHandle self)
	{
		return GtkColumnViewCellExterns.gtk_column_view_cell_get_position(self);
	}

	public static bool GetSelected(this GtkColumnViewCellHandle self)
	{
		return GtkColumnViewCellExterns.gtk_column_view_cell_get_selected(self);
	}

	public static GtkColumnViewCellHandle SetChild(this GtkColumnViewCellHandle self, GtkWidgetHandle child)
	{
		GtkColumnViewCellExterns.gtk_column_view_cell_set_child(self, child);
		return self;
	}

	public static GtkColumnViewCellHandle SetFocusable(this GtkColumnViewCellHandle self, bool focusable)
	{
		GtkColumnViewCellExterns.gtk_column_view_cell_set_focusable(self, focusable);
		return self;
	}

}

internal class GtkColumnViewCellExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_column_view_cell_get_child(GtkColumnViewCellHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_cell_get_focusable(GtkColumnViewCellHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_column_view_cell_get_item(GtkColumnViewCellHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_column_view_cell_get_position(GtkColumnViewCellHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_cell_get_selected(GtkColumnViewCellHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_cell_set_child(GtkColumnViewCellHandle self, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_cell_set_focusable(GtkColumnViewCellHandle self, bool focusable);

}
