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

public class GFilenameCompleterHandle : GObjectHandle
{
	public static GFilenameCompleterHandle New()
	{
		return GFilenameCompleterExterns.g_filename_completer_new();
	}

}

public class GFilenameCompleterSignal
{
	public string Value { get; set; }
	public GFilenameCompleterSignal(string value) => Value = value;
}

public static class GFilenameCompleterSignals
{
	public static GFilenameCompleterSignal GotCompletionData = new("BindingTransform.MethodDeclaration");
}

public static class GFilenameCompleterHandleExtensions
{
	public static string GetCompletionSuffix(this GFilenameCompleterHandle completer, string initial_text)
	{
		return GFilenameCompleterExterns.g_filename_completer_get_completion_suffix(completer, initial_text);
	}

	public static string[] GetCompletions(this GFilenameCompleterHandle completer, string initial_text)
	{
		return GFilenameCompleterExterns.g_filename_completer_get_completions(completer, initial_text);
	}

	public static GFilenameCompleterHandle SetDirsOnly(this GFilenameCompleterHandle completer, bool dirs_only)
	{
		GFilenameCompleterExterns.g_filename_completer_set_dirs_only(completer, dirs_only);
		return completer;
	}

	public static GFilenameCompleterHandle Signal_GotCompletionData(this GFilenameCompleterHandle instance, GFilenameCompleterDelegates.GotCompletionData handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "got_completion_data", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GFilenameCompleterDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GotCompletionData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFilenameCompleterHandle>))] GFilenameCompleterHandle self, IntPtr user_data);
}

internal class GFilenameCompleterExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFilenameCompleterHandle g_filename_completer_new();

	[DllImport(Libraries.Gio)]
	internal static extern string g_filename_completer_get_completion_suffix(GFilenameCompleterHandle completer, string initial_text);

	[DllImport(Libraries.Gio)]
	internal static extern string[] g_filename_completer_get_completions(GFilenameCompleterHandle completer, string initial_text);

	[DllImport(Libraries.Gio)]
	internal static extern void g_filename_completer_set_dirs_only(GFilenameCompleterHandle completer, bool dirs_only);

}
