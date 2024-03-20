using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public static class GdkContentDeserializerExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_mime_type")]
	internal static extern string gdk_content_deserializer_get_mime_type(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_gtype")]
	internal static extern GType gdk_content_deserializer_get_gtype(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_value")]
	internal static extern GValueHandle gdk_content_deserializer_get_value(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_input_stream")]
	internal static extern GInputStreamHandle gdk_content_deserializer_get_input_stream(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_priority")]
	internal static extern int gdk_content_deserializer_get_priority(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_cancellable")]
	internal static extern GCancellableHandle gdk_content_deserializer_get_cancellable(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_user_data")]
	internal static extern IntPtr gdk_content_deserializer_get_user_data(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_set_task_data")]
	internal static extern void gdk_content_deserializer_set_task_data(this GdkContentDeserializerHandle deserializer, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_get_task_data")]
	internal static extern IntPtr gdk_content_deserializer_get_task_data(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_return_success")]
	internal static extern void gdk_content_deserializer_return_success(this GdkContentDeserializerHandle deserializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserializer_return_error")]
	internal static extern void gdk_content_deserializer_return_error(this GdkContentDeserializerHandle deserializer, GErrorHandle error);
}
