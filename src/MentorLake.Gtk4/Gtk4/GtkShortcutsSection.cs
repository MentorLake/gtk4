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

public class GtkShortcutsSectionHandle : GtkBoxHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
}

public static class GtkShortcutsSectionSignalExtensions
{

	public static IObservable<GtkShortcutsSectionSignalStructs.ChangeCurrentPageSignal> Signal_ChangeCurrentPage(this GtkShortcutsSectionHandle instance)
	{
		return Observable.Create((IObserver<GtkShortcutsSectionSignalStructs.ChangeCurrentPageSignal> obs) =>
		{
			GtkShortcutsSectionSignalDelegates.ChangeCurrentPage handler = (GtkShortcutsSectionHandle self, int @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsSectionSignalStructs.ChangeCurrentPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "change_current_page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkShortcutsSectionSignalStructs
{

public struct ChangeCurrentPageSignal
{
	public GtkShortcutsSectionHandle Self;
	public int Object;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkShortcutsSectionSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool ChangeCurrentPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsSectionHandle>))] GtkShortcutsSectionHandle self, int @object, IntPtr user_data);
}


public static class GtkShortcutsSectionHandleExtensions
{
	public static GtkShortcutsSectionHandle AddGroup(this GtkShortcutsSectionHandle self, GtkShortcutsGroupHandle group)
	{
		GtkShortcutsSectionExterns.gtk_shortcuts_section_add_group(self, group);
		return self;
	}

}

internal class GtkShortcutsSectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcuts_section_add_group(GtkShortcutsSectionHandle self, GtkShortcutsGroupHandle group);

}
