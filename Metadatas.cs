using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConversionHexadecimal_Others
{
    class Metadatas
    {
        #region Variables

        private FileInfo _infoOfFile;
        private string _name;
        private int _hourUTC;
        private DateTime _creationTime;
        private DateTime _lastWriteTime;
        private DateTime _lastAccessTime;
        private string _shortName;
        private string _attributs;
        private long _fileSize;
        
        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                return _lastWriteTime;
            }
        }

        public DateTime LastAccessTime
        {
            get
            {
                return _lastAccessTime;
            }
        }

        public string Attributs
        {
            get
            {
                return _attributs;
            }
        }

        public long FileSize
        {
            get
            {
                return _fileSize;
            }
        }

        public string ShortName
        {
            get
            {
                return _shortName;
            }
        }

        public int HourUTC
        {
            get
            {
                return _hourUTC;
            }
        }

        #endregion
        
        #region Methods

        public Metadatas(string filename) : this(filename, 1) //1 -> Suisse
        { }

        public Metadatas(string filename, int hourUTC)
        {
            _infoOfFile = new FileInfo(filename);
            _hourUTC = hourUTC;
            _name = _infoOfFile.Name;
            _creationTime = _infoOfFile.CreationTimeUtc.AddHours(HourUTC);
            _lastWriteTime = _infoOfFile.LastWriteTimeUtc.AddHours(HourUTC);
            _lastAccessTime = _infoOfFile.LastAccessTimeUtc.AddHours(HourUTC);
            _attributs = GetLetterOfAttributs(_infoOfFile.Attributes.ToString().Split(','));
            _fileSize = _infoOfFile.Length;
            _shortName = ConvertToDOSFileName(_infoOfFile.Name, _infoOfFile.Extension).ToUpper();
        }

        private static string ConvertToDOSFileName(string myStr, string extension)
        {
            if (myStr.Length > 7)
                return myStr.Substring(0, 6) + @"~1" + extension;
            return myStr + extension;
        }

        private static string GetLetterOfAttributs(string[] listAttributs)
        {
            string returnValue = "";
            string temp;
            foreach (string item in listAttributs)
            {
                temp = item.Trim();
                if (temp == "NotContentIndexed")
                {
                    returnValue += "NCI ";
                }
                else if (temp == "SparseFile")
                {
                    returnValue += "SF ";
                }
                else if (temp == "ReparsePoint")
                {
                    returnValue += "RP ";
                }
                else
                {
                    returnValue += temp[0] + " ";
                }
            }
            return returnValue;
        }
        
        #endregion
    }
}
