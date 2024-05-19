using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GSubprocessHandle : GObjectHandle, GInitableHandle
{
	public static GSubprocessHandle New(GSubprocessFlags flags, out GErrorHandle error, string argv0, IntPtr @__arglist)
	{
		return GSubprocessExterns.g_subprocess_new(flags, out error, argv0, @__arglist);
	}

	public static GSubprocessHandle Newv(string argv, GSubprocessFlags flags, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_newv(argv, flags, out error);
	}

}

public static class GSubprocessHandleExtensions
{
	public static bool Communicate(this GSubprocessHandle subprocess, GBytesHandle stdin_buf, GCancellableHandle cancellable, out GBytesHandle stdout_buf, out GBytesHandle stderr_buf, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_communicate(subprocess, stdin_buf, cancellable, out stdout_buf, out stderr_buf, out error);
	}

	public static GSubprocessHandle CommunicateAsync(this GSubprocessHandle subprocess, GBytesHandle stdin_buf, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSubprocessExterns.g_subprocess_communicate_async(subprocess, stdin_buf, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool CommunicateFinish(this GSubprocessHandle subprocess, GAsyncResultHandle result, out GBytesHandle stdout_buf, out GBytesHandle stderr_buf, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_communicate_finish(subprocess, result, out stdout_buf, out stderr_buf, out error);
	}

	public static bool CommunicateUtf8(this GSubprocessHandle subprocess, string stdin_buf, GCancellableHandle cancellable, out string stdout_buf, out string stderr_buf, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_communicate_utf8(subprocess, stdin_buf, cancellable, out stdout_buf, out stderr_buf, out error);
	}

	public static GSubprocessHandle CommunicateUtf8Async(this GSubprocessHandle subprocess, string stdin_buf, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSubprocessExterns.g_subprocess_communicate_utf8_async(subprocess, stdin_buf, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool CommunicateUtf8Finish(this GSubprocessHandle subprocess, GAsyncResultHandle result, out string stdout_buf, out string stderr_buf, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_communicate_utf8_finish(subprocess, result, out stdout_buf, out stderr_buf, out error);
	}

	public static GSubprocessHandle ForceExit(this GSubprocessHandle subprocess)
	{
		GSubprocessExterns.g_subprocess_force_exit(subprocess);
		return subprocess;
	}

	public static int GetExitStatus(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_exit_status(subprocess);
	}

	public static string GetIdentifier(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_identifier(subprocess);
	}

	public static bool GetIfExited(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_if_exited(subprocess);
	}

	public static bool GetIfSignaled(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_if_signaled(subprocess);
	}

	public static int GetStatus(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_status(subprocess);
	}

	public static GInputStreamHandle GetStderrPipe(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_stderr_pipe(subprocess);
	}

	public static GOutputStreamHandle GetStdinPipe(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_stdin_pipe(subprocess);
	}

	public static GInputStreamHandle GetStdoutPipe(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_stdout_pipe(subprocess);
	}

	public static bool GetSuccessful(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_successful(subprocess);
	}

	public static int GetTermSig(this GSubprocessHandle subprocess)
	{
		return GSubprocessExterns.g_subprocess_get_term_sig(subprocess);
	}

	public static GSubprocessHandle SendSignal(this GSubprocessHandle subprocess, int signal_num)
	{
		GSubprocessExterns.g_subprocess_send_signal(subprocess, signal_num);
		return subprocess;
	}

	public static bool Wait(this GSubprocessHandle subprocess, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_wait(subprocess, cancellable, out error);
	}

	public static GSubprocessHandle WaitAsync(this GSubprocessHandle subprocess, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSubprocessExterns.g_subprocess_wait_async(subprocess, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool WaitCheck(this GSubprocessHandle subprocess, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_wait_check(subprocess, cancellable, out error);
	}

	public static GSubprocessHandle WaitCheckAsync(this GSubprocessHandle subprocess, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSubprocessExterns.g_subprocess_wait_check_async(subprocess, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool WaitCheckFinish(this GSubprocessHandle subprocess, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_wait_check_finish(subprocess, result, out error);
	}

	public static bool WaitFinish(this GSubprocessHandle subprocess, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSubprocessExterns.g_subprocess_wait_finish(subprocess, result, out error);
	}

}

internal class GSubprocessExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessHandle g_subprocess_new(GSubprocessFlags flags, out GErrorHandle error, string argv0, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessHandle g_subprocess_newv(string argv, GSubprocessFlags flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_communicate(GSubprocessHandle subprocess, GBytesHandle stdin_buf, GCancellableHandle cancellable, out GBytesHandle stdout_buf, out GBytesHandle stderr_buf, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_communicate_async(GSubprocessHandle subprocess, GBytesHandle stdin_buf, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_communicate_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, out GBytesHandle stdout_buf, out GBytesHandle stderr_buf, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_communicate_utf8(GSubprocessHandle subprocess, string stdin_buf, GCancellableHandle cancellable, out string stdout_buf, out string stderr_buf, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_communicate_utf8_async(GSubprocessHandle subprocess, string stdin_buf, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_communicate_utf8_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, out string stdout_buf, out string stderr_buf, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_force_exit(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern int g_subprocess_get_exit_status(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern string g_subprocess_get_identifier(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_get_if_exited(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_get_if_signaled(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern int g_subprocess_get_status(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_subprocess_get_stderr_pipe(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern GOutputStreamHandle g_subprocess_get_stdin_pipe(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_subprocess_get_stdout_pipe(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_get_successful(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern int g_subprocess_get_term_sig(GSubprocessHandle subprocess);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_send_signal(GSubprocessHandle subprocess, int signal_num);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_wait(GSubprocessHandle subprocess, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_wait_async(GSubprocessHandle subprocess, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_wait_check(GSubprocessHandle subprocess, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_wait_check_async(GSubprocessHandle subprocess, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_wait_check_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_subprocess_wait_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, out GErrorHandle error);

}
