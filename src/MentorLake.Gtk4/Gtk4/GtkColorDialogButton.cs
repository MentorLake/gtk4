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

public class GtkColorDialogButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkColorDialogButtonHandle New(GtkColorDialogHandle dialog)
	{
		return GtkColorDialogButtonExterns.gtk_color_dialog_button_new(dialog);
	}

}

public static class GtkColorDialogButtonSignalExtensions
{

	public static IObservable<GtkColorDialogButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkColorDialogButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkColorDialogButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkColorDialogButtonSignalDelegates.Activate handler = (GtkColorDialogButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorDialogButtonSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkColorDialogButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkColorDialogButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkColorDialogButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColorDialogButtonHandle>))] GtkColorDialogButtonHandle self, IntPtr user_data);
}


public static class GtkColorDialogButtonHandleExtensions
{
	public static GtkColorDialogHandle GetDialog(this GtkColorDialogButtonHandle self)
	{
		return GtkColorDialogButtonExterns.gtk_color_dialog_button_get_dialog(self);
	}

	public static GdkRGBAHandle GetRgba(this GtkColorDialogButtonHandle self)
	{
		return GtkColorDialogButtonExterns.gtk_color_dialog_button_get_rgba(self);
	}

	public static GtkColorDialogButtonHandle SetDialog(this GtkColorDialogButtonHandle self, GtkColorDialogHandle dialog)
	{
		GtkColorDialogButtonExterns.gtk_color_dialog_button_set_dialog(self, dialog);
		return self;
	}

	public static GtkColorDialogButtonHandle SetRgba(this GtkColorDialogButtonHandle self, GdkRGBAHandle color)
	{
		GtkColorDialogButtonExterns.gtk_color_dialog_button_set_rgba(self, color);
		return self;
	}

}

internal class GtkColorDialogButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorDialogButtonHandle gtk_color_dialog_button_new(GtkColorDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorDialogHandle gtk_color_dialog_button_get_dialog(GtkColorDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkRGBAHandle gtk_color_dialog_button_get_rgba(GtkColorDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_button_set_dialog(GtkColorDialogButtonHandle self, GtkColorDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_button_set_rgba(GtkColorDialogButtonHandle self, GdkRGBAHandle color);

}
