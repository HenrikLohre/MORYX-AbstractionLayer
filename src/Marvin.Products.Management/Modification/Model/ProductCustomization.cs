// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Marvin.Products.Management.Modification
{
    [DataContract]
    internal class ProductCustomization
    {
        [DataMember]
        public ProductTypeModel[] ProductTypes { get; set; }

        [DataMember]
        public RecipeTypeModel[] RecipeTypes { get; set; }

        [DataMember]
        public ProductImporter[] Importers { get; set; }
    }
}
