using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDragExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_display")]
	internal static extern GdkDisplayHandle gdk_drag_get_display(this GdkDragHandle drag);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_device")]
	internal static extern GdkDeviceHandle gdk_drag_get_device(this GdkDragHandle drag);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_formats")]
	internal static extern GdkContentFormatsHandle gdk_drag_get_formats(this GdkDragHandle drag);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_actions")]
	internal static extern GdkDragAction gdk_drag_get_actions(this GdkDragHandle drag);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_selected_action")]
	internal static extern GdkDragAction gdk_drag_get_selected_action(this GdkDragHandle drag);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_drop_done")]
	internal static extern void gdk_drag_drop_done(this GdkDragHandle drag, int success);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_drag_surface")]
	internal static extern GdkSurfaceHandle gdk_drag_get_drag_surface(this GdkDragHandle drag);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_set_hotspot")]
	internal static extern void gdk_drag_set_hotspot(this GdkDragHandle drag, int hot_x, int hot_y);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_content")]
	internal static extern GdkContentProviderHandle gdk_drag_get_content(this GdkDragHandle drag);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_get_surface")]
	internal static extern GdkSurfaceHandle gdk_drag_get_surface(this GdkDragHandle drag);
}
