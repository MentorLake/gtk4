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

public class GTlsDatabaseHandle : GObjectHandle
{
}

public static class GTlsDatabaseHandleExtensions
{
	public static string CreateCertificateHandle(this GTlsDatabaseHandle self, GTlsCertificateHandle certificate)
	{
		return GTlsDatabaseExterns.g_tls_database_create_certificate_handle(self, certificate);
	}

	public static GTlsCertificateHandle LookupCertificateForHandle(this GTlsDatabaseHandle self, string handle, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_lookup_certificate_for_handle(self, handle, interaction, flags, cancellable, out error);
	}

	public static GTlsDatabaseHandle LookupCertificateForHandleAsync(this GTlsDatabaseHandle self, string handle, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GTlsDatabaseExterns.g_tls_database_lookup_certificate_for_handle_async(self, handle, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static GTlsCertificateHandle LookupCertificateForHandleFinish(this GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_lookup_certificate_for_handle_finish(self, result, out error);
	}

	public static GTlsCertificateHandle LookupCertificateIssuer(this GTlsDatabaseHandle self, GTlsCertificateHandle certificate, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_lookup_certificate_issuer(self, certificate, interaction, flags, cancellable, out error);
	}

	public static GTlsDatabaseHandle LookupCertificateIssuerAsync(this GTlsDatabaseHandle self, GTlsCertificateHandle certificate, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GTlsDatabaseExterns.g_tls_database_lookup_certificate_issuer_async(self, certificate, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static GTlsCertificateHandle LookupCertificateIssuerFinish(this GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_lookup_certificate_issuer_finish(self, result, out error);
	}

	public static GListHandle LookupCertificatesIssuedBy(this GTlsDatabaseHandle self, GByteArray[] issuer_raw_dn, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_lookup_certificates_issued_by(self, issuer_raw_dn, interaction, flags, cancellable, out error);
	}

	public static GTlsDatabaseHandle LookupCertificatesIssuedByAsync(this GTlsDatabaseHandle self, GByteArray[] issuer_raw_dn, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GTlsDatabaseExterns.g_tls_database_lookup_certificates_issued_by_async(self, issuer_raw_dn, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static GListHandle LookupCertificatesIssuedByFinish(this GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_lookup_certificates_issued_by_finish(self, result, out error);
	}

	public static GTlsCertificateFlags VerifyChain(this GTlsDatabaseHandle self, GTlsCertificateHandle chain, string purpose, GSocketConnectableHandle identity, GTlsInteractionHandle interaction, GTlsDatabaseVerifyFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_verify_chain(self, chain, purpose, identity, interaction, flags, cancellable, out error);
	}

	public static GTlsDatabaseHandle VerifyChainAsync(this GTlsDatabaseHandle self, GTlsCertificateHandle chain, string purpose, GSocketConnectableHandle identity, GTlsInteractionHandle interaction, GTlsDatabaseVerifyFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GTlsDatabaseExterns.g_tls_database_verify_chain_async(self, chain, purpose, identity, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static GTlsCertificateFlags VerifyChainFinish(this GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GTlsDatabaseExterns.g_tls_database_verify_chain_finish(self, result, out error);
	}

}

internal class GTlsDatabaseExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_tls_database_create_certificate_handle(GTlsDatabaseHandle self, GTlsCertificateHandle certificate);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle(GTlsDatabaseHandle self, string handle, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_database_lookup_certificate_for_handle_async(GTlsDatabaseHandle self, string handle, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_database_lookup_certificate_issuer(GTlsDatabaseHandle self, GTlsCertificateHandle certificate, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_database_lookup_certificate_issuer_async(GTlsDatabaseHandle self, GTlsCertificateHandle certificate, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_tls_database_lookup_certificate_issuer_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_tls_database_lookup_certificates_issued_by(GTlsDatabaseHandle self, GByteArray[] issuer_raw_dn, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_database_lookup_certificates_issued_by_async(GTlsDatabaseHandle self, GByteArray[] issuer_raw_dn, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_tls_database_lookup_certificates_issued_by_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_tls_database_verify_chain(GTlsDatabaseHandle self, GTlsCertificateHandle chain, string purpose, GSocketConnectableHandle identity, GTlsInteractionHandle interaction, GTlsDatabaseVerifyFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_database_verify_chain_async(GTlsDatabaseHandle self, GTlsCertificateHandle chain, string purpose, GSocketConnectableHandle identity, GTlsInteractionHandle interaction, GTlsDatabaseVerifyFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_tls_database_verify_chain_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);

}
