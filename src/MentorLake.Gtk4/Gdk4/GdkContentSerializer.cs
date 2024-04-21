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

public class GdkContentSerializerHandle : GObjectHandle, GAsyncResultHandle
{
}

public static class GdkContentSerializerHandleExtensions
{
	public static GCancellableHandle GetCancellable(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_cancellable(serializer);
	}

	public static GType GetGtype(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_gtype(serializer);
	}

	public static string GetMimeType(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_mime_type(serializer);
	}

	public static GOutputStreamHandle GetOutputStream(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_output_stream(serializer);
	}

	public static int GetPriority(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_priority(serializer);
	}

	public static IntPtr GetTaskData(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_task_data(serializer);
	}

	public static IntPtr GetUserData(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_user_data(serializer);
	}

	public static GValueHandle GetValue(this GdkContentSerializerHandle serializer)
	{
		return GdkContentSerializerExterns.gdk_content_serializer_get_value(serializer);
	}

	public static GdkContentSerializerHandle ReturnError(this GdkContentSerializerHandle serializer, GErrorHandle error)
	{
		GdkContentSerializerExterns.gdk_content_serializer_return_error(serializer, error);
		return serializer;
	}

	public static GdkContentSerializerHandle ReturnSuccess(this GdkContentSerializerHandle serializer)
	{
		GdkContentSerializerExterns.gdk_content_serializer_return_success(serializer);
		return serializer;
	}

	public static GdkContentSerializerHandle SetTaskData(this GdkContentSerializerHandle serializer, IntPtr data, GDestroyNotify notify)
	{
		GdkContentSerializerExterns.gdk_content_serializer_set_task_data(serializer, data, notify);
		return serializer;
	}

}

internal class GdkContentSerializerExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GCancellableHandle gdk_content_serializer_get_cancellable(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern GType gdk_content_serializer_get_gtype(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_content_serializer_get_mime_type(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern GOutputStreamHandle gdk_content_serializer_get_output_stream(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_content_serializer_get_priority(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern IntPtr gdk_content_serializer_get_task_data(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern IntPtr gdk_content_serializer_get_user_data(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern GValueHandle gdk_content_serializer_get_value(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_serializer_return_error(GdkContentSerializerHandle serializer, GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_serializer_return_success(GdkContentSerializerHandle serializer);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_serializer_set_task_data(GdkContentSerializerHandle serializer, IntPtr data, GDestroyNotify notify);

}
