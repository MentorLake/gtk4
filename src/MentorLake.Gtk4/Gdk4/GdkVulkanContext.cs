namespace MentorLake.Gtk4.Gdk4;

public class GdkVulkanContextHandle : GdkDrawContextHandle, GInitableHandle
{
}

public static class GdkVulkanContextSignalExtensions
{

	public static IObservable<GdkVulkanContextSignalStructs.ImagesUpdatedSignal> Signal_ImagesUpdated(this GdkVulkanContextHandle instance)
	{
		return Observable.Create((IObserver<GdkVulkanContextSignalStructs.ImagesUpdatedSignal> obs) =>
		{
			GdkVulkanContextSignalDelegates.images_updated handler = (GdkVulkanContextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkVulkanContextSignalStructs.ImagesUpdatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "images_updated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkVulkanContextSignalStructs
{

public struct ImagesUpdatedSignal
{
	public GdkVulkanContextHandle Self;
	public IntPtr UserData;
}
}

public static class GdkVulkanContextSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void images_updated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkVulkanContextHandle>))] GdkVulkanContextHandle self, IntPtr user_data);

}


public static class GdkVulkanContextHandleExtensions
{
}

internal class GdkVulkanContextExterns
{
}
