namespace MentorLake.Gtk4.Gtk4;

public class GtkPasswordEntryHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkEditableHandle
{
	public static GtkPasswordEntryHandle New()
	{
		return GtkPasswordEntryExterns.gtk_password_entry_new();
	}

}

public static class GtkPasswordEntrySignalExtensions
{

	public static IObservable<GtkPasswordEntrySignalStructs.ActivateSignal> Signal_Activate(this GtkPasswordEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkPasswordEntrySignalStructs.ActivateSignal> obs) =>
		{
			GtkPasswordEntrySignalDelegates.activate handler = (GtkPasswordEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPasswordEntrySignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPasswordEntrySignalStructs
{

public struct ActivateSignal
{
	public GtkPasswordEntryHandle Self;
	public IntPtr UserData;
}
}

public static class GtkPasswordEntrySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPasswordEntryHandle>))] GtkPasswordEntryHandle self, IntPtr user_data);

}


public static class GtkPasswordEntryHandleExtensions
{
	public static GMenuModelHandle GetExtraMenu(this GtkPasswordEntryHandle entry)
	{
		return GtkPasswordEntryExterns.gtk_password_entry_get_extra_menu(entry);
	}

	public static bool GetShowPeekIcon(this GtkPasswordEntryHandle entry)
	{
		return GtkPasswordEntryExterns.gtk_password_entry_get_show_peek_icon(entry);
	}

	public static GtkPasswordEntryHandle SetExtraMenu(this GtkPasswordEntryHandle entry, GMenuModelHandle model)
	{
		GtkPasswordEntryExterns.gtk_password_entry_set_extra_menu(entry, model);
		return entry;
	}

	public static GtkPasswordEntryHandle SetShowPeekIcon(this GtkPasswordEntryHandle entry, bool show_peek_icon)
	{
		GtkPasswordEntryExterns.gtk_password_entry_set_show_peek_icon(entry, show_peek_icon);
		return entry;
	}

}

internal class GtkPasswordEntryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPasswordEntryHandle gtk_password_entry_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_password_entry_get_extra_menu(GtkPasswordEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_password_entry_get_show_peek_icon(GtkPasswordEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_password_entry_set_extra_menu(GtkPasswordEntryHandle entry, GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_password_entry_set_show_peek_icon(GtkPasswordEntryHandle entry, bool show_peek_icon);

}
