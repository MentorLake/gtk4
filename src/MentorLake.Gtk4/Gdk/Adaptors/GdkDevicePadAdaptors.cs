using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDevicePadAdaptors
{
    public static int GetNGroups(this GdkDevicePadHandle pad)
    {
        return GdkDevicePadExterns.gdk_device_pad_get_n_groups(pad);
    }

    public static int GetGroupNModes(this GdkDevicePadHandle pad, int group_idx)
    {
        return GdkDevicePadExterns.gdk_device_pad_get_group_n_modes(pad, group_idx);
    }

    public static int GetNFeatures(this GdkDevicePadHandle pad, GdkDevicePadFeature feature)
    {
        return GdkDevicePadExterns.gdk_device_pad_get_n_features(pad, feature);
    }

    public static int GetFeatureGroup(this GdkDevicePadHandle pad, GdkDevicePadFeature feature, int feature_idx)
    {
        return GdkDevicePadExterns.gdk_device_pad_get_feature_group(pad, feature, feature_idx);
    }
}
