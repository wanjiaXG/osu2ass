using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace osu2ass
{
    /// <summary>
    /// Ini文件解析
    /// </summary>
    public class Ini
    {
        /// <summary>
        /// 基础数据
        /// </summary>
        private Dictionary<string, Dictionary<string, string>> Data = new Dictionary<string, Dictionary<string, string>>();
        
        /// <summary>
        /// 获取值 如果获取的值无法转换成指定类型，将返回该数据类型的默认值
        /// </summary>
        /// <typeparam name="T">需要获取的类型</typeparam>
        /// <param name="block">节点</param>
        /// <param name="key">见</param>
        /// <returns>值</returns>
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

        /// <summary>
        /// 新增/修改数据
        /// </summary>
        /// <param name="block">节点</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void SetValue(string block, string key, string value)
        {
            if (string.IsNullOrWhiteSpace(block))
            {
                throw new ArgumentException("节点不能为空");
            }
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException("键不能为空");
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

        /// <summary>
        /// 获取Ini字符串
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 解析Ini字符串
        /// </summary>
        /// <param name="content">Ini字符串</param>
        /// <returns>Ini对象</returns>
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
                            throw new ArgumentException($"第{lineNum}行代码无法解析");
                        }

                    }
                }
            }


            return ini;
        }
    }
}
