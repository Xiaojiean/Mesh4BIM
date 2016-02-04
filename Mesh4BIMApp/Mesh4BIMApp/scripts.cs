using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mesh4BIMApp
{
    class scripts
    {
        public static void scriptStart()
        {
            string start = "<!DOCTYPE FilterScript>\n" +
                "<FilterScript>\n";
            File.WriteAllText("script.mlx", start);
        }

        public static void poissonDiskSampling(string radius)
        {
            string sampling = " <filter name = \"Poisson-disk Sampling\" >\n" +
                "  <Param name=\"SampleNum\" value=\"1000\" tooltip=\"The desired number of samples.The ray of the disk is calculated according to the sampling density.\" description=\"Number of samples\" type=\"RichInt\"/>\n" +
                "  <Param name = \"Radius\" value =\"" + radius + "\" min=\"0\" max=\"1.32081\" tooltip=\"If not zero this parameter override the previous parameter to allow exact radius specification\" description=\"Explicit Radius\" type=\"RichAbsPerc\"/>\n" +
                "  <Param name = \"MontecarloRate\" value=\"20\" tooltip=\"The over-sampling rate that is used to generate the intial Montecarlo samples (e.g. if this parameter is &lt;i>K&lt;/i> means that&lt;i>K&lt;/i> x &lt;i>poisson sample&lt;/i> points will be used). The generated Poisson-disk samples are a subset of these initial Montecarlo samples. Larger this number slows the process but make it a bit more accurate.\" description=\"MonterCarlo OverSampling\" type=\"RichInt\"/>\n" +
                "  <Param name = \"ApproximateGeodesicDistance\" value=\"false\" tooltip=\"If true Poisson Disc distances are computed using an approximate geodesic distance, e.g. an euclidean distance weighted by a function of the difference between the normals of the two points.\" description=\"Approximate Geodesic Distance\" type=\"RichBool\"/>\n" +
                "  <Param name = \"Subsample\" value=\"true\" tooltip=\"If true the original vertices of the base mesh are used as base set of points. In this case the SampleNum should be obviously much smaller than the original vertex number.&lt;br>Note that this option is very useful in the case you want to subsample a dense point cloud.\" description=\"Base Mesh Subsampling\" type=\"RichBool\"/>\n" +
                "  <Param name = \"RefineFlag\" value=\"false\" tooltip=\"If true the vertices of the below mesh are used as starting vertices, and they will utterly refined by adding more and more points until possible. \" description=\"Refine Existing Samples\" type=\"RichBool\"/>\n" +
                "  <Param name = \"RefineMesh\" value=\"0\" tooltip=\"Used only if the above option is checked. \" description=\"Samples to be refined\" type=\"RichMesh\"/>\n" +
                "  <Param name = \"BestSampleFlag\" value=\"true\" tooltip=\"If true it will use an heuristic for choosing the samples that at a small cost can improve the maximality of the generated sampling. It can slow a bit the process. \" description=\"Best Sample Heuristic\" type=\"RichBool\"/>\n" +
                "  <Param name = \"BestSamplePool\" value=\"10\" tooltip=\"Used only if the Best Sample Flag is true. It control the number of attempt that it makes to get the best sample. It is reasonable that it is smaller than the Montecarlo oversampling factor.\" description=\"Best Sample Pool Size\" type=\"RichInt\"/>\n" +
                " </filter>\n";
            File.AppendAllText("script.mlx", sampling);
        }

        public static void collapseDecimation(string triangles)
        {
            string decimation = " <filter name=\"Quadric Edge Collapse Decimation\">\n" +
                "  <Param name=\"TargetFaceNum\" description=\"Target number of faces\" tooltip=\"The desired final number of faces.\" value=\"" + triangles + "\" type=\"RichInt\"/>\n" +
                "  <Param name=\"TargetPerc\" description=\"Percentage reduction (0..1)\" tooltip=\"If non zero, this parameter specifies the desired final size of the mesh as a percentage of the initial size.\" value=\"0\" type=\"RichFloat\"/>\n" +
                "  <Param name=\"QualityThr\" description=\"Quality threshold\" tooltip=\"Quality threshold for penalizing bad shaped faces.The value is in the range[0..1]; 0 accept any kind of face (no penalties),0.5 penalize faces with quality 0.5, proportionally to their shape\" value=\"0.3\" type=\"RichFloat\"/>\n" +
                "  <Param name=\"PreserveBoundary\" description=\"Preserve Boundary of the mesh\" tooltip=\"The simplification process tries to do not affect mesh boundaries during simplification\" value=\"false\" type=\"RichBool\"/>\n" +
                "  <Param name=\"BoundaryWeight\" description=\"Boundary Preserving Weight\" tooltip=\"The importance of the boundary during simplification.Default(1.0) means that the boundary has the same importance of the rest.Values greater than 1.0 raise boundary importance and has the effect of removing less vertices on the border. Admitted range of values (0, +inf). \" value=\"1\" type=\"RichFloat\"/>\n" +
                "  <Param name=\"PreserveNormal\" description=\"Preserve Normal\" tooltip=\"Try to avoid face flipping effects and try to preserve the original orientation of the surface\" value=\"false\" type=\"RichBool\"/>\n" +
                "  <Param name=\"PreserveTopology\" description=\"Preserve Topology\" tooltip=\"Avoid all the collapses that should cause a topology change in the mesh (like closing holes, squeezing handles, etc). If checked the genus of the mesh should stay unchanged.\" value=\"false\" type=\"RichBool\"/>\n" +
                "  <Param name=\"OptimalPlacement\" description=\"Optimal position of simplified vertices\" tooltip=\"Each collapsed vertex is placed in the position minimizing the quadric error.&#xa; It can fail (creating bad spikes) in case of very flat areas. &#xa;If disabled edges are collapsed onto one of the two original vertices and the final mesh is composed by a subset of the original vertices. \" value=\"false\" type=\"RichBool\"/>\n" +
                "  <Param name=\"PlanarQuadric\" description=\"Planar Simplification\" tooltip=\"Add additional simplification constraints that improves the quality of the simplification of the planar portion of the mesh.\" value=\"true\" type=\"RichBool\"/>\n" +
                "  <Param name=\"QualityWeight\" description=\"Weighted Simplification\" tooltip=\"Use the Per - Vertex quality as a weighting factor for the simplification. The weight is used as a error amplification value, so a vertex with a high quality value will not be simplified and a portion of the mesh with low quality values will be aggressively simplified.\" value=\"false\" type=\"RichBool\"/>\n" +
                "  <Param name=\"AutoClean\" description=\"Post - simplification cleaning\" tooltip=\"After the simplification an additional set of steps is performed to clean the mesh (unreferenced vertices, bad faces, etc)\" value=\"true\" type=\"RichBool\"/>\n" +
                "  <Param name=\"Selected\" description=\"Simplify only selected faces\" tooltip=\"The simplification is applied only to the selected set of faces.&#xa; Take care of the target number of faces!\" value=\"false\" type=\"RichBool\"/>\n" +
                " </filter>\n";
            File.AppendAllText("script.mlx", decimation);
        }

        public static void conputeNormals()
        {
            string normals = " <filter name=\"Compute normals for point sets\">\n" +
                "  <Param name=\"K\" value=\"10\" tooltip=\"The number of neighbors used to estimate normals.\" description=\"Neighbour num\" type=\"RichInt\"/>\n" +
                "  <Param name=\"smoothIter\" value=\"0\" tooltip=\"The number of smoothing iteration done on the p used to estimate and propagate normals.\" description=\"Smooth Iteration\" type=\"RichInt\"/>\n" +
                "  <Param name=\"flipFlag\" value=\"false\" tooltip=\"If the 'viewpoint'(i.e.scanner position) is known, it can be used to disambiguate normals orientation, so that all the normals will be oriented in the same direction.\" description=\"Flip normals w.r.t.viewpoint\" type=\"RichBool\"/>\n" +
                "  <Param name=\"viewPos\" x=\"0\" y=\"0\" z=\"0\" tooltip=\"The viewpoint position can be set by hand (i.e.getting the current viewpoint) or it can be retrieved from mesh camera, if the viewpoint position is stored there.\" description=\"Viewpoint Pos.\" type=\"RichPoint3f\"/>\n" +
                " </filter>\n";
            File.AppendAllText("script.mlx", normals);
        }

        public static void surfaceReconstruction(string ballRadius)
        {
            string surface = " <filter name=\"Surface Reconstruction: Ball Pivoting\">\n" +
                "  <Param name=\"BallRadius\" value=\"" + ballRadius + "\" min=\"0\" max=\"1.31592\" tooltip=\"The radius of the ball pivoting (rolling)over the set of points.Gaps that are larger than the ball radius will not be filled; similarly the small pits that are smaller than the ball radius will be filled.\" description=\"Pivoting Ball radius(0 autoguess)\" type=\"RichAbsPerc\"/>\n" +
                "  <Param name=\"Clustering\" value=\"20\" tooltip=\"To avoid the creation of too small triangles, if a vertex is found too close to a previous one, it is clustered / merged with it.\" description=\"Clustering radius (% of ball radius)\" type=\"RichFloat\"/>\n" +
                "  <Param name=\"CreaseThr\" value=\"90\" tooltip=\"If we encounter a crease angle that is too large we should stop the ball rolling\" description=\"Angle Threshold (degrees)\" type=\"RichFloat\"/>\n" +
                "  <Param name=\"DeleteFaces\" value=\"false\" tooltip=\"if true all the initial faces of the mesh are deleted and the whole surface is rebuilt from scratch, other wise the current faces are used as a starting point. Useful if you run multiple times the algorithm with an incrasing ball radius.\" description=\"Delete intial set of faces\" type=\"RichBool\"/>\n" +
                " </filter>\n";
            File.AppendAllText("script.mlx", surface);
        }

        public static void scriptEnding()
        {
            string ending = "</FilterScript>\n";
            File.AppendAllText("script.mlx", ending);
        }

        public static void nothing()
        {
            string nothing = "<!DOCTYPE FilterScript>\n";
            File.WriteAllText("nothing.mlx", nothing);
        }
    }
}
