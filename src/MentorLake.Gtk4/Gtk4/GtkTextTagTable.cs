namespace MentorLake.Gtk4.Gtk4;

public class GtkTextTagTableHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkTextTagTableHandle New()
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_new();
	}

}

public static class GtkTextTagTableSignalExtensions
{

	public static IObservable<GtkTextTagTableSignalStructs.TagAddedSignal> Signal_TagAdded(this GtkTextTagTableHandle instance)
	{
		return Observable.Create((IObserver<GtkTextTagTableSignalStructs.TagAddedSignal> obs) =>
		{
			GtkTextTagTableSignalDelegates.tag_added handler = (GtkTextTagTableHandle self, GtkTextTagHandle tag, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableSignalStructs.TagAddedSignal()
				{
					Self = self, Tag = tag, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "tag_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextTagTableSignalStructs.TagChangedSignal> Signal_TagChanged(this GtkTextTagTableHandle instance)
	{
		return Observable.Create((IObserver<GtkTextTagTableSignalStructs.TagChangedSignal> obs) =>
		{
			GtkTextTagTableSignalDelegates.tag_changed handler = (GtkTextTagTableHandle self, GtkTextTagHandle tag, bool size_changed, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableSignalStructs.TagChangedSignal()
				{
					Self = self, Tag = tag, SizeChanged = size_changed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "tag_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextTagTableSignalStructs.TagRemovedSignal> Signal_TagRemoved(this GtkTextTagTableHandle instance)
	{
		return Observable.Create((IObserver<GtkTextTagTableSignalStructs.TagRemovedSignal> obs) =>
		{
			GtkTextTagTableSignalDelegates.tag_removed handler = (GtkTextTagTableHandle self, GtkTextTagHandle tag, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableSignalStructs.TagRemovedSignal()
				{
					Self = self, Tag = tag, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "tag_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkTextTagTableSignalStructs
{

public struct TagAddedSignal
{
	public GtkTextTagTableHandle Self;
	public GtkTextTagHandle Tag;
	public IntPtr UserData;
}

public struct TagChangedSignal
{
	public GtkTextTagTableHandle Self;
	public GtkTextTagHandle Tag;
	public bool SizeChanged;
	public IntPtr UserData;
}

public struct TagRemovedSignal
{
	public GtkTextTagTableHandle Self;
	public GtkTextTagHandle Tag;
	public IntPtr UserData;
}
}

public static class GtkTextTagTableSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagTableHandle>))] GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagHandle>))] GtkTextTagHandle tag, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagTableHandle>))] GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagHandle>))] GtkTextTagHandle tag, bool size_changed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagTableHandle>))] GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagHandle>))] GtkTextTagHandle tag, IntPtr user_data);

}


public static class GtkTextTagTableHandleExtensions
{
	public static bool Add(this GtkTextTagTableHandle table, GtkTextTagHandle tag)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_add(table, tag);
	}

	public static GtkTextTagTableHandle Foreach(this GtkTextTagTableHandle table, GtkTextTagTableForeach func, IntPtr data)
	{
		GtkTextTagTableExterns.gtk_text_tag_table_foreach(table, func, data);
		return table;
	}

	public static int GetSize(this GtkTextTagTableHandle table)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_get_size(table);
	}

	public static GtkTextTagHandle Lookup(this GtkTextTagTableHandle table, string name)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_lookup(table, name);
	}

	public static GtkTextTagTableHandle Remove(this GtkTextTagTableHandle table, GtkTextTagHandle tag)
	{
		GtkTextTagTableExterns.gtk_text_tag_table_remove(table, tag);
		return table;
	}

}

internal class GtkTextTagTableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextTagTableHandle gtk_text_tag_table_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_tag_table_add(GtkTextTagTableHandle table, GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_tag_table_foreach(GtkTextTagTableHandle table, GtkTextTagTableForeach func, IntPtr data);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_tag_table_get_size(GtkTextTagTableHandle table);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextTagHandle gtk_text_tag_table_lookup(GtkTextTagTableHandle table, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_tag_table_remove(GtkTextTagTableHandle table, GtkTextTagHandle tag);

}
