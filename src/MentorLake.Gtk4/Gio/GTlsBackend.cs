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

public class GTlsBackendHandle  : GObjectHandle
{
}

public static class GTlsBackendHandleExtensions
{
	public static GType GetCertificateType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_certificate_type(backend);
	}

	public static GType GetClientConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_client_connection_type(backend);
	}

	public static GTlsDatabaseHandle GetDefaultDatabase(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_default_database(backend);
	}

	public static GType GetDtlsClientConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_dtls_client_connection_type(backend);
	}

	public static GType GetDtlsServerConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_dtls_server_connection_type(backend);
	}

	public static GType GetFileDatabaseType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_file_database_type(backend);
	}

	public static GType GetServerConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_server_connection_type(backend);
	}

	public static GTlsBackendHandle SetDefaultDatabase(this GTlsBackendHandle backend, GTlsDatabaseHandle database)
	{
		GTlsBackendExterns.g_tls_backend_set_default_database(backend, database);
		return backend;
	}

	public static bool SupportsDtls(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_supports_dtls(backend);
	}

	public static bool SupportsTls(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_supports_tls(backend);
	}

}

internal class GTlsBackendExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_certificate_type(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_client_connection_type(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern GTlsDatabaseHandle g_tls_backend_get_default_database(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_dtls_client_connection_type(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_dtls_server_connection_type(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_file_database_type(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_server_connection_type(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_backend_set_default_database(GTlsBackendHandle backend, GTlsDatabaseHandle database);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_backend_supports_dtls(GTlsBackendHandle backend);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_backend_supports_tls(GTlsBackendHandle backend);
}
