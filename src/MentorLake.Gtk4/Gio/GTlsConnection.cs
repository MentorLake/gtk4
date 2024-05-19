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

public class GTlsConnectionHandle : GIOStreamHandle
{
}

public static class GTlsConnectionSignalExtensions
{

	public static IObservable<GTlsConnectionSignalStructs.AcceptCertificateSignal> Signal_AcceptCertificate(this GTlsConnectionHandle instance)
	{
		return Observable.Create((IObserver<GTlsConnectionSignalStructs.AcceptCertificateSignal> obs) =>
		{
			GTlsConnectionSignalDelegates.AcceptCertificate handler = (GTlsConnectionHandle self, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors, IntPtr user_data) =>
			{
				

				var signalStruct = new GTlsConnectionSignalStructs.AcceptCertificateSignal()
				{
					Self = self, PeerCert = peer_cert, Errors = errors, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accept_certificate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GTlsConnectionSignalStructs
{

public struct AcceptCertificateSignal
{
	public GTlsConnectionHandle Self;
	public GTlsCertificateHandle PeerCert;
	public GTlsCertificateFlags Errors;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GTlsConnectionSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool AcceptCertificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GTlsConnectionHandle>))] GTlsConnectionHandle self, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors, IntPtr user_data);
}


public static class GTlsConnectionHandleExtensions
{
	public static bool EmitAcceptCertificate(this GTlsConnectionHandle conn, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors)
	{
		return GTlsConnectionExterns.g_tls_connection_emit_accept_certificate(conn, peer_cert, errors);
	}

	public static GTlsCertificateHandle GetCertificate(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_certificate(conn);
	}

	public static bool GetChannelBindingData(this GTlsConnectionHandle conn, GTlsChannelBindingType type, out GByteArray data, out GErrorHandle error)
	{
		return GTlsConnectionExterns.g_tls_connection_get_channel_binding_data(conn, type, out data, out error);
	}

	public static string GetCiphersuiteName(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_ciphersuite_name(conn);
	}

	public static GTlsDatabaseHandle GetDatabase(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_database(conn);
	}

	public static GTlsInteractionHandle GetInteraction(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_interaction(conn);
	}

	public static string GetNegotiatedProtocol(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_negotiated_protocol(conn);
	}

	public static GTlsCertificateHandle GetPeerCertificate(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_peer_certificate(conn);
	}

	public static GTlsCertificateFlags GetPeerCertificateErrors(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_peer_certificate_errors(conn);
	}

	public static GTlsProtocolVersion GetProtocolVersion(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_protocol_version(conn);
	}

	public static GTlsRehandshakeMode GetRehandshakeMode(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_rehandshake_mode(conn);
	}

	public static bool GetRequireCloseNotify(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_require_close_notify(conn);
	}

	public static bool GetUseSystemCertdb(this GTlsConnectionHandle conn)
	{
		return GTlsConnectionExterns.g_tls_connection_get_use_system_certdb(conn);
	}

	public static bool Handshake(this GTlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsConnectionExterns.g_tls_connection_handshake(conn, cancellable, out error);
	}

	public static GTlsConnectionHandle HandshakeAsync(this GTlsConnectionHandle conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GTlsConnectionExterns.g_tls_connection_handshake_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

	public static bool HandshakeFinish(this GTlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GTlsConnectionExterns.g_tls_connection_handshake_finish(conn, result, out error);
	}

	public static GTlsConnectionHandle SetAdvertisedProtocols(this GTlsConnectionHandle conn, string protocols)
	{
		GTlsConnectionExterns.g_tls_connection_set_advertised_protocols(conn, protocols);
		return conn;
	}

	public static GTlsConnectionHandle SetCertificate(this GTlsConnectionHandle conn, GTlsCertificateHandle certificate)
	{
		GTlsConnectionExterns.g_tls_connection_set_certificate(conn, certificate);
		return conn;
	}

	public static GTlsConnectionHandle SetDatabase(this GTlsConnectionHandle conn, GTlsDatabaseHandle database)
	{
		GTlsConnectionExterns.g_tls_connection_set_database(conn, database);
		return conn;
	}

	public static GTlsConnectionHandle SetInteraction(this GTlsConnectionHandle conn, GTlsInteractionHandle interaction)
	{
		GTlsConnectionExterns.g_tls_connection_set_interaction(conn, interaction);
		return conn;
	}

	public static GTlsConnectionHandle SetRehandshakeMode(this GTlsConnectionHandle conn, GTlsRehandshakeMode mode)
	{
		GTlsConnectionExterns.g_tls_connection_set_rehandshake_mode(conn, mode);
		return conn;
	}

	public static GTlsConnectionHandle SetRequireCloseNotify(this GTlsConnectionHandle conn, bool require_close_notify)
	{
		GTlsConnectionExterns.g_tls_connection_set_require_close_notify(conn, require_close_notify);
		return conn;
	}

	public static GTlsConnectionHandle SetUseSystemCertdb(this GTlsConnectionHandle conn, bool use_system_certdb)
	{
		GTlsConnectionExterns.g_tls_connection_set_use_system_certdb(conn, use_system_certdb);
		return conn;
	}

}

internal class GTlsConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_connection_emit_accept_certificate(GTlsConnectionHandle conn, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_connection_get_certificate(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_connection_get_channel_binding_data(GTlsConnectionHandle conn, GTlsChannelBindingType type, out GByteArray data, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_tls_connection_get_ciphersuite_name(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsDatabaseHandle g_tls_connection_get_database(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionHandle g_tls_connection_get_interaction(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern string g_tls_connection_get_negotiated_protocol(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_connection_get_peer_certificate(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_tls_connection_get_peer_certificate_errors(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsProtocolVersion g_tls_connection_get_protocol_version(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsRehandshakeMode g_tls_connection_get_rehandshake_mode(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_connection_get_require_close_notify(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_connection_get_use_system_certdb(GTlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_connection_handshake(GTlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_handshake_async(GTlsConnectionHandle conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_connection_handshake_finish(GTlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_set_advertised_protocols(GTlsConnectionHandle conn, string protocols);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_set_certificate(GTlsConnectionHandle conn, GTlsCertificateHandle certificate);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_set_database(GTlsConnectionHandle conn, GTlsDatabaseHandle database);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_set_interaction(GTlsConnectionHandle conn, GTlsInteractionHandle interaction);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_set_rehandshake_mode(GTlsConnectionHandle conn, GTlsRehandshakeMode mode);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_set_require_close_notify(GTlsConnectionHandle conn, bool require_close_notify);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_connection_set_use_system_certdb(GTlsConnectionHandle conn, bool use_system_certdb);

}
