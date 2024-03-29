using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkGridLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkGridLayoutHandle New()
	{
		return GtkGridLayoutExterns.gtk_grid_layout_new();
	}

}

public static class GtkGridLayoutHandleExtensions
{
	public static int GetBaselineRow(this GtkGridLayoutHandle grid)
	{
		return GtkGridLayoutExterns.gtk_grid_layout_get_baseline_row(grid);
	}

	public static bool GetColumnHomogeneous(this GtkGridLayoutHandle grid)
	{
		return GtkGridLayoutExterns.gtk_grid_layout_get_column_homogeneous(grid);
	}

	public static uint GetColumnSpacing(this GtkGridLayoutHandle grid)
	{
		return GtkGridLayoutExterns.gtk_grid_layout_get_column_spacing(grid);
	}

	public static GtkBaselinePosition GetRowBaselinePosition(this GtkGridLayoutHandle grid, int row)
	{
		return GtkGridLayoutExterns.gtk_grid_layout_get_row_baseline_position(grid, row);
	}

	public static bool GetRowHomogeneous(this GtkGridLayoutHandle grid)
	{
		return GtkGridLayoutExterns.gtk_grid_layout_get_row_homogeneous(grid);
	}

	public static uint GetRowSpacing(this GtkGridLayoutHandle grid)
	{
		return GtkGridLayoutExterns.gtk_grid_layout_get_row_spacing(grid);
	}

	public static GtkGridLayoutHandle SetBaselineRow(this GtkGridLayoutHandle grid, int row)
	{
		GtkGridLayoutExterns.gtk_grid_layout_set_baseline_row(grid, row);
		return grid;
	}

	public static GtkGridLayoutHandle SetColumnHomogeneous(this GtkGridLayoutHandle grid, bool homogeneous)
	{
		GtkGridLayoutExterns.gtk_grid_layout_set_column_homogeneous(grid, homogeneous);
		return grid;
	}

	public static GtkGridLayoutHandle SetColumnSpacing(this GtkGridLayoutHandle grid, uint spacing)
	{
		GtkGridLayoutExterns.gtk_grid_layout_set_column_spacing(grid, spacing);
		return grid;
	}

	public static GtkGridLayoutHandle SetRowBaselinePosition(this GtkGridLayoutHandle grid, int row, GtkBaselinePosition pos)
	{
		GtkGridLayoutExterns.gtk_grid_layout_set_row_baseline_position(grid, row, pos);
		return grid;
	}

	public static GtkGridLayoutHandle SetRowHomogeneous(this GtkGridLayoutHandle grid, bool homogeneous)
	{
		GtkGridLayoutExterns.gtk_grid_layout_set_row_homogeneous(grid, homogeneous);
		return grid;
	}

	public static GtkGridLayoutHandle SetRowSpacing(this GtkGridLayoutHandle grid, uint spacing)
	{
		GtkGridLayoutExterns.gtk_grid_layout_set_row_spacing(grid, spacing);
		return grid;
	}

}

internal class GtkGridLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGridLayoutHandle gtk_grid_layout_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_grid_layout_get_baseline_row(GtkGridLayoutHandle grid);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_grid_layout_get_column_homogeneous(GtkGridLayoutHandle grid);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_grid_layout_get_column_spacing(GtkGridLayoutHandle grid);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBaselinePosition gtk_grid_layout_get_row_baseline_position(GtkGridLayoutHandle grid, int row);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_grid_layout_get_row_homogeneous(GtkGridLayoutHandle grid);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_grid_layout_get_row_spacing(GtkGridLayoutHandle grid);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_set_baseline_row(GtkGridLayoutHandle grid, int row);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_set_column_homogeneous(GtkGridLayoutHandle grid, bool homogeneous);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_set_column_spacing(GtkGridLayoutHandle grid, uint spacing);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_set_row_baseline_position(GtkGridLayoutHandle grid, int row, GtkBaselinePosition pos);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_set_row_homogeneous(GtkGridLayoutHandle grid, bool homogeneous);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_set_row_spacing(GtkGridLayoutHandle grid, uint spacing);
}
