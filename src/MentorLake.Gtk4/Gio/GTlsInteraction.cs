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

public class GTlsInteractionHandle : GObjectHandle
{
}

public static class GTlsInteractionHandleExtensions
{
	public static GTlsInteractionResult AskPassword(this GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsInteractionExterns.g_tls_interaction_ask_password(interaction, password, cancellable, out error);
	}

	public static GTlsInteractionHandle AskPasswordAsync(this GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GTlsInteractionExterns.g_tls_interaction_ask_password_async(interaction, password, cancellable, callback, user_data);
		return interaction;
	}

	public static GTlsInteractionResult AskPasswordFinish(this GTlsInteractionHandle interaction, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GTlsInteractionExterns.g_tls_interaction_ask_password_finish(interaction, result, out error);
	}

	public static GTlsInteractionResult InvokeAskPassword(this GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsInteractionExterns.g_tls_interaction_invoke_ask_password(interaction, password, cancellable, out error);
	}

	public static GTlsInteractionResult InvokeRequestCertificate(this GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsInteractionExterns.g_tls_interaction_invoke_request_certificate(interaction, connection, flags, cancellable, out error);
	}

	public static GTlsInteractionResult RequestCertificate(this GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GTlsInteractionExterns.g_tls_interaction_request_certificate(interaction, connection, flags, cancellable, out error);
	}

	public static GTlsInteractionHandle RequestCertificateAsync(this GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GTlsInteractionExterns.g_tls_interaction_request_certificate_async(interaction, connection, flags, cancellable, callback, user_data);
		return interaction;
	}

	public static GTlsInteractionResult RequestCertificateFinish(this GTlsInteractionHandle interaction, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GTlsInteractionExterns.g_tls_interaction_request_certificate_finish(interaction, result, out error);
	}

}

internal class GTlsInteractionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionResult g_tls_interaction_ask_password(GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_interaction_ask_password_async(GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionResult g_tls_interaction_ask_password_finish(GTlsInteractionHandle interaction, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionResult g_tls_interaction_invoke_ask_password(GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionResult g_tls_interaction_invoke_request_certificate(GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionResult g_tls_interaction_request_certificate(GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_interaction_request_certificate_async(GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionResult g_tls_interaction_request_certificate_finish(GTlsInteractionHandle interaction, GAsyncResultHandle result, out GErrorHandle error);

}
