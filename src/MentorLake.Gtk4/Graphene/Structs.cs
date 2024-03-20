// graphene_matrix_t
// graphene_rect_t
// graphene_point_t
// graphene_size_t
// graphene_vec4_t
// graphene_point3d_t
// graphene_vec3_t

namespace MentorLake.Gtk4.Graphene;

public struct graphene_rect_t
{
	public graphene_point_t origin;
	public graphene_size_t size;
}

public struct graphene_size_t
{
	public float width;
	public float height;
}

public struct graphene_vec2_t { }
public struct graphene_vec3_t { }
public struct graphene_vec4_t { }

public struct graphene_point_t
{
	public float x;
	public float y;
}

public struct graphene_point3d_t
{
	public float x;
	public float y;
	public float z;
}

public struct graphene_matrix_t { }
