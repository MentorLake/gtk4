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

public class GTlsCertificateHandle : GObjectHandle
{
	public static GTlsCertificateHandle NewFromFile(string file, out GErrorHandle error)
	{
		return GTlsCertificateExterns.g_tls_certificate_new_from_file(file, out error);
	}

	public static GTlsCertificateHandle NewFromFileWithPassword(string file, string password, out GErrorHandle error)
	{
		return GTlsCertificateExterns.g_tls_certificate_new_from_file_with_password(file, password, out error);
	}

	public static GTlsCertificateHandle NewFromFiles(string cert_file, string key_file, out GErrorHandle error)
	{
		return GTlsCertificateExterns.g_tls_certificate_new_from_files(cert_file, key_file, out error);
	}

	public static GTlsCertificateHandle NewFromPem(string data, int length, out GErrorHandle error)
	{
		return GTlsCertificateExterns.g_tls_certificate_new_from_pem(data, length, out error);
	}

	public static GTlsCertificateHandle NewFromPkcs11Uris(string pkcs11_uri, string private_key_pkcs11_uri, out GErrorHandle error)
	{
		return GTlsCertificateExterns.g_tls_certificate_new_from_pkcs11_uris(pkcs11_uri, private_key_pkcs11_uri, out error);
	}

	public static GTlsCertificateHandle NewFromPkcs12(byte[] data, int length, string password, out GErrorHandle error)
	{
		return GTlsCertificateExterns.g_tls_certificate_new_from_pkcs12(data, length, password, out error);
	}

	public static GListHandle ListNewFromFile(string file, out GErrorHandle error)
	{
		return GTlsCertificateExterns.g_tls_certificate_list_new_from_file(file, out error);
	}

}

public static class GTlsCertificateHandleExtensions
{
	public static GPtrArray[] GetDnsNames(this GTlsCertificateHandle cert)
	{
		return GTlsCertificateExterns.g_tls_certificate_get_dns_names(cert);
	}

	public static GPtrArray[] GetIpAddresses(this GTlsCertificateHandle cert)
	{
		return GTlsCertificateExterns.g_tls_certificate_get_ip_addresses(cert);
	}

	public static GTlsCertificateHandle GetIssuer(this GTlsCertificateHandle cert)
	{
		return GTlsCertificateExterns.g_tls_certificate_get_issuer(cert);
	}

	public static string GetIssuerName(this GTlsCertificateHandle cert)
	{
		return GTlsCertificateExterns.g_tls_certificate_get_issuer_name(cert);
	}

	public static GDateTimeHandle GetNotValidAfter(this GTlsCertificateHandle cert)
	{
		return GTlsCertificateExterns.g_tls_certificate_get_not_valid_after(cert);
	}

	public static GDateTimeHandle GetNotValidBefore(this GTlsCertificateHandle cert)
	{
		return GTlsCertificateExterns.g_tls_certificate_get_not_valid_before(cert);
	}

	public static string GetSubjectName(this GTlsCertificateHandle cert)
	{
		return GTlsCertificateExterns.g_tls_certificate_get_subject_name(cert);
	}

	public static bool IsSame(this GTlsCertificateHandle cert_one, GTlsCertificateHandle cert_two)
	{
		return GTlsCertificateExterns.g_tls_certificate_is_same(cert_one, cert_two);
	}

	public static GTlsCertificateFlags Verify(this GTlsCertificateHandle cert, GSocketConnectableHandle identity, GTlsCertificateHandle trusted_ca)
	{
		return GTlsCertificateExterns.g_tls_certificate_verify(cert, identity, trusted_ca);
	}

}

internal class GTlsCertificateExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_certificate_new_from_file(string file, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_certificate_new_from_file_with_password(string file, string password, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_certificate_new_from_files(string cert_file, string key_file, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_certificate_new_from_pem(string data, int length, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_certificate_new_from_pkcs11_uris(string pkcs11_uri, string private_key_pkcs11_uri, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_certificate_new_from_pkcs12(byte[] data, int length, string password, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GPtrArray[] g_tls_certificate_get_dns_names(GTlsCertificateHandle cert);

	[DllImport(Libraries.Gio)]
	internal static extern GPtrArray[] g_tls_certificate_get_ip_addresses(GTlsCertificateHandle cert);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_certificate_get_issuer(GTlsCertificateHandle cert);

	[DllImport(Libraries.Gio)]
	internal static extern string g_tls_certificate_get_issuer_name(GTlsCertificateHandle cert);

	[DllImport(Libraries.Gio)]
	internal static extern GDateTimeHandle g_tls_certificate_get_not_valid_after(GTlsCertificateHandle cert);

	[DllImport(Libraries.Gio)]
	internal static extern GDateTimeHandle g_tls_certificate_get_not_valid_before(GTlsCertificateHandle cert);

	[DllImport(Libraries.Gio)]
	internal static extern string g_tls_certificate_get_subject_name(GTlsCertificateHandle cert);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_certificate_is_same(GTlsCertificateHandle cert_one, GTlsCertificateHandle cert_two);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_tls_certificate_verify(GTlsCertificateHandle cert, GSocketConnectableHandle identity, GTlsCertificateHandle trusted_ca);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_tls_certificate_list_new_from_file(string file, out GErrorHandle error);

}
