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

namespace MentorLake.Gtk4.Gio;

public class GTaskHandle : GObjectHandle
{
	public static GTaskHandle New(GObjectHandle source_object, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr callback_data)
	{
		return GTaskExterns.g_task_new(source_object, cancellable, callback, callback_data);
	}
}

public static class GTaskSignals
{
}

public static class GTaskHandleExtensions
{
	public static GTaskHandle AttachSource(this GTaskHandle task, GSourceHandle source, GSourceFunc callback)
	{
		GTaskExterns.g_task_attach_source(task, source, callback);
		return task;
	}

	public static GCancellableHandle GetCancellable(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_cancellable(task);
	}

	public static bool GetCheckCancellable(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_check_cancellable(task);
	}

	public static bool GetCompleted(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_completed(task);
	}

	public static GMainContextHandle GetContext(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_context(task);
	}

	public static string GetName(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_name(task);
	}

	public static int GetPriority(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_priority(task);
	}

	public static bool GetReturnOnCancel(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_return_on_cancel(task);
	}

	public static GObjectHandle GetSourceObject(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_source_object(task);
	}

	public static IntPtr GetSourceTag(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_source_tag(task);
	}

	public static IntPtr GetTaskData(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_task_data(task);
	}

	public static bool HadError(this GTaskHandle task)
	{
		return GTaskExterns.g_task_had_error(task);
	}

	public static bool PropagateBoolean(this GTaskHandle task, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_boolean(task, out error);
	}

	public static int PropagateInt(this GTaskHandle task, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_int(task, out error);
	}

	public static IntPtr PropagatePointer(this GTaskHandle task, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_pointer(task, out error);
	}

	public static bool PropagateValue(this GTaskHandle task, out GValue value, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_value(task, out value, out error);
	}

	public static GTaskHandle ReturnBoolean(this GTaskHandle task, bool result)
	{
		GTaskExterns.g_task_return_boolean(task, result);
		return task;
	}

	public static GTaskHandle ReturnError(this GTaskHandle task, GErrorHandle error)
	{
		GTaskExterns.g_task_return_error(task, error);
		return task;
	}

	public static bool ReturnErrorIfCancelled(this GTaskHandle task)
	{
		return GTaskExterns.g_task_return_error_if_cancelled(task);
	}

	public static GTaskHandle ReturnInt(this GTaskHandle task, int result)
	{
		GTaskExterns.g_task_return_int(task, result);
		return task;
	}

	public static GTaskHandle ReturnNewError(this GTaskHandle task, GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GTaskExterns.g_task_return_new_error(task, domain, code, format, @__arglist);
		return task;
	}

	public static GTaskHandle ReturnNewErrorLiteral(this GTaskHandle task, GQuark domain, int code, string message)
	{
		GTaskExterns.g_task_return_new_error_literal(task, domain, code, message);
		return task;
	}

	public static GTaskHandle ReturnPointer(this GTaskHandle task, IntPtr result, GDestroyNotify result_destroy)
	{
		GTaskExterns.g_task_return_pointer(task, result, result_destroy);
		return task;
	}

	public static GTaskHandle ReturnPrefixedError(this GTaskHandle task, GErrorHandle error, string format, IntPtr @__arglist)
	{
		GTaskExterns.g_task_return_prefixed_error(task, error, format, @__arglist);
		return task;
	}

	public static GTaskHandle ReturnValue(this GTaskHandle task, GValueHandle result)
	{
		GTaskExterns.g_task_return_value(task, result);
		return task;
	}

	public static GTaskHandle RunInThread(this GTaskHandle task, GTaskThreadFunc task_func)
	{
		GTaskExterns.g_task_run_in_thread(task, task_func);
		return task;
	}

	public static GTaskHandle RunInThreadSync(this GTaskHandle task, GTaskThreadFunc task_func)
	{
		GTaskExterns.g_task_run_in_thread_sync(task, task_func);
		return task;
	}

	public static GTaskHandle SetCheckCancellable(this GTaskHandle task, bool check_cancellable)
	{
		GTaskExterns.g_task_set_check_cancellable(task, check_cancellable);
		return task;
	}

	public static GTaskHandle SetName(this GTaskHandle task, string name)
	{
		GTaskExterns.g_task_set_name(task, name);
		return task;
	}

	public static GTaskHandle SetPriority(this GTaskHandle task, int priority)
	{
		GTaskExterns.g_task_set_priority(task, priority);
		return task;
	}

	public static bool SetReturnOnCancel(this GTaskHandle task, bool return_on_cancel)
	{
		return GTaskExterns.g_task_set_return_on_cancel(task, return_on_cancel);
	}

	public static GTaskHandle SetSourceTag(this GTaskHandle task, IntPtr source_tag)
	{
		GTaskExterns.g_task_set_source_tag(task, source_tag);
		return task;
	}

	public static GTaskHandle SetStaticName(this GTaskHandle task, string name)
	{
		GTaskExterns.g_task_set_static_name(task, name);
		return task;
	}

	public static GTaskHandle SetTaskData(this GTaskHandle task, IntPtr task_data, GDestroyNotify task_data_destroy)
	{
		GTaskExterns.g_task_set_task_data(task, task_data, task_data_destroy);
		return task;
	}

}

internal class GTaskExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_attach_source(GTaskHandle task, GSourceHandle source, GSourceFunc callback);
	[DllImport(Libraries.Gio)]
	internal static extern GCancellableHandle g_task_get_cancellable(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_get_check_cancellable(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_get_completed(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern GMainContextHandle g_task_get_context(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern string g_task_get_name(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern int g_task_get_priority(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_get_return_on_cancel(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_task_get_source_object(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_task_get_source_tag(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_task_get_task_data(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_had_error(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_propagate_boolean(GTaskHandle task, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_task_propagate_int(GTaskHandle task, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_task_propagate_pointer(GTaskHandle task, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_propagate_value(GTaskHandle task, out GValue value, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_boolean(GTaskHandle task, bool result);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_error(GTaskHandle task, GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_return_error_if_cancelled(GTaskHandle task);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_int(GTaskHandle task, int result);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_new_error(GTaskHandle task, GQuark domain, int code, string format, IntPtr @__arglist);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_new_error_literal(GTaskHandle task, GQuark domain, int code, string message);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_pointer(GTaskHandle task, IntPtr result, GDestroyNotify result_destroy);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_prefixed_error(GTaskHandle task, GErrorHandle error, string format, IntPtr @__arglist);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_value(GTaskHandle task, GValueHandle result);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_run_in_thread(GTaskHandle task, GTaskThreadFunc task_func);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_run_in_thread_sync(GTaskHandle task, GTaskThreadFunc task_func);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_check_cancellable(GTaskHandle task, bool check_cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_name(GTaskHandle task, string name);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_priority(GTaskHandle task, int priority);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_set_return_on_cancel(GTaskHandle task, bool return_on_cancel);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_source_tag(GTaskHandle task, IntPtr source_tag);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_static_name(GTaskHandle task, string name);
	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_task_data(GTaskHandle task, IntPtr task_data, GDestroyNotify task_data_destroy);
	[DllImport(Libraries.Gio)]
	internal static extern GTaskHandle g_task_new(GObjectHandle source_object, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr callback_data);
}
