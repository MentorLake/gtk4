namespace MentorLake.Gtk4.Gtk4;

public class GtkFileChooserWidgetHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkFileChooserHandle
{
	public static GtkFileChooserWidgetHandle New(GtkFileChooserAction action)
	{
		return GtkFileChooserWidgetExterns.gtk_file_chooser_widget_new(action);
	}

}

public static class GtkFileChooserWidgetSignalExtensions
{

	public static IObservable<GtkFileChooserWidgetSignalStructs.DesktopFolderSignal> Signal_DesktopFolder(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.DesktopFolderSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.desktop_folder handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.DesktopFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "desktop_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.DownFolderSignal> Signal_DownFolder(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.DownFolderSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.down_folder handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.DownFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "down_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.HomeFolderSignal> Signal_HomeFolder(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.HomeFolderSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.home_folder handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.HomeFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "home_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.LocationPopupSignal> Signal_LocationPopup(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.LocationPopupSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.location_popup handler = (GtkFileChooserWidgetHandle self, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.LocationPopupSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "location_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.LocationPopupOnPasteSignal> Signal_LocationPopupOnPaste(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.LocationPopupOnPasteSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.location_popup_on_paste handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.LocationPopupOnPasteSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "location_popup_on_paste", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.LocationTogglePopupSignal> Signal_LocationTogglePopup(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.LocationTogglePopupSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.location_toggle_popup handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.LocationTogglePopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "location_toggle_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.PlacesShortcutSignal> Signal_PlacesShortcut(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.PlacesShortcutSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.places_shortcut handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.PlacesShortcutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "places_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.QuickBookmarkSignal> Signal_QuickBookmark(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.QuickBookmarkSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.quick_bookmark handler = (GtkFileChooserWidgetHandle self, int bookmark_index, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.QuickBookmarkSignal()
				{
					Self = self, BookmarkIndex = bookmark_index, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "quick_bookmark", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.RecentShortcutSignal> Signal_RecentShortcut(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.RecentShortcutSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.recent_shortcut handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.RecentShortcutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "recent_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.SearchShortcutSignal> Signal_SearchShortcut(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.SearchShortcutSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.search_shortcut handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.SearchShortcutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "search_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.ShowHiddenSignal> Signal_ShowHidden(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.ShowHiddenSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.show_hidden handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.ShowHiddenSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_hidden", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFileChooserWidgetSignalStructs.UpFolderSignal> Signal_UpFolder(this GtkFileChooserWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetSignalStructs.UpFolderSignal> obs) =>
		{
			GtkFileChooserWidgetSignalDelegates.up_folder handler = (GtkFileChooserWidgetHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetSignalStructs.UpFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "up_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkFileChooserWidgetSignalStructs
{

public struct DesktopFolderSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct DownFolderSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct HomeFolderSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct LocationPopupSignal
{
	public GtkFileChooserWidgetHandle Self;
	public string Path;
	public IntPtr UserData;
}

public struct LocationPopupOnPasteSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct LocationTogglePopupSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct PlacesShortcutSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct QuickBookmarkSignal
{
	public GtkFileChooserWidgetHandle Self;
	public int BookmarkIndex;
	public IntPtr UserData;
}

public struct RecentShortcutSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct SearchShortcutSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct ShowHiddenSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}

public struct UpFolderSignal
{
	public GtkFileChooserWidgetHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFileChooserWidgetSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void desktop_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void down_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void home_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_popup_on_paste([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_toggle_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void places_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void quick_bookmark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, int bookmark_index, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void recent_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void up_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

}


public static class GtkFileChooserWidgetHandleExtensions
{
}

internal class GtkFileChooserWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileChooserWidgetHandle gtk_file_chooser_widget_new(GtkFileChooserAction action);

}
