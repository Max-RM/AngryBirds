using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Innogiant;

public class LuaParser
{
	private List<string> a = new List<string>();

	private Dictionary<string, LuaVariable> b;

	private LuaVariable c;

	public LuaVariable Value => c;

	public void Parse(string aString)
	{
		string text = "";
		text += "(--.*?\\n)|(--.*?\\r)|";
		text += "(\"[^\"]*\")";
		text += "|(=)|(,)|(\\[)|(\\])|(\\{)|(\\})|(\\n)|(\\r)";
		string[] array = Regex.Split(aString, text);
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (text2.Trim().Length > 0 && text2 != "," && !text2.StartsWith("--"))
			{
				a.Add(text2.Trim());
			}
		}
		b = new Dictionary<string, LuaVariable>();
		DoParsing();
		c = new LuaVariable(b);
	}

	protected void DoParsing()
	{
		while (Peek() != null)
		{
			string token = GetToken();
			if (!IsLiteral(token))
			{
				throw new Exception("Error: Expecting literal token.");
			}
			if (GetToken() != "=")
			{
				throw new Exception("Error: Expecting '=' token.");
			}
			LuaVariable value = GetValue(GetToken());
			b.Add(token, value);
		}
	}

	protected string Peek()
	{
		if (a.Count > 0)
		{
			return a[0];
		}
		return null;
	}

	protected void NextToken()
	{
		if (a.Count > 0)
		{
			a.RemoveAt(0);
		}
	}

	protected string GetToken()
	{
		if (a.Count > 0)
		{
			string result = a[0];
			a.RemoveAt(0);
			return result;
		}
		return null;
	}

	protected LuaVariable GetValue(string token)
	{
		if (token == "{")
		{
			return GetArray();
		}
		if (IsBoolean(token))
		{
			return GetBoolean(token);
		}
		if (IsString(token))
		{
			return GetString(token);
		}
		if (IsNumber(token))
		{
			return GetNumber(token);
		}
		if (IsCalculation(token))
		{
			return GetCalculation(token);
		}
		if (IsReference(token))
		{
			return GetReferenceValue(token);
		}
		string message = "Error: Expecting '{', a string or a number token instead of '" + token + "'.";
		throw new Exception(message);
	}

	protected bool IsLiteral(string token)
	{
		return Regex.IsMatch(token, "^[a-zA-Z]+[0-9a-zA-Z_]*");
	}

	protected bool IsBoolean(string token)
	{
		return Regex.IsMatch(token, "^(false)|(true)|(False)|(True)$");
	}

	protected bool IsString(string token)
	{
		if (token.StartsWith("\""))
		{
			return token.EndsWith("\"");
		}
		return false;
	}

	protected bool IsNumber(string token)
	{
		if (!Regex.IsMatch(token, "^-?\\d+$") && !Regex.IsMatch(token, "^-?\\d*\\.\\d+$"))
		{
			return Regex.IsMatch(token, "^-?\\d*\\.\\d+e?-?\\+?\\d{3}?$");
		}
		return true;
	}

	protected bool IsCalculation(string token)
	{
		return Enumerable.Contains<char>((IEnumerable<char>)token, '*');
	}

	protected bool IsReference(string token)
	{
		if (token.StartsWith("-"))
		{
			return b.ContainsKey(token.Remove(0, 1));
		}
		return b.ContainsKey(token);
	}

	protected LuaVariable GetArray()
	{
		Dictionary<string, LuaVariable> dictionary = new Dictionary<string, LuaVariable>();
		while (Peek() != null && Peek() != "}")
		{
			string token = GetToken();
			if (IsBoolean(token))
			{
				dictionary.Add(dictionary.Count.ToString(), GetBoolean(token));
			}
			else if (IsLiteral(token))
			{
				if (GetToken() != "=")
				{
					throw new Exception("Error: Expecting '=' token.");
				}
				dictionary.Add(token, GetValue(GetToken()));
			}
			else if (token == "[")
			{
				token = GetToken();
				if (GetToken() != "]")
				{
					throw new Exception("Error: Expecting ']' token.");
				}
				if (GetToken() != "=")
				{
					throw new Exception("Error: Expecting '=' token.");
				}
				dictionary.Add(token, GetValue(GetToken()));
			}
			else
			{
				dictionary.Add(dictionary.Count.ToString(), GetValue(token));
			}
		}
		NextToken();
		return dictionary;
	}

	protected LuaVariable GetString(string token)
	{
		return token.Remove(token.Length - 1, 1).Remove(0, 1);
	}

	protected LuaVariable GetNumber(string token)
	{
		return Convert.ToDouble(token, CultureInfo.InvariantCulture.NumberFormat);
	}

	protected LuaVariable GetBoolean(string token)
	{
		return Convert.ToBoolean(token);
	}

	protected LuaVariable GetCalculation(string token)
	{
		string[] array = token.Split('*');
		if (array.Length != 2)
		{
			throw new Exception("Error: Too many values to multiply.");
		}
		string text = array[0].Trim();
		string text2 = array[1].Trim();
		double num = 0.0;
		double num2 = 0.0;
		num = ((!IsReference(text)) ? Convert.ToDouble(text, CultureInfo.InvariantCulture.NumberFormat) : ((double)GetReferenceValue(text)));
		num2 = ((!IsReference(text2)) ? Convert.ToDouble(text2, CultureInfo.InvariantCulture.NumberFormat) : ((double)GetReferenceValue(text2)));
		return num * num2;
	}

	protected LuaVariable GetReferenceValue(string token)
	{
		string key = token;
		if (token.StartsWith("-"))
		{
			key = token.Remove(0, 1);
		}
		double num = b[key];
		if (token.StartsWith("-"))
		{
			num *= -1.0;
		}
		return num;
	}

	public static string ReturnString(LuaVariable variable, string indent)
	{
		string text = "";
		foreach (KeyValuePair<string, LuaVariable> item in variable)
		{
			text += indent;
			if (item.Value.Content is Dictionary<string, LuaVariable>)
			{
				string text2 = text;
				text = text2 + item.Key.ToString() + " = {\n" + ReturnString(item.Value, indent + "\t") + indent + "}";
			}
			else if (item.Value.Content is string)
			{
				string text3 = text;
				text = text3 + item.Key.ToString() + " = \"" + item.Value.Content.ToString() + "\"";
			}
			else
			{
				text = text + item.Key.ToString() + " = " + item.Value.Content.ToString();
			}
			text += ",\n";
		}
		return text;
	}

	public static string ReturnString(LuaVariable variable)
	{
		return ReturnString(variable, "");
	}
}
