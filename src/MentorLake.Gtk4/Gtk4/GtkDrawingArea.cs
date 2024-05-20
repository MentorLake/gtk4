namespace MentorLake.Gtk4.Gtk4;

public class GtkDrawingAreaHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkDrawingAreaHandle New()
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_new();
	}

}

public static class GtkDrawingAreaSignalExtensions
{

	public static IObservable<GtkDrawingAreaSignalStructs.ResizeSignal> Signal_Resize(this GtkDrawingAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkDrawingAreaSignalStructs.ResizeSignal> obs) =>
		{
			GtkDrawingAreaSignalDelegates.resize handler = (GtkDrawingAreaHandle self, int width, int height, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDrawingAreaSignalStructs.ResizeSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkDrawingAreaSignalStructs
{

public struct ResizeSignal
{
	public GtkDrawingAreaHandle Self;
	public int Width;
	public int Height;
	public IntPtr UserData;
}
}

public static class GtkDrawingAreaSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDrawingAreaHandle>))] GtkDrawingAreaHandle self, int width, int height, IntPtr user_data);

}


public static class GtkDrawingAreaHandleExtensions
{
	public static int GetContentHeight(this GtkDrawingAreaHandle self)
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_get_content_height(self);
	}

	public static int GetContentWidth(this GtkDrawingAreaHandle self)
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_get_content_width(self);
	}

	public static GtkDrawingAreaHandle SetContentHeight(this GtkDrawingAreaHandle self, int height)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_content_height(self, height);
		return self;
	}

	public static GtkDrawingAreaHandle SetContentWidth(this GtkDrawingAreaHandle self, int width)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_content_width(self, width);
		return self;
	}

	public static GtkDrawingAreaHandle SetDrawFunc(this GtkDrawingAreaHandle self, GtkDrawingAreaDrawFunc draw_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkDrawingAreaExterns.gtk_drawing_area_set_draw_func(self, draw_func, user_data, destroy);
		return self;
	}

}

internal class GtkDrawingAreaExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDrawingAreaHandle gtk_drawing_area_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_drawing_area_get_content_height(GtkDrawingAreaHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_drawing_area_get_content_width(GtkDrawingAreaHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drawing_area_set_content_height(GtkDrawingAreaHandle self, int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drawing_area_set_content_width(GtkDrawingAreaHandle self, int width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drawing_area_set_draw_func(GtkDrawingAreaHandle self, GtkDrawingAreaDrawFunc draw_func, IntPtr user_data, GDestroyNotify destroy);

}
