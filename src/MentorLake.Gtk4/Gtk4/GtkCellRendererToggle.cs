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

public class GtkCellRendererToggleHandle : GtkCellRendererHandle
{
	public static GtkCellRendererToggleHandle New()
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_new();
	}

}

public static class GtkCellRendererToggleSignalExtensions
{
	public static GtkCellRendererToggleHandle Signal_Toggled(this GtkCellRendererToggleHandle instance, GtkCellRendererToggleSignalDelegates.Toggled handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkCellRendererToggleSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererToggleHandle>))] GtkCellRendererToggleHandle self, string path, IntPtr user_data);
}


public static class GtkCellRendererToggleHandleExtensions
{
	public static bool GetActivatable(this GtkCellRendererToggleHandle toggle)
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_activatable(toggle);
	}

	public static bool GetActive(this GtkCellRendererToggleHandle toggle)
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_active(toggle);
	}

	public static bool GetRadio(this GtkCellRendererToggleHandle toggle)
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_radio(toggle);
	}

	public static GtkCellRendererToggleHandle SetActivatable(this GtkCellRendererToggleHandle toggle, bool setting)
	{
		GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_activatable(toggle, setting);
		return toggle;
	}

	public static GtkCellRendererToggleHandle SetActive(this GtkCellRendererToggleHandle toggle, bool setting)
	{
		GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_active(toggle, setting);
		return toggle;
	}

	public static GtkCellRendererToggleHandle SetRadio(this GtkCellRendererToggleHandle toggle, bool radio)
	{
		GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_radio(toggle, radio);
		return toggle;
	}

}

internal class GtkCellRendererToggleExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererToggleHandle gtk_cell_renderer_toggle_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_toggle_get_activatable(GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_toggle_get_active(GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_renderer_toggle_get_radio(GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_toggle_set_activatable(GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_toggle_set_active(GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_toggle_set_radio(GtkCellRendererToggleHandle toggle, bool radio);

}
