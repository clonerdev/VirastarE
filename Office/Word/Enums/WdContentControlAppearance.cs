﻿using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
    /// <summary>
    /// SupportByVersion Word 15,16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231358.aspx </remarks>
    [SupportByVersion("Word", 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum WdContentControlAppearance
    {
        /// <summary>
        /// SupportByVersion Word 15,16
        /// </summary>
        /// <remarks>0</remarks>
        [SupportByVersion("Word", 15, 16)]
        wdContentControlBoundingBox = 0,

        /// <summary>
        /// SupportByVersion Word 15,16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Word", 15, 16)]
        wdContentControlTags = 1,

        /// <summary>
        /// SupportByVersion Word 15,16
        /// </summary>
        /// <remarks>2</remarks>
        [SupportByVersion("Word", 15, 16)]
        wdContentControlHidden = 2
    }
}