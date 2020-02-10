using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Fiddler;

[assembly: RequiredVersion("2.3.5.0")]
namespace ComposerBodyFormatter
{
    public class Darcane : IFiddlerExtension
    {
        private TabPage _oPage;
        private DarcaneView _oView;
        private EventHandler _tabActiveHandler;
        private Session[] _sessions;

        private MenuItem _oMenu;

        public void OnLoad()
        {
            FiddlerApplication.UI.actToggleCapture();


            _oPage = new TabPage("Darcane") { ImageIndex = 5 };
            FiddlerApplication.UI.tabsViews.TabPages.Add(_oPage);
            _tabActiveHandler = TabsViewsSelectedIndexChanged;
            FiddlerApplication.UI.tabsViews.SelectedIndexChanged += _tabActiveHandler;

            _oMenu = new MenuItem("Darcane") { Name = "Darcane Menu" };
            FiddlerApplication.UI.mnuMain.MenuItems.Add(_oMenu);

            DeleteUnwantedTabs();
        }

        private void TabsViewsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FiddlerApplication.isClosing && FiddlerApplication.UI.tabsViews.SelectedTab == _oPage)
            {
                EnsureReady();
            }
        }

        private void EnsureReady()
        {
            FiddlerApplication.UI.tabsViews.SelectedIndexChanged -= _tabActiveHandler;
            _tabActiveHandler = null;
            _oView = new DarcaneView();
            _oPage.Controls.Add(_oView);
            _oView.Dock = DockStyle.Fill;
            _oView.AllowDrop = true;

            FiddlerApplication.CalculateReport += FiddlerApplicationOnCalculateReport;

            _sessions = FiddlerApplication.UI.GetSelectedSessions();

            RecalcDisplay();
        }

        private void FiddlerApplicationOnCalculateReport(Session[] arrsessions)
        {
            _sessions = arrsessions;
            RecalcDisplay();
        }

        private void RecalcDisplay()
        {
            // do your calculation here mate ;)
        }

        public void OnBeforeUnload()
        {
            _sessions = null;
        }

        private void DeleteUnwantedTabs()
        {
            var tabs = FiddlerApplication.UI.tabsViews.TabPages;
            var unwantedTabs = new List<string> { "Get Started", "Fiddler Orchestra Beta" };
            var indexes = new List<int>();
            for (var i = 0; i < tabs.Count; i++)
            {
                if (unwantedTabs.Contains(tabs[i].Text))
                {
                    indexes.Add(i);
                }
            }
            foreach (var i in indexes.OrderByDescending(x => x))
            {
                tabs.RemoveAt(i);
            }
        }
    }
}