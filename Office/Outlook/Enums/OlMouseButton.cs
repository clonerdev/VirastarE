﻿using NetOffice.Attributes;
namespace NetOffice.OutlookApi.Enums
{
    /// <summary>
    /// SupportByVersion Outlook 12, 14, 15, 16
    /// </summary>
    ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869983.aspx </remarks>
    [SupportByVersion("Outlook", 12, 14, 15, 16)]
    [EntityType(EntityType.IsEnum)]
    public enum OlMouseButton
    {
        /// <summary>
        /// SupportByVersion Outlook 12, 14, 15, 16
        /// </summary>
        /// <remarks>1</remarks>
        [SupportByVersion("Outlook", 12, 14, 15, 16)]
        olMouseButtonLeft = 1,

        /// <summary>
        /// SupportByVersion Outlook 12, 14, 15, 16
        /// </summary>
        /// <remarks>2</remarks>
        [SupportByVersion("Outlook", 12, 14, 15, 16)]
        olMouseButtonRight = 2,

        /// <summary>
        /// SupportByVersion Outlook 12, 14, 15, 16
        /// </summary>
        /// <remarks>4</remarks>
        [SupportByVersion("Outlook", 12, 14, 15, 16)]
        olMouseButtonMiddle = 4
    }
}