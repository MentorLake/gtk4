using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellAreaAdaptors
{
	public static GtkCellAreaHandle Add(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		GtkCellAreaExterns.gtk_cell_area_add(area, renderer);
		return area;
	}

	public static GtkCellAreaHandle Remove(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		GtkCellAreaExterns.gtk_cell_area_remove(area, renderer);
		return area;
	}

	public static int HasRenderer(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_has_renderer(area, renderer);
	}

	public static GtkCellAreaHandle Foreach(this GtkCellAreaHandle area, GtkCellCallback callback, IntPtr callback_data)
	{
		GtkCellAreaExterns.gtk_cell_area_foreach(area, callback, callback_data);
		return area;
	}

	public static GtkCellAreaHandle ForeachAlloc(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GdkRectangleHandle background_area, GtkCellAllocCallback callback, IntPtr callback_data)
	{
		GtkCellAreaExterns.gtk_cell_area_foreach_alloc(area, context, widget, cell_area, background_area, callback, callback_data);
		return area;
	}

	public static int Event(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellAreaExterns.gtk_cell_area_event(area, context, widget, @event, cell_area, flags);
	}

	public static GtkCellAreaHandle Snapshot(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkSnapshotHandle snapshot, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags, int paint_focus)
	{
		GtkCellAreaExterns.gtk_cell_area_snapshot(area, context, widget, snapshot, background_area, cell_area, flags, paint_focus);
		return area;
	}

	public static GtkCellAreaHandle GetCellAllocation(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkRectangleHandle cell_area, GdkRectangleHandle allocation)
	{
		GtkCellAreaExterns.gtk_cell_area_get_cell_allocation(area, context, widget, renderer, cell_area, allocation);
		return area;
	}

	public static GtkCellRendererHandle GetCellAtPosition(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, int x, int y, GdkRectangleHandle alloc_area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_cell_at_position(area, context, widget, cell_area, x, y, alloc_area);
	}

	public static GtkCellAreaContextHandle CreateContext(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_create_context(area);
	}

	public static GtkCellAreaContextHandle CopyContext(this GtkCellAreaHandle area, GtkCellAreaContextHandle context)
	{
		return GtkCellAreaExterns.gtk_cell_area_copy_context(area, context);
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_request_mode(area);
	}

	public static GtkCellAreaHandle GetPreferredWidth(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_width, out int natural_width)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_width(area, context, widget, out minimum_width, out natural_width);
		return area;
	}

	public static GtkCellAreaHandle GetPreferredHeightForWidth(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_height_for_width(area, context, widget, width, out minimum_height, out natural_height);
		return area;
	}

	public static GtkCellAreaHandle GetPreferredHeight(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_height, out int natural_height)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_height(area, context, widget, out minimum_height, out natural_height);
		return area;
	}

	public static GtkCellAreaHandle GetPreferredWidthForHeight(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_width_for_height(area, context, widget, height, out minimum_width, out natural_width);
		return area;
	}

	public static string GetCurrentPathString(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_current_path_string(area);
	}

	public static GtkCellAreaHandle ApplyAttributes(this GtkCellAreaHandle area, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, int is_expander, int is_expanded)
	{
		GtkCellAreaExterns.gtk_cell_area_apply_attributes(area, tree_model, iter, is_expander, is_expanded);
		return area;
	}

	public static GtkCellAreaHandle AttributeConnect(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute, int column)
	{
		GtkCellAreaExterns.gtk_cell_area_attribute_connect(area, renderer, attribute, column);
		return area;
	}

	public static GtkCellAreaHandle AttributeDisconnect(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute)
	{
		GtkCellAreaExterns.gtk_cell_area_attribute_disconnect(area, renderer, attribute);
		return area;
	}

	public static int AttributeGetColumn(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute)
	{
		return GtkCellAreaExterns.gtk_cell_area_attribute_get_column(area, renderer, attribute);
	}

	public static GtkCellAreaHandle AddWithProperties(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__argList)
	{
		GtkCellAreaExterns.gtk_cell_area_add_with_properties(area, renderer, first_prop_name, @__argList);
		return area;
	}

	public static GtkCellAreaHandle CellSet(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__argList)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set(area, renderer, first_prop_name, @__argList);
		return area;
	}

	public static GtkCellAreaHandle CellGet(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__argList)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get(area, renderer, first_prop_name, @__argList);
		return area;
	}

	public static GtkCellAreaHandle CellSetValist(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, IntPtr @__argList)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set_valist(area, renderer, first_property_name, @__argList);
		return area;
	}

	public static GtkCellAreaHandle CellGetValist(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, IntPtr @__argList)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get_valist(area, renderer, first_property_name, @__argList);
		return area;
	}

	public static GtkCellAreaHandle CellSetProperty(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set_property(area, renderer, property_name, value);
		return area;
	}

	public static GtkCellAreaHandle CellGetProperty(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get_property(area, renderer, property_name, value);
		return area;
	}

	public static int IsActivatable(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_is_activatable(area);
	}

	public static int Activate(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GtkCellRendererState flags, int edit_only)
	{
		return GtkCellAreaExterns.gtk_cell_area_activate(area, context, widget, cell_area, flags, edit_only);
	}

	public static int Focus(this GtkCellAreaHandle area, GtkDirectionType direction)
	{
		return GtkCellAreaExterns.gtk_cell_area_focus(area, direction);
	}

	public static GtkCellAreaHandle SetFocusCell(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		GtkCellAreaExterns.gtk_cell_area_set_focus_cell(area, renderer);
		return area;
	}

	public static GtkCellRendererHandle GetFocusCell(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_cell(area);
	}

	public static GtkCellAreaHandle AddFocusSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling)
	{
		GtkCellAreaExterns.gtk_cell_area_add_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static GtkCellAreaHandle RemoveFocusSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling)
	{
		GtkCellAreaExterns.gtk_cell_area_remove_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static int IsFocusSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling)
	{
		return GtkCellAreaExterns.gtk_cell_area_is_focus_sibling(area, renderer, sibling);
	}

	public static GListHandle GetFocusSiblings(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_siblings(area, renderer);
	}

	public static GtkCellRendererHandle GetFocusFromSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_from_sibling(area, renderer);
	}

	public static GtkCellRendererHandle GetEditedCell(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_edited_cell(area);
	}

	public static GtkCellEditableHandle GetEditWidget(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_edit_widget(area);
	}

	public static int ActivateCell(this GtkCellAreaHandle area, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellAreaExterns.gtk_cell_area_activate_cell(area, widget, renderer, @event, cell_area, flags);
	}

	public static GtkCellAreaHandle StopEditing(this GtkCellAreaHandle area, int canceled)
	{
		GtkCellAreaExterns.gtk_cell_area_stop_editing(area, canceled);
		return area;
	}

	public static GtkCellAreaHandle InnerCellArea(this GtkCellAreaHandle area, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GdkRectangleHandle inner_area)
	{
		GtkCellAreaExterns.gtk_cell_area_inner_cell_area(area, widget, cell_area, inner_area);
		return area;
	}

	public static GtkCellAreaHandle RequestRenderer(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkOrientation orientation, GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size)
	{
		GtkCellAreaExterns.gtk_cell_area_request_renderer(area, renderer, orientation, widget, for_size, out minimum_size, out natural_size);
		return area;
	}

	public static GtkCellViewHandle GtkCellViewNewWithContext(this GtkCellAreaHandle area, GtkCellAreaContextHandle context)
	{
		return GtkCellAreaExterns.gtk_cell_view_new_with_context(area, context);
	}

	public static GtkTreeViewColumnHandle GtkTreeViewColumnNewWithArea(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_tree_view_column_new_with_area(area);
	}

	public static GtkEntryCompletionHandle GtkEntryCompletionNewWithArea(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_entry_completion_new_with_area(area);
	}

	public static GtkIconViewHandle GtkIconViewNewWithArea(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_icon_view_new_with_area(area);
	}
}
