﻿using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
    /// <summary>
    /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839338.aspx </remarks>
    [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum WdMailMergeDataSource
    {
        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>-1</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdNoMergeInfo = -1,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>0</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdMergeInfoFromWord = 0,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdMergeInfoFromAccessDDE = 1,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>2</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdMergeInfoFromExcelDDE = 2,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>3</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdMergeInfoFromMSQueryDDE = 3,

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>4</remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        wdMergeInfoFromODBC = 4,

        /// <summary>
        /// SupportByVersion Word 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>5</remarks>
        [SupportByVersion("Word", 10, 11, 12, 14, 15, 16)]
        wdMergeInfoFromODSO = 5
    }
}