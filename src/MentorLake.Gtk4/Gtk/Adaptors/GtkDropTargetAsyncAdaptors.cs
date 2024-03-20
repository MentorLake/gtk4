using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDropTargetAsyncAdaptors
{
	public static GtkDropTargetAsyncHandle SetFormats(this GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_formats(self, formats);
		return self;
	}

	public static GdkContentFormatsHandle GetFormats(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_formats(self);
	}

	public static GtkDropTargetAsyncHandle SetActions(this GtkDropTargetAsyncHandle self, GdkDragAction actions)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_actions(self, actions);
		return self;
	}

	public static GdkDragAction GetActions(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_actions(self);
	}

	public static GtkDropTargetAsyncHandle RejectDrop(this GtkDropTargetAsyncHandle self, GdkDropHandle drop)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_reject_drop(self, drop);
		return self;
	}
}
