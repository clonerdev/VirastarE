﻿using NetOffice.Attributes;
namespace NetOffice.OfficeApi.Enums
{
    /// <summary>
    /// SupportByVersion Office 10, 11, 12, 14, 15, 16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862396.aspx </remarks>
    [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum MsoFileNewSection
    {
        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>0</remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        msoOpenDocument = 0,

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        msoNew = 1,

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>2</remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        msoNewfromExistingFile = 2,

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>3</remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        msoNewfromTemplate = 3,

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks>4</remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        msoBottomSection = 4
    }
}