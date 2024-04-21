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

public class GtkColorButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkConstraintTargetHandle
{
	public static GtkColorButtonHandle New()
	{
		return GtkColorButtonExterns.gtk_color_button_new();
	}

	public static GtkColorButtonHandle NewWithRgba(GdkRGBAHandle rgba)
	{
		return GtkColorButtonExterns.gtk_color_button_new_with_rgba(rgba);
	}

}

public class GtkColorButtonSignal
{
	public string Value { get; set; }
	public GtkColorButtonSignal(string value) => Value = value;
}

public static class GtkColorButtonSignals
{
	public static GtkColorButtonSignal Activate = new("BindingTransform.MethodDeclaration");
	public static GtkColorButtonSignal ColorSet = new("BindingTransform.MethodDeclaration");
}

public static class GtkColorButtonHandleExtensions
{
	public static bool GetModal(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_modal(button);
	}

	public static string GetTitle(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_title(button);
	}

	public static GtkColorButtonHandle SetModal(this GtkColorButtonHandle button, bool modal)
	{
		GtkColorButtonExterns.gtk_color_button_set_modal(button, modal);
		return button;
	}

	public static GtkColorButtonHandle SetTitle(this GtkColorButtonHandle button, string title)
	{
		GtkColorButtonExterns.gtk_color_button_set_title(button, title);
		return button;
	}

	public static GtkColorButtonHandle Signal_Activate(this GtkColorButtonHandle instance, GtkColorButtonDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkColorButtonHandle Signal_ColorSet(this GtkColorButtonHandle instance, GtkColorButtonDelegates.ColorSet handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "color_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkColorButtonDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColorButtonHandle>))] GtkColorButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ColorSet([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColorButtonHandle>))] GtkColorButtonHandle self, IntPtr user_data);
}

internal class GtkColorButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorButtonHandle gtk_color_button_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorButtonHandle gtk_color_button_new_with_rgba(GdkRGBAHandle rgba);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_color_button_get_modal(GtkColorButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_color_button_get_title(GtkColorButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_button_set_modal(GtkColorButtonHandle button, bool modal);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_button_set_title(GtkColorButtonHandle button, string title);

}
