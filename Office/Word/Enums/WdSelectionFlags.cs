﻿using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
    /// <summary>
    /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192779.aspx </remarks>
    [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum WdSelectionFlags
    {
        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdSelStartActive = 1,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>2</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdSelAtEOL = 2,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>4</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdSelOvertype = 4,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>8</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdSelActive = 8,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>16</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdSelReplace = 16
    }
}