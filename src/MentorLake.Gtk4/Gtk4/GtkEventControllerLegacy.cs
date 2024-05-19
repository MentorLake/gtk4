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

namespace MentorLake.Gtk4.Gtk4;

public class GtkEventControllerLegacyHandle : GtkEventControllerHandle
{
	public static GtkEventControllerLegacyHandle New()
	{
		return GtkEventControllerLegacyExterns.gtk_event_controller_legacy_new();
	}

}

public static class GtkEventControllerLegacySignalExtensions
{

	public static IObservable<GtkEventControllerLegacySignalStructs.EventSignal> Signal_Event(this GtkEventControllerLegacyHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerLegacySignalStructs.EventSignal> obs) =>
		{
			GtkEventControllerLegacySignalDelegates.Event handler = (GtkEventControllerLegacyHandle self, GdkEventHandle @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerLegacySignalStructs.EventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEventControllerLegacySignalStructs
{

public struct EventSignal
{
	public GtkEventControllerLegacyHandle Self;
	public GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkEventControllerLegacySignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerLegacyHandle>))] GtkEventControllerLegacyHandle self, GdkEventHandle @event, IntPtr user_data);
}


public static class GtkEventControllerLegacyHandleExtensions
{
}

internal class GtkEventControllerLegacyExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerLegacyHandle gtk_event_controller_legacy_new();

}
