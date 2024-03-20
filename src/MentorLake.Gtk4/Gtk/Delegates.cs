using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GtkScaleFormatValueFunc(GtkScaleHandle scale, double value, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeModelFilterModifyFunc(GtkTreeModelHandle model, GtkTreeIterHandle iter, GValueHandle value, int column, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkCellCallback(GtkCellRendererHandle renderer, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkMenuButtonCreatePopupFunc(GtkMenuButtonHandle menu_button, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeViewSearchEqualFunc(GtkTreeModelHandle model, int column, string key, GtkTreeIterHandle iter, IntPtr search_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeViewMappingFunc(GtkTreeViewHandle tree_view, GtkTreePathHandle path, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkExpressionNotify(IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkListBoxFilterFunc(GtkListBoxRowHandle row, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkListBoxForeachFunc(GtkListBoxHandle box, GtkListBoxRowHandle row, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkCustomAllocateFunc(GtkWidgetHandle widget, int width, int height, int baseline);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkWidgetActionActivateFunc(GtkWidgetHandle widget, string action_name, GVariantHandle parameter);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeViewRowSeparatorFunc(GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeCellDataFunc(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkCellLayoutDataFunc(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkFontFilterFunc(PangoFontFamilyHandle family, PangoFontFaceHandle face, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkCustomMeasureFunc(GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkCellAllocCallback(GtkCellRendererHandle renderer, GdkRectangleHandle cell_area, GdkRectangleHandle cell_background, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkFlowBoxForeachFunc(GtkFlowBoxHandle box, GtkFlowBoxChildHandle child, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkPageSetupDoneFunc(GtkPageSetupHandle page_setup, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTextTagTableForeach(GtkTextTagHandle tag, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeModelForeachFunc(GtkTreeModelHandle model, GtkTreePathHandle path, GtkTreeIterHandle iter, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GtkSizeRequestMode GtkCustomRequestModeFunc(GtkWidgetHandle widget);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeViewColumnDropFunc(GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, GtkTreeViewColumnHandle prev_column, GtkTreeViewColumnHandle next_column, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkIconViewForeachFunc(GtkIconViewHandle icon_view, GtkTreePathHandle path, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkCustomFilterFunc(IntPtr item, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkListBoxSortFunc(GtkListBoxRowHandle row1, GtkListBoxRowHandle row2, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkShortcutFunc(GtkWidgetHandle widget, GVariantHandle args, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkPrintSettingsFunc(string key, string value, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkEntryCompletionMatchFunc(GtkEntryCompletionHandle completion, string key, GtkTreeIterHandle iter, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeSelectionFunc(GtkTreeSelectionHandle selection, GtkTreeModelHandle model, GtkTreePathHandle path, int path_currently_selected, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkAssistantPageFunc(int current_page, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GtkWidgetHandle GtkFlowBoxCreateWidgetFunc(IntPtr item, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTextCharPredicate(uint ch, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeModelFilterVisibleFunc(GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GListModelHandle GtkTreeListModelCreateModelFunc(IntPtr item, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkDrawingAreaDrawFunc(GtkDrawingAreaHandle drawing_area, cairoHandle cr, int width, int height, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GtkMapListModelMapFunc(IntPtr item, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkListBoxUpdateHeaderFunc(GtkListBoxRowHandle row, GtkListBoxRowHandle before, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkFlowBoxSortFunc(GtkFlowBoxChildHandle child1, GtkFlowBoxChildHandle child2, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GtkWidgetHandle GtkListBoxCreateWidgetFunc(IntPtr item, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeIterCompareFunc(GtkTreeModelHandle model, GtkTreeIterHandle a, GtkTreeIterHandle b, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeSelectionForeachFunc(GtkTreeModelHandle model, GtkTreePathHandle path, GtkTreeIterHandle iter, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkFlowBoxFilterFunc(GtkFlowBoxChildHandle child, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTickCallback(GtkWidgetHandle widget, GdkFrameClockHandle frame_clock, IntPtr user_data);
