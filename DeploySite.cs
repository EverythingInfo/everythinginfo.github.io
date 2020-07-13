using Statiq.Common;
using Statiq.Core;
using Statiq.Web.GitHub;

namespace Website
{
    public class DeploySite : Pipeline
    {
        public DeploySite()
        {
            Deployment = true;

            OutputModules = new ModuleList
            {
                new DeployGitHubPages("everythinginfo", "everythinginfo.github.io", Config.FromSetting<string>("GITHUB_TOKEN")).ToBranch("master")
            };
        }
    }
}
