﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Objects
{
    class ObjectMass
    {
        double mass;
        double energy;
        Point3d_GL position;
        Point3d_GL rotation;
        Point3d_GL translation_velocity;
        Point3d_GL rotation_velocity;
        Point3d_GL inertia_moment;
        Point3d_GL force_result;
        Point3d_GL moment_result;


    }

    class NativeObjs :ObjectMass
    {
        NativeObjs()
        {
           
        }
    }
}
