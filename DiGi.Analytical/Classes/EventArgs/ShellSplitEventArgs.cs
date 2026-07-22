using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides the event data for shell splitting operations.
    /// <para>A handler decides which <see cref="IUniqueReference"/> the shell created out of <see cref="Polyhedron"/> receives and sets <see cref="Handled"/> to true. When no handler sets it, the solver falls back to the reference of <see cref="Input"/>, so that every part of a split space points back at the space it came from.</para>
    /// </summary>
    public class ShellSplitEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShellSplitEventArgs" /> class.
        /// </summary>
        /// <param name="input">The <see cref="Shell" /> that is being split.</param>
        /// <param name="polyhedron">The <see cref="Polyhedron" /> used to perform the split operation.</param>
        public ShellSplitEventArgs(Shell? input, Polyhedron? polyhedron)
        {
            Input = input;
            Polyhedron = polyhedron;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the shell split event has been handled.
        /// </summary>
        public bool Handled { get; set; } = false;

        /// <summary>
        /// Gets the <see cref="Shell" /> used as the input for the split operation.
        /// </summary>
        public Shell? Input { get; }

        /// <summary>
        /// Gets the <see cref="Polyhedron" /> involved in the shell splitting operation.
        /// </summary>
        public Polyhedron? Polyhedron { get; }

        /// <summary>
        /// Gets or sets the unique reference associated with the shell split event.
        /// </summary>
        public IUniqueReference? UniqueReference { get; set; }
    }
}