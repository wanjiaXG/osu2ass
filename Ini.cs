using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu2ass
{
    public class Ini
    {
        public Dictionary<string, Dictionary<string, string>> Data = new Dictionary<string, Dictionary<string, string>>();

        public T GetValue<T>(string block, string key)
        {
            try
            {
                if (Data.ContainsKey(block) && Data[block].ContainsKey(key))
                {
                    return (T)Convert.ChangeType(Data[block][key], typeof(T));
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                return default;
            }
            
        }

        public void SetValue(string block, string key, string value)
        {
            if (string.IsNullOrWhiteSpace(block))
            {
                throw new ArgumentException("Block is null or empty.");
            }
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException("Key is null or empty.");
            }

            if (!Data.ContainsKey(block))
            {
                Data.Add(block, new Dictionary<string, string>());
            }

            if (Data[block].ContainsKey(key))
            {
                Data[block][key] = value;
            }
            else
            {
                Data[block].Add(key, value);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var blocks in Data)
            {
                sb.Append('[').Append(blocks.Key).Append(']').Append("\r\n");
                foreach(var item in Data[blocks.Key])
                {
                    sb.Append(item.Key).Append(" = ").Append(item.Value).Append("\r\n");
                }
                sb.Append("\r\n");
            }
            return sb.ToString();
        }


        public static Ini Parse(string content)
        {
            Ini ini = new Ini();
            int lineNum = 0;
            string currentBlock = string.Empty;
            if (!string.IsNullOrWhiteSpace(content))
            {
                foreach (var line in content.Split('\n'))
                {
                    lineNum++;


                    StringBuilder sb = new StringBuilder();
                    char[] arr = line.Trim().ToArray();

                    if(arr.Length<=0 || arr[0].Equals(';'))
                    {
                        continue;
                    }


                    for (int i = 0; i <  arr.Length; i++)
                    {
                        if (arr[i].Equals(';') && !arr[i - 1].Equals('\\'))
                        {
                            break;
                        }
                        sb.Append(arr[i]);
                    }

                    string tmp = sb.ToString().Trim();


                    if (!string.IsNullOrWhiteSpace(tmp))
                    {
                        if(tmp.StartsWith("[") && tmp.EndsWith("]"))
                        {
                            currentBlock = tmp.Substring(1, tmp.Length - 2);
                            continue;
                        }

                        int index = tmp.IndexOf('=');

                        if(index > 1)
                        {
                            string key = tmp.Substring(0, index).Trim();
                            string value = string.Empty;
                            if(index + 1 <= tmp.Length - 1)
                            {
                                value = tmp.Substring(index + 1).Trim();
                            }
                            ini.SetValue(currentBlock, key, value);
                        }
                        else
                        {
                            throw new ArgumentException($"Line {lineNum} Error");
                        }

                    }
                }
            }


            return ini;
        }


    }
}
