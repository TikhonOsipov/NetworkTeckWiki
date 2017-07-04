using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlevonProject
{
    /// <summary>
    /// Consists of paths to annotation, Profile and Extended Profile
    /// </summary>
    class ArticleSet
    {
        public string annotationPath { get; private set; }
        public string profilePath { get; private set; }
        public string extendedProfilePath { get; private set; }

        public ArticleSet(string annotationPath, string profilePath, string extendedProfilePath)
        {
            this.annotationPath = annotationPath;
            this.profilePath = profilePath;
            this.extendedProfilePath = extendedProfilePath;
        }
    }
}
