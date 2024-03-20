using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRevealerAdaptors
{
	public static int GetRevealChild(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_reveal_child(revealer);
	}

	public static GtkRevealerHandle SetRevealChild(this GtkRevealerHandle revealer, int reveal_child)
	{
		GtkRevealerExterns.gtk_revealer_set_reveal_child(revealer, reveal_child);
		return revealer;
	}

	public static int GetChildRevealed(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_child_revealed(revealer);
	}

	public static uint GetTransitionDuration(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_transition_duration(revealer);
	}

	public static GtkRevealerHandle SetTransitionDuration(this GtkRevealerHandle revealer, uint duration)
	{
		GtkRevealerExterns.gtk_revealer_set_transition_duration(revealer, duration);
		return revealer;
	}

	public static GtkRevealerHandle SetTransitionType(this GtkRevealerHandle revealer, GtkRevealerTransitionType transition)
	{
		GtkRevealerExterns.gtk_revealer_set_transition_type(revealer, transition);
		return revealer;
	}

	public static GtkRevealerTransitionType GetTransitionType(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_transition_type(revealer);
	}

	public static GtkRevealerHandle SetChild(this GtkRevealerHandle revealer, GtkWidgetHandle child)
	{
		GtkRevealerExterns.gtk_revealer_set_child(revealer, child);
		return revealer;
	}

	public static GtkWidgetHandle GetChild(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_child(revealer);
	}
}
