using System;
namespace DataAccessLayer.Util
{

    public class CustomSQLUtil
    {



        public static String[] keywords(String keywords)
        {
            return _instance._customSQL.keywords(keywords);
        }

        public static String[] keywords(String keywords, Boolean lowerCase)
        {
            return _instance._customSQL.keywords(keywords, lowerCase);
        }

        public static String[] keywords(String[] keywordsArray)
        {
            return _instance._customSQL.keywords(keywordsArray);
        }

        public static String[] keywords(String[] keywordsArray, Boolean lowerCase)
        {
            return _instance._customSQL.keywords(
                keywordsArray, lowerCase);
        }

        public static String ReplaceAndOperator(String sql, Boolean andOperator)
        {
            return _instance._customSQL.ReplaceAndOperator(
                sql, andOperator);
        }



        public static String ReplaceKeywords(
            String sql, String field, String Operator, Boolean last,
            String[] values)
        {

            return _instance._customSQL.ReplaceKeywords(
                sql, field, Operator, last, values);
        }

        public static String removeOrderBy(String sql)
        {
            return _instance._customSQL.removeOrderBy(sql);
        }


        private CustomSQLUtil()
        {

            _customSQL = new CustomSQL();


        }



        private static CustomSQLUtil _instance = new CustomSQLUtil();

        private CustomSQL _customSQL;

    }
}