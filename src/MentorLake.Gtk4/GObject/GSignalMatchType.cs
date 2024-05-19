namespace MentorLake.Gtk4.GObject;

[Flags]
public enum GSignalMatchType
{
	G_SIGNAL_MATCH_ID = 0,
	G_SIGNAL_MATCH_DETAIL = 1,
	G_SIGNAL_MATCH_CLOSURE = 2,
	G_SIGNAL_MATCH_FUNC = 4,
	G_SIGNAL_MATCH_DATA = 8,
	G_SIGNAL_MATCH_UNBLOCKED = 16
}
