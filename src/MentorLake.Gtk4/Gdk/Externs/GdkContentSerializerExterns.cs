using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public static class GdkContentSerializerExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_mime_type")]
	internal static extern string gdk_content_serializer_get_mime_type(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_gtype")]
	internal static extern GType gdk_content_serializer_get_gtype(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_value")]
	internal static extern GValueHandle gdk_content_serializer_get_value(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_output_stream")]
	internal static extern GOutputStreamHandle gdk_content_serializer_get_output_stream(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_priority")]
	internal static extern int gdk_content_serializer_get_priority(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_cancellable")]
	internal static extern GCancellableHandle gdk_content_serializer_get_cancellable(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_user_data")]
	internal static extern IntPtr gdk_content_serializer_get_user_data(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_set_task_data")]
	internal static extern void gdk_content_serializer_set_task_data(this GdkContentSerializerHandle serializer, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_get_task_data")]
	internal static extern IntPtr gdk_content_serializer_get_task_data(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_return_success")]
	internal static extern void gdk_content_serializer_return_success(this GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serializer_return_error")]
	internal static extern void gdk_content_serializer_return_error(this GdkContentSerializerHandle serializer, GErrorHandle error);
}
