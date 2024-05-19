namespace MentorLake.Gtk4.GLib;

[Flags]
public enum GTraverseFlags
{
	G_TRAVERSE_LEAVES = 0,
	G_TRAVERSE_NON_LEAVES = 1,
	G_TRAVERSE_ALL = 2,
	G_TRAVERSE_MASK = 4,
	G_TRAVERSE_LEAFS = 8,
	G_TRAVERSE_NON_LEAFS = 16
}
