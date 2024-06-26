namespace MentorLake.Gtk4.Gtk4;

[Flags]
public enum GtkEventControllerScrollFlags
{
	GTK_EVENT_CONTROLLER_SCROLL_NONE = 0,
	GTK_EVENT_CONTROLLER_SCROLL_VERTICAL = 1,
	GTK_EVENT_CONTROLLER_SCROLL_HORIZONTAL = 2,
	GTK_EVENT_CONTROLLER_SCROLL_DISCRETE = 4,
	GTK_EVENT_CONTROLLER_SCROLL_KINETIC = 8,
	GTK_EVENT_CONTROLLER_SCROLL_BOTH_AXES = 16
}
