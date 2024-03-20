using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentProviderAdaptors
{
	public static GdkContentFormatsHandle RefFormats(this GdkContentProviderHandle provider)
	{
		return GdkContentProviderExterns.gdk_content_provider_ref_formats(provider);
	}

	public static GdkContentFormatsHandle RefStorableFormats(this GdkContentProviderHandle provider)
	{
		return GdkContentProviderExterns.gdk_content_provider_ref_storable_formats(provider);
	}

	public static GdkContentProviderHandle ContentChanged(this GdkContentProviderHandle provider)
	{
		GdkContentProviderExterns.gdk_content_provider_content_changed(provider);
		return provider;
	}

	public static GdkContentProviderHandle WriteMimeTypeAsync(this GdkContentProviderHandle provider, string mime_type, GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkContentProviderExterns.gdk_content_provider_write_mime_type_async(provider, mime_type, stream, io_priority, cancellable, callback, user_data);
		return provider;
	}

	public static int WriteMimeTypeFinish(this GdkContentProviderHandle provider, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GdkContentProviderExterns.gdk_content_provider_write_mime_type_finish(provider, result, out error);
	}

	public static int GetValue(this GdkContentProviderHandle provider, GValueHandle value, out GErrorHandle error)
	{
		return GdkContentProviderExterns.gdk_content_provider_get_value(provider, value, out error);
	}

	public static GdkContentProviderHandle NewTyped(GType type, IntPtr @__arglist)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_typed(type, @__arglist);
	}

	public static GdkContentProviderHandle NewForBytes(string mime_type, GBytesHandle bytes)
	{
		return GdkContentProviderExterns.gdk_content_provider_new_for_bytes(mime_type, bytes);
	}
}
