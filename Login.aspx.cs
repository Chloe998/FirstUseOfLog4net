namespace learnlog4net
{

    public partial class Login : System.Web.UI.Page
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Login));
        protected void Page_Load(object sender, EventArgs e)
        {
            log.Info("Login to the page.");
        }
    }
}
