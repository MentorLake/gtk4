namespace MentorLake.Gtk4.Gtk4;

public class GtkEventControllerHandle : GObjectHandle
{
}

public static class GtkEventControllerHandleExtensions
{
	public static GdkEventHandle GetCurrentEvent(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event(controller);
	}

	public static GdkDeviceHandle GetCurrentEventDevice(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event_device(controller);
	}

	public static GdkModifierType GetCurrentEventState(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event_state(controller);
	}

	public static uint GetCurrentEventTime(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_current_event_time(controller);
	}

	public static string GetName(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_name(controller);
	}

	public static GtkPropagationLimit GetPropagationLimit(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_propagation_limit(controller);
	}

	public static GtkPropagationPhase GetPropagationPhase(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_propagation_phase(controller);
	}

	public static GtkWidgetHandle GetWidget(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_widget(controller);
	}

	public static GtkEventControllerHandle Reset(this GtkEventControllerHandle controller)
	{
		GtkEventControllerExterns.gtk_event_controller_reset(controller);
		return controller;
	}

	public static GtkEventControllerHandle SetName(this GtkEventControllerHandle controller, string name)
	{
		GtkEventControllerExterns.gtk_event_controller_set_name(controller, name);
		return controller;
	}

	public static GtkEventControllerHandle SetPropagationLimit(this GtkEventControllerHandle controller, GtkPropagationLimit limit)
	{
		GtkEventControllerExterns.gtk_event_controller_set_propagation_limit(controller, limit);
		return controller;
	}

	public static GtkEventControllerHandle SetPropagationPhase(this GtkEventControllerHandle controller, GtkPropagationPhase phase)
	{
		GtkEventControllerExterns.gtk_event_controller_set_propagation_phase(controller, phase);
		return controller;
	}

	public static GtkEventControllerHandle SetStaticName(this GtkEventControllerHandle controller, string name)
	{
		GtkEventControllerExterns.gtk_event_controller_set_static_name(controller, name);
		return controller;
	}

}

internal class GtkEventControllerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkEventHandle gtk_event_controller_get_current_event(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDeviceHandle gtk_event_controller_get_current_event_device(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkModifierType gtk_event_controller_get_current_event_state(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_event_controller_get_current_event_time(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_event_controller_get_name(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPropagationLimit gtk_event_controller_get_propagation_limit(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPropagationPhase gtk_event_controller_get_propagation_phase(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_event_controller_get_widget(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_reset(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_set_name(GtkEventControllerHandle controller, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_set_propagation_limit(GtkEventControllerHandle controller, GtkPropagationLimit limit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_set_propagation_phase(GtkEventControllerHandle controller, GtkPropagationPhase phase);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_set_static_name(GtkEventControllerHandle controller, string name);

}
