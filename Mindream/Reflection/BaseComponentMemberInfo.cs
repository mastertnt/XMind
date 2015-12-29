﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindream.Reflection
{
    public class BaseComponentMemberInfo : IComponentMemberInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name of the component member info.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the position of the component member info.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public int Position
        {
            get
            {
                return -1;
            }
        }

        /// <summary>
        /// Gets or sets the type of the component member info.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public Type Type
        {
            get;
            private set;
        }

        #endregion // Properties.

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseComponentMemberInfo" /> class.
        /// </summary>
        /// <param name="pName">Name of the component info.</param>
        /// <param name="pType">Type of the component info.</param>
        public BaseComponentMemberInfo(string pName, Type pType)
        {
            this.Name = pName;
            this.Type = pType;
        }

        #endregion // Constructors.

        #region Methods

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="pInstance">The instance to modify.</param>
        /// <param name="pNewValue">The value of component member info.</param>
        public void SetValue(IComponent pInstance, object pNewValue)
        {
            pInstance[this.Name] = pNewValue;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns>The value of the component member info.</returns>
        public object GetValue(IComponent pInstance)
        {
            return pInstance[this.Name];
        }

        #endregion // Methods.
    }
}
