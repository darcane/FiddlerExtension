using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Fiddler;

namespace ComposerBodyFormatter
{
    public class DarcaneView: UserControl
    {
        private IContainer components;
        private Panel _pnlControls;
        public FlowLayoutPanel FlpItems;
        public Button BtnTest;

        public DarcaneView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new Container();
            _pnlControls = new Panel {Name = "pnlDarcane"};
            FlpItems = new FlowLayoutPanel
            {
                AutoScroll = true,
                BackColor = Color.White,
                Cursor = Cursors.Default,
                Dock = DockStyle.Fill,
                Location = new Point(0, 25),
                Name = "flpItems"
            };

            BtnTest = new Button {Name = "TestButton", Text = "Test Me!"};
            BtnTest.Click += OnBtnTestOnClick;

            Controls.Add(BtnTest);
            Controls.Add(FlpItems);
            Controls.Add(_pnlControls);

            _pnlControls.ResumeLayout(false);
            _pnlControls.PerformLayout();
        }

        private void OnBtnTestOnClick(object sender, EventArgs args)
        {
            var selectedSessions = FiddlerApplication.UI.GetSelectedSessions();
            MessageBox.Show($"Hello Avensians !!\r\n{selectedSessions.Length} Session is selected! Good Job!");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}