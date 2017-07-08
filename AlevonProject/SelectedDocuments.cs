using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlevonProject
{
    class SelectedDocuments
    {
        private static SelectedDocuments instance = null;
        private List<ArticleSet> articleSets;
        private int selectedArticleIndex = 0;

        public string selectedAnnotation {
            get { return articleSets[selectedArticleIndex].annotationPath; }
            private set { }
        }

        public string selectedProfile
        {
            get { return articleSets[selectedArticleIndex].profilePath; }
            private set { }
        }

        public string selectedExtendedProfile
        {
            get { return articleSets[selectedArticleIndex].extendedProfilePath; }
            private set { }
        }

        //this constructor can not be called outside
        private SelectedDocuments()
        {
            articleSets = new List<ArticleSet>();
            articleSets.Add(generateArticleSet(@"MIMO(AN).pdf", @"MIMO(PR).pdf", @"MIMO(ExtPR).pdf")); //MIMO
            articleSets.Add(generateArticleSet(@"M2M(AN).pdf", @"M2M(PR).pdf", @"M2M(ExtPR).pdf")); //M2M
            articleSets.Add(generateArticleSet(@"Kvantovye_kommunikatsii(AN).pdf", @"Kvantovye_kommunikatsii(PR).pdf", @"Kvantovye_kommunikatsii(ExtPR).pdf")); //QC

            articleSets.Add(generateArticleSet(@"USN(AN).pdf", @"USN(PR).pdf", @"USN(ExtPR).pdf")); //USN
            articleSets.Add(generateArticleSet(@"RFID(AN).pdf", @"RFID(PR).pdf", @"RFID(ExtPR).pdf")); //RFID

            articleSets.Add(generateArticleSet(@"LTE(AN).pdf", @"LTE(PR).pdf", @"LTE(ExtPR).pdf")); //LTE
            articleSets.Add(generateArticleSet(@"LTEadvanced(AN).pdf", @"LTEadvanced(PR).pdf", @"LTEadvanced(ExtPR).pdf")); //LTEadvanced

            articleSets.Add(generateArticleSet(@"GLONASS(AN).pdf", @"GLONASS(PR).pdf", @"GLONASS(ExtPR).pdf")); //GLONASS
            articleSets.Add(generateArticleSet(@"NSN(AN).pdf", @"NSN(PR).pdf", @"NSN(ExtPR).pdf")); //NSN
        }

        public void setArticleIndex(int index)
        {
            selectedArticleIndex = index;
        }

        public void increaseArticleIndex()
        {
            int articleSetsSize = articleSets.Count;
            selectedArticleIndex++;
            if (selectedArticleIndex >= articleSetsSize) selectedArticleIndex = 0;
        }

        public void decreaseArticleIndex()
        {
            int articleSetsSize = articleSets.Count;
            selectedArticleIndex--;
            if (selectedArticleIndex < 0) selectedArticleIndex = articleSetsSize - 1;
        }

        private ArticleSet generateArticleSet(string annotationName, string profileName, string extendedProfileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"..\..\Resources\";
            string annotationsPath = path + @"annotations\";
            string profilesPath = path + @"profiles\";
            string extendedProfilesPath = path + @"extendedProfiles\";
            return new ArticleSet(
                annotationsPath + annotationName, 
                profilesPath + profileName, 
                extendedProfilesPath + extendedProfileName);
        }
        
        //this is singleton getInstance() method
        public static SelectedDocuments getInstance()
        {
            if(instance == null)
            {
                instance = new SelectedDocuments();
            }
            return instance;
        }
    }
}
