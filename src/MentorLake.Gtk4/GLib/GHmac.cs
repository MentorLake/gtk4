namespace MentorLake.Gtk4.GLib;

public class GHmacHandle : BaseSafeHandle
{
	public static GHmacHandle New(GChecksumType digest_type, string key, UIntPtr key_len)
	{
		return GHmacExterns.g_hmac_new(digest_type, key, key_len);
	}

}

internal class GHmacExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GHmacHandle g_hmac_new(GChecksumType digest_type, string key, UIntPtr key_len);

}

public struct GHmac
{
}
