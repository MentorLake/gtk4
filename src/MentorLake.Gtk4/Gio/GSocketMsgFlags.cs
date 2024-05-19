namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GSocketMsgFlags
{
	G_SOCKET_MSG_NONE = 0,
	G_SOCKET_MSG_OOB = 1,
	G_SOCKET_MSG_PEEK = 2,
	G_SOCKET_MSG_DONTROUTE = 4
}
