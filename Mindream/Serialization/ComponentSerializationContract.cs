﻿using System.Linq;
using System.Xml.Linq;
using Mindream.Components;
using XSerialization;
using XSerialization.Defaults;

namespace Mindream.Serialization
{
    /// <summary>
    ///     This class defines a serialization contract for TimeSpan.
    /// </summary>
    public class TimeSpanSerializationContract : AObjectSerializationContract<IComponent>
    {
        private ComponentDescriptorRegistry mRegistry;

        /// <summary>
        ///     Creates the specified element.
        /// </summary>
        /// <param name="pElement">The element.</param>
        /// <param name="pSerializationContext">The serialization context.</param>
        /// <returns></returns>
        public override object Create(XElement pElement, IXSerializationContext pSerializationContext)
        {
            var lDescriptorAttribute = pElement.Attribute("Descriptor");
            if (lDescriptorAttribute != null)
            {
                if (this.mRegistry == null)
                {
                    this.mRegistry = new ComponentDescriptorRegistry();
                    this.mRegistry.FindAllDescriptors();
                }

                var lDescriptor = this.mRegistry.Descriptors.FirstOrDefault(pDescriptor => pDescriptor.Id == lDescriptorAttribute.Value);
                return lDescriptor.Create();
            }
            return null;
        }

        /// <summary>
        ///     This method writes the specified object.
        /// </summary>
        /// <param name="pObject">The object to serialize.</param>
        /// <param name="pParentElement">The parent element.</param>
        /// <param name="pSerializationContext">The serialization context.</param>
        /// <returns>The modified parent element</returns>
        public override XElement Write(object pObject, XElement pParentElement, IXSerializationContext pSerializationContext)
        {
            var lComponent = pObject as AComponent;
            pParentElement.SetAttributeValue("Descriptor", lComponent.Descriptor.Id);
            return base.Write(pObject, pParentElement, pSerializationContext);
        }
    }
}