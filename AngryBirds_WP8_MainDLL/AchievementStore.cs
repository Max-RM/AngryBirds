using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal class AchievementStore
{
	public class Entry
	{
		public string Key;

		public string Name;

		public string Description;

		public int Score;

		public bool Earned;

		public string EarnedAt;
	}

	private static AchievementStore m_instance;

	private List<Entry> m_entries = new List<Entry>();

	public static AchievementStore I()
	{
		if (m_instance == null)
		{
			m_instance = new AchievementStore();
			m_instance.Load();
		}
		return m_instance;
	}

	private AchievementStore()
	{
		Add("Woodpecker", "Woodpecker", "Destroy 5000 wooden blocks.", 10);
		Add("Stonecutter", "Stonecutter", "Destroy 5000 stone blocks.", 10);
		Add("Icepicker", "Icepicker", "Destroy 5000 ice blocks.", 10);
		Add("Pig Popper", "Pig Popper", "Pop 1000 pigs.", 10);
		Add("Block Smasher", "Block Smasher", "Deal 50000 points of damage to blocks.", 20);
		Add("Smash Maniac", "Smash Maniac", "Deal 250000 points of damage to blocks.", 30);
		Add("Egg Hunter", "Egg Hunter", "Find 10 golden eggs.", 10);
		Add("Split it", "Split it", "Split into three with the blue bird.", 10);
		Add("Speed is the Essence", "Speed is the Essence", "Dash with the yellow bird.", 10);
		Add("Boom Boom", "Boom Boom", "Explode with the black bird.", 10);
		Add("Mother of all Bombs", "Mother of all Bombs", "Drop the egg bomb with the white bird.", 10);
		Add("Return to Sender", "Return to Sender", "Boomerang back with the green bird.", 10);
		Add("Seeing Red", "Seeing Red", "Bash through with the big brother bird.", 10);
		Add("Just Getting Started", "Just Getting Started", "Complete every level of the first pack.", 5);
		Add("Defeat of The King", "Defeat of The King", "Complete every level of the third pack.", 5);
		Add("The Mysterious Escape", "The Mysterious Escape", "Complete every level of the fifth pack.", 5);
		Add("Green Baron", "Green Baron", "Complete every level of the eighth pack.", 5);
		Add("Episode 1 Total Destruction", "Episode 1 Total Destruction", "Get three stars in every level of the first episode.", 10);
		Add("Episode 2 Total Destruction", "Episode 2 Total Destruction", "Get three stars in every level of the second episode.", 5);
		Add("Episode 3 Total Destruction", "Episode 3 Total Destruction", "Get three stars in every level of the third episode.", 5);
	}

	private void Add(string key, string name, string description, int score)
	{
		Entry entry = new Entry();
		entry.Key = key;
		entry.Name = name;
		entry.Description = description;
		entry.Score = score;
		entry.Earned = false;
		entry.EarnedAt = "";
		m_entries.Add(entry);
	}

	public List<Entry> Entries
	{
		get
		{
			return m_entries;
		}
	}

	public Entry Find(string key)
	{
		foreach (Entry entry in m_entries)
		{
			if (entry.Key == key)
			{
				return entry;
			}
		}
		return null;
	}

	public bool IsEarned(string key)
	{
		Entry entry = Find(key);
		return entry != null && entry.Earned;
	}

	public int EarnedCount()
	{
		int num = 0;
		foreach (Entry entry in m_entries)
		{
			if (entry.Earned)
			{
				num++;
			}
		}
		return num;
	}

	public int TotalScore()
	{
		int num = 0;
		foreach (Entry entry in m_entries)
		{
			num += entry.Score;
		}
		return num;
	}

	public void Award(string key)
	{
		Entry entry = Find(key);
		if (entry != null && !entry.Earned)
		{
			entry.Earned = true;
			entry.EarnedAt = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
			Save();
		}
	}

	public static string FilePath()
	{
		return Path.Combine(AppContext.BaseDirectory, "achievements.json");
	}

	public void Load()
	{
		try
		{
			string text = ReadAllText(FilePath());
			if (text != null && text.Length > 0)
			{
				ParseJson(text);
			}
			else
			{
				Save();
			}
		}
		catch
		{
		}
	}

	public void Save()
	{
		try
		{
			WriteAllText(FilePath(), ToJson());
		}
		catch
		{
		}
	}

	private static string ReadAllText(string path)
	{
		try
		{
			using (StreamReader streamReader = new StreamReader(path))
			{
				return streamReader.ReadToEnd();
			}
		}
		catch
		{
			return null;
		}
	}

	private static void WriteAllText(string path, string text)
	{
		try
		{
			using (StreamWriter streamWriter = new StreamWriter(path, append: false))
			{
				streamWriter.Write(text);
			}
		}
		catch
		{
		}
	}

	private static string Esc(string s)
	{
		if (s == null)
		{
			return "";
		}
		return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "").Replace("\t", "\\t");
	}

	public string ToJson()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("{\n  \"version\": 1,\n  \"achievements\": [\n");
		for (int i = 0; i < m_entries.Count; i++)
		{
			Entry entry = m_entries[i];
			stringBuilder.Append("    { \"key\": \"").Append(Esc(entry.Key));
			stringBuilder.Append("\", \"name\": \"").Append(Esc(entry.Name));
			stringBuilder.Append("\", \"description\": \"").Append(Esc(entry.Description));
			stringBuilder.Append("\", \"score\": ").Append(entry.Score);
			stringBuilder.Append(", \"earned\": ").Append(entry.Earned ? "true" : "false");
			stringBuilder.Append(", \"earnedAt\": \"").Append(Esc(entry.EarnedAt)).Append("\" }");
			if (i < m_entries.Count - 1)
			{
				stringBuilder.Append(",");
			}
			stringBuilder.Append("\n");
		}
		stringBuilder.Append("  ],\n  \"earnedCount\": ").Append(EarnedCount());
		stringBuilder.Append(",\n  \"earnedScore\": ").Append(TotalScore());
		stringBuilder.Append("\n}");
		return stringBuilder.ToString();
	}

	private void ParseJson(string json)
	{
		if (json == null || json.Length == 0)
		{
			return;
		}
		int i = 0;
		Dictionary<string, object> dictionary = ParseValue(json, ref i) as Dictionary<string, object>;
		if (dictionary == null)
		{
			return;
		}
		object value;
		if (!dictionary.TryGetValue("achievements", out value))
		{
			return;
		}
		List<object> list = value as List<object>;
		if (list == null)
		{
			return;
		}
		foreach (object item in list)
		{
			Dictionary<string, object> dictionary2 = item as Dictionary<string, object>;
			if (dictionary2 == null)
			{
				continue;
			}
			object value2;
			if (!dictionary2.TryGetValue("key", out value2))
			{
				continue;
			}
			string text = value2 as string;
			if (text == null)
			{
				continue;
			}
			Entry entry = Find(text);
			if (entry == null)
			{
				continue;
			}
			object value3;
			if (dictionary2.TryGetValue("earned", out value3) && value3 is bool)
			{
				entry.Earned = (bool)value3;
			}
			if (dictionary2.TryGetValue("earnedAt", out value3))
			{
				string text2 = value3 as string;
				if (text2 != null)
				{
					entry.EarnedAt = text2;
				}
			}
		}
	}

	private static int SkipWs(string s, int i)
	{
		while (i < s.Length && (s[i] == ' ' || s[i] == '\t' || s[i] == '\r' || s[i] == '\n'))
		{
			i++;
		}
		return i;
	}

	private static string ParseString(string s, ref int i)
	{
		StringBuilder stringBuilder = new StringBuilder();
		i++;
		while (i < s.Length)
		{
			char c = s[i];
			if (c == '"')
			{
				i++;
				return stringBuilder.ToString();
			}
			if (c == '\\' && i + 1 < s.Length)
			{
				i++;
				char c2 = s[i];
				switch (c2)
				{
				case 'n':
					stringBuilder.Append('\n');
					break;
				case 't':
					stringBuilder.Append('\t');
					break;
				case 'r':
					stringBuilder.Append('\r');
					break;
				case '"':
					stringBuilder.Append('"');
					break;
				case '\\':
					stringBuilder.Append('\\');
					break;
				case '/':
					stringBuilder.Append('/');
					break;
				case 'u':
					if (i + 4 < s.Length)
					{
						int result;
						if (int.TryParse(s.Substring(i + 1, 4), System.Globalization.NumberStyles.HexNumber, null, out result))
						{
							stringBuilder.Append((char)result);
						}
						i += 4;
					}
					break;
				default:
					stringBuilder.Append(c2);
					break;
				}
				i++;
				continue;
			}
			stringBuilder.Append(c);
			i++;
		}
		return stringBuilder.ToString();
	}

	private static object ParseValue(string s, ref int i)
	{
		i = SkipWs(s, i);
		if (i >= s.Length)
		{
			return null;
		}
		char c = s[i];
		if (c == '"')
		{
			return ParseString(s, ref i);
		}
		if (c == '{')
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			i = SkipWs(s, i + 1);
			if (i < s.Length && s[i] == '}')
			{
				i++;
				return dictionary;
			}
			while (i < s.Length)
			{
				i = SkipWs(s, i);
				if (i >= s.Length || s[i] != '"')
				{
					break;
				}
				string text = ParseString(s, ref i);
				i = SkipWs(s, i);
				if (i < s.Length && s[i] == ':')
				{
					i++;
				}
				object value = ParseValue(s, ref i);
				if (text != null)
				{
					dictionary[text] = value;
				}
				i = SkipWs(s, i);
				if (i < s.Length && s[i] == ',')
				{
					i++;
					continue;
				}
				if (i < s.Length && s[i] == '}')
				{
					i++;
				}
				break;
			}
			return dictionary;
		}
		if (c == '[')
		{
			List<object> list = new List<object>();
			i = SkipWs(s, i + 1);
			if (i < s.Length && s[i] == ']')
			{
				i++;
				return list;
			}
			while (i < s.Length)
			{
				object value2 = ParseValue(s, ref i);
				list.Add(value2);
				i = SkipWs(s, i);
				if (i < s.Length && s[i] == ',')
				{
					i++;
					continue;
				}
				if (i < s.Length && s[i] == ']')
				{
					i++;
				}
				break;
			}
			return list;
		}
		if (s.IndexOf("true", i, StringComparison.Ordinal) == i)
		{
			i += 4;
			return true;
		}
		if (s.IndexOf("false", i, StringComparison.Ordinal) == i)
		{
			i += 5;
			return false;
		}
		if (s.IndexOf("null", i, StringComparison.Ordinal) == i)
		{
			i += 4;
			return null;
		}
		int num = i;
		while (i < s.Length && (char.IsDigit(s[i]) || s[i] == '-' || s[i] == '+' || s[i] == '.' || s[i] == 'e' || s[i] == 'E'))
		{
			i++;
		}
		double result = 0.0;
		double.TryParse(s.Substring(num, i - num), out result);
		return result;
	}
}
