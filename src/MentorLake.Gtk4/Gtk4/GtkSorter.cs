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

public class GtkSorterHandle : GObjectHandle
{
}

public static class GtkSorterSignalExtensions
{

	public static IObservable<GtkSorterSignalStructs.ChangedSignal> Signal_Changed(this GtkSorterHandle instance)
	{
		return Observable.Create((IObserver<GtkSorterSignalStructs.ChangedSignal> obs) =>
		{
			GtkSorterSignalDelegates.Changed handler = (GtkSorterHandle self, GtkSorterChange change, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSorterSignalStructs.ChangedSignal()
				{
					Self = self, Change = change, UserData = user_data
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

public static class GtkSorterSignalStructs
{

public struct ChangedSignal
{
	public GtkSorterHandle Self;
	public GtkSorterChange Change;
	public IntPtr UserData;
}
}

public static class GtkSorterSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSorterHandle>))] GtkSorterHandle self, GtkSorterChange change, IntPtr user_data);
}


public static class GtkSorterHandleExtensions
{
	public static GtkSorterHandle Changed(this GtkSorterHandle self, GtkSorterChange change)
	{
		GtkSorterExterns.gtk_sorter_changed(self, change);
		return self;
	}

	public static GtkOrdering Compare(this GtkSorterHandle self, GObjectHandle item1, GObjectHandle item2)
	{
		return GtkSorterExterns.gtk_sorter_compare(self, item1, item2);
	}

	public static GtkSorterOrder GetOrder(this GtkSorterHandle self)
	{
		return GtkSorterExterns.gtk_sorter_get_order(self);
	}

}

internal class GtkSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_sorter_changed(GtkSorterHandle self, GtkSorterChange change);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkOrdering gtk_sorter_compare(GtkSorterHandle self, GObjectHandle item1, GObjectHandle item2);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSorterOrder gtk_sorter_get_order(GtkSorterHandle self);

}
