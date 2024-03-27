using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Demo;

public static class Program
{
	public static void Main(string[] args)
	{
		SynchronizationContext.SetSynchronizationContext(new GLibSynchronizationContext());

		var appHandle = GtkApplicationHandle.New("my.app", GApplicationFlags.G_APPLICATION_FLAGS_NONE);

		appHandle.Connect(GApplicationSignals.Activate, async () =>
		{
			var window = GtkWindowHandle.New()
				.SetChild(GtkBoxHandle.New(GtkOrientation.GTK_ORIENTATION_HORIZONTAL, 0)
					.Append(GtkButtonHandle.New()
						.SetLabel("TEST")
						.Connect(GtkButtonSignals.Clicked, () => Console.WriteLine("CLICK")))
					.Append(GtkImageHandle.NewFromIconName("face-smile")
						.SetIconSize(GtkIconSize.GTK_ICON_SIZE_LARGE)
						.SetSizeRequest(64, 64)));

			window.Show();
			appHandle.AddWindow(window);
			await Task.Delay(2000);
			window.Destroy();
		});

		appHandle.Run(0, null);
	}
}
