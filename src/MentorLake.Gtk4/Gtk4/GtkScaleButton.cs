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

public class GtkScaleButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkScaleButtonHandle New(double min, double max, double step, string[] icons)
	{
		return GtkScaleButtonExterns.gtk_scale_button_new(min, max, step, icons);
	}

}

public static class GtkScaleButtonSignalExtensions
{

	public static IObservable<GtkScaleButtonSignalStructs.PopdownSignal> Signal_Popdown(this GtkScaleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkScaleButtonSignalStructs.PopdownSignal> obs) =>
		{
			GtkScaleButtonSignalDelegates.Popdown handler = (GtkScaleButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonSignalStructs.PopdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkScaleButtonSignalStructs.PopupSignal> Signal_Popup(this GtkScaleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkScaleButtonSignalStructs.PopupSignal> obs) =>
		{
			GtkScaleButtonSignalDelegates.Popup handler = (GtkScaleButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonSignalStructs.PopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkScaleButtonSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkScaleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkScaleButtonSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkScaleButtonSignalDelegates.ValueChanged handler = (GtkScaleButtonHandle self, double value, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonSignalStructs.ValueChangedSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "value_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkScaleButtonSignalStructs
{

public struct PopdownSignal
{
	public GtkScaleButtonHandle Self;
	public IntPtr UserData;
}

public struct PopupSignal
{
	public GtkScaleButtonHandle Self;
	public IntPtr UserData;
}

public struct ValueChangedSignal
{
	public GtkScaleButtonHandle Self;
	public double Value;
	public IntPtr UserData;
}
}

public static class GtkScaleButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScaleButtonHandle>))] GtkScaleButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScaleButtonHandle>))] GtkScaleButtonHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ValueChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScaleButtonHandle>))] GtkScaleButtonHandle self, double value, IntPtr user_data);
}


public static class GtkScaleButtonHandleExtensions
{
	public static bool GetActive(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_active(button);
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_adjustment(button);
	}

	public static bool GetHasFrame(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_has_frame(button);
	}

	public static GtkWidgetHandle GetMinusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_minus_button(button);
	}

	public static GtkWidgetHandle GetPlusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_plus_button(button);
	}

	public static GtkWidgetHandle GetPopup(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_popup(button);
	}

	public static double GetValue(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_value(button);
	}

	public static GtkScaleButtonHandle SetAdjustment(this GtkScaleButtonHandle button, GtkAdjustmentHandle adjustment)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_adjustment(button, adjustment);
		return button;
	}

	public static GtkScaleButtonHandle SetHasFrame(this GtkScaleButtonHandle button, bool has_frame)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_has_frame(button, has_frame);
		return button;
	}

	public static GtkScaleButtonHandle SetIcons(this GtkScaleButtonHandle button, string[] icons)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_icons(button, icons);
		return button;
	}

	public static GtkScaleButtonHandle SetValue(this GtkScaleButtonHandle button, double value)
	{
		GtkScaleButtonExterns.gtk_scale_button_set_value(button, value);
		return button;
	}

}

internal class GtkScaleButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScaleButtonHandle gtk_scale_button_new(double min, double max, double step, string[] icons);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scale_button_get_active(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_scale_button_get_adjustment(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scale_button_get_has_frame(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_minus_button(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_plus_button(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_popup(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_scale_button_get_value(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_adjustment(GtkScaleButtonHandle button, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_has_frame(GtkScaleButtonHandle button, bool has_frame);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_icons(GtkScaleButtonHandle button, string[] icons);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scale_button_set_value(GtkScaleButtonHandle button, double value);

}
