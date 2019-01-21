using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using SendSMS.Models;

namespace SendSMS
{
    using System.Linq;

    using SendSMS.Data;

    class Utils
    {
        public static List<Contact> ImportFromDump(string dumpFile)
        {
            string text = File.ReadAllText(dumpFile, Encoding.GetEncoding(1251));
            const string Pattern = @"(?:8|\+7)? ?\(?(\d{3})\)? ?(\d{3})[ -]?(\d{2})[ -]?(\d{2})";

            var rx = new Regex(Pattern);
            var ms = rx.Matches(text);
            return (from Match m in ms select new Contact { Phone = Int64.Parse(m.Value).ToString() }).Distinct().ToList();
        }

        public static List<Contact> ImportFromCsv(string file)
        {
            var list = new List<Contact>();
            string[] lines = File.ReadAllLines(file, Encoding.GetEncoding(1251));
            foreach (var line in lines)
            {
                string[] strings = line.Split(';');
                var c = new Contact
                    {
                        Group = new Models.Group { Name = strings[0] },
                        Phone = strings[1],
                        LastName = strings[2],
                        FirstName = strings[3],
                        Patronymic = strings[4],
                        Sex = TryParse(strings[5]) ?? 0,
                    };

                if (!string.IsNullOrEmpty(strings[6]))
                {
                    string[] date = strings[6].Split('.');
                    if (!string.IsNullOrEmpty(date[0]))
                    {
                        c.BirthdayDay = TryParse(date[0]);
                    }
                    if (!string.IsNullOrEmpty(date[1]))
                    {
                        c.BirthdayMonth = TryParse(date[1]);
                    }
                    if (!string.IsNullOrEmpty(date[2]))
                    {
                        c.BirthdayYear = TryParse(date[2]);
                    }
                }
                list.Add(c);
            }

            return list.Distinct().ToList();

        }

        public static void BackupDatabase()
        {
            if (!Directory.Exists("Backup"))
                Directory.CreateDirectory("Backup");
            File.Copy(DbManager.DatabaseFileName, @"Backup\" + DbManager.DatabaseFileName + "_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".db");
        }

        public static string TranslitText(string text, bool backToRussian = false)
        {
            var strArray1 = new[]
      {
        "ё",
        "ж",
        "й",
        "х",
        "щ",
        "ш",
        "ч",
        "э",
        "ю",
        "я",
        "а",
        "б",
        "в",
        "г",
        "д",
        "е",
        "з",
        "и",
        "к",
        "л",
        "м",
        "н",
        "о",
        "п",
        "р",
        "с",
        "т",
        "у",
        "ф",
        "ц",
        "ъ",
        "ы",
        "ь",
        "Ё",
        "Ж",
        "Й",
        "Х",
        "Щ",
        "Ш",
        "Ч",
        "Э",
        "Ю",
        "Я",
        "А",
        "Б",
        "В",
        "Г",
        "Д",
        "Е",
        "З",
        "И",
        "К",
        "Л",
        "М",
        "Н",
        "О",
        "П",
        "Р",
        "С",
        "Т",
        "У",
        "Ф",
        "Ц",
        "Ъ",
        "Ы",
        "Ь"
      };
            var strArray2 = new[]
      {
        "jo",
        "zh",
        "jj",
        "kh",
        "shh",
        "sh",
        "ch",
        "je",
        "ju",
        "ja",
        "a",
        "b",
        "v",
        "g",
        "d",
        "e",
        "z",
        "i",
        "k",
        "l",
        "m",
        "n",
        "o",
        "p",
        "r",
        "s",
        "t",
        "u",
        "f",
        "c",
        "\"",
        "y",
        "'",
        "Jo",
        "Zh",
        "Jj",
        "Kh",
        "Shh",
        "Sh",
        "Ch",
        "Je",
        "Ju",
        "Ja",
        "A",
        "B",
        "V",
        "G",
        "D",
        "E",
        "Z",
        "I",
        "K",
        "L",
        "M",
        "N",
        "O",
        "P",
        "R",
        "S",
        "T",
        "U",
        "F",
        "C",
        "\"",
        "Y",
        "'"
      };
            string str = text;
            for (int index = 0; index < strArray1.Length; ++index)
                str = !backToRussian ? str.Replace(strArray1[index], strArray2[index]) : str.Replace(strArray2[index], strArray1[index]);
            return str;
        }

        public static string TranslitChar(string character)
        {
            return (string)new Hashtable
                               {
        {
          "а",
          "a"
        },
        {
          "б",
          "b"
        },
        {
          "в",
          "v"
        },
        {
          "г",
          "g"
        },
        {
          "д",
          "d"
        },
        {
          "е",
          "e"
        },
        {
          "ё",
          "jo"
        },
        {
          "ж",
          "zh"
        },
        {
          "з",
          "z"
        },
        {
          "и",
          "i"
        },
        {
          "й",
          "jj"
        },
        {
          "к",
          "k"
        },
        {
          "л",
          "l"
        },
        {
          "м",
          "m"
        },
        {
          "н",
          "n"
        },
        {
          "о",
          "o"
        },
        {
          "п",
          "p"
        },
        {
          "р",
          "r"
        },
        {
          "с",
          "s"
        },
        {
          "т",
          "t"
        },
        {
          "у",
          "u"
        },
        {
          "ф",
          "f"
        },
        {
          "х",
          "kh"
        },
        {
          "ц",
          "c"
        },
        {
          "ч",
          "ch"
        },
        {
          "ш",
          "sh"
        },
        {
          "щ",
          "shh"
        },
        {
          "ъ",
          "\""
        },
        {
          "ы",
          "y"
        },
        {
          "ь",
          "'"
        },
        {
          "э",
          "je"
        },
        {
          "ю",
          "ju"
        },
        {
          "я",
          "ja"
        },
        {
          "А",
          "A"
        },
        {
          "Б",
          "B"
        },
        {
          "В",
          "V"
        },
        {
          "Г",
          "G"
        },
        {
          "D",
          "Д"
        },
        {
          "Е",
          "E"
        },
        {
          "Ё",
          "Jo"
        },
        {
          "Ж",
          "Zh"
        },
        {
          "З",
          "Z"
        },
        {
          "И",
          "I"
        },
        {
          "Й",
          "Jj"
        },
        {
          "К",
          "K"
        },
        {
          "Л",
          "L"
        },
        {
          "М",
          "M"
        },
        {
          "Н",
          "N"
        },
        {
          "О",
          "O"
        },
        {
          "П",
          "P"
        },
        {
          "Р",
          "R"
        },
        {
          "С",
          "S"
        },
        {
          "Т",
          "T"
        },
        {
          "У",
          "U"
        },
        {
          "Ф",
          "F"
        },
        {
          "Х",
          "Kh"
        },
        {
          "Ц",
          "C"
        },
        {
          "Ч",
          "Ch"
        },
        {
          "Ш",
          "Sh"
        },
        {
          "Щ",
          "Shh"
        },
        {
          "Ъ",
          "\""
        },
        {
          "Ы",
          "Y"
        },
        {
          "Ь",
          "'"
        },
        {
          "Э",
          "Je"
        },
        {
          "Ю",
          "Ju"
        },
        {
          "Я",
          "Ja"
        }
      }[character] ?? character;
        }


        private static int? TryParse(string val)
        {
            try
            {
                return Int32.Parse(val);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

}
