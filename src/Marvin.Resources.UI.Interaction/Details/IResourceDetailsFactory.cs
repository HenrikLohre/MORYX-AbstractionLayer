// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Marvin.AbstractionLayer.UI;
using Marvin.Container;

namespace Marvin.Resources.UI.Interaction
{
    /// <summary>
    /// Factory to create a <see cref="IResourceDetails"/> view model for the given resource type name
    /// </summary>
    [PluginFactory(typeof(ResourceDetailsComponentSelector))]
    internal interface IResourceDetailsFactory : IDetailsFactory<IResourceDetails>
    {

    }
}
