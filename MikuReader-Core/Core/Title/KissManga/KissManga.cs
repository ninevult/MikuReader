using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MikuReader.Core
{
    /// <summary>
    /// Representation of a Manga
    /// </summary>
    public class KissManga : Manga
    {
        private string id;
        private string name;
        private string userlang;
        private string usergroup;
        private string usertitle;
        private string currentchapter;
        private string currentpage;
        private string lastchapter;

        private List<Chapter> chapters;
        private DirectoryInfo mangaRoot;

        /// <summary>
        /// Create a new Manga when the files exist
        /// </summary>
        /// <param name="location">Root directory for this Manga</param>
        public KissManga(DirectoryInfo location)
        {
            this.mangaRoot = location;
            chapters = new List<Chapter>();
            _Load(true);
        }

        /// <summary>
        /// Create a new manga and its files
        /// </summary>
        /// <param name="location">Root directory for this Manga</param>
        /// <param name="mangaUrl">MangaDex URL</param>
        public KissManga(DirectoryInfo location, string mangaUrl)
        {
            this.mangaRoot = location;
            chapters = new List<Chapter>();
            _Create(mangaUrl);
            _Load(true);
        }

        /// <summary>
        /// Loads Manga info from manga.txt
        /// </summary>
        public override void _Load(bool doChapters)
        {
            string input = File.ReadAllText(FileHelper.GetFilePath(mangaRoot, "manga.json"));
            MangaInfo info = JsonConvert.DeserializeObject<MangaInfo>(input);

            id = info.Id;
            name = info.Name;
            userlang = info.LangCode;
            usergroup = info.Group;
            usertitle = info.UserName;
            currentchapter = info.Chapter;
            currentpage = info.Page;
            lastchapter = info.Latest;

            if (doChapters)
                _PopulateChapters();
        }

        /// <summary>
        /// Creates manga.txt, then calls Load()
        /// </summary>
        /// <param name="mangaUrl"></param>
        public override void _Create(string mangaUrl)
        {
            id = mangaUrl;
            string title = KissMangaHelper.GetName(mangaUrl);
            string lang_code = "gb"; // Not that it matters for KissManga

            FileHelper.CreateFolder(FileHelper.APP_ROOT, KissMangaHelper.GetUrlName(mangaUrl));

            MangaInfo info = new MangaInfo()
            {
                Type = "manga",
                Source = "kissmanga",
                Id = KissMangaHelper.GetUrlName(mangaUrl),
                Name = title,
                LangCode = lang_code,
                Group = "^any-group",
                UserName = title,
                Chapter = "1",
                Page = "1",
                Latest = "1"
            };

            string output = JsonConvert.SerializeObject(info);
            File.WriteAllText(Path.Combine(mangaRoot.FullName, "manga.json"), output);

            _Load(false);
            GetSetPrunedChapters(true);
        }

        public override Chapter[] GetSetPrunedChapters(bool overrideDlc)
        {
            chapters.Clear();
            
            List<Chapter> result = new List<Chapter>();

            String[] dlc = GetDLChapters();
            bool doFullSetup;

            if (!overrideDlc)
            {
                doFullSetup = true;
            }
            else // override
            {
                doFullSetup = false;
            }

            foreach (string chapterUrl in KissMangaHelper.GetChapterUrls(KissMangaHelper.KISS_URL + "/manga/" + mangaRoot.Name))
            {
                string[] urlSplits = chapterUrl.Split('/');
                string chapID = urlSplits[urlSplits.Length - 1];
                string chapNum = chapID.Substring(8); // remove "chapter_"
                if ((!doFullSetup) || (doFullSetup && dlc == null) || (doFullSetup && dlc[0].Equals("-1")) || (doFullSetup && dlc.Contains(chapNum)))
                {                    
                    DirectoryInfo chapDir = null; // Only create folder if doing full setup
                    if (doFullSetup)
                        chapDir = FileHelper.CreateFolder(mangaRoot, chapID);
                    Chapter newchapter = new Chapter(chapDir, chapID, chapNum, doFullSetup);
                    chapters.Add(newchapter);
                    result.Add(newchapter);
                }
            }

            chapters = result;
            return result.ToArray();
        }

        public override Chapter[] GetUpdates()
        {
            List<Chapter> result = new List<Chapter>();

            String[] dlc = GetDLChapters();
            bool doFullSetup = true;

            foreach (string chapterUrl in KissMangaHelper.GetChapterUrls(KissMangaHelper.KISS_URL + "/manga/" + mangaRoot.Name))
            {
                string[] urlSplits = chapterUrl.Split('/');
                string chapID = urlSplits[urlSplits.Length - 1];
                string chapNum = chapID.Substring(8); // remove "chapter_"
                if ((!doFullSetup) || (doFullSetup && dlc == null) || (doFullSetup && dlc[0].Equals("-1")) || (doFullSetup && dlc.Contains(chapNum)))
                {
                    if (!Directory.Exists(Path.Combine(mangaRoot.FullName, chapID)))
                    {
                        DirectoryInfo chapDir = FileHelper.CreateFolder(mangaRoot, chapID);
                        Chapter newchapter = new Chapter(chapDir, chapID, chapNum, doFullSetup);
                        chapters.Add(newchapter);
                        result.Add(newchapter);
                    }
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Get the groups associated with this manga
        /// </summary>
        /// <param name="langCode">Language to select group from</param>
        /// <returns>List of groups associated with the language</returns>
        public override string[] GetGroups(string langCode)
        {
            return null;
        }

        public override string[] GetLangs()
        {
            return null;
        }

        /// <summary>
        /// Get the user's specified language
        /// </summary>
        public override string GetUserLang() => userlang;

        /// <summary>
        /// Get the user's specified Group
        /// </summary>
        public override string GetUserGroup() => usergroup;

        /// <summary>
        /// Create a Chapter for each chapter and add it to the chapter list
        /// </summary>
        public override void _PopulateChapters()
        {
            foreach (DirectoryInfo di in FileHelper.GetDirs(mangaRoot))
            {
                chapters.Add(new Chapter(di));
            }
        }

        public override void UpdateLocation(string chapter, string page)
        {
            this.currentchapter = chapter;
            this.currentpage = page;
        }

        public override void Save(string chapter, string page)
        {
            this.currentchapter = chapter;
            this.currentpage = page;

            MangaInfo info = new MangaInfo()
            {
                Type = "manga",
                Source = "kissmanga",
                Id = mangaRoot.Name,
                Name = name,
                LangCode = userlang,
                Group = usergroup,
                UserName = usertitle,
                Chapter = chapter,
                Page = page,
                Latest = lastchapter
            };

            string output = JsonConvert.SerializeObject(info);
            File.WriteAllText(Path.Combine(mangaRoot.FullName, "manga.json"), output);
        }

        public override void UpdateProperties(string title, string lang, string group)
        {
            this.usertitle = title;
            this.userlang = lang;
            if (group == "{Any}") this.usergroup = "^any-group"; else this.usergroup = group;
            Save(currentchapter, currentpage);
        }

        public override string GetTitle()
        {
            return this.name;
        }

        public override string GetUserTitle()
        {
            return this.usertitle;
        }

        public override List<Chapter> GetChapters()
        {
            return chapters;
        }

        public override string GetCurrentChapter()
        {
            return currentchapter;
        }

        public override string GetCurrentPage()
        {
            return currentpage;
        }

        public override string GetID()
        {
            return id;
        }

        public override bool IsDownloading()
        {
            FileInfo[] files = FileHelper.GetFiles(mangaRoot);
            foreach (FileInfo f in files)
                if (f.Name.StartsWith("dl"))
                    return true;
            return false;
        }

        public override void UpdateDLChapters(String[] chapterNums)
        {
            using (StreamWriter file = new StreamWriter(Path.Combine(mangaRoot.FullName, "cdl.txt")))
            {
                foreach (String num in chapterNums)
                {
                    file.WriteLine(num);
                }
            }
        }

        public override String[] GetDLChapters()
        {
            if (File.Exists(Path.Combine(mangaRoot.FullName, "cdl.txt")))
                return File.ReadAllLines(Path.Combine(mangaRoot.FullName, "cdl.txt"));
            else
                return null;
        }

    }
}
