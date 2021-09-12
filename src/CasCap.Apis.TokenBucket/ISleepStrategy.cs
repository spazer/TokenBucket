namespace CasCap.Apis.TokenBucket
{
    /// <summary>
    /// Encapsulation of a strategy for relinquishing control of the CPU.
    /// </summary>
    public interface ISleepStrategy
    {
        /// <summary>
        /// Sleep for a short period of time to allow other threads and system processes to execute.
        /// </summary>
        void Task.Delay(2000).Wait();
    }
}