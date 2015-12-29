﻿using System;
using Mindream.Attributes;

namespace Mindream.Components.Debug
{
    /// <summary>
    ///     The PrintString node serves as a simple way to display a string in the console.
    /// </summary>
    [FunctionComponent]
    public class PrintString : AComponent
    {
        #region Inputs

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="PrintString" /> is condition.
        /// </summary>
        /// <value>
        ///     <c>true</c> if condition; otherwise, <c>false</c>.
        /// </value>
        //[Input]
        public string String { get; set; }

        #endregion // Inputs

        #region Events

        /// <summary>
        ///     This event is raised when a false is computed.
        /// </summary>
        public event ComponentReturnDelegate End;

        #endregion // Events.

        #region Methods

        /// <summary>
        ///     This method is called to start the component.
        /// </summary>
        protected override void ComponentStarted()
        {
            this.Stop();
        }

        /// <summary>
        ///     This method is called to start the component.
        /// </summary>
        protected override void ComponentStopped()
        {
            if (this.End != null)
            {
                this.End();
            }
        }

        #endregion // Methods
    }
}
