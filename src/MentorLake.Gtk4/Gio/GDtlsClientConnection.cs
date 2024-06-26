namespace MentorLake.Gtk4.Gio;

public interface GDtlsClientConnectionHandle
{
}

internal class GDtlsClientConnectionHandleImpl : BaseSafeHandle, GDtlsClientConnectionHandle
{
}

public static class GDtlsClientConnectionHandleExtensions
{
	public static GListHandle GetAcceptedCas(this GDtlsClientConnectionHandle conn)
	{
		return GDtlsClientConnectionExterns.g_dtls_client_connection_get_accepted_cas(conn);
	}

	public static GSocketConnectableHandle GetServerIdentity(this GDtlsClientConnectionHandle conn)
	{
		return GDtlsClientConnectionExterns.g_dtls_client_connection_get_server_identity(conn);
	}

	public static GTlsCertificateFlags GetValidationFlags(this GDtlsClientConnectionHandle conn)
	{
		return GDtlsClientConnectionExterns.g_dtls_client_connection_get_validation_flags(conn);
	}

	public static GDtlsClientConnectionHandle SetServerIdentity(this GDtlsClientConnectionHandle conn, GSocketConnectableHandle identity)
	{
		GDtlsClientConnectionExterns.g_dtls_client_connection_set_server_identity(conn, identity);
		return conn;
	}

	public static GDtlsClientConnectionHandle SetValidationFlags(this GDtlsClientConnectionHandle conn, GTlsCertificateFlags flags)
	{
		GDtlsClientConnectionExterns.g_dtls_client_connection_set_validation_flags(conn, flags);
		return conn;
	}

}

internal class GDtlsClientConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_dtls_client_connection_get_accepted_cas(GDtlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectableHandle g_dtls_client_connection_get_server_identity(GDtlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_dtls_client_connection_get_validation_flags(GDtlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_client_connection_set_server_identity(GDtlsClientConnectionHandle conn, GSocketConnectableHandle identity);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_client_connection_set_validation_flags(GDtlsClientConnectionHandle conn, GTlsCertificateFlags flags);

}
