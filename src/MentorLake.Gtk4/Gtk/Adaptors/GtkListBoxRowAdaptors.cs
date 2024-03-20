using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListBoxRowAdaptors
{
	public static GtkListBoxRowHandle SetChild(this GtkListBoxRowHandle row, GtkWidgetHandle child)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_child(row, child);
		return row;
	}

	public static GtkWidgetHandle GetChild(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_child(row);
	}

	public static GtkWidgetHandle GetHeader(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_header(row);
	}

	public static GtkListBoxRowHandle SetHeader(this GtkListBoxRowHandle row, GtkWidgetHandle header)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_header(row, header);
		return row;
	}

	public static int GetIndex(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_index(row);
	}

	public static GtkListBoxRowHandle Changed(this GtkListBoxRowHandle row)
	{
		GtkListBoxRowExterns.gtk_list_box_row_changed(row);
		return row;
	}

	public static int IsSelected(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_is_selected(row);
	}

	public static GtkListBoxRowHandle SetSelectable(this GtkListBoxRowHandle row, int selectable)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_selectable(row, selectable);
		return row;
	}

	public static int GetSelectable(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_selectable(row);
	}

	public static GtkListBoxRowHandle SetActivatable(this GtkListBoxRowHandle row, int activatable)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_activatable(row, activatable);
		return row;
	}

	public static int GetActivatable(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_activatable(row);
	}
}
