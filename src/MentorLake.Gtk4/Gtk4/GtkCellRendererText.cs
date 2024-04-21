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

public class GtkCellRendererTextHandle : GtkCellRendererHandle
{
	public static GtkCellRendererTextHandle New()
	{
		return GtkCellRendererTextExterns.gtk_cell_renderer_text_new();
	}

}

public class GtkCellRendererTextSignal
{
	public string Value { get; set; }
	public GtkCellRendererTextSignal(string value) => Value = value;
}

public static class GtkCellRendererTextSignals
{
	public static GtkCellRendererTextSignal Edited = new("BindingTransform.MethodDeclaration");
}

public static class GtkCellRendererTextHandleExtensions
{
	public static GtkCellRendererTextHandle SetFixedHeightFromFont(this GtkCellRendererTextHandle renderer, int number_of_rows)
	{
		GtkCellRendererTextExterns.gtk_cell_renderer_text_set_fixed_height_from_font(renderer, number_of_rows);
		return renderer;
	}

	public static GtkCellRendererTextHandle Signal_Edited(this GtkCellRendererTextHandle instance, GtkCellRendererTextDelegates.Edited handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkCellRendererTextDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Edited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererTextHandle>))] GtkCellRendererTextHandle self, string path, string new_text, IntPtr user_data);
}

internal class GtkCellRendererTextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererTextHandle gtk_cell_renderer_text_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_renderer_text_set_fixed_height_from_font(GtkCellRendererTextHandle renderer, int number_of_rows);

}
