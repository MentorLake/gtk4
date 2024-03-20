using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEventControllerAdaptors
{
	public static GtkWidgetHandle GetWidget(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_widget(controller);
	}

	public static GtkEventControllerHandle Reset(this GtkEventControllerHandle controller)
	{
		GtkEventControllerExterns.gtk_event_controller_reset(controller);
		return controller;
	}

	public static GtkPropagationPhase GetPropagationPhase(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_propagation_phase(controller);
	}

	public static GtkEventControllerHandle SetPropagationPhase(this GtkEventControllerHandle controller, GtkPropagationPhase phase)
	{
		GtkEventControllerExterns.gtk_event_controller_set_propagation_phase(controller, phase);
		return controller;
	}

	public static GtkPropagationLimit GetPropagationLimit(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_propagation_limit(controller);
	}

	public static GtkEventControllerHandle SetPropagationLimit(this GtkEventControllerHandle controller, GtkPropagationLimit limit)
	{
		GtkEventControllerExterns.gtk_event_controller_set_propagation_limit(controller, limit);
		return controller;
	}

	public static string GetName(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_name(controller);
	}

	public static GtkEventControllerHandle SetName(this GtkEventControllerHandle controller, string name)
	{
		GtkEventControllerExterns.gtk_event_controller_set_name(controller, name);
		return controller;
	}

	public static GdkEventHandle GetCurrentEvent(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event(controller);
	}

	public static uint GetCurrentEventTime(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event_time(controller);
	}

	public static GdkDeviceHandle GetCurrentEventDevice(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event_device(controller);
	}

	public static GdkModifierType GetCurrentEventState(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event_state(controller);
	}

	public static GtkEventControllerHandle FocusNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_focus_new();
	}

	public static GtkEventControllerHandle KeyNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_key_new();
	}

	public static GtkEventControllerHandle LegacyNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_legacy_new();
	}

	public static GtkEventControllerHandle MotionNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_motion_new();
	}

	public static GtkEventControllerHandle ScrollNew(GtkEventControllerScrollFlags flags)
	{
		return GtkEventControllerExterns.gtk_event_controller_scroll_new(flags);
	}

	public static GtkEventControllerHandle GtkShortcutControllerNew()
	{
		return GtkEventControllerExterns.gtk_shortcut_controller_new();
	}

	public static GtkEventControllerHandle GtkShortcutControllerNewForModel(GListModelHandle model)
	{
		return GtkEventControllerExterns.gtk_shortcut_controller_new_for_model(model);
	}
}
