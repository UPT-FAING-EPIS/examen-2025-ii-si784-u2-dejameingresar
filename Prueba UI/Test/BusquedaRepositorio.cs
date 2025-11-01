using Microsoft.Playwright;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UPTRepoTests
{
    [TestClass]
    public class BusquedaRepositorioTests
    {
        private IBrowser _browser;
        private IPage _page;
        private IPlaywright _playwright;

        [TestInitialize]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true
            });
            _page = await _browser.NewPageAsync(new BrowserNewPageOptions
            {
                RecordVideoDir = "videos/"
            });
        }

        [TestMethod]
        public async Task BuscarTesisDeTecnologia()
        {
            await _page.GotoAsync("https://repositorio.upt.edu.pe/");
            await _page.FillAsync("input[name='query']", "tecnologia");
            await _page.PressAsync("input[name='query']", "Enter");

            var results = await _page.Locator(".artifact-title").CountAsync();
            Assert.IsTrue(results > 0, "No se encontraron tesis relacionadas con tecnología");
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await _page.CloseAsync();
            await _browser.CloseAsync();
            _playwright.Dispose();
        }
    }
}
