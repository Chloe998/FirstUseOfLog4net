// Also, you can create a custom class to log.
namespace learnlog4net
{
    public class LogHelper
    {
        /// <summary>
        /// Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        #region static void WriteLog(Type t, Exception ex)

        public static void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        #endregion

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        #region static void WriteLog(Type t, string msg)

        public static void WriteLog(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error(msg);
        }
 
        #endregion
    }
}

// How to use it?
LogHelper.WriteLog(typeof(Login),"someoen login to the page.");
// It only has a problem.
//---------------------------
//When this satement running, it generates a log.txt file which only has error. 
//You need to add more function on it.

