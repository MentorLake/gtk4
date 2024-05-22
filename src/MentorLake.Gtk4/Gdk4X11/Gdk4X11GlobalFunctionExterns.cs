namespace MentorLake.Gtk4.Gdk4X11;

internal class Gdk4X11GlobalFunctionExterns
{
	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_free_text_list(ref string list);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkDisplayHandle gdk_x11_lookup_xdisplay(IntPtr xdisplay);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern ulong gdk_x11_get_xatom_by_name_for_display(GdkDisplayHandle display, string atom_name);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_set_sm_client_id(string sm_client_id);

	[DllImport(Libraries.Gdk4X11)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_get_xatom_name_for_display(GdkDisplayHandle display, ulong xatom);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern int gdk_x11_device_get_id(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_free_compound_text(string ctext);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern uint gdk_x11_get_server_time(GdkSurfaceHandle surface);

}
