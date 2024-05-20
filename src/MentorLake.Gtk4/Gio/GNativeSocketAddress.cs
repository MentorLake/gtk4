namespace MentorLake.Gtk4.Gio;

public class GNativeSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
	public static GNativeSocketAddressHandle New(IntPtr native, UIntPtr len)
	{
		return GNativeSocketAddressExterns.g_native_socket_address_new(native, len);
	}

}

public static class GNativeSocketAddressHandleExtensions
{
}

internal class GNativeSocketAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GNativeSocketAddressHandle g_native_socket_address_new(IntPtr native, UIntPtr len);

}
