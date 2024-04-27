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

public class GtkExpanderHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkExpanderHandle New(string label)
	{
		return GtkExpanderExterns.gtk_expander_new(label);
	}

	public static GtkExpanderHandle NewWithMnemonic(string label)
	{
		return GtkExpanderExterns.gtk_expander_new_with_mnemonic(label);
	}

}

public static class GtkExpanderSignalExtensions
{
	public static GtkExpanderHandle Signal_Activate(this GtkExpanderHandle instance, GtkExpanderSignalDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkExpanderSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkExpanderHandle>))] GtkExpanderHandle self, IntPtr user_data);
}


public static class GtkExpanderHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_child(expander);
	}

	public static bool GetExpanded(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_expanded(expander);
	}

	public static string GetLabel(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_label(expander);
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_label_widget(expander);
	}

	public static bool GetResizeToplevel(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_resize_toplevel(expander);
	}

	public static bool GetUseMarkup(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_use_markup(expander);
	}

	public static bool GetUseUnderline(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_use_underline(expander);
	}

	public static GtkExpanderHandle SetChild(this GtkExpanderHandle expander, GtkWidgetHandle child)
	{
		GtkExpanderExterns.gtk_expander_set_child(expander, child);
		return expander;
	}

	public static GtkExpanderHandle SetExpanded(this GtkExpanderHandle expander, bool expanded)
	{
		GtkExpanderExterns.gtk_expander_set_expanded(expander, expanded);
		return expander;
	}

	public static GtkExpanderHandle SetLabel(this GtkExpanderHandle expander, string label)
	{
		GtkExpanderExterns.gtk_expander_set_label(expander, label);
		return expander;
	}

	public static GtkExpanderHandle SetLabelWidget(this GtkExpanderHandle expander, GtkWidgetHandle label_widget)
	{
		GtkExpanderExterns.gtk_expander_set_label_widget(expander, label_widget);
		return expander;
	}

	public static GtkExpanderHandle SetResizeToplevel(this GtkExpanderHandle expander, bool resize_toplevel)
	{
		GtkExpanderExterns.gtk_expander_set_resize_toplevel(expander, resize_toplevel);
		return expander;
	}

	public static GtkExpanderHandle SetUseMarkup(this GtkExpanderHandle expander, bool use_markup)
	{
		GtkExpanderExterns.gtk_expander_set_use_markup(expander, use_markup);
		return expander;
	}

	public static GtkExpanderHandle SetUseUnderline(this GtkExpanderHandle expander, bool use_underline)
	{
		GtkExpanderExterns.gtk_expander_set_use_underline(expander, use_underline);
		return expander;
	}

}

internal class GtkExpanderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpanderHandle gtk_expander_new(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpanderHandle gtk_expander_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_expander_get_child(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_expander_get_expanded(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_expander_get_label(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_expander_get_label_widget(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_expander_get_resize_toplevel(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_expander_get_use_markup(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_expander_get_use_underline(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expander_set_child(GtkExpanderHandle expander, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expander_set_expanded(GtkExpanderHandle expander, bool expanded);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expander_set_label(GtkExpanderHandle expander, string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expander_set_label_widget(GtkExpanderHandle expander, GtkWidgetHandle label_widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expander_set_resize_toplevel(GtkExpanderHandle expander, bool resize_toplevel);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expander_set_use_markup(GtkExpanderHandle expander, bool use_markup);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expander_set_use_underline(GtkExpanderHandle expander, bool use_underline);

}
