using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSwitchAdaptors
{
	public static GtkSwitchHandle SetActive(this GtkSwitchHandle self, int is_active)
	{
		GtkSwitchExterns.gtk_switch_set_active(self, is_active);
		return self;
	}

	public static int GetActive(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_active(self);
	}

	public static GtkSwitchHandle SetState(this GtkSwitchHandle self, int state)
	{
		GtkSwitchExterns.gtk_switch_set_state(self, state);
		return self;
	}

	public static int GetState(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_state(self);
	}
}
