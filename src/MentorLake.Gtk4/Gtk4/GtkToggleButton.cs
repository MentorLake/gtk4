using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkToggleButtonHandle : GtkButtonHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkToggleButtonHandle New()
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new();
	}

	public static GtkToggleButtonHandle NewWithLabel(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_label(label);
	}

	public static GtkToggleButtonHandle NewWithMnemonic(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_mnemonic(label);
	}

}

public static class GtkToggleButtonSignalExtensions
{

	public static IObservable<GtkToggleButtonSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkToggleButtonSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleButtonSignalDelegates.Toggled handler = (GtkToggleButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleButtonSignalStructs.ToggledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkToggleButtonSignalStructs
{

public struct ToggledSignal
{
	public GtkToggleButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToggleButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToggleButtonHandle>))] GtkToggleButtonHandle self, IntPtr user_data);
}


public static class GtkToggleButtonHandleExtensions
{
	public static bool GetActive(this GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_get_active(toggle_button);
	}

	public static GtkToggleButtonHandle SetActive(this GtkToggleButtonHandle toggle_button, bool is_active)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_active(toggle_button, is_active);
		return toggle_button;
	}

	public static GtkToggleButtonHandle SetGroup(this GtkToggleButtonHandle toggle_button, GtkToggleButtonHandle group)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_group(toggle_button, group);
		return toggle_button;
	}

	public static GtkToggleButtonHandle Toggled(this GtkToggleButtonHandle toggle_button)
	{
		GtkToggleButtonExterns.gtk_toggle_button_toggled(toggle_button);
		return toggle_button;
	}

}

internal class GtkToggleButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_label(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_toggle_button_get_active(GtkToggleButtonHandle toggle_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_toggle_button_set_active(GtkToggleButtonHandle toggle_button, bool is_active);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_toggle_button_set_group(GtkToggleButtonHandle toggle_button, GtkToggleButtonHandle group);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_toggle_button_toggled(GtkToggleButtonHandle toggle_button);

}
