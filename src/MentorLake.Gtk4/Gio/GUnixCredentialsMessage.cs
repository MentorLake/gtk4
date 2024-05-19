namespace MentorLake.Gtk4.Gio;

public class GUnixCredentialsMessageHandle : GSocketControlMessageHandle
{
	public static GUnixCredentialsMessageHandle New()
	{
		return GUnixCredentialsMessageExterns.g_unix_credentials_message_new();
	}

	public static GUnixCredentialsMessageHandle NewWithCredentials(GCredentialsHandle credentials)
	{
		return GUnixCredentialsMessageExterns.g_unix_credentials_message_new_with_credentials(credentials);
	}

	public static bool IsSupported()
	{
		return GUnixCredentialsMessageExterns.g_unix_credentials_message_is_supported();
	}

}

public static class GUnixCredentialsMessageHandleExtensions
{
	public static GCredentialsHandle GetCredentials(this GUnixCredentialsMessageHandle message)
	{
		return GUnixCredentialsMessageExterns.g_unix_credentials_message_get_credentials(message);
	}

}

internal class GUnixCredentialsMessageExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixCredentialsMessageHandle g_unix_credentials_message_new();

	[DllImport(Libraries.Gio)]
	internal static extern GUnixCredentialsMessageHandle g_unix_credentials_message_new_with_credentials(GCredentialsHandle credentials);

	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_unix_credentials_message_get_credentials(GUnixCredentialsMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_credentials_message_is_supported();

}
