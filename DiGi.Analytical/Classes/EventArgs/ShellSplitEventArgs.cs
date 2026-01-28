using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;

namespace DiGi.Analytical.Classes
{
    public class ShellSplitEventArgs : EventArgs
    {
        public ShellSplitEventArgs(Shell? input, Polyhedron? polyhedron)
        {
            Input = input;
            Polyhedron = polyhedron;
        }

        public bool Handled { get; set; } = false;

        public Shell? Input { get; }

        public Polyhedron? Polyhedron { get; }

        public IUniqueReference? UniqueReference { get; set; }
    }
}