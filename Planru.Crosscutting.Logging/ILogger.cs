﻿using System;

namespace Planru.Crosscutting.Logging
{
    /// <summary>
    /// Common contract for trace instrumentation. You 
    /// can implement this contrat with several frameworks.
    /// .NET Diagnostics API, EntLib, Log4Net,NLog etc.
    /// <remarks>
    /// The use of this abstraction depends on the real needs you have and the specific features  
    /// you want to use of a particular existing implementation. 
    /// You could also eliminate this abstraction and directly use "any" implementation in your code, 
    /// Logger.Write(new LogEntry()) in EntLib, or LogManager.GetLog("logger-name") with log4net... etc.
    /// </remarks>
    /// </summary>
    /// <summary>
    /// Logger interface
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Is debug enabled ?
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <returns>Is enabled</returns>
        bool IsDebugEnabled(string logType = null);

        /// <summary>
        /// Is info enabled ?
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <returns>Is enabled</returns>
        bool IsInfoEnabled(string logType = null);

        /// <summary>
        /// Is warning enabled ?
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <returns>Is enabled</returns>
        bool IsWarnEnabled(string logType = null);

        /// <summary>
        /// Is error enabled ?
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <returns>Is enabled</returns>
        bool IsErrorEnabled(string logType = null);

        /// <summary>
        /// Is fatal enabled ?
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <returns>Is enabled</returns>
        bool IsFatalEnabled(string logType = null);

        /// <summary>
        /// Log debug message
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Debug(string message, Exception exception = null);

        /// <summary>
        /// Log debug message
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Debug(string logType, string message, Exception exception = null);

        /// <summary>
        /// Log info message
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Info(string message, Exception exception = null);

        /// <summary>
        /// Log info message
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Info(string logType, string message, Exception exception = null);

        /// <summary>
        /// Log warning message
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Warn(string message, Exception exception = null);

        /// <summary>
        /// Log warning message
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Warn(string logType, string message, Exception exception = null);

        /// <summary>
        /// Log error message
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Error(string message, Exception exception = null);

        /// <summary>
        /// Log error message
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Error(string logType, string message, Exception exception = null);

        /// <summary>
        /// Log fatal message
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Fatal(string message, Exception exception = null);

        /// <summary>
        /// Log fatal message
        /// </summary>
        /// <param name="logType">log type, category, or logical group</param>
        /// <param name="message">message to log</param>
        /// <param name="exception">exception</param>
        void Fatal(string logType, string message, Exception exception = null);
    }
}
