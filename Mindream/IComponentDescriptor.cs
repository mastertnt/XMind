﻿using System.Collections.Generic;
using System.Reflection;

namespace Mindream
{
    /// <summary>
    /// This delegate represents the end of a method (by default, just a simple return).
    /// </summary>
    public delegate void MethodEnd();

    /// <summary>
    /// This interface describes a component descriptor.
    /// A component descriptor can instanciate a component.
    /// </summary>
    public interface IComponentDescriptor
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets the inputs.
        /// </summary>
        /// <value>
        /// The inputs.
        /// </value>
        List<IComponentMemberInfo> Inputs { get; }

        /// <summary>
        /// Gets the outputs.
        /// </summary>
        /// <value>
        /// The outputs.
        /// </value>
        List<IComponentMemberInfo> Outputs { get; }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>
        /// The results (By default, the result is ended).
        /// </value>
        List<MethodEnd> Results { get; }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <returns>The created instance of the component.</returns>
        IComponent Create();
    }
}
