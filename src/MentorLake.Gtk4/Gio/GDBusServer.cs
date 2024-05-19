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

public class GDBusServerHandle : GObjectHandle, GInitableHandle
{
	public static GDBusServerHandle GDbusServerNewSync(string address, GDBusServerFlags flags, string guid, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusServerExterns.g_dbus_server_new_sync(address, flags, guid, observer, cancellable, out error);
	}

}

public static class GDBusServerSignalExtensions
{

	public static IObservable<GDBusServerSignalStructs.NewConnectionSignal> Signal_NewConnection(this GDBusServerHandle instance)
	{
		return Observable.Create((IObserver<GDBusServerSignalStructs.NewConnectionSignal> obs) =>
		{
			GDBusServerSignalDelegates.NewConnection handler = (GDBusServerHandle self, GDBusConnectionHandle connection, IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusServerSignalStructs.NewConnectionSignal()
				{
					Self = self, Connection = connection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "new_connection", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GDBusServerSignalStructs
{

public struct NewConnectionSignal
{
	public GDBusServerHandle Self;
	public GDBusConnectionHandle Connection;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusServerSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool NewConnection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusServerHandle>))] GDBusServerHandle self, GDBusConnectionHandle connection, IntPtr user_data);
}


public static class GDBusServerHandleExtensions
{
	public static string GDbusServerGetClientAddress(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_get_client_address(server);
	}

	public static GDBusServerFlags GDbusServerGetFlags(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_get_flags(server);
	}

	public static string GDbusServerGetGuid(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_get_guid(server);
	}

	public static bool GDbusServerIsActive(this GDBusServerHandle server)
	{
		return GDBusServerExterns.g_dbus_server_is_active(server);
	}

	public static GDBusServerHandle GDbusServerStart(this GDBusServerHandle server)
	{
		GDBusServerExterns.g_dbus_server_start(server);
		return server;
	}

	public static GDBusServerHandle GDbusServerStop(this GDBusServerHandle server)
	{
		GDBusServerExterns.g_dbus_server_stop(server);
		return server;
	}

}

internal class GDBusServerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusServerHandle g_dbus_server_new_sync(string address, GDBusServerFlags flags, string guid, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_server_get_client_address(GDBusServerHandle server);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusServerFlags g_dbus_server_get_flags(GDBusServerHandle server);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_server_get_guid(GDBusServerHandle server);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_server_is_active(GDBusServerHandle server);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_server_start(GDBusServerHandle server);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_server_stop(GDBusServerHandle server);

}
