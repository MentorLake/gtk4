using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GHmacAdaptors
{
	public static GHmacHandle Copy(this GHmacHandle hmac)
	{
		return GHmacExterns.g_hmac_copy(hmac);
	}

	public static GHmacHandle Ref(this GHmacHandle hmac)
	{
		return GHmacExterns.g_hmac_ref(hmac);
	}

	public static GHmacHandle Unref(this GHmacHandle hmac)
	{
		GHmacExterns.g_hmac_unref(hmac);
		return hmac;
	}

	public static GHmacHandle Update(this GHmacHandle hmac, string data, nint length)
	{
		GHmacExterns.g_hmac_update(hmac, data, length);
		return hmac;
	}

	public static string GetString(this GHmacHandle hmac)
	{
		return GHmacExterns.g_hmac_get_string(hmac);
	}

	public static GHmacHandle GetDigest(this GHmacHandle hmac, byte[] buffer, ref nuint digest_len)
	{
		GHmacExterns.g_hmac_get_digest(hmac, buffer, ref digest_len);
		return hmac;
	}
}
