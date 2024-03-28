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

public class GResolverHandle : GObjectHandle
{
}

public class GResolverSignal
{
	public string Value { get; set; }
	public GResolverSignal(string value) => Value = value;
}

public static class GResolverSignals
{
	public static GResolverSignal Reload = new("reload");
}

public static class GResolverHandleExtensions
{
	public static int GetTimeout(this GResolverHandle resolver)
	{
		return GResolverExterns.g_resolver_get_timeout(resolver);
	}

	public static string LookupByAddress(this GResolverHandle resolver, GInetAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_by_address(resolver, address, cancellable, out error);
	}

	public static GResolverHandle LookupByAddressAsync(this GResolverHandle resolver, GInetAddressHandle address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GResolverExterns.g_resolver_lookup_by_address_async(resolver, address, cancellable, callback, user_data);
		return resolver;
	}

	public static string LookupByAddressFinish(this GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_by_address_finish(resolver, result, out error);
	}

	public static GListHandle LookupByName(this GResolverHandle resolver, string hostname, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_by_name(resolver, hostname, cancellable, out error);
	}

	public static GResolverHandle LookupByNameAsync(this GResolverHandle resolver, string hostname, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GResolverExterns.g_resolver_lookup_by_name_async(resolver, hostname, cancellable, callback, user_data);
		return resolver;
	}

	public static GListHandle LookupByNameFinish(this GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_by_name_finish(resolver, result, out error);
	}

	public static GListHandle LookupByNameWithFlags(this GResolverHandle resolver, string hostname, GResolverNameLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_by_name_with_flags(resolver, hostname, flags, cancellable, out error);
	}

	public static GResolverHandle LookupByNameWithFlagsAsync(this GResolverHandle resolver, string hostname, GResolverNameLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GResolverExterns.g_resolver_lookup_by_name_with_flags_async(resolver, hostname, flags, cancellable, callback, user_data);
		return resolver;
	}

	public static GListHandle LookupByNameWithFlagsFinish(this GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_by_name_with_flags_finish(resolver, result, out error);
	}

	public static GListHandle LookupRecords(this GResolverHandle resolver, string rrname, GResolverRecordType record_type, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_records(resolver, rrname, record_type, cancellable, out error);
	}

	public static GResolverHandle LookupRecordsAsync(this GResolverHandle resolver, string rrname, GResolverRecordType record_type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GResolverExterns.g_resolver_lookup_records_async(resolver, rrname, record_type, cancellable, callback, user_data);
		return resolver;
	}

	public static GListHandle LookupRecordsFinish(this GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_records_finish(resolver, result, out error);
	}

	public static GListHandle LookupService(this GResolverHandle resolver, string service, string protocol, string domain, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_service(resolver, service, protocol, domain, cancellable, out error);
	}

	public static GResolverHandle LookupServiceAsync(this GResolverHandle resolver, string service, string protocol, string domain, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GResolverExterns.g_resolver_lookup_service_async(resolver, service, protocol, domain, cancellable, callback, user_data);
		return resolver;
	}

	public static GListHandle LookupServiceFinish(this GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GResolverExterns.g_resolver_lookup_service_finish(resolver, result, out error);
	}

	public static GResolverHandle SetDefault(this GResolverHandle resolver)
	{
		GResolverExterns.g_resolver_set_default(resolver);
		return resolver;
	}

	public static GResolverHandle SetTimeout(this GResolverHandle resolver, int timeout_ms)
	{
		GResolverExterns.g_resolver_set_timeout(resolver, timeout_ms);
		return resolver;
	}

	public static GResolverHandle FreeAddresses(this GResolverHandle @handle, GListHandle addresses)
	{
		GResolverExterns.g_resolver_free_addresses(addresses);
		return @handle;
	}

	public static GResolverHandle FreeTargets(this GResolverHandle @handle, GListHandle targets)
	{
		GResolverExterns.g_resolver_free_targets(targets);
		return @handle;
	}

	public static GResolverHandle GetDefault()
	{
		return GResolverExterns.g_resolver_get_default();
	}

	public static GResolverHandle Connect(this GResolverHandle instance, GResolverSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GResolverExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern int g_resolver_get_timeout(GResolverHandle resolver);
	[DllImport(Libraries.Gio)]
	internal static extern string g_resolver_lookup_by_address(GResolverHandle resolver, GInetAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_lookup_by_address_async(GResolverHandle resolver, GInetAddressHandle address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern string g_resolver_lookup_by_address_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_by_name(GResolverHandle resolver, string hostname, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_lookup_by_name_async(GResolverHandle resolver, string hostname, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_by_name_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_by_name_with_flags(GResolverHandle resolver, string hostname, GResolverNameLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_lookup_by_name_with_flags_async(GResolverHandle resolver, string hostname, GResolverNameLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_by_name_with_flags_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_records(GResolverHandle resolver, string rrname, GResolverRecordType record_type, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_lookup_records_async(GResolverHandle resolver, string rrname, GResolverRecordType record_type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_records_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_service(GResolverHandle resolver, string service, string protocol, string domain, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_lookup_service_async(GResolverHandle resolver, string service, string protocol, string domain, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_resolver_lookup_service_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_set_default(GResolverHandle resolver);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_set_timeout(GResolverHandle resolver, int timeout_ms);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_free_addresses(GListHandle addresses);
	[DllImport(Libraries.Gio)]
	internal static extern void g_resolver_free_targets(GListHandle targets);
	[DllImport(Libraries.Gio)]
	internal static extern GResolverHandle g_resolver_get_default();
}
