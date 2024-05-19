namespace MentorLake.Gtk4.Gtk4;

public class GtkCellRendererAccelHandle : GtkCellRendererTextHandle
{
	public static GtkCellRendererAccelHandle New()
	{
		return GtkCellRendererAccelExterns.gtk_cell_renderer_accel_new();
	}

}

public static class GtkCellRendererAccelSignalExtensions
{

	public static IObservable<GtkCellRendererAccelSignalStructs.AccelClearedSignal> Signal_AccelCleared(this GtkCellRendererAccelHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererAccelSignalStructs.AccelClearedSignal> obs) =>
		{
			GtkCellRendererAccelSignalDelegates.AccelCleared handler = (GtkCellRendererAccelHandle self, string path_string, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererAccelSignalStructs.AccelClearedSignal()
				{
					Self = self, PathString = path_string, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accel_cleared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCellRendererAccelSignalStructs.AccelEditedSignal> Signal_AccelEdited(this GtkCellRendererAccelHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererAccelSignalStructs.AccelEditedSignal> obs) =>
		{
			GtkCellRendererAccelSignalDelegates.AccelEdited handler = (GtkCellRendererAccelHandle self, string path_string, uint accel_key, GdkModifierType accel_mods, uint hardware_keycode, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererAccelSignalStructs.AccelEditedSignal()
				{
					Self = self, PathString = path_string, AccelKey = accel_key, AccelMods = accel_mods, HardwareKeycode = hardware_keycode, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accel_edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCellRendererAccelSignalStructs
{

public struct AccelClearedSignal
{
	public GtkCellRendererAccelHandle Self;
	public string PathString;
	public IntPtr UserData;
}

public struct AccelEditedSignal
{
	public GtkCellRendererAccelHandle Self;
	public string PathString;
	public uint AccelKey;
	public GdkModifierType AccelMods;
	public uint HardwareKeycode;
	public IntPtr UserData;
}
}

public static class GtkCellRendererAccelSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AccelCleared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererAccelHandle>))] GtkCellRendererAccelHandle self, string path_string, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AccelEdited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererAccelHandle>))] GtkCellRendererAccelHandle self, string path_string, uint accel_key, GdkModifierType accel_mods, uint hardware_keycode, IntPtr user_data);
}


public static class GtkCellRendererAccelHandleExtensions
{
}

internal class GtkCellRendererAccelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererAccelHandle gtk_cell_renderer_accel_new();

}
