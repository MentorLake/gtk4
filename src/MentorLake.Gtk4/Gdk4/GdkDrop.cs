namespace MentorLake.Gtk4.Gdk4;

public class GdkDropHandle : GObjectHandle
{
}

public static class GdkDropHandleExtensions
{
	public static GdkDropHandle Finish(this GdkDropHandle self, GdkDragAction action)
	{
		GdkDropExterns.gdk_drop_finish(self, action);
		return self;
	}

	public static GdkDragAction GetActions(this GdkDropHandle self)
	{
		return GdkDropExterns.gdk_drop_get_actions(self);
	}

	public static GdkDeviceHandle GetDevice(this GdkDropHandle self)
	{
		return GdkDropExterns.gdk_drop_get_device(self);
	}

	public static GdkDisplayHandle GetDisplay(this GdkDropHandle self)
	{
		return GdkDropExterns.gdk_drop_get_display(self);
	}

	public static GdkDragHandle GetDrag(this GdkDropHandle self)
	{
		return GdkDropExterns.gdk_drop_get_drag(self);
	}

	public static GdkContentFormatsHandle GetFormats(this GdkDropHandle self)
	{
		return GdkDropExterns.gdk_drop_get_formats(self);
	}

	public static GdkSurfaceHandle GetSurface(this GdkDropHandle self)
	{
		return GdkDropExterns.gdk_drop_get_surface(self);
	}

	public static GdkDropHandle ReadAsync(this GdkDropHandle self, string[] mime_types, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkDropExterns.gdk_drop_read_async(self, mime_types, io_priority, cancellable, callback, user_data);
		return self;
	}

	public static GInputStreamHandle ReadFinish(this GdkDropHandle self, GAsyncResultHandle result, out string out_mime_type, out GErrorHandle error)
	{
		return GdkDropExterns.gdk_drop_read_finish(self, result, out out_mime_type, out error);
	}

	public static GdkDropHandle ReadValueAsync(this GdkDropHandle self, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkDropExterns.gdk_drop_read_value_async(self, type, io_priority, cancellable, callback, user_data);
		return self;
	}

	public static GValueHandle ReadValueFinish(this GdkDropHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GdkDropExterns.gdk_drop_read_value_finish(self, result, out error);
	}

	public static GdkDropHandle Status(this GdkDropHandle self, GdkDragAction actions, GdkDragAction preferred)
	{
		GdkDropExterns.gdk_drop_status(self, actions, preferred);
		return self;
	}

}

internal class GdkDropExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_drop_finish(GdkDropHandle self, GdkDragAction action);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDragAction gdk_drop_get_actions(GdkDropHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceHandle gdk_drop_get_device(GdkDropHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_drop_get_display(GdkDropHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDragHandle gdk_drop_get_drag(GdkDropHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_drop_get_formats(GdkDropHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_drop_get_surface(GdkDropHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_drop_read_async(GdkDropHandle self, string[] mime_types, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern GInputStreamHandle gdk_drop_read_finish(GdkDropHandle self, GAsyncResultHandle result, out string out_mime_type, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_drop_read_value_async(GdkDropHandle self, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern GValueHandle gdk_drop_read_value_finish(GdkDropHandle self, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_drop_status(GdkDropHandle self, GdkDragAction actions, GdkDragAction preferred);

}
