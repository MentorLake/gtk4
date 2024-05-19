namespace MentorLake.Gtk4.Gtk4;

public class GtkPadActionEntryHandle : BaseSafeHandle
{
}

internal class GtkPadActionEntryExterns
{
}

public struct GtkPadActionEntry
{
	public GtkPadActionType type;
	public int index;
	public int mode;
	public string label;
	public string action_name;
}
