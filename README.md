# Physarum3D

Building on [Barbelot's 3D Physarum](https://github.com/Barbelot/Physarum3D)
No longer requires setup steps. Added some test scenes, one with particles, the other with geo. 
Added VR support, some extra parameters, and started messing with some of the math.

Unity implementation of the [Physarum Transport Network](https://www.mitpressjournals.org/doi/abs/10.1162/artl.2010.16.2.16202) from Jeff Jones in 3D.


## Samples:

![Solid](https://github.com/miketucker/Physarum3D/raw/master/Screenshots/physarum4c.gif?raw=true)

![Particles](https://github.com/miketucker/Physarum3D/raw/master/Screenshots/physarum5b.gif?raw=true)

# Technical Details

The particles positions and trail volume are computed with compute shaders.

The particles are displayed using Unity Visual Effect Graph and the HDRP pipeline.
The trail volume can be displayed through volumetric rendering using the VolumeRayCast shader.

Tested with Unity 2019.3.7f1 and the corresponding HDRP/VFX Graph packages.

# Acknowledgments

- [Sage Jenson](https://sagejenson.com/) for the helpful discussions
- DenizBicer for the [2D implementation](https://github.com/DenizBicer/Physarum) in Unity
- Scrawk for the [GPU-GEMS-3D-Fluid-Simulation](https://github.com/Scrawk/GPU-GEMS-3D-Fluid-Simulation)
