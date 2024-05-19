namespace MentorLake.Gtk4.GLib;

public class GChecksumHandle : BaseSafeHandle
{
	public static GChecksumHandle New(GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_new(checksum_type);
	}

}

internal class GChecksumExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GChecksumHandle g_checksum_new(GChecksumType checksum_type);

}

public struct GChecksum
{
}
