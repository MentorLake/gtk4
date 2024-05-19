namespace MentorLake.Gtk4.Gtk4;

public class GtkLevelBarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkLevelBarHandle New()
	{
		return GtkLevelBarExterns.gtk_level_bar_new();
	}

	public static GtkLevelBarHandle NewForInterval(double min_value, double max_value)
	{
		return GtkLevelBarExterns.gtk_level_bar_new_for_interval(min_value, max_value);
	}

}

public static class GtkLevelBarSignalExtensions
{

	public static IObservable<GtkLevelBarSignalStructs.OffsetChangedSignal> Signal_OffsetChanged(this GtkLevelBarHandle instance)
	{
		return Observable.Create((IObserver<GtkLevelBarSignalStructs.OffsetChangedSignal> obs) =>
		{
			GtkLevelBarSignalDelegates.OffsetChanged handler = (GtkLevelBarHandle self, string name, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLevelBarSignalStructs.OffsetChangedSignal()
				{
					Self = self, Name = name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "offset_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkLevelBarSignalStructs
{

public struct OffsetChangedSignal
{
	public GtkLevelBarHandle Self;
	public string Name;
	public IntPtr UserData;
}
}

public static class GtkLevelBarSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void OffsetChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLevelBarHandle>))] GtkLevelBarHandle self, string name, IntPtr user_data);
}


public static class GtkLevelBarHandleExtensions
{
	public static GtkLevelBarHandle AddOffsetValue(this GtkLevelBarHandle self, string name, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_add_offset_value(self, name, value);
		return self;
	}

	public static bool GetInverted(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_inverted(self);
	}

	public static double GetMaxValue(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_max_value(self);
	}

	public static double GetMinValue(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_min_value(self);
	}

	public static GtkLevelBarMode GetMode(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_mode(self);
	}

	public static bool GetOffsetValue(this GtkLevelBarHandle self, string name, out double value)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_offset_value(self, name, out value);
	}

	public static double GetValue(this GtkLevelBarHandle self)
	{
		return GtkLevelBarExterns.gtk_level_bar_get_value(self);
	}

	public static GtkLevelBarHandle RemoveOffsetValue(this GtkLevelBarHandle self, string name)
	{
		GtkLevelBarExterns.gtk_level_bar_remove_offset_value(self, name);
		return self;
	}

	public static GtkLevelBarHandle SetInverted(this GtkLevelBarHandle self, bool inverted)
	{
		GtkLevelBarExterns.gtk_level_bar_set_inverted(self, inverted);
		return self;
	}

	public static GtkLevelBarHandle SetMaxValue(this GtkLevelBarHandle self, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_set_max_value(self, value);
		return self;
	}

	public static GtkLevelBarHandle SetMinValue(this GtkLevelBarHandle self, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_set_min_value(self, value);
		return self;
	}

	public static GtkLevelBarHandle SetMode(this GtkLevelBarHandle self, GtkLevelBarMode mode)
	{
		GtkLevelBarExterns.gtk_level_bar_set_mode(self, mode);
		return self;
	}

	public static GtkLevelBarHandle SetValue(this GtkLevelBarHandle self, double value)
	{
		GtkLevelBarExterns.gtk_level_bar_set_value(self, value);
		return self;
	}

}

internal class GtkLevelBarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLevelBarHandle gtk_level_bar_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLevelBarHandle gtk_level_bar_new_for_interval(double min_value, double max_value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_level_bar_add_offset_value(GtkLevelBarHandle self, string name, double value);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_level_bar_get_inverted(GtkLevelBarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_level_bar_get_max_value(GtkLevelBarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_level_bar_get_min_value(GtkLevelBarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLevelBarMode gtk_level_bar_get_mode(GtkLevelBarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_level_bar_get_offset_value(GtkLevelBarHandle self, string name, out double value);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_level_bar_get_value(GtkLevelBarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_level_bar_remove_offset_value(GtkLevelBarHandle self, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_level_bar_set_inverted(GtkLevelBarHandle self, bool inverted);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_level_bar_set_max_value(GtkLevelBarHandle self, double value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_level_bar_set_min_value(GtkLevelBarHandle self, double value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_level_bar_set_mode(GtkLevelBarHandle self, GtkLevelBarMode mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_level_bar_set_value(GtkLevelBarHandle self, double value);

}
