# Mesh4BIM
Convert Point Cloud to Mesh3D for Revit

## Synopsis
The performance of Revit while working with Point Clouds can be increased.With Mesh4BIM, PTX or PTS datasets are processed and converted into polygon meshes automatically. So it also increases the accuracy of the geometric shapes of the Point Cloud.

## Introduction
Currently in the construction industry, laser scanners are being used to perform surveys of various works, especially of large buildings. With these laser scanners, surveys of the highest precision are obtained, and the result is a Point Cloud, made up of millions of dots, representing the exact geometric construction forms relieved.

These Point Clouds are stored in files that have a size of several gigabytes. Then, the interest lays in creating a BIM model from these Point Cloud, to manage the entire lifecycle of the building, from remodeling to Facility Management.

AutoDesk Revit platform can import these Point Clouds, which are then taken as a reference for modeling architectural and structural elements of the BIM model. However, the performance of work with hundreds of millions of points is very low, and the software becomes unstable and may cause unexpected shutdowns. Redraw views of work can take several minutes even for the newest of computers.

Another problem that arises is that Point Clouds do not provide certainty about the geometric shapes of the project components, and may create confusion due to varying density and low work performance.

## Work Objectives
It is proposed to process the Point Cloud’s dataset and turn it into polygon mesh, reducing hundreds of millions of points to only tens of thousands of points, and increase the work performance with Autodesk Revit.

The processing of Point Clouds is performed with the MeshLab (free and open source) software, using different sampling and reconstruction algorithms, using various automatic scripts prepared by the author of this work.

To prevent construction professionals from having to process Point Clouds with complex algorithms and repeated procedures, it created an Application in C# that performs all processes automatically in the background. This App is called Mesh4BIM.

After processing Point Clouds, polygon meshes are obtained, as files in DXF format, with the following benefits:

- Reduction of the number of points and size of work files (about 1% final).
- Precise geometric shapes, increasing accuracy for BIM modeling.
- High work performance with Autodesk Revit, avoiding instability and unexpected shutdowns.
