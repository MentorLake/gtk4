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

namespace MentorLake.Gtk4.Gdk4;

public class GdkContentProviderHandle : GObjectHandle
{
	public static GdkContentProviderHandle NewForBytes(string mime_type, GBytesHandle bytes)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_for_bytes(mime_type, bytes);
	}

	public static GdkContentProviderHandle NewForValue(GValueHandle value)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_for_value(value);
	}

	public static GdkContentProviderHandle NewTyped(GType type, IntPtr @__arglist)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_typed(type, @__arglist);
	}

	public static GdkContentProviderHandle NewUnion(GdkContentProviderHandle[] providers, int n_providers)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_union(providers, n_providers);
	}

}

public static class GdkContentProviderSignalExtensions
{
	public static GdkContentProviderHandle Signal_ContentChanged(this GdkContentProviderHandle instance, GdkContentProviderSignalDelegates.ContentChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "content_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GdkContentProviderSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ContentChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkContentProviderHandle>))] GdkContentProviderHandle self, IntPtr user_data);
}


public static class GdkContentProviderHandleExtensions
{
	public static GdkContentProviderHandle ContentChanged(this GdkContentProviderHandle provider)
	{
		GdkContentProviderExterns.gdk_content_provider_content_changed(provider);
		return provider;
	}

	public static bool GetValue(this GdkContentProviderHandle provider, out GValue value, out GErrorHandle error)
	{
		return GdkContentProviderExterns.gdk_content_provider_get_value(provider, out value, out error);
	}

	public static GdkContentFormatsHandle RefFormats(this GdkContentProviderHandle provider)
	{
		return GdkContentProviderExterns.gdk_content_provider_ref_formats(provider);
	}

	public static GdkContentFormatsHandle RefStorableFormats(this GdkContentProviderHandle provider)
	{
		return GdkContentProviderExterns.gdk_content_provider_ref_storable_formats(provider);
	}

	public static GdkContentProviderHandle WriteMimeTypeAsync(this GdkContentProviderHandle provider, string mime_type, GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkContentProviderExterns.gdk_content_provider_write_mime_type_async(provider, mime_type, stream, io_priority, cancellable, callback, user_data);
		return provider;
	}

	public static bool WriteMimeTypeFinish(this GdkContentProviderHandle provider, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GdkContentProviderExterns.gdk_content_provider_write_mime_type_finish(provider, result, out error);
	}

}

internal class GdkContentProviderExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentProviderHandle gdk_content_provider_new_for_bytes(string mime_type, GBytesHandle bytes);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentProviderHandle gdk_content_provider_new_for_value(GValueHandle value);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentProviderHandle gdk_content_provider_new_typed(GType type, IntPtr @__arglist);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentProviderHandle gdk_content_provider_new_union(GdkContentProviderHandle[] providers, int n_providers);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_provider_content_changed(GdkContentProviderHandle provider);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_content_provider_get_value(GdkContentProviderHandle provider, out GValue value, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_provider_ref_formats(GdkContentProviderHandle provider);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_provider_ref_storable_formats(GdkContentProviderHandle provider);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_provider_write_mime_type_async(GdkContentProviderHandle provider, string mime_type, GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_content_provider_write_mime_type_finish(GdkContentProviderHandle provider, GAsyncResultHandle result, out GErrorHandle error);

}
