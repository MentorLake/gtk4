using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDragSourceAdaptors
{
	public static GtkDragSourceHandle SetContent(this GtkDragSourceHandle source, GdkContentProviderHandle content)
	{
		GtkDragSourceExterns.gtk_drag_source_set_content(source, content);
		return source;
	}

	public static GdkContentProviderHandle GetContent(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_content(source);
	}

	public static GtkDragSourceHandle SetActions(this GtkDragSourceHandle source, GdkDragAction actions)
	{
		GtkDragSourceExterns.gtk_drag_source_set_actions(source, actions);
		return source;
	}

	public static GdkDragAction GetActions(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_actions(source);
	}

	public static GtkDragSourceHandle SetIcon(this GtkDragSourceHandle source, GdkPaintableHandle paintable, int hot_x, int hot_y)
	{
		GtkDragSourceExterns.gtk_drag_source_set_icon(source, paintable, hot_x, hot_y);
		return source;
	}

	public static GtkDragSourceHandle DragCancel(this GtkDragSourceHandle source)
	{
		GtkDragSourceExterns.gtk_drag_source_drag_cancel(source);
		return source;
	}

	public static GdkDragHandle GetDrag(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_drag(source);
	}
}
