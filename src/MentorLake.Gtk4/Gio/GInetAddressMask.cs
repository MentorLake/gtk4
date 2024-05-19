namespace MentorLake.Gtk4.Gio;

public class GInetAddressMaskHandle : GObjectHandle, GInitableHandle
{
	public static GInetAddressMaskHandle New(GInetAddressHandle addr, uint length, out GErrorHandle error)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_new(addr, length, out error);
	}

	public static GInetAddressMaskHandle NewFromString(string mask_string, out GErrorHandle error)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_new_from_string(mask_string, out error);
	}

}

public static class GInetAddressMaskHandleExtensions
{
	public static bool Equal(this GInetAddressMaskHandle mask, GInetAddressMaskHandle mask2)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_equal(mask, mask2);
	}

	public static GInetAddressHandle GetAddress(this GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_get_address(mask);
	}

	public static GSocketFamily GetFamily(this GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_get_family(mask);
	}

	public static uint GetLength(this GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_get_length(mask);
	}

	public static bool Matches(this GInetAddressMaskHandle mask, GInetAddressHandle address)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_matches(mask, address);
	}

	public static string ToString(this GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskExterns.g_inet_address_mask_to_string(mask);
	}

}

internal class GInetAddressMaskExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressMaskHandle g_inet_address_mask_new(GInetAddressHandle addr, uint length, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressMaskHandle g_inet_address_mask_new_from_string(string mask_string, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_mask_equal(GInetAddressMaskHandle mask, GInetAddressMaskHandle mask2);

	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_mask_get_address(GInetAddressMaskHandle mask);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketFamily g_inet_address_mask_get_family(GInetAddressMaskHandle mask);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_inet_address_mask_get_length(GInetAddressMaskHandle mask);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_mask_matches(GInetAddressMaskHandle mask, GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern string g_inet_address_mask_to_string(GInetAddressMaskHandle mask);

}
