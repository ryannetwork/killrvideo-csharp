﻿namespace KillrVideo.Host.Config
{
    /// <summary>
    /// Configuration values in the host.
    /// </summary>
    public interface IHostConfiguration
    {
        /// <summary>
        /// Gets a required configuration value and throws an InvalidOperationException if the value is not present or is null/empty.
        /// </summary>
        string GetRequiredConfigurationValue(string key);

        /// <summary>
        /// Gets a configuration value. Value could be null/empty.
        /// </summary>
        string GetConfigurationValue(string key);
    }
}