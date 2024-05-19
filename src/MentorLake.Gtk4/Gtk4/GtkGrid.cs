namespace MentorLake.Gtk4.Gtk4;

public class GtkGridHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkGridHandle New()
	{
		return GtkGridExterns.gtk_grid_new();
	}

}

public static class GtkGridHandleExtensions
{
	public static GtkGridHandle Attach(this GtkGridHandle grid, GtkWidgetHandle child, int column, int row, int width, int height)
	{
		GtkGridExterns.gtk_grid_attach(grid, child, column, row, width, height);
		return grid;
	}

	public static GtkGridHandle AttachNextTo(this GtkGridHandle grid, GtkWidgetHandle child, GtkWidgetHandle sibling, GtkPositionType side, int width, int height)
	{
		GtkGridExterns.gtk_grid_attach_next_to(grid, child, sibling, side, width, height);
		return grid;
	}

	public static int GetBaselineRow(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_baseline_row(grid);
	}

	public static GtkWidgetHandle GetChildAt(this GtkGridHandle grid, int column, int row)
	{
		return GtkGridExterns.gtk_grid_get_child_at(grid, column, row);
	}

	public static bool GetColumnHomogeneous(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_column_homogeneous(grid);
	}

	public static uint GetColumnSpacing(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_column_spacing(grid);
	}

	public static GtkBaselinePosition GetRowBaselinePosition(this GtkGridHandle grid, int row)
	{
		return GtkGridExterns.gtk_grid_get_row_baseline_position(grid, row);
	}

	public static bool GetRowHomogeneous(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_row_homogeneous(grid);
	}

	public static uint GetRowSpacing(this GtkGridHandle grid)
	{
		return GtkGridExterns.gtk_grid_get_row_spacing(grid);
	}

	public static GtkGridHandle InsertColumn(this GtkGridHandle grid, int position)
	{
		GtkGridExterns.gtk_grid_insert_column(grid, position);
		return grid;
	}

	public static GtkGridHandle InsertNextTo(this GtkGridHandle grid, GtkWidgetHandle sibling, GtkPositionType side)
	{
		GtkGridExterns.gtk_grid_insert_next_to(grid, sibling, side);
		return grid;
	}

	public static GtkGridHandle InsertRow(this GtkGridHandle grid, int position)
	{
		GtkGridExterns.gtk_grid_insert_row(grid, position);
		return grid;
	}

	public static GtkGridHandle QueryChild(this GtkGridHandle grid, GtkWidgetHandle child, out int column, out int row, out int width, out int height)
	{
		GtkGridExterns.gtk_grid_query_child(grid, child, out column, out row, out width, out height);
		return grid;
	}

	public static GtkGridHandle Remove(this GtkGridHandle grid, GtkWidgetHandle child)
	{
		GtkGridExterns.gtk_grid_remove(grid, child);
		return grid;
	}

	public static GtkGridHandle RemoveColumn(this GtkGridHandle grid, int position)
	{
		GtkGridExterns.gtk_grid_remove_column(grid, position);
		return grid;
	}

	public static GtkGridHandle RemoveRow(this GtkGridHandle grid, int position)
	{
		GtkGridExterns.gtk_grid_remove_row(grid, position);
		return grid;
	}

	public static GtkGridHandle SetBaselineRow(this GtkGridHandle grid, int row)
	{
		GtkGridExterns.gtk_grid_set_baseline_row(grid, row);
		return grid;
	}

	public static GtkGridHandle SetColumnHomogeneous(this GtkGridHandle grid, bool homogeneous)
	{
		GtkGridExterns.gtk_grid_set_column_homogeneous(grid, homogeneous);
		return grid;
	}

	public static GtkGridHandle SetColumnSpacing(this GtkGridHandle grid, uint spacing)
	{
		GtkGridExterns.gtk_grid_set_column_spacing(grid, spacing);
		return grid;
	}

	public static GtkGridHandle SetRowBaselinePosition(this GtkGridHandle grid, int row, GtkBaselinePosition pos)
	{
		GtkGridExterns.gtk_grid_set_row_baseline_position(grid, row, pos);
		return grid;
	}

	public static GtkGridHandle SetRowHomogeneous(this GtkGridHandle grid, bool homogeneous)
	{
		GtkGridExterns.gtk_grid_set_row_homogeneous(grid, homogeneous);
		return grid;
	}

	public static GtkGridHandle SetRowSpacing(this GtkGridHandle grid, uint spacing)
	{
		GtkGridExterns.gtk_grid_set_row_spacing(grid, spacing);
		return grid;
	}

}

internal class GtkGridExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGridHandle gtk_grid_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_attach(GtkGridHandle grid, GtkWidgetHandle child, int column, int row, int width, int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_attach_next_to(GtkGridHandle grid, GtkWidgetHandle child, GtkWidgetHandle sibling, GtkPositionType side, int width, int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_grid_get_baseline_row(GtkGridHandle grid);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_grid_get_child_at(GtkGridHandle grid, int column, int row);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_grid_get_column_homogeneous(GtkGridHandle grid);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_grid_get_column_spacing(GtkGridHandle grid);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBaselinePosition gtk_grid_get_row_baseline_position(GtkGridHandle grid, int row);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_grid_get_row_homogeneous(GtkGridHandle grid);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_grid_get_row_spacing(GtkGridHandle grid);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_insert_column(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_insert_next_to(GtkGridHandle grid, GtkWidgetHandle sibling, GtkPositionType side);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_insert_row(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_query_child(GtkGridHandle grid, GtkWidgetHandle child, out int column, out int row, out int width, out int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_remove(GtkGridHandle grid, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_remove_column(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_remove_row(GtkGridHandle grid, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_set_baseline_row(GtkGridHandle grid, int row);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_set_column_homogeneous(GtkGridHandle grid, bool homogeneous);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_set_column_spacing(GtkGridHandle grid, uint spacing);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_set_row_baseline_position(GtkGridHandle grid, int row, GtkBaselinePosition pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_set_row_homogeneous(GtkGridHandle grid, bool homogeneous);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_set_row_spacing(GtkGridHandle grid, uint spacing);

}
