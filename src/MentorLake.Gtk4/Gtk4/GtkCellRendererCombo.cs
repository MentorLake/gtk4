namespace MentorLake.Gtk4.Gtk4;

public class GtkCellRendererComboHandle : GtkCellRendererTextHandle
{
	public static GtkCellRendererComboHandle New()
	{
		return GtkCellRendererComboExterns.gtk_cell_renderer_combo_new();
	}

}

public static class GtkCellRendererComboSignalExtensions
{

	public static IObservable<GtkCellRendererComboSignalStructs.ChangedSignal> Signal_Changed(this GtkCellRendererComboHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererComboSignalStructs.ChangedSignal> obs) =>
		{
			GtkCellRendererComboSignalDelegates.Changed handler = (GtkCellRendererComboHandle self, string path_string, GtkTreeIterHandle new_iter, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererComboSignalStructs.ChangedSignal()
				{
					Self = self, PathString = path_string, NewIter = new_iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCellRendererComboSignalStructs
{

public struct ChangedSignal
{
	public GtkCellRendererComboHandle Self;
	public string PathString;
	public GtkTreeIterHandle NewIter;
	public IntPtr UserData;
}
}

public static class GtkCellRendererComboSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererComboHandle>))] GtkCellRendererComboHandle self, string path_string, GtkTreeIterHandle new_iter, IntPtr user_data);
}


public static class GtkCellRendererComboHandleExtensions
{
}

internal class GtkCellRendererComboExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererComboHandle gtk_cell_renderer_combo_new();

}
