namespace MentorLake.Gtk4.Gtk4;

public class GtkSignalListItemFactoryHandle : GtkListItemFactoryHandle
{
	public static GtkSignalListItemFactoryHandle New()
	{
		return GtkSignalListItemFactoryExterns.gtk_signal_list_item_factory_new();
	}

}

public static class GtkSignalListItemFactorySignalExtensions
{

	public static IObservable<GtkSignalListItemFactorySignalStructs.BindSignal> Signal_Bind(this GtkSignalListItemFactoryHandle instance)
	{
		return Observable.Create((IObserver<GtkSignalListItemFactorySignalStructs.BindSignal> obs) =>
		{
			GtkSignalListItemFactorySignalDelegates.bind handler = (GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSignalListItemFactorySignalStructs.BindSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "bind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSignalListItemFactorySignalStructs.SetupSignal> Signal_Setup(this GtkSignalListItemFactoryHandle instance)
	{
		return Observable.Create((IObserver<GtkSignalListItemFactorySignalStructs.SetupSignal> obs) =>
		{
			GtkSignalListItemFactorySignalDelegates.setup handler = (GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSignalListItemFactorySignalStructs.SetupSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "setup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSignalListItemFactorySignalStructs.TeardownSignal> Signal_Teardown(this GtkSignalListItemFactoryHandle instance)
	{
		return Observable.Create((IObserver<GtkSignalListItemFactorySignalStructs.TeardownSignal> obs) =>
		{
			GtkSignalListItemFactorySignalDelegates.teardown handler = (GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSignalListItemFactorySignalStructs.TeardownSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "teardown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSignalListItemFactorySignalStructs.UnbindSignal> Signal_Unbind(this GtkSignalListItemFactoryHandle instance)
	{
		return Observable.Create((IObserver<GtkSignalListItemFactorySignalStructs.UnbindSignal> obs) =>
		{
			GtkSignalListItemFactorySignalDelegates.unbind handler = (GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSignalListItemFactorySignalStructs.UnbindSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unbind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkSignalListItemFactorySignalStructs
{

public struct BindSignal
{
	public GtkSignalListItemFactoryHandle Self;
	public GObjectHandle Object;
	public IntPtr UserData;
}

public struct SetupSignal
{
	public GtkSignalListItemFactoryHandle Self;
	public GObjectHandle Object;
	public IntPtr UserData;
}

public struct TeardownSignal
{
	public GtkSignalListItemFactoryHandle Self;
	public GObjectHandle Object;
	public IntPtr UserData;
}

public struct UnbindSignal
{
	public GtkSignalListItemFactoryHandle Self;
	public GObjectHandle Object;
	public IntPtr UserData;
}
}

public static class GtkSignalListItemFactorySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void teardown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle @object, IntPtr user_data);

}


public static class GtkSignalListItemFactoryHandleExtensions
{
}

internal class GtkSignalListItemFactoryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSignalListItemFactoryHandle gtk_signal_list_item_factory_new();

}
