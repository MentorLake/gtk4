using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public interface GtkTreeDragSourceHandle
{
}

internal class GtkTreeDragSourceHandleImpl : BaseSafeHandle, GtkTreeDragSourceHandle
{
}

public static class GtkTreeDragSourceHandleExtensions
{
	public static bool DragDataDelete(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
	{
		return GtkTreeDragSourceExterns.gtk_tree_drag_source_drag_data_delete(drag_source, path);
	}

	public static GdkContentProviderHandle DragDataGet(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
	{
		return GtkTreeDragSourceExterns.gtk_tree_drag_source_drag_data_get(drag_source, path);
	}

	public static bool RowDraggable(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
	{
		return GtkTreeDragSourceExterns.gtk_tree_drag_source_row_draggable(drag_source, path);
	}

}

internal class GtkTreeDragSourceExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_drag_source_drag_data_delete(GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentProviderHandle gtk_tree_drag_source_drag_data_get(GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_drag_source_row_draggable(GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);

}
