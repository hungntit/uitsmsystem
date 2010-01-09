using System;
using System.Text;
namespace DataAccessLayer.Util
{
    public class CustomSQL
    {



        public CustomSQL()
        {

        }


        public String[] keywords(String Keywords)
        {
            return keywords(Keywords, true);
        }

        public String[] keywords(String Keywords, Boolean lowerCase)
        {
            if (lowerCase)
            {
                Keywords = Keywords.ToLower();
            }

            Keywords = Keywords.Trim();
            
            String[] keywordsArray = StringUtil.Split(Keywords, StringPool.SPACE);

            for (int i = 0; i < keywordsArray.Length; i++)
            {
                String keyword = keywordsArray[i];

                keywordsArray[i] =
                    StringPool.PERCENT + keyword + StringPool.PERCENT;
            }

            return keywordsArray;
        }

        public String[] keywords(String[] keywordsArray)
        {
            return keywords(keywordsArray, true);
        }

        public String[] keywords(String[] keywordsArray, Boolean lowerCase)
        {
            if ((keywordsArray == null) || (keywordsArray.Length == 0))
            {
                keywordsArray = new String[] { null };
            }

            if (lowerCase)
            {
                for (int i = 0; i < keywordsArray.Length; i++)
                {
                    keywordsArray[i] = StringUtil.lowerCase(keywordsArray[i]);
                }
            }

            return keywordsArray;
        }

        public String ReplaceAndOperator(String sql, Boolean andOperator)
        {
            String andOrConnector = "OR";
            String andOrNullCheck = "AND ? IS NOT NULL";

            if (andOperator)
            {
                andOrConnector = "AND";
                andOrNullCheck = "OR ? IS NULL";
            }

            sql = StringUtil.Replace(
                sql,
                new String[] {
				"[$AND_OR_CONNECTOR$]", "[$AND_OR_NULL_CHECK$]"
			},
                new String[] {
				andOrConnector, andOrNullCheck
			});





            return sql;
        }



        public String ReplaceKeywords(
            String sql, String field, String Operator, Boolean last,
            String[] values)
        {

            if (values.Length == 0)
            {
                return sql;
            }

            StringBuilder oldSql = new StringBuilder();

            oldSql.Append("(");
            oldSql.Append(field);
            oldSql.Append(" ");
            oldSql.Append(Operator);
            oldSql.Append(" ? [$AND_OR_NULL_CHECK$])");

            if (!last)
            {
                oldSql.Append(" [$AND_OR_CONNECTOR$]");
            }

            StringBuilder newSql = new StringBuilder();

            newSql.Append("(");

            for (int i = 0; i < values.Length; i++)
            {
                if (i > 0)
                {
                    newSql.Append(" OR ");
                }

                newSql.Append("(");
                newSql.Append(field);
                newSql.Append(" ");
                newSql.Append(Operator);
                newSql.Append(" ? [$AND_OR_NULL_CHECK$])");
            }

            newSql.Append(")");

            if (!last)
            {
                newSql.Append(" [$AND_OR_CONNECTOR$]");
            }

            return StringUtil.Replace(sql, oldSql.ToString(), newSql.ToString());
        }

        public String removeOrderBy(String sql)
        {
            int pos = sql.IndexOf(" ORDER BY ");

            if (pos != -1)
            {
                sql = sql.Substring(0, pos);
            }

            return sql;
        }






    }
}