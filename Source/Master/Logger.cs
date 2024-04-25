using System;
using System.Diagnostics;
using UnityEngine;
using Verse;

namespace ProjectR
{
    // Record log messages
    public static class Logger
    {
        // new LogMessageQueue
        private static readonly LogMessageQueue messageQueuePR = new LogMessageQueue();

        // throw normal message
        public static void Message(string text)
        {
            bool IsDevModeEnable = ProjectRSettings.IsDevMode;

            if (!IsDevModeEnable) return;
            UnityEngine.Debug.Log(text);
            messageQueuePR.Enqueue(new LogMessage(LogMessageType.Message, text, StackTraceUtility.ExtractStackTrace()));
        }

        // throw warning massage
        public static void Warning(string text)
        {
            bool IsDevModeEnable = ProjectRSettings.IsDevMode;
            
            if(!IsDevModeEnable) return;
            UnityEngine.Debug.Log(text);
            messageQueuePR.Enqueue(new LogMessage(LogMessageType.Warning, text, StackTraceUtility.ExtractStackTrace()));
        }

        // throw error massage
        public static void Error(string text)
        {
            bool IsDevModeEnable = ProjectRSettings.IsDevMode;
            if(!IsDevModeEnable) return;
            UnityEngine.Debug.Log(text);
            messageQueuePR.Enqueue(new LogMessage(LogMessageType.Error, text, StackTraceUtility.ExtractStackTrace()));
        }

        public static TimeSpan Time(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}