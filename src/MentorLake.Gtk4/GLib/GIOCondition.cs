namespace MentorLake.Gtk4.GLib;

[Flags]
public enum GIOCondition
{
	G_IO_IN = 0,
	G_IO_OUT = 1,
	G_IO_PRI = 2,
	G_IO_ERR = 4,
	G_IO_HUP = 8,
	G_IO_NVAL = 16
}
