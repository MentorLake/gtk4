namespace MentorLake.Gtk4.Gdk4;

public interface GdkDevicePadHandle
{
}

internal class GdkDevicePadHandleImpl : BaseSafeHandle, GdkDevicePadHandle
{
}

public static class GdkDevicePadHandleExtensions
{
	public static int GetFeatureGroup(this GdkDevicePadHandle pad, GdkDevicePadFeature feature, int feature_idx)
	{
		return GdkDevicePadExterns.gdk_device_pad_get_feature_group(pad, feature, feature_idx);
	}

	public static int GetGroupNModes(this GdkDevicePadHandle pad, int group_idx)
	{
		return GdkDevicePadExterns.gdk_device_pad_get_group_n_modes(pad, group_idx);
	}

	public static int GetNFeatures(this GdkDevicePadHandle pad, GdkDevicePadFeature feature)
	{
		return GdkDevicePadExterns.gdk_device_pad_get_n_features(pad, feature);
	}

	public static int GetNGroups(this GdkDevicePadHandle pad)
	{
		return GdkDevicePadExterns.gdk_device_pad_get_n_groups(pad);
	}

}

internal class GdkDevicePadExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_device_pad_get_feature_group(GdkDevicePadHandle pad, GdkDevicePadFeature feature, int feature_idx);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_device_pad_get_group_n_modes(GdkDevicePadHandle pad, int group_idx);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_device_pad_get_n_features(GdkDevicePadHandle pad, GdkDevicePadFeature feature);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_device_pad_get_n_groups(GdkDevicePadHandle pad);

}
