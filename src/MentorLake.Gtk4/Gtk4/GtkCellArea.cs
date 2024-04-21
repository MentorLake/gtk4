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

public class GtkCellAreaHandle : GInitiallyUnownedHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
}

public class GtkCellAreaSignal
{
	public string Value { get; set; }
	public GtkCellAreaSignal(string value) => Value = value;
}

public static class GtkCellAreaSignals
{
	public static GtkCellAreaSignal AddEditable = new("BindingTransform.MethodDeclaration");
	public static GtkCellAreaSignal ApplyAttributes = new("BindingTransform.MethodDeclaration");
	public static GtkCellAreaSignal FocusChanged = new("BindingTransform.MethodDeclaration");
	public static GtkCellAreaSignal RemoveEditable = new("BindingTransform.MethodDeclaration");
}

public static class GtkCellAreaHandleExtensions
{
	public static bool Activate(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool edit_only)
	{
		return GtkCellAreaExterns.gtk_cell_area_activate(area, context, widget, cell_area, flags, edit_only);
	}

	public static bool ActivateCell(this GtkCellAreaHandle area, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellAreaExterns.gtk_cell_area_activate_cell(area, widget, renderer, @event, cell_area, flags);
	}

	public static GtkCellAreaHandle Add(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		GtkCellAreaExterns.gtk_cell_area_add(area, renderer);
		return area;
	}

	public static GtkCellAreaHandle AddFocusSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling)
	{
		GtkCellAreaExterns.gtk_cell_area_add_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static GtkCellAreaHandle AddWithProperties(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist)
	{
		GtkCellAreaExterns.gtk_cell_area_add_with_properties(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static GtkCellAreaHandle ApplyAttributes(this GtkCellAreaHandle area, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded)
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

	public static GtkCellAreaHandle CellGet(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static GtkCellAreaHandle CellGetProperty(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get_property(area, renderer, property_name, value);
		return area;
	}

	public static GtkCellAreaHandle CellGetValist(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, out IntPtr var_args)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get_valist(area, renderer, first_property_name, out var_args);
		return area;
	}

	public static GtkCellAreaHandle CellSet(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static GtkCellAreaHandle CellSetProperty(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set_property(area, renderer, property_name, value);
		return area;
	}

	public static GtkCellAreaHandle CellSetValist(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args)
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set_valist(area, renderer, first_property_name, var_args);
		return area;
	}

	public static GtkCellAreaContextHandle CopyContext(this GtkCellAreaHandle area, GtkCellAreaContextHandle context)
	{
		return GtkCellAreaExterns.gtk_cell_area_copy_context(area, context);
	}

	public static GtkCellAreaContextHandle CreateContext(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_create_context(area);
	}

	public static int Event(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellAreaExterns.gtk_cell_area_event(area, context, widget, @event, cell_area, flags);
	}

	public static bool Focus(this GtkCellAreaHandle area, GtkDirectionType direction)
	{
		return GtkCellAreaExterns.gtk_cell_area_focus(area, direction);
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

	public static GtkCellAreaHandle GetCellAllocation(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkRectangleHandle cell_area, out GdkRectangle allocation)
	{
		GtkCellAreaExterns.gtk_cell_area_get_cell_allocation(area, context, widget, renderer, cell_area, out allocation);
		return area;
	}

	public static GtkCellRendererHandle GetCellAtPosition(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, int x, int y, out GdkRectangle alloc_area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_cell_at_position(area, context, widget, cell_area, x, y, out alloc_area);
	}

	public static string GetCurrentPathString(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_current_path_string(area);
	}

	public static GtkCellEditableHandle GetEditWidget(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_edit_widget(area);
	}

	public static GtkCellRendererHandle GetEditedCell(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_edited_cell(area);
	}

	public static GtkCellRendererHandle GetFocusCell(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_cell(area);
	}

	public static GtkCellRendererHandle GetFocusFromSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_from_sibling(area, renderer);
	}

	public static GListHandle GetFocusSiblings(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_siblings(area, renderer);
	}

	public static GtkCellAreaHandle GetPreferredHeight(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_height, out int natural_height)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_height(area, context, widget, out minimum_height, out natural_height);
		return area;
	}

	public static GtkCellAreaHandle GetPreferredHeightForWidth(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_height_for_width(area, context, widget, width, out minimum_height, out natural_height);
		return area;
	}

	public static GtkCellAreaHandle GetPreferredWidth(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_width, out int natural_width)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_width(area, context, widget, out minimum_width, out natural_width);
		return area;
	}

	public static GtkCellAreaHandle GetPreferredWidthForHeight(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width)
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_width_for_height(area, context, widget, height, out minimum_width, out natural_width);
		return area;
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_request_mode(area);
	}

	public static bool HasRenderer(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_has_renderer(area, renderer);
	}

	public static GtkCellAreaHandle InnerCellArea(this GtkCellAreaHandle area, GtkWidgetHandle widget, GdkRectangleHandle cell_area, out GdkRectangle inner_area)
	{
		GtkCellAreaExterns.gtk_cell_area_inner_cell_area(area, widget, cell_area, out inner_area);
		return area;
	}

	public static bool IsActivatable(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_is_activatable(area);
	}

	public static bool IsFocusSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling)
	{
		return GtkCellAreaExterns.gtk_cell_area_is_focus_sibling(area, renderer, sibling);
	}

	public static GtkCellAreaHandle Remove(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		GtkCellAreaExterns.gtk_cell_area_remove(area, renderer);
		return area;
	}

	public static GtkCellAreaHandle RemoveFocusSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling)
	{
		GtkCellAreaExterns.gtk_cell_area_remove_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static GtkCellAreaHandle RequestRenderer(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkOrientation orientation, GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size)
	{
		GtkCellAreaExterns.gtk_cell_area_request_renderer(area, renderer, orientation, widget, for_size, out minimum_size, out natural_size);
		return area;
	}

	public static GtkCellAreaHandle SetFocusCell(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		GtkCellAreaExterns.gtk_cell_area_set_focus_cell(area, renderer);
		return area;
	}

	public static GtkCellAreaHandle Snapshot(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkSnapshotHandle snapshot, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool paint_focus)
	{
		GtkCellAreaExterns.gtk_cell_area_snapshot(area, context, widget, snapshot, background_area, cell_area, flags, paint_focus);
		return area;
	}

	public static GtkCellAreaHandle StopEditing(this GtkCellAreaHandle area, bool canceled)
	{
		GtkCellAreaExterns.gtk_cell_area_stop_editing(area, canceled);
		return area;
	}

	public static GtkCellAreaHandle Signal_AddEditable(this GtkCellAreaHandle instance, GtkCellAreaDelegates.AddEditable handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "add_editable", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCellAreaHandle Signal_ApplyAttributes(this GtkCellAreaHandle instance, GtkCellAreaDelegates.ApplyAttributes handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "apply_attributes", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCellAreaHandle Signal_FocusChanged(this GtkCellAreaHandle instance, GtkCellAreaDelegates.FocusChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "focus_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCellAreaHandle Signal_RemoveEditable(this GtkCellAreaHandle instance, GtkCellAreaDelegates.RemoveEditable handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "remove_editable", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkCellAreaDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AddEditable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, GtkCellRendererHandle renderer, GtkCellEditableHandle editable, GdkRectangleHandle cell_area, string path, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ApplyAttributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void FocusChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, GtkCellRendererHandle renderer, string path, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void RemoveEditable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, GtkCellRendererHandle renderer, GtkCellEditableHandle editable, IntPtr user_data);
}

internal class GtkCellAreaExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_area_activate(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool edit_only);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_area_activate_cell(GtkCellAreaHandle area, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_add(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_add_focus_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_add_with_properties(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_apply_attributes(GtkCellAreaHandle area, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_attribute_connect(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute, int column);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_attribute_disconnect(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_cell_area_attribute_get_column(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_cell_get(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_cell_get_property(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_cell_get_valist(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, out IntPtr var_args);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_cell_set(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_cell_set_property(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_cell_set_valist(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellAreaContextHandle gtk_cell_area_copy_context(GtkCellAreaHandle area, GtkCellAreaContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellAreaContextHandle gtk_cell_area_create_context(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_cell_area_event(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_area_focus(GtkCellAreaHandle area, GtkDirectionType direction);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_foreach(GtkCellAreaHandle area, GtkCellCallback callback, IntPtr callback_data);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_foreach_alloc(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GdkRectangleHandle background_area, GtkCellAllocCallback callback, IntPtr callback_data);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_get_cell_allocation(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkRectangleHandle cell_area, out GdkRectangle allocation);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_cell_at_position(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, int x, int y, out GdkRectangle alloc_area);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_cell_area_get_current_path_string(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellEditableHandle gtk_cell_area_get_edit_widget(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_edited_cell(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_focus_cell(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_focus_from_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_cell_area_get_focus_siblings(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_get_preferred_height(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_get_preferred_height_for_width(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_get_preferred_width(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_get_preferred_width_for_height(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSizeRequestMode gtk_cell_area_get_request_mode(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_area_has_renderer(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_inner_cell_area(GtkCellAreaHandle area, GtkWidgetHandle widget, GdkRectangleHandle cell_area, out GdkRectangle inner_area);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_area_is_activatable(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_area_is_focus_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_remove(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_remove_focus_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_request_renderer(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkOrientation orientation, GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_set_focus_cell(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_snapshot(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkSnapshotHandle snapshot, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool paint_focus);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_stop_editing(GtkCellAreaHandle area, bool canceled);

}
