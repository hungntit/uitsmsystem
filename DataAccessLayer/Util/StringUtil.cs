using System.Text;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Util
{
    public class StringUtil
    {




        public static Boolean contains(String s, String text)
        {
            return contains(s, text, StringPool.COMMA);
        }

        public static Boolean contains(String s, String text, String delimiter)
        {
            if ((s == null) || (text == null) || (delimiter == null))
            {
                return false;
            }

            StringBuilder sb = null;

            if (!s.EndsWith(delimiter))
            {
                sb = new StringBuilder();

                sb.Append(s);
                sb.Append(delimiter);

                s = sb.ToString();
            }

            sb = new StringBuilder();

            sb.Append(delimiter);
            sb.Append(text);
            sb.Append(delimiter);

            String dtd = sb.ToString();

            int pos = s.IndexOf(dtd);

            if (pos == -1)
            {
                sb = new StringBuilder();

                sb.Append(text);
                sb.Append(delimiter);

                String td = sb.ToString();

                if (s.StartsWith(td))
                {
                    return true;
                }

                return false;
            }

            return true;
        }

        public static int count(String s, String text)
        {

            if ((s == null) || (text == null))
            {
                return 0;
            }

            int count = 0;

            int pos = s.IndexOf(text);

            while (pos != -1)
            {
                pos = s.IndexOf(text, pos + text.Length);

                count++;
            }

            return count;
        }

        public static Boolean EndsWith(String s, char end)
        {
            return EndsWith(s, end);
        }

        public static Boolean EndsWith(String s, String end)
        {
            if ((s == null) || (end == null))
            {
                return false;
            }

            if (end.Length > s.Length)
            {
                return false;
            }

            String temp = s.Substring(s.Length - end.Length, s.Length);

            if (temp.Equals(end,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
       
        
        public static String Insert(String s, String Insert, int offset)
        {
            if (s == null)
            {
                return null;
            }

            if (Insert == null)
            {
                return s;
            }

            if (offset > s.Length)
            {
                offset = s.Length;
            }

            StringBuilder sb = new StringBuilder(s);

            sb.Insert(offset, Insert);

            return sb.ToString();
        }

        public static String lowerCase(String s)
        {
            if (s == null)
            {
                return null;
            }
            else
            {
                return s.ToLower();
            }
        }

        public static Boolean matches(String s, String pattern)
        {
            
            String[] array = pattern.Split("\\*".ToCharArray());

            for (int i = 0; i < array.Length; i++)
            {
                int pos = s.IndexOf(array[i]);

                if (pos == -1)
                {
                    return false;
                }

                s = s.Substring(pos + array[i].Length);
            }

            return true;
        }

        public static String merge(Boolean[] array)
        {
            return merge(array, StringPool.COMMA);
        }

        public static String merge(Boolean[] array, String delimiter)
        {
            if (array == null)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if ((i + 1) != array.Length)
                {
                    sb.Append(delimiter);
                }
            }

            return sb.ToString();
        }

        public static String merge(double[] array)
        {
            return merge(array, StringPool.COMMA);
        }

        public static String merge(double[] array, String delimiter)
        {
            if (array == null)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if ((i + 1) != array.Length)
                {
                    sb.Append(delimiter);
                }
            }

            return sb.ToString();
        }

        public static String merge(float[] array)
        {
            return merge(array, StringPool.COMMA);
        }

        public static String merge(float[] array, String delimiter)
        {
            if (array == null)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if ((i + 1) != array.Length)
                {
                    sb.Append(delimiter);
                }
            }

            return sb.ToString();
        }

        public static String merge(int[] array)
        {
            return merge(array, StringPool.COMMA);
        }

        public static String merge(int[] array, String delimiter)
        {
            if (array == null)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if ((i + 1) != array.Length)
                {
                    sb.Append(delimiter);
                }
            }

            return sb.ToString();
        }

        public static String merge(long[] array)
        {
            return merge(array, StringPool.COMMA);
        }

        public static String merge(long[] array, String delimiter)
        {
            if (array == null)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if ((i + 1) != array.Length)
                {
                    sb.Append(delimiter);
                }
            }

            return sb.ToString();
        }

        public static String merge(short[] array)
        {
            return merge(array, StringPool.COMMA);
        }

        public static String merge(short[] array, String delimiter)
        {
            if (array == null)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if ((i + 1) != array.Length)
                {
                    sb.Append(delimiter);
                }
            }

            return sb.ToString();
        }


        public static String remove(String s, String Remove)
        {
            return remove(s, Remove, StringPool.COMMA);
        }

        public static String remove(String s, String Remove, String delimiter)
        {
            if ((s == null) || (Remove == null) || (delimiter == null))
            {
                return null;
            }

            if (s != null && !s.EndsWith(delimiter))
            {
                s += delimiter;
            }

            StringBuilder sb = new StringBuilder();

            sb.Append(delimiter);
            sb.Append(Remove);
            sb.Append(delimiter);

            String drd = sb.ToString();

            sb = new StringBuilder();

            sb.Append(Remove);
            sb.Append(delimiter);

            String rd = sb.ToString();

            while (contains(s, Remove, delimiter))
            {
                int pos = s.IndexOf(drd);

                if (pos == -1)
                {
                    if (s.StartsWith(rd))
                    {
                        int x = Remove.Length + delimiter.Length;
                        int y = s.Length;

                        s = s.Substring(x, y);
                    }
                }
                else
                {
                    int x = pos + Remove.Length + delimiter.Length;
                    int y = s.Length;

                    sb = new StringBuilder();

                    sb.Append(s.Substring(0, pos));
                    sb.Append(s.Substring(x, y));

                    s = sb.ToString();
                }
            }

            return s;
        }

        public static String Replace(String s, char oldSub, char newSub)
        {
            if (s == null)
            {
                return null;
            }

            return s.Replace(oldSub, newSub);
        }

        public static String Replace(String s, char oldSub, String newSub)
        {
            if ((s == null) || (newSub == null))
            {
                return null;
            }

            // The number 5 is arbitrary and is used as extra padding to reduce
            // buffer expansion

            StringBuilder sb = new StringBuilder(s.Length + 5 * newSub.Length);

            char[] charArray = s.ToCharArray();

            foreach (char c in charArray)
            {
                if (c == oldSub)
                {
                    sb.Append(newSub);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static String Replace(String s, String oldSub, String newSub)
        {
            if ((s == null) || (oldSub == null) || (newSub == null))
            {
                return null;
            }

            int y = s.IndexOf(oldSub);

            if (y >= 0)
            {

                // The number 5 is arbitrary and is used as extra padding to reduce
                // buffer expansion

                StringBuilder sb = new StringBuilder(
                    s.Length + 5 * newSub.Length);

                int Length = oldSub.Length;
                int x = 0;

                while (x <= y)
                {
                    sb.Append(s.Substring(x, y));
                    sb.Append(newSub);

                    x = y + Length;
                    y = s.IndexOf(oldSub, x);
                }

                sb.Append(s.Substring(x));

                return sb.ToString();
            }
            else
            {
                return s;
            }
        }

        public static String Replace(String s, String[] oldSubs, String[] newSubs)
        {
            if ((s == null) || (oldSubs == null) || (newSubs == null))
            {
                return null;
            }

            if (oldSubs.Length != newSubs.Length)
            {
                return s;
            }

            for (int i = 0; i < oldSubs.Length; i++)
            {
                s = Replace(s, oldSubs[i], newSubs[i]);
            }

            return s;
        }

      



        /**
         * Returns a string with Replaced values. This method will Replace all text
         * in the given string, between the beginning and ending delimiter, with new
         * values found in the given map. For example, if the string contained the
         * text <code>[$HELLO$]</code>, and the beginning delimiter was
         * <code>[$]</code>, and the ending delimiter was <code>$]</code>, and the
         * values map had a key of <code>HELLO</code> that mapped to
         * <code>WORLD</code>, then the Replaced string will contain the text
         * <code>[$WORLD$]</code>.
         *
         * @param		s the original string
         * @param		begin the beginning delimiter
         * @param		end the ending delimiter
         * @param		values a map of old and new values
         * @return		a string with Replaced values
         */

        public static String reverse(String s)
        {
            if (s == null)
            {
                return null;
            }

            char[] c = s.ToCharArray();
            char[] reverse = new char[c.Length];

            for (int i = 0; i < c.Length; i++)
            {
                reverse[i] = c[c.Length - i - 1];
            }

            return new String(reverse);
        }

        public static String safePath(String path)
        {
            return Replace(path, StringPool.DOUBLE_SLASH, StringPool.SLASH);
        }

      
       

        public static String[] Split(String s)
        {
            return Split(s, StringPool.COMMA);
        }

        public static String[] Split(String s, String delimiter)
        {
            if (s == null || (delimiter == null) ||
                (delimiter.Equals(StringPool.BLANK)))
            {

                return new String[0];
            }

            s = s.Trim();

            if (!s.EndsWith(delimiter))
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(s);
                sb.Append(delimiter);

                s = sb.ToString();
            }

            if (s.Equals(delimiter))
            {
                return new String[0];
            }

            List<String> nodeValues = new List<String>();

            
                int offset = 0;
                int pos = s.IndexOf(delimiter, offset);

                while (pos != -1)
                {
                    
                    nodeValues.Add(s.Substring(offset,pos));

                    offset = pos + delimiter.Length;
                    pos = s.IndexOf(delimiter, offset);
                }
            
           
            return nodeValues.ToArray();
        }

      
      


        public static Boolean StartsWith(String s, char begin)
        {
            return StartsWith(s, begin);
        }

        public static Boolean StartsWith(String s, String start)
        {
            if ((s == null) || (start == null))
            {
                return false;
            }

            if (start.Length > s.Length)
            {
                return false;
            }

            String temp = s.Substring(0, start.Length);

            if (temp.Equals(start,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
         * Return the number of starting letters that s1 and s2 have in common
         * before they deviate.
         *
         * @param		s1 the first string
         * @param		s2 the second string
         *
         * @return		the number of starting letters that s1 and s2 have in common
         *				before they deviate
         */
        public static int StartsWithWeight(String s1, String s2)
        {
            if ((s1 == null) || (s2 == null))
            {
                return 0;
            }

            char[] charArray1 = s1.ToCharArray();
            char[] charArray2 = s2.ToCharArray();

            int i = 0;

            for (; (i < charArray1.Length) && (i < charArray2.Length); i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    break;
                }
            }

            return i;
        }

        public static String stripBetween(String s, String begin, String end)
        {
            if ((s == null) || (begin == null) || (end == null))
            {
                return s;
            }

            StringBuilder sb = new StringBuilder(s.Length);

            int pos = 0;

            while (true)
            {
                int x = s.IndexOf(begin, pos);
                int y = s.IndexOf(end, x + begin.Length);

                if ((x == -1) || (y == -1))
                {
                    sb.Append(s.Substring(pos, s.Length));

                    break;
                }
                else
                {
                    sb.Append(s.Substring(pos, x));

                    pos = y + end.Length;
                }
            }

            return sb.ToString();
        }

       
      

        public static String upperCase(String s)
        {
            if (s == null)
            {
                return null;
            }
            else
            {
                return s.ToUpper();
            }
        }

        public static String upperCaseFirstLetter(String s)
        {
            char[] chars = s.ToCharArray();

            if ((chars[0] >= 97) && (chars[0] <= 122))
            {
                chars[0] = (char)(chars[0] - 32);
            }

            return new String(chars);
        }

        public static String valueOf(Object obj)
        {
            return obj.ToString();
        }

      
       


    }
}