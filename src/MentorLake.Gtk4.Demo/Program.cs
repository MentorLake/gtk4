using MentorLake.Gtk4;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gtk;

namespace MentorLake.Gtk4.Demo;

public static class Program
{
	public static void Main(string[] args)
	{
		SynchronizationContext.SetSynchronizationContext(new GLibSynchronizationContext());

		var appHandle = GtkApplicationHandle.New("my.app", GApplicationFlags.G_APPLICATION_FLAGS_NONE);

		appHandle.GSignalConnect("activate", async () =>
		{
			var window = appHandle.WindowNew();
			window
				.SetChild(GtkBoxHandle.New(GtkOrientation.GTK_ORIENTATION_HORIZONTAL, 0)
					.Append(GtkButtonHandle.New()
						.SetLabel("TEST")))
				.Show();

			await Task.Delay(1000);

			window.Destroy();
		});

		appHandle.Run(0, null);
	}
}
