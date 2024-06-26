namespace MentorLake.Gtk4.Gtk4;

public class GtkRangeHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
}

public static class GtkRangeSignalExtensions
{

	public static IObservable<GtkRangeSignalStructs.AdjustBoundsSignal> Signal_AdjustBounds(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.AdjustBoundsSignal> obs) =>
		{
			GtkRangeSignalDelegates.adjust_bounds handler = (GtkRangeHandle self, double value, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.AdjustBoundsSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "adjust_bounds", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkRangeSignalStructs.ChangeValueSignal> Signal_ChangeValue(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.ChangeValueSignal> obs) =>
		{
			GtkRangeSignalDelegates.change_value handler = (GtkRangeHandle self, ref GtkScrollType scroll, double value, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.ChangeValueSignal()
				{
					Self = self, Scroll = scroll, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "change_value", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkRangeSignalStructs.MoveSliderSignal> Signal_MoveSlider(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.MoveSliderSignal> obs) =>
		{
			GtkRangeSignalDelegates.move_slider handler = (GtkRangeHandle self, ref GtkScrollType step, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.MoveSliderSignal()
				{
					Self = self, Step = step, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_slider", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkRangeSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkRangeSignalDelegates.value_changed handler = (GtkRangeHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.ValueChangedSignal()
				{
					Self = self, UserData = user_data
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

public static class GtkRangeSignalStructs
{

public struct AdjustBoundsSignal
{
	public GtkRangeHandle Self;
	public double Value;
	public IntPtr UserData;
}

public struct ChangeValueSignal
{
	public GtkRangeHandle Self;
	public GtkScrollType Scroll;
	public double Value;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveSliderSignal
{
	public GtkRangeHandle Self;
	public GtkScrollType Step;
	public IntPtr UserData;
}

public struct ValueChangedSignal
{
	public GtkRangeHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRangeSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void adjust_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, double value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, ref GtkScrollType scroll, double value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_slider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, ref GtkScrollType step, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, IntPtr user_data);

}


public static class GtkRangeHandleExtensions
{
	public static GtkAdjustmentHandle GetAdjustment(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_adjustment(range);
	}

	public static double GetFillLevel(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_fill_level(range);
	}

	public static bool GetFlippable(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_flippable(range);
	}

	public static bool GetInverted(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_inverted(range);
	}

	public static GtkRangeHandle GetRangeRect(this GtkRangeHandle range, out GdkRectangle range_rect)
	{
		GtkRangeExterns.gtk_range_get_range_rect(range, out range_rect);
		return range;
	}

	public static bool GetRestrictToFillLevel(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_restrict_to_fill_level(range);
	}

	public static int GetRoundDigits(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_round_digits(range);
	}

	public static bool GetShowFillLevel(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_show_fill_level(range);
	}

	public static GtkRangeHandle GetSliderRange(this GtkRangeHandle range, out int slider_start, out int slider_end)
	{
		GtkRangeExterns.gtk_range_get_slider_range(range, out slider_start, out slider_end);
		return range;
	}

	public static bool GetSliderSizeFixed(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_slider_size_fixed(range);
	}

	public static double GetValue(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_value(range);
	}

	public static GtkRangeHandle SetAdjustment(this GtkRangeHandle range, GtkAdjustmentHandle adjustment)
	{
		GtkRangeExterns.gtk_range_set_adjustment(range, adjustment);
		return range;
	}

	public static GtkRangeHandle SetFillLevel(this GtkRangeHandle range, double fill_level)
	{
		GtkRangeExterns.gtk_range_set_fill_level(range, fill_level);
		return range;
	}

	public static GtkRangeHandle SetFlippable(this GtkRangeHandle range, bool flippable)
	{
		GtkRangeExterns.gtk_range_set_flippable(range, flippable);
		return range;
	}

	public static GtkRangeHandle SetIncrements(this GtkRangeHandle range, double step, double page)
	{
		GtkRangeExterns.gtk_range_set_increments(range, step, page);
		return range;
	}

	public static GtkRangeHandle SetInverted(this GtkRangeHandle range, bool setting)
	{
		GtkRangeExterns.gtk_range_set_inverted(range, setting);
		return range;
	}

	public static GtkRangeHandle SetRange(this GtkRangeHandle range, double min, double max)
	{
		GtkRangeExterns.gtk_range_set_range(range, min, max);
		return range;
	}

	public static GtkRangeHandle SetRestrictToFillLevel(this GtkRangeHandle range, bool restrict_to_fill_level)
	{
		GtkRangeExterns.gtk_range_set_restrict_to_fill_level(range, restrict_to_fill_level);
		return range;
	}

	public static GtkRangeHandle SetRoundDigits(this GtkRangeHandle range, int round_digits)
	{
		GtkRangeExterns.gtk_range_set_round_digits(range, round_digits);
		return range;
	}

	public static GtkRangeHandle SetShowFillLevel(this GtkRangeHandle range, bool show_fill_level)
	{
		GtkRangeExterns.gtk_range_set_show_fill_level(range, show_fill_level);
		return range;
	}

	public static GtkRangeHandle SetSliderSizeFixed(this GtkRangeHandle range, bool size_fixed)
	{
		GtkRangeExterns.gtk_range_set_slider_size_fixed(range, size_fixed);
		return range;
	}

	public static GtkRangeHandle SetValue(this GtkRangeHandle range, double value)
	{
		GtkRangeExterns.gtk_range_set_value(range, value);
		return range;
	}

}

internal class GtkRangeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_range_get_adjustment(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_range_get_fill_level(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_range_get_flippable(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_range_get_inverted(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_get_range_rect(GtkRangeHandle range, out GdkRectangle range_rect);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_range_get_restrict_to_fill_level(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_range_get_round_digits(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_range_get_show_fill_level(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_get_slider_range(GtkRangeHandle range, out int slider_start, out int slider_end);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_range_get_slider_size_fixed(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_range_get_value(GtkRangeHandle range);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_adjustment(GtkRangeHandle range, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_fill_level(GtkRangeHandle range, double fill_level);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_flippable(GtkRangeHandle range, bool flippable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_increments(GtkRangeHandle range, double step, double page);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_inverted(GtkRangeHandle range, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_range(GtkRangeHandle range, double min, double max);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_restrict_to_fill_level(GtkRangeHandle range, bool restrict_to_fill_level);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_round_digits(GtkRangeHandle range, int round_digits);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_show_fill_level(GtkRangeHandle range, bool show_fill_level);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_slider_size_fixed(GtkRangeHandle range, bool size_fixed);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_range_set_value(GtkRangeHandle range, double value);

}
