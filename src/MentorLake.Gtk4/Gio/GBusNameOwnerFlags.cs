namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GBusNameOwnerFlags
{
	G_BUS_NAME_OWNER_FLAGS_NONE = 0,
	G_BUS_NAME_OWNER_FLAGS_ALLOW_REPLACEMENT = 1,
	G_BUS_NAME_OWNER_FLAGS_REPLACE = 2,
	G_BUS_NAME_OWNER_FLAGS_DO_NOT_QUEUE = 4
}
