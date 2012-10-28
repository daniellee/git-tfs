using Sep.Git.Tfs.VsFake;
using Xunit;

namespace Sep.Git.Tfs.Test.Core
{
    public class TfsHelperTests
    {
        [Fact]
        public void MatchesUrl_should_be_case_insensitive_for_tfs_url()
        {
            var helper = new TfsHelper(null)
                             {
                                 Url = "http://testvcs:8080/tfs/test", 
                                 LegacyUrls = new string[0]
                             };

            bool matches = helper.MatchesUrl("http://testvcs:8080/tfs/Test");

            Assert.Equal(true, matches);
        }

        [Fact]
        public void MatchesUrl_should_be_case_insensitive_for_legacy_urls()
        {
            var helper = new TfsHelper(null)
            {
                Url = "",
                LegacyUrls = new[] { "http://testvcs:8080/tfs/test", "AnotherUrlThatDoesntMatch" }
            };

            bool matches = helper.MatchesUrl("http://testvcs:8080/tfs/Test");

            Assert.Equal(true, matches);
        }
    }

}