// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.AzureStack.Storage.Admin;
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    public partial class BlobServiceSettings : BlobServiceWritableSettings
    {
        /// <summary>
        /// Initializes a new instance of the BlobServiceSettings class.
        /// </summary>
        public BlobServiceSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobServiceSettings class.
        /// </summary>
        /// <param name="frontEndCallbackThreadsCount">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds">TODO</param>
        /// <param name="frontEndMemoryThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndMaxMillisecondsBetweenMemorySamples">TODO</param>
        /// <param name="frontEndMemoryThrottleThresholdSettings">TODO</param>
        /// <param name="frontEndMinThreadPoolThreads">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveIOCompletionThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAlivePercentage">TODO</param>
        /// <param name="frontEndUseSlaTimeInAvailability">TODO</param>
        /// <param name="blobSvcContainerGcInterval">TODO</param>
        /// <param name="blobSvcShallowGcInterval">TODO</param>
        /// <param
        /// name="blobSvcStreamMapMinContainerOccupancyPercent">TODO</param>
        public BlobServiceSettings(int? frontEndCallbackThreadsCount = default(int?), bool? frontEndCpuBasedKeepAliveThrottlingEnabled = default(bool?), double? frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = default(double?), double? frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = default(double?), int? frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = default(int?), bool? frontEndMemoryThrottlingEnabled = default(bool?), int? frontEndMaxMillisecondsBetweenMemorySamples = default(int?), string frontEndMemoryThrottleThresholdSettings = default(string), int? frontEndMinThreadPoolThreads = default(int?), int? frontEndThreadPoolBasedKeepAliveIOCompletionThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = default(int?), double? frontEndThreadPoolBasedKeepAlivePercentage = default(double?), bool? frontEndUseSlaTimeInAvailability = default(bool?), int? frontEndHttpListenPort = default(int?), int? backEndHttpListenPort = default(int?), int? blobSvcContainerGcInterval = default(int?), int? blobSvcShallowGcInterval = default(int?), int? blobSvcStreamMapMinContainerOccupancyPercent = default(int?))
            : base(frontEndCallbackThreadsCount, frontEndCpuBasedKeepAliveThrottlingEnabled, frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold, frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle, frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds, frontEndMemoryThrottlingEnabled, frontEndMaxMillisecondsBetweenMemorySamples, frontEndMemoryThrottleThresholdSettings, frontEndMinThreadPoolThreads, frontEndThreadPoolBasedKeepAliveIOCompletionThreshold, frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold, frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds, frontEndThreadPoolBasedKeepAlivePercentage, frontEndUseSlaTimeInAvailability, frontEndHttpListenPort, backEndHttpListenPort, blobSvcContainerGcInterval, blobSvcShallowGcInterval, blobSvcStreamMapMinContainerOccupancyPercent)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}