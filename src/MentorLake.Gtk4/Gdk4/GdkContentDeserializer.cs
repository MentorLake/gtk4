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

public class GdkContentDeserializerHandle : GObjectHandle
{
}

public static class GdkContentDeserializerHandleExtensions
{
	public static GCancellableHandle GetCancellable(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_cancellable(deserializer);
	}

	public static GType GetGtype(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_gtype(deserializer);
	}

	public static GInputStreamHandle GetInputStream(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_input_stream(deserializer);
	}

	public static string GetMimeType(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_mime_type(deserializer);
	}

	public static int GetPriority(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_priority(deserializer);
	}

	public static IntPtr GetTaskData(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_task_data(deserializer);
	}

	public static IntPtr GetUserData(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_user_data(deserializer);
	}

	public static GValueHandle GetValue(this GdkContentDeserializerHandle deserializer)
	{
		return GdkContentDeserializerExterns.gdk_content_deserializer_get_value(deserializer);
	}

	public static GdkContentDeserializerHandle ReturnError(this GdkContentDeserializerHandle deserializer, GErrorHandle error)
	{
		GdkContentDeserializerExterns.gdk_content_deserializer_return_error(deserializer, error);
		return deserializer;
	}

	public static GdkContentDeserializerHandle ReturnSuccess(this GdkContentDeserializerHandle deserializer)
	{
		GdkContentDeserializerExterns.gdk_content_deserializer_return_success(deserializer);
		return deserializer;
	}

	public static GdkContentDeserializerHandle SetTaskData(this GdkContentDeserializerHandle deserializer, IntPtr data, GDestroyNotify notify)
	{
		GdkContentDeserializerExterns.gdk_content_deserializer_set_task_data(deserializer, data, notify);
		return deserializer;
	}

}

internal class GdkContentDeserializerExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GCancellableHandle gdk_content_deserializer_get_cancellable(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern GType gdk_content_deserializer_get_gtype(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern GInputStreamHandle gdk_content_deserializer_get_input_stream(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_content_deserializer_get_mime_type(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_content_deserializer_get_priority(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern IntPtr gdk_content_deserializer_get_task_data(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern IntPtr gdk_content_deserializer_get_user_data(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern GValueHandle gdk_content_deserializer_get_value(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_deserializer_return_error(GdkContentDeserializerHandle deserializer, GErrorHandle error);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_deserializer_return_success(GdkContentDeserializerHandle deserializer);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_deserializer_set_task_data(GdkContentDeserializerHandle deserializer, IntPtr data, GDestroyNotify notify);
}
