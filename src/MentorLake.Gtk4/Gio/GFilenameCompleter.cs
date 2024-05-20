namespace MentorLake.Gtk4.Gio;

public class GFilenameCompleterHandle : GObjectHandle
{
	public static GFilenameCompleterHandle New()
	{
		return GFilenameCompleterExterns.g_filename_completer_new();
	}

}

public static class GFilenameCompleterSignalExtensions
{

	public static IObservable<GFilenameCompleterSignalStructs.GotCompletionDataSignal> Signal_GotCompletionData(this GFilenameCompleterHandle instance)
	{
		return Observable.Create((IObserver<GFilenameCompleterSignalStructs.GotCompletionDataSignal> obs) =>
		{
			GFilenameCompleterSignalDelegates.got_completion_data handler = (GFilenameCompleterHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GFilenameCompleterSignalStructs.GotCompletionDataSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "got_completion_data", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GFilenameCompleterSignalStructs
{

public struct GotCompletionDataSignal
{
	public GFilenameCompleterHandle Self;
	public IntPtr UserData;
}
}

public static class GFilenameCompleterSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_completion_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFilenameCompleterHandle>))] GFilenameCompleterHandle self, IntPtr user_data);

}


public static class GFilenameCompleterHandleExtensions
{
	public static string GetCompletionSuffix(this GFilenameCompleterHandle completer, string initial_text)
	{
		return GFilenameCompleterExterns.g_filename_completer_get_completion_suffix(completer, initial_text);
	}

	public static IntPtr GetCompletions(this GFilenameCompleterHandle completer, string initial_text)
	{
		return GFilenameCompleterExterns.g_filename_completer_get_completions(completer, initial_text);
	}

	public static GFilenameCompleterHandle SetDirsOnly(this GFilenameCompleterHandle completer, bool dirs_only)
	{
		GFilenameCompleterExterns.g_filename_completer_set_dirs_only(completer, dirs_only);
		return completer;
	}

}

internal class GFilenameCompleterExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFilenameCompleterHandle g_filename_completer_new();

	[DllImport(Libraries.Gio)]
	internal static extern string g_filename_completer_get_completion_suffix(GFilenameCompleterHandle completer, string initial_text);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_filename_completer_get_completions(GFilenameCompleterHandle completer, string initial_text);

	[DllImport(Libraries.Gio)]
	internal static extern void g_filename_completer_set_dirs_only(GFilenameCompleterHandle completer, bool dirs_only);

}
