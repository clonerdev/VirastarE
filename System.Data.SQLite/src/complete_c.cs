namespace System.Data.SQLite
{

    using u8 = System.Byte;

    public partial class Sqlite3
    {
        /*
		** 2001 September 15
		**
		** The author disclaims copyright to this source code.  In place of
		** a legal notice, here is a blessing:
		**
		**    May you do good and not evil.
		**    May you find forgiveness for yourself and forgive others.
		**    May you share freely, never taking more than you give.
		**
		*************************************************************************
		** An tokenizer for SQL
		**
		** This file contains C code that implements the sqlite3_complete() API.
		** This code used to be part of the tokenizer.c source file.  But by
		** separating it out, the code will be automatically omitted from
		** static links that do not use it.
		*************************************************************************
		**  Included in SQLite3 port to C#-SQLite;  2008 Noah B Hart
		**  C#-SQLite is an independent reimplementation of the SQLite software library
		**
		**  SQLITE_SOURCE_ID: 2010-08-23 18:52:01 42537b60566f288167f1b5864a5435986838e3a3
		**
		*************************************************************************
		*/
        //#include "sqliteInt.h"
#if !SQLITE_OMIT_COMPLETE

        /*
** This is defined in tokenize.c.  We just have to import the definition.
*/
#if !SQLITE_AMALGAMATION
#if SQLITE_ASCII
        //#define IdChar(C)  ((sqlite3CtypeMap[(unsigned char)C]&0x46)!=0)
        static bool IdChar(u8 C)
        {
            return (sqlite3CtypeMap[(char)C] & 0x46) != 0;
        }
#endif
        //#if  SQLITE_EBCDIC
        //extern const char sqlite3IsEbcdicIdChar[];
        //#define IdChar(C)  (((c=C)>=0x42 && sqlite3IsEbcdicIdChar[c-0x40]))
        //#endif
#endif // * SQLITE_AMALGAMATION */


        /*
** Token types used by the sqlite3_complete() routine.  See the header
** comments on that procedure for additional information.
*/
        const int tkSEMI = 0;
        const int tkWS = 1;
        const int tkOTHER = 2;
#if !SQLITE_OMIT_TRIGGER
        const int tkEXPLAIN = 3;
        const int tkCREATE = 4;
        const int tkTEMP = 5;
        const int tkTRIGGER = 6;
        const int tkEND = 7;
#endif

        /*
** Return TRUE if the given SQL string ends in a semicolon.
**
** Special handling is require for CREATE TRIGGER statements.
** Whenever the CREATE TRIGGER keywords are seen, the statement
** must end with ";END;".
**
** This implementation uses a state machine with 8 states:
**
**   (0) INVALID   We have not yet seen a non-whitespace character.
**
**   (1) START     At the beginning or end of an SQL statement.  This routine
**                 returns 1 if it ends in the START state and 0 if it ends
**                 in any other state.
**
**   (2) NORMAL    We are in the middle of statement which ends with a single
**                 semicolon.
**
**   (3) EXPLAIN   The keyword EXPLAIN has been seen at the beginning of 
**                 a statement.
**
**   (4) CREATE    The keyword CREATE has been seen at the beginning of a
**                 statement, possibly preceeded by EXPLAIN and/or followed by
**                 TEMP or TEMPORARY
**
**   (5) TRIGGER   We are in the middle of a trigger definition that must be
**                 ended by a semicolon, the keyword END, and another semicolon.
**
**   (6) SEMI      We've seen the first semicolon in the ";END;" that occurs at
**                 the end of a trigger definition.
**
**   (7) END       We've seen the ";END" of the ";END;" that occurs at the end
**                 of a trigger difinition.
**
** Transitions between states above are determined by tokens extracted
** from the input.  The following tokens are significant:
**
**   (0) tkSEMI      A semicolon.
**   (1) tkWS        Whitespace.
**   (2) tkOTHER     Any other SQL token.
**   (3) tkEXPLAIN   The "explain" keyword.
**   (4) tkCREATE    The "create" keyword.
**   (5) tkTEMP      The "temp" or "temporary" keyword.
**   (6) tkTRIGGER   The "trigger" keyword.
**   (7) tkEND       The "end" keyword.
**
** Whitespace never causes a state transition and is always ignored.
** This means that a SQL string of all whitespace is invalid.
**
** If we compile with SQLITE_OMIT_TRIGGER, all of the computation needed
** to recognize the end of a trigger can be omitted.  All we have to do
** is look for a semicolon that is not part of an string or comment.
*/

        static public int sqlite3_complete(string zSql)
        {
            int state = 0;   /* Current state, using numbers defined in header comment */
            int token;       /* Value of the next token */

#if !SQLITE_OMIT_TRIGGER
            /* A complex statement machine used to detect the end of a CREATE TRIGGER
** statement.  This is the normal case.
*/
            u8[][] trans = new u8[][]       {
					 /* Token:                                                */
	 /* State:       **  SEMI  WS  OTHER  EXPLAIN  CREATE  TEMP  TRIGGER  END */
	 /* 0 INVALID: */ new u8[]{    1,  0,     2,       3,      4,    2,       2,   2, },
	 /* 1   START: */ new u8[]{    1,  1,     2,       3,      4,    2,       2,   2, },
	 /* 2  NORMAL: */ new u8[]{    1,  2,     2,       2,      2,    2,       2,   2, },
	 /* 3 EXPLAIN: */ new u8[]{    1,  3,     3,       2,      4,    2,       2,   2, },
	 /* 4  CREATE: */ new u8[]{    1,  4,     2,       2,      2,    4,       5,   2, },
	 /* 5 TRIGGER: */ new u8[]{    6,  5,     5,       5,      5,    5,       5,   5, },
	 /* 6    SEMI: */ new u8[]{    6,  6,     5,       5,      5,    5,       5,   7, },
	 /* 7     END: */ new u8[]{    1,  7,     5,       5,      5,    5,       5,   5, },
};
#else
	  /* If triggers are not supported by this compile then the statement machine
  ** used to detect the end of a statement is much simplier
  */
	  u8[][] trans = new u8[][]   {
	 /* Token:           */
	 /* State:       **  SEMI  WS  OTHER */
	 /* 0 INVALID: */new u8[]  {    1,  0,     2, },
	 /* 1   START: */new u8[]  {    1,  1,     2, },
	 /* 2  NORMAL: */new u8[] {    1,  2,     2, },
};
#endif // * SQLITE_OMIT_TRIGGER */

            int zIdx = 0;
            while (zIdx < zSql.Length)
            {
                switch (zSql[zIdx])
                {
                    case ';':
                        {  /* A semicolon */
                            token = tkSEMI;
                            break;
                        }
                    case ' ':
                    case '\r':
                    case '\t':
                    case '\n':
                    case '\f':
                        {  /* White space is ignored */
                            token = tkWS;
                            break;
                        }
                    case '/':
                        {   /* C-style comments */
                            if (zSql[zIdx + 1] != '*')
                            {
                                token = tkOTHER;
                                break;
                            }
                            zIdx += 2;
                            while (zIdx < zSql.Length && zSql[zIdx] != '*' || zIdx < zSql.Length - 1 && zSql[zIdx + 1] != '/')
                            {
                                zIdx++;
                            }
                            if (zIdx == zSql.Length)
                                return 0;
                            zIdx++;
                            token = tkWS;
                            break;
                        }
                    case '-':
                        {   /* SQL-style comments from "--" to end of line */
                            if (zSql[zIdx + 1] != '-')
                            {
                                token = tkOTHER;
                                break;
                            }
                            while (zIdx < zSql.Length && zSql[zIdx] != '\n')
                            {
                                zIdx++;
                            }
                            if (zIdx == zSql.Length)
                                return state == 1 ? 1 : 0;//if( *zSql==0 ) return state==1;
                            token = tkWS;
                            break;
                        }
                    case '[':
                        {   /* Microsoft-style identifiers in [...] */
                            zIdx++;
                            while (zIdx < zSql.Length && zSql[zIdx] != ']')
                            {
                                zIdx++;
                            }
                            if (zIdx == zSql.Length)
                                return 0;
                            token = tkOTHER;
                            break;
                        }
                    case '`':     /* Grave-accent quoted symbols used by MySQL */
                    case '"':     /* single- and double-quoted strings */
                    case '\'':
                        {
                            int c = zSql[zIdx];
                            zIdx++;
                            while (zIdx < zSql.Length && zSql[zIdx] != c)
                            {
                                zIdx++;
                            }
                            if (zIdx == zSql.Length)
                                return 0;
                            token = tkOTHER;
                            break;
                        }
                    default:
                        {
                            //#if SQLITE_EBCDIC
                            //        unsigned char c;
                            //#endif
                            if (IdChar((u8)zSql[zIdx]))
                            {
                                /* Keywords and unquoted identifiers */
                                int nId;
                                for (nId = 1; (zIdx + nId) < zSql.Length && IdChar((u8)zSql[zIdx + nId]); nId++)
                                {
                                }
#if SQLITE_OMIT_TRIGGER
				token = tkOTHER;
#else
                                switch (zSql[zIdx])
                                {
                                    case 'c':
                                    case 'C':
                                        {
                                            if (nId == 6 && sqlite3StrNICmp(zSql, zIdx, "create", 6) == 0)
                                            {
                                                token = tkCREATE;
                                            }
                                            else
                                            {
                                                token = tkOTHER;
                                            }
                                            break;
                                        }
                                    case 't':
                                    case 'T':
                                        {
                                            if (nId == 7 && sqlite3StrNICmp(zSql, zIdx, "trigger", 7) == 0)
                                            {
                                                token = tkTRIGGER;
                                            }
                                            else if (nId == 4 && sqlite3StrNICmp(zSql, zIdx, "temp", 4) == 0)
                                            {
                                                token = tkTEMP;
                                            }
                                            else if (nId == 9 && sqlite3StrNICmp(zSql, zIdx, "temporary", 9) == 0)
                                            {
                                                token = tkTEMP;
                                            }
                                            else
                                            {
                                                token = tkOTHER;
                                            }
                                            break;
                                        }
                                    case 'e':
                                    case 'E':
                                        {
                                            if (nId == 3 && sqlite3StrNICmp(zSql, zIdx, "end", 3) == 0)
                                            {
                                                token = tkEND;
                                            }
                                            else
#if !SQLITE_OMIT_EXPLAIN
                                                if (nId == 7 && sqlite3StrNICmp(zSql, zIdx, "explain", 7) == 0)
                                            {
                                                token = tkEXPLAIN;
                                            }
                                            else
#endif
                                            {
                                                token = tkOTHER;
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            token = tkOTHER;
                                            break;
                                        }
                                }
#endif // * SQLITE_OMIT_TRIGGER */
                                zIdx += nId - 1;
                            }
                            else
                            {
                                /* Operators and special symbols */
                                token = tkOTHER;
                            }
                            break;
                        }
                }
                state = trans[state][token];
                zIdx++;
            }
            return (state == 1) ? 1 : 0;//return state==1;
        }

#if !SQLITE_OMIT_UTF16
/*
** This routine is the same as the sqlite3_complete() routine described
** above, except that the parameter is required to be UTF-16 encoded, not
** UTF-8.
*/
int sqlite3_complete16(const void *zSql){
sqlite3_value pVal;
char const *zSql8;
int rc = SQLITE_NOMEM;

#if !SQLITE_OMIT_AUTOINIT
rc = sqlite3_initialize();
if( rc !=0) return rc;
#endif
pVal = sqlite3ValueNew(0);
sqlite3ValueSetStr(pVal, -1, zSql, SQLITE_UTF16NATIVE, SQLITE_STATIC);
zSql8 = sqlite3ValueText(pVal, SQLITE_UTF8);
if( zSql8 ){
rc = sqlite3_complete(zSql8);
}else{
rc = SQLITE_NOMEM;
}
sqlite3ValueFree(pVal);
return sqlite3ApiExit(0, rc);
}
#endif // * SQLITE_OMIT_UTF16 */
#endif // * SQLITE_OMIT_COMPLETE */
    }
}
