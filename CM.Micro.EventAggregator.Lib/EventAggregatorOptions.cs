﻿namespace CM.Micro.EventAggregator.Lib
{
    public class EventAggregatorOptions
    {
        /// <summary>
        /// If true, Event Aggregator tries to run ComponentBase.StateHasChanged for the target component after
        /// it has handled the message.
        /// </summary>
        public bool AutoRefresh { get; set; }
    }
}
