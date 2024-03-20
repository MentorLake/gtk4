using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellRendererAdaptors
{
	public static GtkSizeRequestMode GetRequestMode(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_request_mode(cell);
	}

	public static GtkCellRendererHandle GetPreferredWidth(this GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_width(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredHeightForWidth(this GtkCellRendererHandle cell, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_height_for_width(cell, widget, width, out minimum_height, out natural_height);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredHeight(this GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_height(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredWidthForHeight(this GtkCellRendererHandle cell, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_width_for_height(cell, widget, height, out minimum_width, out natural_width);
		return cell;
	}

	public static GtkCellRendererHandle GetPreferredSize(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkRequisitionHandle minimum_size, GtkRequisitionHandle natural_size)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_size(cell, widget, minimum_size, natural_size);
		return cell;
	}

	public static GtkCellRendererHandle GetAlignedArea(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState flags, GdkRectangleHandle cell_area, GdkRectangleHandle aligned_area)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_aligned_area(cell, widget, flags, cell_area, aligned_area);
		return cell;
	}

	public static GtkCellRendererHandle Snapshot(this GtkCellRendererHandle cell, GtkSnapshotHandle snapshot, GtkWidgetHandle widget, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		GtkCellRendererExterns.gtk_cell_renderer_snapshot(cell, snapshot, widget, background_area, cell_area, flags);
		return cell;
	}

	public static int Activate(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_activate(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static GtkCellEditableHandle StartEditing(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_start_editing(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static GtkCellRendererHandle SetFixedSize(this GtkCellRendererHandle cell, int width, int height)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_fixed_size(cell, width, height);
		return cell;
	}

	public static GtkCellRendererHandle GetFixedSize(this GtkCellRendererHandle cell, out int width, out int height)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_fixed_size(cell, out width, out height);
		return cell;
	}

	public static GtkCellRendererHandle SetAlignment(this GtkCellRendererHandle cell, float xalign, float yalign)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_alignment(cell, xalign, yalign);
		return cell;
	}

	public static GtkCellRendererHandle GetAlignment(this GtkCellRendererHandle cell, out float xalign, out float yalign)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_alignment(cell, out xalign, out yalign);
		return cell;
	}

	public static GtkCellRendererHandle SetPadding(this GtkCellRendererHandle cell, int xpad, int ypad)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_padding(cell, xpad, ypad);
		return cell;
	}

	public static GtkCellRendererHandle GetPadding(this GtkCellRendererHandle cell, out int xpad, out int ypad)
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_padding(cell, out xpad, out ypad);
		return cell;
	}

	public static GtkCellRendererHandle SetVisible(this GtkCellRendererHandle cell, int visible)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_visible(cell, visible);
		return cell;
	}

	public static int GetVisible(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_visible(cell);
	}

	public static GtkCellRendererHandle SetSensitive(this GtkCellRendererHandle cell, int sensitive)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_sensitive(cell, sensitive);
		return cell;
	}

	public static int GetSensitive(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_sensitive(cell);
	}

	public static int IsActivatable(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_is_activatable(cell);
	}

	public static GtkCellRendererHandle SetIsExpander(this GtkCellRendererHandle cell, int is_expander)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_is_expander(cell, is_expander);
		return cell;
	}

	public static int GetIsExpander(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_is_expander(cell);
	}

	public static GtkCellRendererHandle SetIsExpanded(this GtkCellRendererHandle cell, int is_expanded)
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_is_expanded(cell, is_expanded);
		return cell;
	}

	public static int GetIsExpanded(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_is_expanded(cell);
	}

	public static GtkCellRendererHandle StopEditing(this GtkCellRendererHandle cell, int canceled)
	{
		GtkCellRendererExterns.gtk_cell_renderer_stop_editing(cell, canceled);
		return cell;
	}

	public static GtkStateFlags GetState(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState cell_state)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_state(cell, widget, cell_state);
	}

	public static GtkCellRendererHandle AccelNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_accel_new();
	}

	public static GtkCellRendererHandle ComboNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_combo_new();
	}

	public static GtkCellRendererHandle PixbufNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_pixbuf_new();
	}

	public static GtkCellRendererHandle ProgressNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_progress_new();
	}

	public static GtkCellRendererHandle SpinNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_spin_new();
	}

	public static GtkCellRendererHandle SpinnerNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_spinner_new();
	}

	public static GtkCellRendererHandle ToggleNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_toggle_new();
	}
}
