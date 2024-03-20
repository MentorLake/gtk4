using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GChecksumAdaptors
{
	public static GChecksumHandle Reset(this GChecksumHandle checksum)
	{
		GChecksumExterns.g_checksum_reset(checksum);
		return checksum;
	}

	public static GChecksumHandle Copy(this GChecksumHandle checksum)
	{
		return GChecksumExterns.g_checksum_copy(checksum);
	}

	public static GChecksumHandle Free(this GChecksumHandle checksum)
	{
		GChecksumExterns.g_checksum_free(checksum);
		return checksum;
	}

	public static GChecksumHandle Update(this GChecksumHandle checksum, string data, nint length)
	{
		GChecksumExterns.g_checksum_update(checksum, data, length);
		return checksum;
	}

	public static string GetString(this GChecksumHandle checksum)
	{
		return GChecksumExterns.g_checksum_get_string(checksum);
	}

	public static GChecksumHandle GetDigest(this GChecksumHandle checksum, byte[] buffer, ref nuint digest_len)
	{
		GChecksumExterns.g_checksum_get_digest(checksum, buffer, ref digest_len);
		return checksum;
	}
}
