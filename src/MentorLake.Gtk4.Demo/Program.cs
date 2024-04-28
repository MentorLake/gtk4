﻿using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Demo;

public static class Program
{
	public static void Main(string[] args)
	{
		SynchronizationContext.SetSynchronizationContext(new GLibSynchronizationContext());

		var appHandle = GtkApplicationHandle.New("my.app", GApplicationFlags.G_APPLICATION_FLAGS_NONE);

		appHandle.Signal_Activate(async (self, data) =>
		{
			var window = GtkWindowHandle.New()
				.SetChild(GtkBoxHandle.New(GtkOrientation.GTK_ORIENTATION_HORIZONTAL, 0)
					.Append(GtkDrawingAreaHandle.New()
						.SetDrawFunc((area, cr, width, height, userData) =>
						{
							cr.CairoArc(0, 0, 10, 0, 180);
							cr.CairoStroke();
						}, IntPtr.Zero, null)
						.SetSizeRequest(200, 200))
					.Append(GtkButtonHandle.New()
						.SetLabel("TEST")
						.Signal_Clicked((button, _) =>
						{
							Console.WriteLine(button.GetLabel());
							Console.WriteLine(button.GetLabel());
							Console.WriteLine(button.GetLabel());
							Console.WriteLine(button.GetHeight());
							Console.WriteLine(button.GetHeight());
						}))
					.Append(GtkImageHandle.NewFromIconName("face-smile")
						.SetIconSize(GtkIconSize.GTK_ICON_SIZE_LARGE)
						.SetSizeRequest(64, 64)));

			window.Show();
			appHandle.AddWindow(window);
			await Task.Delay(5000);
			window.Destroy();
		});

		appHandle.Run(0, null);
	}
}
