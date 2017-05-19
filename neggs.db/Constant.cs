﻿namespace neggs.db
{
  public static partial class Constant
  {

    public static string DatabaseSizeQuery = string.Empty
    #region テーブル毎のデータ量
      + " SELECT "
      + "     CAST((ROW_NUMBER() OVER (ORDER BY A3.NAME, A2.NAME)) % 2 AS INT)  AS L1 "
      + "   , A3.NAME                                                           AS NAME_SCHEMA "
      + "   , A2.NAME                                                           AS NAME_TABLE "
      + "   , A1.ROWS                                                           AS ROW_COUNT "
      + "   , (A1.RESERVED + ISNULL(A4.RESERVED, 0)) * 8                        AS RESERVED "
      + "   , A1.DATA * 8                                                       AS DATA_SIZE "
      + "   , ( "
      + "     CASE "
      + "       WHEN (A1.USED + ISNULL(A4.USED, 0)) > A1.DATA "
      + "       THEN (A1.USED + ISNULL(A4.USED, 0)) - A1.DATA "
      + "       ELSE 0 "
      + "       END "
      + "   ) * 8                                                               AS INDEX_SIZE "
      + "   , ( "
      + "     CASE "
      + "       WHEN (A1.RESERVED + ISNULL(A4.RESERVED, 0)) > A1.USED "
      + "       THEN (A1.RESERVED + ISNULL(A4.RESERVED, 0)) - A1.USED "
      + "       ELSE 0 "
      + "       END "
      + "   ) * 8                                                               AS UNUSED "
      + " FROM "
      + "   ( "
      + "     SELECT "
      + "         PS.OBJECT_ID "
      + "       , SUM( "
      + "         CASE "
      + "           WHEN (PS.INDEX_ID < 2) "
      + "           THEN ROW_COUNT "
      + "           ELSE 0 "
      + "           END "
      + "       )                             AS ROWS "
      + "       , SUM(PS.RESERVED_PAGE_COUNT) AS RESERVED "
      + "       , SUM( "
      + "         CASE "
      + "           WHEN (PS.INDEX_ID < 2) "
      + "           THEN ( "
      + "             PS.IN_ROW_DATA_PAGE_COUNT + PS.LOB_USED_PAGE_COUNT + PS.ROW_OVERFLOW_USED_PAGE_COUNT "
      + "           ) "
      + "           ELSE ( "
      + "             PS.LOB_USED_PAGE_COUNT + PS.ROW_OVERFLOW_USED_PAGE_COUNT "
      + "           ) "
      + "           END "
      + "       )                             AS DATA "
      + "       , SUM(PS.USED_PAGE_COUNT)     AS USED "
      + "     FROM "
      + "       SYS.DM_DB_PARTITION_STATS PS "
      + "     GROUP BY "
      + "       PS.OBJECT_ID "
      + "   ) AS A1 "
      + "   LEFT OUTER JOIN ( "
      + "     SELECT "
      + "         IT.PARENT_ID "
      + "       , SUM(PS.RESERVED_PAGE_COUNT) AS RESERVED "
      + "       , SUM(PS.USED_PAGE_COUNT)     AS USED "
      + "     FROM "
      + "       SYS.DM_DB_PARTITION_STATS PS "
      + "       INNER JOIN SYS.INTERNAL_TABLES IT "
      + "         ON (IT.OBJECT_ID = PS.OBJECT_ID) "
      + "     WHERE "
      + "       IT.INTERNAL_TYPE IN (202, 204) "
      + "     GROUP BY "
      + "       IT.PARENT_ID "
      + "   ) AS A4 "
      + "     ON (A4.PARENT_ID = A1.OBJECT_ID) "
      + "   INNER JOIN SYS.ALL_OBJECTS A2 "
      + "     ON (A1.OBJECT_ID = A2.OBJECT_ID) "
      + "   INNER JOIN SYS.SCHEMAS A3 "
      + "     ON (A2.SCHEMA_ID = A3.SCHEMA_ID) "
      + " WHERE A2.TYPE <> N'S' "
      + "   AND A2.TYPE <> N'IT' "
      + " ORDER BY "
      + "     A3.NAME "
      + "   , A2.NAME "
      ;
    #endregion

  }
}
