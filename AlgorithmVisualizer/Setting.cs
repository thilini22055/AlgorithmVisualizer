using System;
using System.Linq;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public enum SettingContext
    {
        Sorting,
        Pathfinding
    }

    public partial class Setting : Form
    {
        private readonly SettingContext _context;
        private MainForm _main;

        public int SortingSize { get; set; }
        public int SortingSpeed { get; set; }
        public int PathSize { get; set; }
        public int PathSpeed { get; set; }

        public Setting(
            SettingContext context,
            int sortingSize,
            int sortingSpeed,
            int pathSize,
            int pathSpeed)
        {
            InitializeComponent();
            _context = context;

            SortingSize = sortingSize;
            SortingSpeed = sortingSpeed;
            PathSize = pathSize;
            PathSpeed = pathSpeed;

            if (context == SettingContext.Sorting)
            {
                Text = "Sorting — Settings";
                label3.Text = "Array size:";
            }
            else
            {
                Text = "Pathfinding — Settings";
                label3.Text = "Grid size:";
            }

            int sizeShown = context == SettingContext.Sorting ? sortingSize : pathSize;
            // speedShown is timer interval (ms): higher = slower. Slider is Slow (left) → Fast (right).
            int intervalMs = context == SettingContext.Sorting ? sortingSpeed : pathSpeed;

            decimal cmbMax = cmb.Maximum;
            decimal cmbMin = cmb.Minimum;
            cmb.Value = Math.Max(cmbMin, Math.Min(cmbMax, sizeShown));

            int clampedInterval = Math.Max(
                trackBar1.Minimum,
                Math.Min(trackBar1.Maximum, intervalMs));
            trackBar1.Value = trackBar1.Maximum + trackBar1.Minimum - clampedInterval;

            Shown += (_, __) => AttachAndSyncToMainForm();
            FormClosed += (_, __) => DetachFromMainForm();
        }

        private void cmb_ValueChanged(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int size = (int)cmb.Value;
            int intervalMs = trackBar1.Maximum + trackBar1.Minimum - trackBar1.Value;

            if (_context == SettingContext.Sorting)
            {
                SortingSize = size;
                SortingSpeed = intervalMs;
            }
            else
            {
                PathSize = size;
                PathSpeed = intervalMs;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
        }

        private void AttachAndSyncToMainForm()
        {
            _main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (_main == null || ReferenceEquals(_main, this)) return;

            // Keep the settings dialog exactly aligned with the main window.
            _main.SizeChanged += MainOnChanged;
            _main.LocationChanged += MainOnChanged;
            _main.FormClosed += MainOnClosed;

            SyncFromMain();
        }

        private void DetachFromMainForm()
        {
            if (_main == null) return;
            _main.SizeChanged -= MainOnChanged;
            _main.LocationChanged -= MainOnChanged;
            _main.FormClosed -= MainOnClosed;
            _main = null;
        }

        private void MainOnClosed(object sender, FormClosedEventArgs e)
        {
            _main = null;
        }

        private void MainOnChanged(object sender, EventArgs e)
        {
            if (IsDisposed || Disposing) return;
            SyncFromMain();
        }

        private void SyncFromMain()
        {
            if (_main == null) return;

            StartPosition = FormStartPosition.Manual;
            Location = _main.Location;

            // Match fullscreen/maximize behavior first, then size.
            WindowState = _main.WindowState;
            if (WindowState == FormWindowState.Normal)
            {
                Size = _main.Size;
            }
        }
    }
}
