namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GDBusServerFlags
{
	G_DBUS_SERVER_FLAGS_NONE = 0,
	G_DBUS_SERVER_FLAGS_RUN_IN_THREAD = 1,
	G_DBUS_SERVER_FLAGS_AUTHENTICATION_ALLOW_ANONYMOUS = 2,
	G_DBUS_SERVER_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER = 4
}
