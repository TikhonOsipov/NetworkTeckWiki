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
            articleSets.Add(generateArticleSet(@"MIMO(AN).docx", @"MIMO(PR).docx", @"MIMO(ExtPR).docx")); //MIMO
            articleSets.Add(generateArticleSet(@"M2M(AN).docx", @"M2M(PR).docx", @"M2M(ExtPR).docx")); //M2M
            articleSets.Add(generateArticleSet(@"Kvantovye_kommunikatsii(AN).docx", @"Kvantovye_kommunikatsii(PR).docx", @"Kvantovye_kommunikatsii(ExtPR).docx")); //QC

            articleSets.Add(generateArticleSet(@"USN(AN).docx", @"USN(PR).docx", @"USN(ExtPR).docx")); //USN
            articleSets.Add(generateArticleSet(@"RFID(AN).docx", @"RFID(PR).docx", @"RFID(ExtPR).docx")); //RFID
            //articleSets.Add(generateArticleSet(@"Kvantovye_kommunikatsii(AN).docx", @"Kvantovye_kommunikatsii(PR).docx", @"Kvantovye_kommunikatsii(ExtPR).docx")); //QC
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
