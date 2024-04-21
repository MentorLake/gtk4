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

public class GtkNativeDialogHandle : GObjectHandle
{
}

public class GtkNativeDialogSignal
{
	public string Value { get; set; }
	public GtkNativeDialogSignal(string value) => Value = value;
}

public static class GtkNativeDialogSignals
{
	public static GtkNativeDialogSignal Response = new("BindingTransform.MethodDeclaration");
}

public static class GtkNativeDialogHandleExtensions
{
	public static GtkNativeDialogHandle Destroy(this GtkNativeDialogHandle self)
	{
		GtkNativeDialogExterns.gtk_native_dialog_destroy(self);
		return self;
	}

	public static bool GetModal(this GtkNativeDialogHandle self)
	{
		return GtkNativeDialogExterns.gtk_native_dialog_get_modal(self);
	}

	public static string GetTitle(this GtkNativeDialogHandle self)
	{
		return GtkNativeDialogExterns.gtk_native_dialog_get_title(self);
	}

	public static GtkWindowHandle GetTransientFor(this GtkNativeDialogHandle self)
	{
		return GtkNativeDialogExterns.gtk_native_dialog_get_transient_for(self);
	}

	public static bool GetVisible(this GtkNativeDialogHandle self)
	{
		return GtkNativeDialogExterns.gtk_native_dialog_get_visible(self);
	}

	public static GtkNativeDialogHandle Hide(this GtkNativeDialogHandle self)
	{
		GtkNativeDialogExterns.gtk_native_dialog_hide(self);
		return self;
	}

	public static GtkNativeDialogHandle SetModal(this GtkNativeDialogHandle self, bool modal)
	{
		GtkNativeDialogExterns.gtk_native_dialog_set_modal(self, modal);
		return self;
	}

	public static GtkNativeDialogHandle SetTitle(this GtkNativeDialogHandle self, string title)
	{
		GtkNativeDialogExterns.gtk_native_dialog_set_title(self, title);
		return self;
	}

	public static GtkNativeDialogHandle SetTransientFor(this GtkNativeDialogHandle self, GtkWindowHandle parent)
	{
		GtkNativeDialogExterns.gtk_native_dialog_set_transient_for(self, parent);
		return self;
	}

	public static GtkNativeDialogHandle Show(this GtkNativeDialogHandle self)
	{
		GtkNativeDialogExterns.gtk_native_dialog_show(self);
		return self;
	}

	public static GtkNativeDialogHandle Signal_Response(this GtkNativeDialogHandle instance, GtkNativeDialogDelegates.Response handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "response", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkNativeDialogDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNativeDialogHandle>))] GtkNativeDialogHandle self, int response_id, IntPtr user_data);
}

internal class GtkNativeDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_dialog_destroy(GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_native_dialog_get_modal(GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_native_dialog_get_title(GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowHandle gtk_native_dialog_get_transient_for(GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_native_dialog_get_visible(GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_dialog_hide(GtkNativeDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_dialog_set_modal(GtkNativeDialogHandle self, bool modal);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_dialog_set_title(GtkNativeDialogHandle self, string title);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_dialog_set_transient_for(GtkNativeDialogHandle self, GtkWindowHandle parent);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_dialog_show(GtkNativeDialogHandle self);

}
