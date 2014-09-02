﻿using Orchard.UI.Resources;

namespace Themes.VanityFayreHairDesign.Theme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("Bootstrap").SetUrl("Bootstrap/bootstrap.min.js").SetVersion("3.1.1");
            manifest.DefineStyle("Bootstrap").SetUrl("Bootstrap/bootstrap.min.css").SetVersion("3.1.1");
        }
    }
}
