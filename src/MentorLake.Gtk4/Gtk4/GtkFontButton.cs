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

public class GtkFontButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkFontChooserHandle
{
	public static GtkFontButtonHandle New()
	{
		return GtkFontButtonExterns.gtk_font_button_new();
	}

	public static GtkFontButtonHandle NewWithFont(string fontname)
	{
		return GtkFontButtonExterns.gtk_font_button_new_with_font(fontname);
	}

}

public class GtkFontButtonSignal
{
	public string Value { get; set; }
	public GtkFontButtonSignal(string value) => Value = value;
}

public static class GtkFontButtonSignals
{
	public static GtkFontButtonSignal Activate = new("BindingTransform.MethodDeclaration");
	public static GtkFontButtonSignal FontSet = new("BindingTransform.MethodDeclaration");
}

public static class GtkFontButtonHandleExtensions
{
	public static bool GetModal(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_modal(font_button);
	}

	public static string GetTitle(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_title(font_button);
	}

	public static bool GetUseFont(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_use_font(font_button);
	}

	public static bool GetUseSize(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_use_size(font_button);
	}

	public static GtkFontButtonHandle SetModal(this GtkFontButtonHandle font_button, bool modal)
	{
		GtkFontButtonExterns.gtk_font_button_set_modal(font_button, modal);
		return font_button;
	}

	public static GtkFontButtonHandle SetTitle(this GtkFontButtonHandle font_button, string title)
	{
		GtkFontButtonExterns.gtk_font_button_set_title(font_button, title);
		return font_button;
	}

	public static GtkFontButtonHandle SetUseFont(this GtkFontButtonHandle font_button, bool use_font)
	{
		GtkFontButtonExterns.gtk_font_button_set_use_font(font_button, use_font);
		return font_button;
	}

	public static GtkFontButtonHandle SetUseSize(this GtkFontButtonHandle font_button, bool use_size)
	{
		GtkFontButtonExterns.gtk_font_button_set_use_size(font_button, use_size);
		return font_button;
	}

	public static GtkFontButtonHandle Signal_Activate(this GtkFontButtonHandle instance, GtkFontButtonDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFontButtonHandle Signal_FontSet(this GtkFontButtonHandle instance, GtkFontButtonDelegates.FontSet handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "font_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkFontButtonDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFontButtonHandle>))] GtkFontButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void FontSet([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFontButtonHandle>))] GtkFontButtonHandle self, IntPtr user_data);
}

internal class GtkFontButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontButtonHandle gtk_font_button_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontButtonHandle gtk_font_button_new_with_font(string fontname);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_button_get_modal(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_button_get_title(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_button_get_use_font(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_button_get_use_size(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_button_set_modal(GtkFontButtonHandle font_button, bool modal);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_button_set_title(GtkFontButtonHandle font_button, string title);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_button_set_use_font(GtkFontButtonHandle font_button, bool use_font);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_button_set_use_size(GtkFontButtonHandle font_button, bool use_size);

}
