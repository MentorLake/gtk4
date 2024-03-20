using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDevicePadExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_pad_get_n_groups")]
	internal static extern int gdk_device_pad_get_n_groups(this GdkDevicePadHandle pad);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_pad_get_group_n_modes")]
	internal static extern int gdk_device_pad_get_group_n_modes(this GdkDevicePadHandle pad, int group_idx);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_pad_get_n_features")]
	internal static extern int gdk_device_pad_get_n_features(this GdkDevicePadHandle pad, GdkDevicePadFeature feature);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_pad_get_feature_group")]
	internal static extern int gdk_device_pad_get_feature_group(this GdkDevicePadHandle pad, GdkDevicePadFeature feature, int feature_idx);
}
