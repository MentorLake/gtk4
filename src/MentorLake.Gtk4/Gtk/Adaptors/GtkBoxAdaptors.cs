using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBoxAdaptors
{
	public static GtkBoxHandle SetHomogeneous(this GtkBoxHandle box, int homogeneous)
	{
		GtkBoxExterns.gtk_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static int GetHomogeneous(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_homogeneous(box);
	}

	public static GtkBoxHandle SetSpacing(this GtkBoxHandle box, int spacing)
	{
		GtkBoxExterns.gtk_box_set_spacing(box, spacing);
		return box;
	}

	public static int GetSpacing(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_spacing(box);
	}

	public static GtkBoxHandle SetBaselinePosition(this GtkBoxHandle box, GtkBaselinePosition position)
	{
		GtkBoxExterns.gtk_box_set_baseline_position(box, position);
		return box;
	}

	public static GtkBaselinePosition GetBaselinePosition(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_baseline_position(box);
	}

	public static GtkBoxHandle Append(this GtkBoxHandle box, GtkWidgetHandle child)
	{
		GtkBoxExterns.gtk_box_append(box, child);
		return box;
	}

	public static GtkBoxHandle Prepend(this GtkBoxHandle box, GtkWidgetHandle child)
	{
		GtkBoxExterns.gtk_box_prepend(box, child);
		return box;
	}

	public static GtkBoxHandle Remove(this GtkBoxHandle box, GtkWidgetHandle child)
	{
		GtkBoxExterns.gtk_box_remove(box, child);
		return box;
	}

	public static GtkBoxHandle InsertChildAfter(this GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling)
	{
		GtkBoxExterns.gtk_box_insert_child_after(box, child, sibling);
		return box;
	}

	public static GtkBoxHandle ReorderChildAfter(this GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling)
	{
		GtkBoxExterns.gtk_box_reorder_child_after(box, child, sibling);
		return box;
	}
}
